using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NewLaptopForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            // Connection string for connecting to the SQL Server database
            string connectionString = "Data Source=DESKTOP-6L4M4DS;Initial Catalog=studentID_CompShop;Integrated Security=True;";

            // SQL query to insert data into the Laptop table
            string query = "INSERT INTO Laptop (Brand, Model, Processor, Memory, Harddisk, Price) " +
                           "VALUES (@Brand, @Model, @Processor, @Memory, @Harddisk, @Price)";

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL command to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters with values from text boxes
                        command.Parameters.AddWithValue("@Brand", brandTextBox.Text);
                        command.Parameters.AddWithValue("@Model", modelTextBox.Text);
                        command.Parameters.AddWithValue("@Processor", processorTextBox.Text);
                        command.Parameters.AddWithValue("@Memory", memoryTextBox.Text);
                        command.Parameters.AddWithValue("@Harddisk", harddiskTextBox.Text);
                        command.Parameters.AddWithValue("@Price", decimal.Parse(priceTextBox.Text));

                        // Execute the command to insert data
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data inserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            // Connection string for connecting to the SQL Server database
            string connectionString = "Data Source=DESKTOP-6L4M4DS;Initial Catalog=studentID_CompShop;Integrated Security=True;";

            // SQL query to retrieve Brand, Model, and Price fields
            string query = "SELECT Brand, Model, Price FROM Laptop";

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL command to execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Fill a DataTable with the retrieved data
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            // Display the data in the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}


