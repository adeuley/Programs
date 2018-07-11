from flask import Flask, request, abort, url_for, redirect, session, render_template
from models import db, User, Event
from datetime import date


app = Flask(__name__)
app.secret_key = 'super secret key'
app.config['SESSION_TYPE'] = 'filesystem'
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///catering.db'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS']=False
db.init_app(app)

@app.route('/')
def default():
    return render_template('main.html')

@app.route('/login/',methods=['GET', 'POST'])  
@app.route('/login/<error>',methods=['GET', 'POST']) 
def login(error=False):
    if request.method == 'GET':
        return render_template('loginError.html',error=error)
      
    elif request.method == 'POST':
        username = request.form['user']
        password = request.form['pass']
        user = User.query.filter_by(username=username).first()
        if user is None:
            return redirect(url_for('login',error=True))
        elif password == user.password:
            session['username'] = username
            if user.role == 'O':
                return redirect(url_for('owner'))
            elif user.role == 'E':
                return redirect(url_for('employee'))
            elif user.role == 'C':
                return redirect(url_for('client'))
            else:
                return redirect(url_for('login',error=True)) 
        else:
            return redirect(url_for('login',error=True))

@app.route('/owner')
def owner():
    noWorkerEvents = Event.query.filter_by(employeeCount=0).all()
    allEvents = Event.query.all()
    return render_template('owner.html', noEvents=noWorkerEvents,events=allEvents)

@app.route('/employee/',methods=['GET'])
@app.route('/employee/<eventId>/<meth>',methods=['GET'])
def employee(eventId=0,meth='b'):
    user = User.query.filter_by(username=session['username']).first()
    userEvents = session.query
    if request.method == 'GET':
        if eventId == 0:
            availableEvents = Event.query.filter(Event.employeeCount<3).all()
            aEvents = set(availableEvents)-set(userEvents)
            return render_template('employee.html',events=user.events,availableEvents=aEvents)
        else:
            event = Event.query.filter_by(id=eventId).first()
            if meth == 'a':
                user.events.append(event)
                event.employeeCount=event.employeeCount + 1
                db.session.commit()
            elif meth == 'r':
                user.events.remove(event)
                event.employeeCount=event.employeeCount - 1
                db.session.commit()
            return redirect(url_for('employee'))

@app.route('/client/',methods=['GET', 'POST'])       
@app.route('/client/<booked>',methods=['GET', 'POST'])
@app.route('/client/<eventId>/<cancel>',methods=['GET','POST'])
def client(booked=False,eventId=0,cancel=False):
    user = User.query.filter_by(username=session['username']).first()
    if request.method == 'GET':
        if cancel == False:
            return render_template('client.html',events = user.events,booked = booked)
        else:
            event = Event.query.filter_by(id=eventId).first()
            for u in event.users:
                u.events.remove(event)
            db.session.delete(event)
            db.session.commit()
            return redirect(url_for('client'))
    elif request.method == 'POST':
        description = request.form['description']
        dateList=request.form['date'].split('-')
        event = Event(0,description,date(int(dateList[0]),int(dateList[1]),int(dateList[2])))
        bookedEvent = Event.query.filter_by(date=event.date).first()
        if bookedEvent is None:
            user.events.append(event)
            db.session.commit()
            return redirect(url_for('client'))
        else:
            return redirect(url_for('client',booked=True))
        
@app.route('/addEmployee',methods=['GET', 'POST'])
def addEmployee():
    if request.method == 'GET':
        return render_template('createAccount.html')
    elif request.method == 'POST':
        user = User(request.form['first'],request.form['last'],request.form['email'],request.form['user'],request.form['pass'],'E')
        db.session.add(user)
        db.session.commit()
        return redirect(url_for('owner'))

@app.route('/createAccount',methods=['GET', 'POST'])
def createAccount():
    if request.method == 'GET':
        return render_template('createAccount.html')
    elif request.method == 'POST':
        user = User(request.form['first'],request.form['last'],request.form['email'],request.form['user'],request.form['pass'],'C')
        db.session.add(user)
        db.session.commit()
        return redirect(url_for('login',error=False))
    
@app.route('/addEvent', methods=['GET', 'POST'])    
def addEvent():
    return render_template('addEvent.html')
    
@app.route('/logout')
def logout():
    return render_template('logout.html')
    
if __name__ == '__main__':
    app.run(debug=True)


@app.cli.command()
def initdb():
    print('Initializing database')    
    
    app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///catering.db'
    app.config['SQLALCHEMY_TRACK_MODIFICATIONS']=False
    db.init_app(app)  
    db.create_all()  
    user = User('Owner','Owner','owner@owner.com','owner','pass','O')
    db.session.add(user)
    db.session.commit()
    print('Initialize complete')
    #stuffDB()

def stuffDB():
    print('Stuffing Databases')
    print('Add Client')
    client = User('Client','Client','Client@client.com','client','cli','C')
    db.session.add(client)
    print('Add Employees')
    employee1 = User('Employee1','Employee','Employee@employee.com','employee1','empl','E')
    employee2 = User('Employee2','Employee','Employee@employee.com','employee2','empl','E')
    employee3 = User('Employee3','Employee','Employee@employee.com','employee3','empl','E')
    employee4 = User('Employee4','Employee','Employee@employee.com','employee4','empl','E')
    db.session.add(employee1)
    db.session.add(employee2)
    db.session.add(employee3)
    db.session.add(employee4)    
    db.session.commit()
    print('Add Events')
    employEvent1 = Event(1,'Event1',date(2018,3,30))
    employEvent2 = Event(2,'Event2',date(2018,3,29))
    employEvent3 = Event(3,'Event3',date(2018,3,28))
    employEvent4 = Event(0,'Event4',date(2018,3,27))
    employEvent5 = Event(3,'Event5',date(2018,3,26))
    employEvent6 = Event(2,'Event6',date(2018,3,25))
    
    client.events.append(employEvent1);
    client.events.append(employEvent2);
    client.events.append(employEvent3);
    client.events.append(employEvent4);
    client.events.append(employEvent5);
    client.events.append(employEvent6);
    print('Add Event 1 Employees')
    employee1.events.append(employEvent1);
    print('Add Event 2 Employees')
    employee1.events.append(employEvent2);
    employee2.events.append(employEvent2);
    print('Add Event 3 Employees')
    employee1.events.append(employEvent3);
    employee2.events.append(employEvent3);
    employee3.events.append(employEvent3);
    print('Add Event 5 Employees')
    employee1.events.append(employEvent5);
    employee2.events.append(employEvent5);
    employee3.events.append(employEvent5);
    print('Add Event 6 Employees')
    employee2.events.append(employEvent6);
    employee3.events.append(employEvent6);
    
    db.session.commit()
    print('Stuffing Complete')