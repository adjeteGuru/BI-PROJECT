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

        private int GetDateId(string date)
        {
            
            return 0;
        }

        private void splitDates(string date)
        {
            //Split the date down and assign it to variables for later use.
            string[] arrayDate = date.Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);

            string dayOfWeek = dateTime.DayOfWeek.ToString();
            int dayOfYear = dateTime.DayOfYear;
            string monthName = dateTime.ToString("MMMM");//check this
            int weekNumber = dayOfYear / 7;
            bool Weekend = false;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") Weekend = true;
            string dbDate = dateTime.ToString("M/dd/yyyy");

            insertTimeDimension(dbDate, dayOfWeek, day, monthName, month, weekNumber, year, Weekend, dayOfYear);
        }

        private void insertTimeDimension(string date, string dayName, int dayNumber, string monthName, int monthNumber, int weekNumber, int year, bool weekend, int dayOfYear)
        {
            //create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {

                //open the SqlConnection
                myConnection.Open();
                //The following code uses an SqlCommand based on the SqlConnection.
                SqlCommand command = new SqlCommand("SELECT id FROM Time Where date = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", date));

                //create a variable and assign it to false by default.
                bool exists = false;

                //Run the command & read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                    //if there are rows, it means the date exists so change the exists variable.
                    if (reader.HasRows) exists = true;
                }

                if(exists == false)
                {
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Time (dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend, date, dayOfYear)" +
                        "VALUES (@dayName, @dayNumber, @monthName, @monthNumber, @weekNumber, @year, @weekend, @date, @dayOfYear)", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("dayName", dayName));
                    insertCommand.Parameters.Add(new SqlParameter("dayNumber", dayNumber));
                    insertCommand.Parameters.Add(new SqlParameter("monthName", monthName));
                    insertCommand.Parameters.Add(new SqlParameter("monthNumber", monthNumber));
                    insertCommand.Parameters.Add(new SqlParameter("weekNumber", weekNumber));
                    insertCommand.Parameters.Add(new SqlParameter("year", year));
                    insertCommand.Parameters.Add(new SqlParameter("weekend", weekend));
                    insertCommand.Parameters.Add(new SqlParameter("date", date));
                    insertCommand.Parameters.Add(new SqlParameter("dayOfYear", dayOfYear));


                    //executes the above insert lines of code
                    insertCommand.ExecuteNonQuery();
                    //insert the line
                    //create a variable to display the no of rows affected and assign it to the execute command
                    //int recordsAffected = insertCommand.ExecuteNonQuery();
                    //display outcome on console output
                    //Console.WriteLine("Records affected: " + recordsAffected);

                    //insertCommand.ExecuteNonQuery();

                }
            }
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

            
            
            //listBoxFromDB.DataSource = btnDestinationDB;

           
            
            
               
            //split the dates and insert every date in the list
            foreach (string date in DatesFormatted)
            {
                splitDates(date);
                //Console.WriteLine("splitdates loop OK");
            }

           
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
                OleDbCommand getProducts = new OleDbCommand("SELECT [Product Id], [Product Name], Quantity, Discount, Category, [Sub-Category] from  Sheet1", connection);

               
                
                reader = getProducts.ExecuteReader();
                while (reader.Read())
                {
                    Products.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString() + ", " + reader[5].ToString());

                    string category = reader[4].ToString();
                    string subcategory = reader[5].ToString();
                    string name = reader[1].ToString();
                    string productCode = reader[0].ToString();

                    insertProductDimension(category, subcategory, name, productCode);
                }
            }

            //bind the listbox to the list
            listBoxProducts.DataSource = Products;

          
        }



        private void insertProductDimension(string category, string subcategory, string name, string productCode)
        {
            //create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {

                //open the SqlConnection
                myConnection.Open();
                //The following code uses an SqlCommand based on the SqlConnection.
                SqlCommand command = new SqlCommand("SELECT Id FROM Product WHERE name = @name", myConnection);
                command.Parameters.Add(new SqlParameter("productcode", productCode));
                command.Parameters.Add(new SqlParameter("name", name));
                command.Parameters.Add(new SqlParameter("subcategory", subcategory));
                command.Parameters.Add(new SqlParameter("category", category));

                //create a variable and assign it to false by default.
                bool exists = false;

                //run the command & read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    //if there are rows, it means the data exists so change the exists variable
                    if (reader.HasRows) exists = true;
                }

                if (exists == false)
                {
                    SqlCommand insertCommand = new SqlCommand(
                        "INSERT INTO Product (category, subcategory, name, productcode)" +
                        "VALUES (@category, @subcategory, @name, @productcode)", myConnection);

                    insertCommand.Parameters.Add(new SqlParameter("category", category));
                    insertCommand.Parameters.Add(new SqlParameter("subcategory", subcategory));
                    insertCommand.Parameters.Add(new SqlParameter("name", name));
                    insertCommand.Parameters.Add(new SqlParameter("productcode", productCode));

                    //insert the line
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Records affected: " + recordsAffected);
                }
            }
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


            //bing the listbox to the list
            listBoxOrder.DataSource = Order;
        }

        //private void splitCustomer(string customer)
        //{//must continous
        //    //Split the customer down and assign it to variables for later use
        //    string[] arrayCustomer = customer.Split(' ');

        //    //HERE TOO....YOU MISSED THAT ARRAY ALWAY STARTING FROM '0'

        //    //string name = Convert.ToString(arrayCustomer[1]);
        //    //string country = Convert.ToString(arrayCustomer[2]);
        //    //string city = Convert.ToString(arrayCustomer[3]);
        //    //string state = Convert.ToString(arrayCustomer[4]);
        //    //string postalCode = Convert.ToString(arrayCustomer[5]);
        //    //string region = Convert.ToString(arrayCustomer[6]);

        //    //ALSO YOU DIDN'T CONVERT REFERENCE TO ARRAY
        //    //string reference = "Test";

        //    string CustomerID = Convert.ToString(arrayCustomer[0]);
        //    string name = Convert.ToString(arrayCustomer[1]);
        //    string country = Convert.ToString(arrayCustomer[2]);
        //    string city = Convert.ToString(arrayCustomer[3]);
        //    string state = Convert.ToString(arrayCustomer[4]);
        //    string postalCode = Convert.ToString(arrayCustomer[5]);
        //    string region = Convert.ToString(arrayCustomer[6]);


        //    insertCustomerDimension(CustomerID, name, country, city, state, postalCode, region);
        //}

        private void insertCustomerDimension(string CustomerID, string name, string country, string city, string state, string postalCode, string region)
        {
            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //Open the SqlConnection
                myConnection.Open();
                //the following code uses an SqlCommand based on the SqlConnection
                SqlCommand command = new SqlCommand("SELECT id FROM Customer WHERE name=@name", myConnection);

                //'ADDITIONAL COMMAND QUERY MISSING' which is MAKING THE TEST NOT TO GO FORWARD @ WENHONG

                command.Parameters.Add(new SqlParameter("name", name));


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
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Customer (CustomerID, name, country, city, state, postalCode, region)" +
                        " VALUES (@CustomerID, @name, @country, @city, @state, @postalCode, @region)", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("CustomerID", CustomerID));
                    insertCommand.Parameters.Add(new SqlParameter("name", name));
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
                    string name = Convert.ToString(reader[1]);
                    string country = Convert.ToString(reader[2]);
                    string city = Convert.ToString(reader[3]);
                    string state = Convert.ToString(reader[4]);
                    string postalcode = Convert.ToString(reader[5]);
                    string region = Convert.ToString(reader[6]);

                    insertCustomerDimension(CustomerID, name, country, city, state, postalcode, region);
                }
            }

            //bind the listbox to the list
            listBoxCustomer.DataSource = Customer;

            
        }

        private void btnDestinationDB_Click(object sender, EventArgs e)
        {
            //create new list to store the indexed results in
            List<string> DestinationDates = new List<string>();

            //create new list to store the named results in
            List<string> DestinationDatesNamed = new List<string>();


            //create the database string
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStringDestination))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend, date, dayOfYear from Time", connection);


                using (SqlDataReader reader = command.ExecuteReader()) 
                    //if there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DestinationDates.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString() 
                            + ", " + reader[5].ToString() + ", " + reader[6].ToString() + ", " + reader[7].ToString() + ", " + reader[8].ToString());

                            DestinationDatesNamed.Add(reader["dayName"].ToString() + ", " + reader["dayNumber"].ToString() + ", " + reader["monthName"].ToString() + ", " + reader["monthNumber"].ToString() 
                            + ", " + reader["weekNumber"].ToString() + ", " + reader["year"].ToString() + ", " + reader["weekend"].ToString() + ", " + reader["date"].ToString() + ", " + reader["dayOfYear"].ToString());
                        }

                        
                    }
                    else
                    {
                        DestinationDates.Add("No data present");
                        DestinationDatesNamed.Add("No data present");
                    }

                //bind the listbox to the list
                listBoxFromDB.DataSource = DestinationDates;
                //bind the listbox to the list
                listBoxFromDBNamed.DataSource = DestinationDatesNamed;

            }
        }
    }


        

    
}

