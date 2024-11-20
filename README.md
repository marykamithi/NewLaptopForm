NewLaptopForm
Overview
NewLaptopForm is a Windows Forms application developed using C# and .NET 8. This application allows users to insert and retrieve laptop data from a SQL Server database. The application provides a simple interface to add new laptop entries and display existing entries in a DataGridView.
Features
•	Insert new laptop data into the database.
•	Retrieve and display laptop data from the database.
Prerequisites
•	.NET 8 SDK
•	SQL Server instance
•	Visual Studio 2022 or later
Setup
1.	Clone the repository:
 git clone https://github.com/marykamithi/NewLaptopForm.git
 cd NewLaptopForm
2. 2.	Open the project in Visual Studio:
•	Open NewLaptopForm.sln in Visual Studio.
3.	Configure the database connection:
•	Update the connection string in Form1.cs to match your SQL Server instance:
        string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=studentID_CompShop;Integrated Security=True;";
2.	Open the project in Visual Studio:
•	Open NewLaptopForm.sln in Visual Studio.
3.	Configure the database connection:
•	Update the connection string in Form1.cs to match your SQL Server instance:
string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=studentID_CompShop;Integrated Security=True;";
4.4.	Build and run the application:
•	Press F5 in Visual Studio to build and run the application.
Usage
1.	Insert Data:
•	Fill in the text boxes with the laptop details.
•	Click the Insert button to add the data to the database.
2.	Retrieve Data:
•	Click the Retrieve button to fetch and display the laptop data in the DataGridView.
Project Structure
•	Form1.cs: Contains the main form logic for inserting and retrieving data.
•	Form1.Designer.cs: Contains the designer code for the form layout.
•	Program.cs: Entry point of the application.
Dependencies
•	.NET 8
•	System.Data.SqlClient
License
This project is licensed under the MIT License. See the LICENSE file for details.
Contributing
Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.
