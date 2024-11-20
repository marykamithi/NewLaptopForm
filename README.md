# NewLaptopForm  

NewLaptopForm is a Windows Forms application built using C# and .NET 8. The application provides an intuitive interface to manage laptop data in a SQL Server database. Users can easily insert new entries and retrieve existing data, which is displayed in a **DataGridView**.  

---

## Features  
- **Insert Data:** Add new laptop details to the SQL Server database.  
- **Retrieve Data:** Fetch and display all laptop entries in a DataGridView.  

---

## Prerequisites  
Before running the application, ensure the following are installed:  
- .NET 8 SDK  
- SQL Server instance  
- Visual Studio 2022 or later  

---

## Setup  

1. **Clone the repository:**  
   ```bash  
   git clone https://github.com/marykamithi/NewLaptopForm.git  
   cd NewLaptopForm  
   ```  

2. **Open the project in Visual Studio:**  
   - Open `NewLaptopForm.sln` in Visual Studio.  

3. **Configure the database connection:**  
   - Update the connection string in `Form1.cs` to match your SQL Server instance:  
     ```csharp  
     string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=studentID_CompShop;Integrated Security=True;";  
     ```  

4. **Build and run the application:**  
   - Press **F5** in Visual Studio to build and launch the application.  

---

## Usage  

1. **Insert Data:**  
   - Fill in the text boxes with laptop details.  
   - Click the **Insert** button to save the data to the database.  

2. **Retrieve Data:**  
   - Click the **Retrieve** button to fetch and display all laptop data in the DataGridView.  

---

## Project Structure  

- **Form1.cs:** Contains the core logic for inserting and retrieving laptop data.  
- **Form1.Designer.cs:** Contains the designer code for the form layout and UI elements.  
- **Program.cs:** Serves as the entry point of the application.  

---

## Dependencies  

- **.NET 8**  
- **System.Data.SqlClient**  

---

## License  

This project is licensed under the [MIT License](LICENSE).  

---

## Contributing  

Contributions are welcome! To propose improvements or report issues:  
1. Open an issue on GitHub.  
2. Submit a pull request with your changes.  

---  

For any questions or feedback, feel free to reach out.
