# Employees_CRUD

Project Description :
Simple Create, Read, Update, Delete Employee details 

Stack: 
Front-End : Angular 14 - User Interface(Bootstrap v5) that calls WebAPI
Back-End : Web Api ASP.NET 6, Entitiy Framework. (Code First Approach)

Programs Required:
1. Visual Studio
2. Visual Studio Code
3. SQL Server

Installation:
1. .NET 6
2. Angular 14


To see it work :


Step 1 : 
Fullstack API's Solution File - Open with Visual Studio
FullStack UI's Folder - Open with Visual Studio Code

Step 2 (Create Table in DB) : 
Open terminal in visual studio and run this command : dotnet ef database update
this is to create table based on the migration folder. extra information : dotnet ef migrations add Initial
^ To create migration folder if does not exist
or if you want to add more columns, tables. but of cos remember to edit the EF models etc..

Step 3:
Open your SQL Server, Copy your local host address (very important), Connect to local host, make sure the employees table is inside

Step 4 (Minor Code changes):
- In visual studio -> appsetings.json change the sever:JOSHUA\\SQLEXPRESS to your own local host connection string
- Run the WebAPI, Swagger will pop up : Check if you can access the database with API, then copy the local host url
- In visual studio code -> src -> environments -> environments.ts -> change the baseApiURL: to your own localhost from the above
- remember to save

Step 5 (Running the application):
- Run WebApi, Swagger will pop up
- In Visual Studio Code -> Top tap click on Terminal and run the command : ng serve
- Ctrl + Click on the URL provided (If you work if angular you should know)
- The application should be running normal

You can then proceed to test out CRUD! Remember to create your own data :)

Thank you!

Screenshots of Application
![1](https://user-images.githubusercontent.com/104182041/180048032-ad72e7b1-746d-407b-96c0-386dc4b2e04d.PNG)
![2](https://user-images.githubusercontent.com/104182041/180048038-52d22b7c-a384-447f-881b-536a1fb94bff.PNG)
![3](https://user-images.githubusercontent.com/104182041/180048040-f6fdaf78-0cf2-49d3-a41a-0e6ca3f6a3c2.PNG)
![4](https://user-images.githubusercontent.com/104182041/180048041-2b97175e-33a9-4f7a-b1bf-8d900d0231a5.PNG)



