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

        //TODO: I MESSED UP THIS PIECES OF CODE IN THE FORM1 DESIGN VIEW (accidently delete the settu on the form1) so please re do them again

        //private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.customerBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.destinationDatabaseDataSet1);

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'destinationDatabaseDataSet2.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter1.Fill(this.destinationDatabaseDataSet2.Customer);
            //// TODO: This line of code loads data into the 'destinationDatabaseDataSet1.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.destinationDatabaseDataSet1.Customer);

        }

        private void btnGetCustomerFromDatabase_Click(object sender, EventArgs e)
        {
            List<string> Customer = new List<string>();
            //clear the listbox
            //listBoxCustomer.Items.Clear();
            //create the database connection string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                //open the connection
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
                    string[] splitname = name.Split(new char[] { ' ' });
                    string firstName = Convert.ToString(splitname[0]);
                    string lastName = Convert.ToString(splitname[1]);
                    string country = Convert.ToString(reader[2]);
                    string city = Convert.ToString(reader[3]);
                    string state = Convert.ToString(reader[4]);
                    string postalCode = Convert.ToString(reader[5]);
                    string region = Convert.ToString(reader[6]);

                    // insert properties into the customer table dimension
                    insertCustomerDimension(CustomerID, firstName, lastName, country, city, state, postalCode, region);
                }
            }

            

            //Create new list to store the indexed results in.
            List<string> DestinationCustomersNamed = new List<string>();

            //Create the database string 
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStringDestination))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT CustomerID, FirstName, LastName, country, city, state, postalCode,region FROM Customer", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //If there are rows, get them. 
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //TrimEnd() function use to delete all the space which in the end
                            DestinationCustomersNamed.Add(reader["CustomerID"].ToString().TrimEnd() + ", " + reader["FirstName"].ToString().TrimEnd() + ", " +
                              reader["LastName"].ToString().TrimEnd() + ", " + reader["country"].ToString().TrimEnd() + ", " + reader["city"].ToString().TrimEnd() +
                              ", " + reader["state"].ToString().TrimEnd() + ", " + reader["postalCode"].ToString().TrimEnd() + ", " + reader["region"].ToString().TrimEnd());

                        }
                    }
                    else
                    {
                        DestinationCustomersNamed.Add("No Data present.");
                    }
                }

            }
            listBoxCustomerFromDbNamed.DataSource = DestinationCustomersNamed;
        }



        private void btnDimension_Click(object sender, EventArgs e)
        {

            List<string> Dates = new List<string>();
            //clear the listbox
            listBoxDates.Items.Clear();

            List<string> Products = new List<string>();
            //clear the listbox
            listBoxProducts.Items.Clear();

            List<string> Customer = new List<string>();
            //clear the listbox
            listBoxCustomer.Items.Clear();

            //create the database connection string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getDates = new OleDbCommand("SELECT [Order Date], [Ship Date] from Sheet1", connection);
                OleDbCommand getProducts = new OleDbCommand("SELECT [Product ID], [Product Name], Quantity, Discount, Category, [Sub-Category] from  Sheet1", connection);
                OleDbCommand getCustomer = new OleDbCommand("SELECT [Customer ID], [Customer Name], Country, City, State, [Postal Code], Region FROM Sheet1", connection);

                reader = getDates.ExecuteReader();
                reader = getProducts.ExecuteReader();
                reader = getCustomer.ExecuteReader();

                while (reader.Read())
                {//Add Dates
                    Dates.Add(reader[0].ToString());
                    Dates.Add(reader[1].ToString());

                    //Add Products
                    Products.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString() + ", " + reader[5].ToString());
                    
                    //Add customers
                    Customer.Add(reader[0].ToString() + "," + reader[1].ToString() + "," + reader[2].ToString() + "," + reader[3].ToString() + "," + reader[4].ToString() + "," + reader[5].ToString() + "," + reader[6].ToString());
                    string CustomerID = Convert.ToString(reader[0]);
                    
                    //split name into firstname and lastname
                    string name = Convert.ToString(reader[1]);
                    string[] splitname = name.Split(new char[] { ' ' });
                    string firstName = Convert.ToString(splitname[0]);
                    string lastName = Convert.ToString(splitname[1]);
                    string country = Convert.ToString(reader[2]);
                    string city = Convert.ToString(reader[3]);
                    string state = Convert.ToString(reader[4]);
                    string postalCode = Convert.ToString(reader[5]);
                    string region = Convert.ToString(reader[6]);

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
            //bind the listbox to the list

            listBoxProducts.DataSource = Products;

            //bind the listbox to the list
            listBoxCustomer.DataSource = Customer;

         
                }
            }
        }
 

