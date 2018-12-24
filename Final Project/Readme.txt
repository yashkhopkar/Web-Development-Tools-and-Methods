I have created a Employee management system web application using BLAZOR C# web assembly programming.

Features include:

- Role based access
Admin Role: To create employees
User Role: To view various products

- CRUD Operations
Create, View, Update and Delete various Employees

- Discounted product page for Employees


STEPS TO RUN THE PROJECT

Prerequisites:
	Install the .NET Core 2.1 
	Install Visual Studio 2017 v15.7 or above 
	Install ASP.NET Core Blazor Language Services extension
	Download and install the MongoDB community edition.

1) Configure MongoDB:
	a. Unzip the MongoData Folder on your local machine.
	b. run command mongod --dbpath 'your-local-unzipped-folder-path-goes-here'\MongoData (ex: C:\MongoData)

2) Install MongoDB Driver in in Visual Studio 2017 as follows:
	a. Navigate to Tools >> NuGet Package Manager >> Package Manager Console. 
	   Select “BlazorWithMongo.Shared” from Default project drop-down and run the following command,
	   
		 Install-Package MongoDB.Driver

3) Run the following command to create the database : 
	use EmployeeDB


4) Execute the following command to create a new collection inside the database: 
	db.createCollection('EmployeeRecord')


5) Insert a sample document in EmployeeRecord collection.Run the following command : 

	db.EmployeeRecord.insert({'Name':'Dino','Gender':'Male','Department':'Software','City':'Boston', Username:'dino', Password: 'dino'})

6) Run the following command to create the Cities collection.
	
	db.createCollection('Cities')

Insert sample cities. To insert the documents in bulk in the Cities collection, run the following command.

	db.Cities.insertMany([  
   		{ CityName : "Boston" },  
   		{ CityName : "Mumbai"},  
   		{ CityName : "New York"},  
   		{ CityName : "San Francisco"},  
   		{ CityName : "New Delhi" }  
	]) 

7) Open the blazor project.

8) Executing the App:
	Press Ctrl+F5 to run the Application.


Steps to Run the Database using COMPASS (IMPORT JSON):
	a. Open MongoDB Compass
	b. Connect to localhost with port number 27017 (might be the default port)
	c. Click on Create Database
	d. In Database Name put EmplyeeDB  and in Collection Name put Cities
	e. Click on EmployeeDB database in the dashboard
	f. Click on the collection Cities
	e. On the top left corner click on Collection>>Import Data and Import the CityData.json collection attached in the Project Folder
	f. Click on the '+' sign next to EmployeeDB on the sidebar and create another collection called EmployeeData
	g. Click on the created EmployeeData collection and import the EmployeeData.json file from the project folder 
 
