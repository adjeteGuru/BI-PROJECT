using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //comment here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> Dates = new List<string>();
            //clear the listbox
            listBoxDates.Items.Clear();

            //create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getDates = new OleDbCommand("SELECT [Order Date], [Ship Date] from Sheet1", connection);

                reader = getDates.ExecuteReader();
                while (reader.Read())
                {
                    Dates.Add(reader[0].ToString());
                    Dates.Add(reader[1].ToString());
                }
            }

            //create a new list for the formatted data
            List<string> DatesFormatted = new List<string>();
            foreach (string date in Dates)
            {
                //split the string on whitespce and remove anything thats blank.
                var dates = date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //grab the first item (we know this is the date) and add it to our new list
                DatesFormatted.Add(dates[0]);
            }
            //bind the listbox to the list
            listBoxDates.DataSource = DatesFormatted;



            }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
           


            }

        private void btnGetProducts_Click_1(object sender, EventArgs e)
        {
            List<string> Products = new List<string>();
            //clear the listbox
            listBoxProducts.Items.Clear();

            //create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getProducts = new OleDbCommand("SELECT [Product ID], [Product Name], Quantity, Discount, Category, [Sub-Category] from  Sheet1", connection);



               
                reader = getProducts.ExecuteReader();
                while (reader.Read())
                {

                    //we enlist the columns to be read 
                    
                    Products.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString() + ", " + reader[5].ToString());



                }
            }


            //bind the listbox to the list
            listBoxProducts.DataSource = Products;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            List<string> Order = new List<string>();
            //clear the listbox
            listBoxOrder.Items.Clear();
            //create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getOrder = new OleDbCommand("SELECT [Order ID], Discount, Quantity, [Ship Mode] from Sheet1", connection);
                reader = getOrder.ExecuteReader();
                while (reader.Read())
                {
                    //we enlist the columns to be read
                    Order.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString());

                }
            }

            //bind the listbox to the list
            listBoxOrder.DataSource = Order;

        }

        private void insertCustomerDimension(string CustomerID, string firstName,string lastName,string country,string city,string state,string postalCode,string region)
        {
            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //Open the SqlConnection
                myConnection.Open();

                //YOU MISSED TO REAJUST THIS LINE OF CODE 'select id from customer where firstName=@firstName
                //SqlCommand command = new SqlCommand("SELECT id FROM Customer WHERE firstName=@name", myConnection);

                //the following code uses an SqlCommand based on the SqlConnection
                SqlCommand command = new SqlCommand("SELECT id FROM Customer WHERE firstName=@firstName", myConnection);

                //'ADDITIONAL COMMAND QUERY MISSING' which is MAKING THE TEST NOT TO GO FORWARD @ WENHONG
                command.Parameters.Add(new SqlParameter("firstName", firstName));

                //Create a variable and assign it to false by defult
                bool exists = false;

                //Run the command & read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if there are rows, it means the customer exsists so change the exsists variable
                    if (reader.HasRows) exists = true;
                }

                if (exists == false)
                {
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Customer (CustomerID, firstName, lastName, country, city, state, postalCode, region)" +
                        " VALUES (@CustomerID, @firstName, @lastName, @country, @city, @state, @postalCode, @region)", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("CustomerID", CustomerID));
                    insertCommand.Parameters.Add(new SqlParameter("firstName", firstName));
                    insertCommand.Parameters.Add(new SqlParameter("lastName", lastName));
                    insertCommand.Parameters.Add(new SqlParameter("country", country));
                    insertCommand.Parameters.Add(new SqlParameter("city", city));
                    insertCommand.Parameters.Add(new SqlParameter("state", state));
                    insertCommand.Parameters.Add(new SqlParameter("postalCode", postalCode));
                    insertCommand.Parameters.Add(new SqlParameter("region", region));


                    // FINALLY THESE TWO LINES OF CODES MUST BE COMMENT OUT
                    //insert the line
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Records affected: " + recordsAffected);
                }

                
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            List<string> Customer = new List<string>();
            //clear the listbox
            listBoxCustomer.Items.Clear();
            //create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getCustomer = new OleDbCommand("SELECT [Customer ID], [Customer Name], Country, City, State, [Postal Code], Region FROM Sheet1", connection);
                reader = getCustomer.ExecuteReader();
                while (reader.Read())
                {
                    //we enlist the columns to be read
                    Customer.Add(reader[0].ToString() + "," + reader[1].ToString() + "," + reader[2].ToString() + "," + reader[3].ToString() + "," + reader[4].ToString() + "," + reader[5].ToString() + "," + reader[6].ToString());

                    string CustomerID = Convert.ToString(reader[0]);
                    //split name into firstname and lastname
                    string name = Convert.ToString(reader[1]);
                    string[] splitname = name.Split(new char[] {' '});
                    string firstName = Convert.ToString(splitname[0]);
                    string lastName = Convert.ToString(splitname[1]);
                    string country = Convert.ToString(reader[2]);
                    string city = Convert.ToString(reader[3]);
                    string state = Convert.ToString(reader[4]);
                    string postalCode = Convert.ToString(reader[5]);
                    string region = Convert.ToString(reader[6]);

                    insertCustomerDimension(CustomerID, firstName,lastName, country, city, state, postalCode, region);
                }
            }

            //bind the listbox to the list
            listBoxCustomer.DataSource = Customer;

         
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.destinationDatabaseDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'destinationDatabaseDataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.destinationDatabaseDataSet2.Customer);
            //// TODO: This line of code loads data into the 'destinationDatabaseDataSet1.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.destinationDatabaseDataSet1.Customer);

        }
    }


        

    
}

