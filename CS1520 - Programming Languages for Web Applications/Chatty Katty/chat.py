from flask import Flask, request, abort, url_for, redirect, session, render_template
from models import db, User, Room, Message
from datetime import date


app = Flask(__name__)
app.secret_key = 'super secret key'
app.config['SESSION_TYPE'] = 'filesystem'
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///chat.db'
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
        print(user.firstName)
        print(user.lastName)
        print(user.id)
        if user is None:
            return redirect(url_for('login',error=True))
        elif password == user.password:
            session['username'] = username
            return redirect(url_for('account',id=user.id))
           

@app.route('/account/',methods=['GET'])
@app.route('/account/<id>/',methods=['GET'])
@app.route('/account/<id>/<remove>',methods=['GET'])
def employee(id=0,remove=False):
    user = User.query.filter_by(username=session['username']).first()
    if request.method == 'GET':
        if id == 0:
            return redirect(url_for('login'))
        else:
            if user.currentRoom == 0:
            else:
                #Gather my rooms
                userRooms = user.rooms
                #Gather all rooms
                allRooms = Room.query.all()
                #render page
                render_template('account.html',uRooms = userRooms, aRooms = allRooms)

@app.route('/createAccount',methods=['GET', 'POST'])
def createAccount():
    if request.method == 'GET':
        return render_template('createAccount.html')
    elif request.method == 'POST':
        user = User(request.form['first'],request.form['last'],request.form['email'],request.form['user'],request.form['pass'])
        db.session.add(user)
        db.session.commit()
        return redirect(url_for('login',error=False))
    
@app.route('/logout')
def logout():
    return render_template('logout.html')
    
if __name__ == '__main__':
    app.run(debug=True)


@app.cli.command()
def initdb():
    print('Initializing database')    
    
    app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///chat.db'
    app.config['SQLALCHEMY_TRACK_MODIFICATIONS']=False
    db.init_app(app)  
    db.create_all()    
    print('Initialize complete')
    #stuffDB()

def stuffDB():
    print('Stuffing Databases')
    print('Add Chatrooms')
    room1 = ChatUser('Client','Client','Client@client.com','client','cli','C')
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