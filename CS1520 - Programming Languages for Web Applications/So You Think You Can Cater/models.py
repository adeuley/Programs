from flask_sqlalchemy import SQLAlchemy

db = SQLAlchemy()

class User(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    firstName = db.Column(db.String(80),unique=False,nullable=False)
    lastName = db.Column(db.String(80),unique=False,nullable=False)
    email = db.Column(db.String(80),unique=False,nullable=False)
    username = db.Column(db.String(80), unique = True, nullable = False)
    password = db.Column(db.String(20), unique = False, nullable = False)
    messages = db.relationship('Message',backref='user');
    
    def __init__(self,first,last,email,user,password,role):
        self.firstName = first
        self.lastName = last
        self.email = email
        self.username = user
        self.password=password

class Room(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    description = db.Column(db.String(80), unique = False, nullable = False)
    users = db.relationship('User', backref='room') 
    messages = db.relationship('Message', backref = 'room')
    
    def __init__(self,count,description,date):
        self.employeeCount = count
        self.description = description
        self.date = date
        
class Message(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    text=db.Column(db.String(),unique=False,nullable=Fale)
    
