from flask import Flask
import MySQLdb

app = Flask(__name__)

conn = MySQLdb.connect(host="localhost",
                           user = "root",
                           passwd = "",
                           db = "test")

cur = conn.cursor()

@app.route('/')
def index():
	return "Hello World"

@app.route('/te')
def users():
	cur.execute("SELECT * FROM te1")
	rv = cur.fetchall()
	return str(rv)