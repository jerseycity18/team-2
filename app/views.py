from flask import Flask
from flask import jsonify, json, request

import MySQLdb

app = Flask(__name__)

conn = MySQLdb.connect(host="18.204.221.202",
                           user = "root",
                           passwd = "Team2",
                           db = "code_for_good")

cur = conn.cursor()

@app.route('/')
def index():
	return "Hello World"

@app.route('/test/<id>')
def test_user(id):
#	id = request.args.get('Id')
	#Needs to handle bad input
	cur.execute("SELECT * FROM user where Id = %s",(id))
	rv = cur.fetchone()
	matching(rv)
	return "Hello"


@app.route('/FetchAll')
def fetchAll():
	allValues = []
	cur.execute("SELECT * FROM user where type = 'B' ")
	rv = cur.fetchall()

	for result in rv:
		allValues.append(jsonifyValues(result))
	return json.dumps(allValues)

def matching(buddy):
	gender = buddy[5]
	matchResult = []
	print gender, "HERE"
	if gender == 'f':
		cur.execute("SELECT * FROM user where type = 'V' and gender = 'F' ")
	else:
		cur.execute("SELECT * FROM user where type = 'V'  ")
	rv = cur.fetchall()
	for result in rv:
		filterVolunteers(buddy, result)
		#print jsonifyValues(result)
		#matchResult.append(jsonifyValues(result))
	return rv


def filterVolunteers(buddyid,volunteer):
	pass
	score = 0
	return (score,volunteer)


def jsonifyValues(data):
	return json.dumps({"id": data[0],"Match_Id" : data[1],"Name":data[2], "Status" : data[3],"Type":data[4],"Gender":data[5], "Zip": data[6], "Borough": data[7], "Email": data[8], "Phone": data[9], "Employed": data[10],"Age":data[11],"Married":data[12],"Interests":data[13],"Preferred_Communication":data[14],"BestTimes_To_Socialize":data[15],"Travel_Independent":data[16],"Days_Since_Matched":data[17],"About_Me":data[18]})
	#return jsonify(id= data[0], Match_Id = data[1], Status = data[2])



