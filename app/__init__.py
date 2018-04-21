from flask import Flask
from flask_mysqldb import MySQL

app = Flask(__name__)
from app import views

mysql = MySQL(app)

