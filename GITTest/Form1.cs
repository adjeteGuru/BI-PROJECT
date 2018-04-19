using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        //Get Date ID
        private int GetDateId(string date)

        {


            //Split the date down and assign it to variables for later use. 
            string[] dateWithoutTime = date.Split(' ');

            string[] arrayDate = dateWithoutTime[0].Split('/');


            int year = Convert.ToInt32(arrayDate[2]);

            int month = Convert.ToInt32(arrayDate[1]);

            int day = Convert.ToInt32(arrayDate[0]);


            DateTime dateTime = new DateTime(year, month, day);


            string dbDate = dateTime.ToString("M/dd/yyyy");



            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;


            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))

            {


                //open the SqlConnection 

                myConnection.Open();

                //The following code uses an SqlCommand based on the SqlConnection. 

                SqlCommand command = new SqlCommand("SELECT id FROM Time Where date = @date", myConnection);

                command.Parameters.Add(new SqlParameter("date", dbDate));


                //Run the command & read the results 
                using (SqlDataReader reader = command.ExecuteReader())

                {

                    int timeId = 0;
                    //if there are rows, it means the date exists so change the exists variable. 

                    if (reader.HasRows)

                    {
                        while (reader.Read())
                        {
                            timeId = Convert.ToInt32(reader["id"].ToString());

                        }

                    }
                    return timeId;
                }

            }



        }

        //Get Product ID
        private int GetProductId(string productcode)

        {


            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;


            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))

            {


                //open the SqlConnection 

                myConnection.Open();

                //The following code uses an SqlCommand based on the SqlConnection. 

                SqlCommand command = new SqlCommand("SELECT Id FROM Product Where productcode = @productcode", myConnection);

                command.Parameters.Add(new SqlParameter("productcode", productcode));


                //Run the command & read the results 

                using (SqlDataReader reader = command.ExecuteReader())

                {
                    int productId = 0;

                    //if there are rows, it means the product exists so change the exists variable. 

                    if (reader.HasRows)

                    {
                        while (reader.Read())
                        {
                            productId = Convert.ToInt32(reader["Id"].ToString());
                        }

                    }
                    return productId;
                }

            }

        }

        //Get Customer Id
        private int GetCustomerId(string CustomerID)
        {
            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {

                // Open the SqlConnection.
                myConnection.Open();
                // The following code uses an SqlCommand based on the SqlConnection.
                SqlCommand command = new SqlCommand("SELECT Id FROM Customer WHERE CustomerID = @CustomerID", myConnection);
                command.Parameters.Add(new SqlParameter("CustomerID", CustomerID));

                //Run the command & read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    int customerId = 0;
                    //If there are rows, it means the date exsists so change the exsists variable. 
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            customerId = Convert.ToInt32(reader["Id"].ToString());
                        }
                    }
                    return customerId;
                }


            }
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

                if (exists == false)
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

                    //insert the lines
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Records affected: " + recordsAffected);

                    //insertCommand.ExecuteNonQuery();
                }
            }
        }


        private void insertProductDimension(string category, string subcategory, string productname, string productCode)
        {
            //create a connection to the MDF file 
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {

                //open the SqlConnection 
                myConnection.Open();
                //The following code uses an SqlCommand based on the SqlConnection. 
                SqlCommand command = new SqlCommand("SELECT Id FROM Product WHERE productname = @productname", myConnection);
                command.Parameters.Add(new SqlParameter("productcode", productCode));
                command.Parameters.Add(new SqlParameter("productname", productname));
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
                        "INSERT INTO Product (category, subcategory, productname, productcode)" +
                        "VALUES (@category, @subcategory, @productname, @productcode)", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("category", category));
                    insertCommand.Parameters.Add(new SqlParameter("subcategory", subcategory));
                    insertCommand.Parameters.Add(new SqlParameter("productname", productname));
                    insertCommand.Parameters.Add(new SqlParameter("productcode", productCode));

                    //insert the line 
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Records affected: " + recordsAffected);
                }
            }
        }



        private void insertCustomerDimension(string CustomerID, string firstName, string lastName, string country, string city, string state, string postalCode, string region)
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

        private void insertFactTableDimension(int productId, int timeId, int customerId, double value, double discount, double profit, int quantity)
        {
            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //Open the SqlConnection
                myConnection.Open();



                SqlCommand insertCommand = new SqlCommand("INSERT INTO FactTable (productId, timeId, customerId, value, discount, profit, quantity)" +
                    " VALUES (@productId, @timeId, @customerId, @value, @discount, @profit, @quantity)", myConnection);
                insertCommand.Parameters.Add(new SqlParameter("productId", productId));
                insertCommand.Parameters.Add(new SqlParameter("timeId", timeId));
                insertCommand.Parameters.Add(new SqlParameter("customerId", customerId));
                insertCommand.Parameters.Add(new SqlParameter("value", value));
                insertCommand.Parameters.Add(new SqlParameter("discount", discount));
                insertCommand.Parameters.Add(new SqlParameter("profit", profit));
                insertCommand.Parameters.Add(new SqlParameter("quantity", quantity));


                // FINALLY THESE TWO LINES OF CODES MUST BE COMMENT OUT
                //insert the line
                int recordsAffected = insertCommand.ExecuteNonQuery();
                Console.WriteLine("build Fact Table Records affected: " + recordsAffected);


            }
        }



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
            string connectionString2 = Properties.Settings.Default.Dataset2ConnectionString;

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
                connection.Close();

            }
            //pull data from the second data source and add to the customer list
            using (OleDbConnection connection = new OleDbConnection(connectionString2))
            {
                //open the connection
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getCustomer = new OleDbCommand("SELECT [Customer ID], [Customer Name], Country, City, State, [Postal Code], Region FROM [Student Sample 2 - Sheet1]", connection);
                reader = getCustomer.ExecuteReader();
                while (reader.Read())
                {

                    bool error = false;


                    //Check Customer ID for irregular data
                    if (VerifyCustomerId(reader[0].ToString()) == false)

                    {
                        error = true;
                    }


                    if (error == false)
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

            //create new lists to store the named read results in 
            List<string> DestinationProducts = new List<string>();

            List<string> Dates = new List<string>();

            List<string> Customer = new List<string>();

            List<string> Fact = new List<string>();


            //create the database string 
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStringDestination))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT category, subcategory, productname, productcode from Product", connection);
                SqlCommand command2 = new SqlCommand("SELECT dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend, date, dayOfYear from Time", connection);
                SqlCommand command3 = new SqlCommand("SELECT CustomerID, FirstName, LastName, country, city, state, postalCode, region from Customer", connection);
                SqlCommand command4 = new SqlCommand("SELECT productId, customerId, timeId, value, quantity, discount, profit FROM FactTable", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if there are rows, it means the products exists so change the exists variable 
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DestinationProducts.Add(reader["category"].ToString().TrimEnd() + ", " + reader["subcategory"].ToString().TrimEnd() + ", " + reader["productname"].ToString().TrimEnd() + ", " + reader["productcode"].ToString().TrimEnd());
                        }

                    }
                    else
                    {
                        DestinationProducts.Add("No data present");
                    }
                }
                //bind the listbox to the list 
                listBoxProducts.DataSource = DestinationProducts;

                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    //if there are rows, it means the date exists so change the exists variable 
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //TrimEnd function used to delete all the spaces after each record
                            Dates.Add(reader["dayName"].ToString().TrimEnd() + ", " + reader["dayNumber"].ToString().TrimEnd() + ", " + reader["monthName"].ToString().TrimEnd() + ", " + reader["monthNumber"].ToString().TrimEnd() + ", " + reader["weekNumber"].ToString().TrimEnd() + ", " + reader["year"].ToString().TrimEnd() + ", " + reader["weekend"].ToString().TrimEnd() + ", " + reader["date"].ToString().TrimEnd() + ", " + reader["dayOfYear"].ToString().TrimEnd());
                        }
                    }

                    else
                    {
                        Dates.Add("No data present");
                    }
                }
                //bind the listbox to the list 
                listBoxDates.DataSource = Dates;

                using (SqlDataReader reader = command3.ExecuteReader())
                {
                    //if there are rows, it means the date exists so change the exists variable 
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //TrimEnd function used to delete all the spaces after each record
                            Customer.Add(reader["CustomerID"].ToString().TrimEnd() + ", " + reader["FirstName"].ToString().TrimEnd() + ", " + reader["LastName"].ToString().TrimEnd() + ", " + reader["country"].ToString().TrimEnd() + ", " + reader["city"].ToString().TrimEnd() + ", " + reader["state"].ToString().TrimEnd() + ", " + reader["postalCode"].ToString().TrimEnd() + ", " + reader["region"].ToString().TrimEnd());
                        }
                    }



                    else
                    {
                        Customer.Add("No data present");
                    }
                }
                //bing the listbox to the list
                listBoxCustomer.DataSource = Customer;

                using (SqlDataReader reader = command4.ExecuteReader())
                {
                    //if there are rows, it means the date exists so change the exists variable
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //trimend function used to delete all the spaces after each record
                            Fact.Add(reader["productId"].ToString().TrimEnd() + ", " + reader["customerId"].ToString().TrimEnd() + ", " + reader["timeId"].ToString().TrimEnd() + ", " + reader["value"].ToString().TrimEnd() + ", " + reader["discount"].ToString().TrimEnd() + ", " + reader["quantity"].ToString().TrimEnd() + ", " + reader["profit"].ToString().TrimEnd());
                        }
                    }
                    else
                    {
                        Fact.Add("No data present");
                    }
                }
                listBoxFactable.DataSource = Fact;

            }
        }

        private void btnGetProductFromDatabase_Click(object sender, EventArgs e)
        {
            //We create a list for the products 
            List<string> Products = new List<string>();
            //clear the listbox 
            //listBoxProductFromDbNamed.Items.Clear();                                            /* POSSIBLE RENAMING*/
            //create the database string 
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;
            string connectionString2 = Properties.Settings.Default.Dataset2ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getProducts = new OleDbCommand("SELECT [Product Id], [Product Name], Quantity, Discount, Category, [Sub-Category] from  Sheet1", connection);
                reader = getProducts.ExecuteReader();
                while (reader.Read())
                {

                    Products.Add(reader[0].ToString().TrimEnd() + ", " + reader[1].ToString().TrimEnd() + ", " + reader[2].ToString().TrimEnd() + ", " + reader[3].ToString().TrimEnd() + ", " + reader[4].ToString().TrimEnd() + ", " + reader[5].ToString().TrimEnd());

                    string category = reader[4].ToString();
                    string subcategory = reader[5].ToString();
                    string name = reader[1].ToString();
                    string productCode = reader[0].ToString();

                    insertProductDimension(category, subcategory, name, productCode);
                }
                connection.Close();
            }
            //begin reading from the second data source  and add to the products list
            using (OleDbConnection connection = new OleDbConnection(connectionString2))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //new select command to pull data from sheet2

                OleDbCommand getProducts = new OleDbCommand("SELECT [Product Id], [Product Name], Category, [Sub-Category] from [Student Sample 2 - Sheet1]", connection);

                reader = getProducts.ExecuteReader();

                while (reader.Read())
                {

                    Products.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString());

                    string category = reader[2].ToString();
                    string subcategory = reader[3].ToString();
                    string name = reader[1].ToString();
                    string productCode = reader[0].ToString();

                    insertProductDimension(category, subcategory, name, productCode);
                }

            }

            //create new list to store the named results in 
            List<string> DestinationProducts = new List<string>();

            //create the database string 
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionStringDestination))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT category, subcategory, productname, productcode from Product", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                    //if there are rows, it means the date exists so change the exists variable 
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DestinationProducts.Add(reader["category"].ToString() + ", " + reader["subcategory"].ToString() + ", " + reader["productname"].ToString() + ", " + reader["productcode"].ToString());
                        }

                    }
                    else
                    {
                        DestinationProducts.Add("No data present");
                    }

                //bind the listbox to the list 
                listBoxProductFromDbNamed.DataSource = DestinationProducts;

            }
        }



        //Kindly ignore because of the reference
        //deleting will me too much trouble
        private void listBoxCustomerFromDbNamed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnDates_Click(object sender, EventArgs e)
        {
            List<string> Dates = new List<string>();
            //clear the listbox 
            //listBoxDates.Items.Clear();
            //create the database string 
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;
            string connectionString2 = Properties.Settings.Default.Dataset2ConnectionString;

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
                connection.Close();
            }
            //pull data from the second data source and add to the dates list
            using (OleDbConnection connection = new OleDbConnection(connectionString2))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getDates = new OleDbCommand("SELECT [Order Date], [Ship Date] from [Student Sample 2 - Sheet1]", connection);
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
            listBoxDateFromSource.DataSource = DatesFormatted;
            //split the dates and insert every date in the list 
            foreach (string date in DatesFormatted)
            {
                splitDates(date);
                //Console.WriteLine("splitdates loop OK"); 
            }
        }

        private void btnGetFactTable_Click(object sender, EventArgs e)
        {
            List<string> Fact = new List<string>();
            //clear the listbox
            //listBoxCustomer.Items.Clear();
            //create the database connection string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;
            string connectionString2 = Properties.Settings.Default.Dataset2ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                //open the connection
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getFact = new OleDbCommand("SELECT [Order Date], [Customer ID], [Product ID], Sales, Quantity, Discount, Profit FROM Sheet1", connection);
                reader = getFact.ExecuteReader();
                while (reader.Read())
                {
                    bool error = false;

                    //Check Order Date column for incorrect date format
                    try
                    {
                        DateTime tempDate;
                        tempDate = Convert.ToDateTime(reader[0].ToString());
                    }
                    catch
                    {
                        error = true;
                    }


                    //Check customerID column for incorrect customerID format
                    if (VerifyCustomerId(reader[1].ToString()) == false)

                    {
                        error = true;
                    }


                    //go ahead to insert only when there are no errors
                    if (error == false)
                    {

                        //we enlist the columns to be read
                        Fact.Add(reader[0].ToString() + "," + reader[1].ToString() + "," + reader[2].ToString() + "," + reader[3].ToString() + ", " + reader[4].ToString() + ", " + reader[5].ToString() + ", " + reader[6].ToString());

                        int productId = GetProductId(reader[2].ToString());
                        int TimeId = GetDateId(reader[0].ToString());
                        int CustomerId = GetCustomerId(reader[1].ToString());
                        double sales = Convert.ToDouble(reader[3]);
                        double discount = Convert.ToDouble(reader[5]);
                        double profit = Convert.ToDouble(reader[6]);
                        int quantity = Convert.ToInt32(reader[4]);
                        //double value = (sales / discount - profit) / quantity;
                        double value = sales / quantity;


                        // insert properties into the fact table dimension
                        insertFactTableDimension(productId, TimeId, CustomerId, value, discount, profit, quantity);
                    }
                }
                //display the records being inserted to the fact table
                listBoxFactTableSource.DataSource = Fact;
            }



            //begin to read data from the second data source
            using (OleDbConnection connection = new OleDbConnection(connectionString2))
            {
                //open the connection
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getFact = new OleDbCommand("SELECT [Order Date], [Customer ID], [Product ID], Sales, Quantity, Discount, Profit FROM [Student Sample 2 - Sheet1]", connection);
                reader = getFact.ExecuteReader();
                while (reader.Read())
                {
                    bool error = false;

                    //Check Order Date for incorrect date format
                    try
                    {
                        DateTime tempDate;
                        tempDate = Convert.ToDateTime(reader[0].ToString());
                    }
                    catch
                    {
                        error = true;
                    }


                    //Check Customer ID for incorrect customerID format
                    if (VerifyCustomerId(reader[1].ToString()) == false)

                    {
                        error = true;
                    }

                    //check productID for incorrect productID format

                    if (VerifyProductId(reader[2].ToString()) == false)
                    {
                        error = true;
                    }


                    //check for sales
                    try
                    {
                        decimal tempSales;
                        tempSales = Convert.ToDecimal(reader[3].ToString());

                    }
                    catch
                    {
                        error = true;
                    }


                    //if there are no errors, proceed to insert the row.
                    if (error == false)
                    {
                        //we enlist the columns to be read
                        Fact.Add(reader[0].ToString() + "," + reader[1].ToString() + "," + reader[2].ToString() + "," + reader[3].ToString() + ", " + reader[4].ToString() + ", " + reader[5].ToString() + ", " + reader[6].ToString());

                        int productId = GetProductId(reader[2].ToString());
                        int TimeId = GetDateId(reader[0].ToString());
                        int CustomerId = GetCustomerId(reader[1].ToString());
                        double sales = Convert.ToDouble(reader[3]);
                        double discount = Convert.ToDouble(reader[5]);
                        double profit = Convert.ToDouble(reader[6]);
                        int quantity = Convert.ToInt32(reader[4]);
                        //double value = (sales / discount - profit) / quantity;
                        double value = sales / quantity;

                        //check to ensure all 3 foreign keys have valid values
                        if (productId > 0 & CustomerId > 0 & TimeId > 0)
                        {
                            // insert properties into the customer table dimension
                            insertFactTableDimension(productId, TimeId, CustomerId, value, discount, profit, quantity);
                        }
                        else
                        {

                            error = true;

                        }
                    }
                }
                //display the records being inserted to the fact table
                listBoxFactTableSource.DataSource = Fact;
            }
        }

        //declaring a regex variable to allow for use in validating customerID and the acceptable format in regular expression
        private static readonly Regex customerIDCheck = new Regex(@"^\w+\-\d{5}$");

        public static bool VerifyCustomerId(string customerID)
        {
            //return value
            return customerIDCheck.IsMatch(customerID);
        }


        //declaring a regex variable to allow for use in validating productID and the acceptable format in regular expression
        private static readonly Regex productIDCheck = new Regex(@"^\w+\-\w+\-\d{8}$");

        public static bool VerifyProductId(string productID)
        {
            //return value
            return productIDCheck.IsMatch(productID);
        }


        private void btnLoadDataSaleRegion_Click(object sender, EventArgs e)
        {
            //Create a list to handle the region
            List<string> regionList = new List<string>(new string[] { "Central", "East", "West", "South" });
            //Create a dictionary to habdle salesCount
            Dictionary<string, int> salesCount = new Dictionary<string, int>();

            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            //run the code once for each date in the list
            foreach (string region in regionList)
            {
                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {
                    //Open the SqlConnection
                    myConnection.Open();
                    //The following code use an SqlCommand based on the SqlConnection
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) AS SalesNumber FROM FactTable JOIN Customer " +
                        "ON FactTable.customerId = Customer.Id WHERE Customer.region = @region; ", myConnection);
                    command.Parameters.Add(new SqlParameter("region", region));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //If there are rows, it means there were sales
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                salesCount.Add(region, Int32.Parse(reader["SalesNumber"].ToString()));
                            }
                        }
                        //if there are no rows it means there were 0 sales
                        else
                        {
                            salesCount.Add(region, 0);
                        }
                    }
                }
            }
            //End foreach
            chart1.DataSource = salesCount;
            chart1.Series[0].XValueMember = "Key";
            chart1.Series[0].YValueMembers = "Value";
            chart1.DataBind();

            ///-------------------------------------------------------------------------------------------------------------
            ///

            //This is a hardcoded week - the lowest grade.
            //Ideally this range would come from your database or elsewhere to allow the user to pick which dates they want to see.
            //A good idea could be to create an empty list and then add in the week of dates you need? Up to you!
            //List<string> datelist = new List<string>(new string[] { "01/06/2014", "01/07/2014", "01/08/2014", "01/09/2014", "01/10/2014", "01/11/2014", "01/12/2014" });
            //List<string> datelist = new List<string>(new string[] { "01/06/2014", "01/07/2014", "01/08/2014", "01/09/2014", "01/10/2014", "01/11/2014", "01/12/2014" });
            string selectedDate = Convert.ToDateTime(dateTimePicker.Text).ToString();
            string[] splitedDate = selectedDate.Split(' ');

            string[] arrayDate = splitedDate[0].Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);

            string dbDate = dateTime.ToString("M/dd/yyyy");

            List<string> datelist = new List<string>(new string[] { dateTime.ToString("M/dd/yyyy"), dateTime.AddDays(1).ToString("M/dd/yyyy"), dateTime.AddDays(2).ToString("M/dd/yyyy"), dateTime.AddDays(3).ToString("M/dd/yyyy"), dateTime.AddDays(4).ToString("M/dd/yyyy"), dateTime.AddDays(5).ToString("M/dd/yyyy"), dateTime.AddDays(6).ToString("M/dd/yyyy") });

            //I need somewhere to hold the information pulled from the database! This is an empty dictionary.
            //I am using a dictionary as I can then manually set my own "key" so rather than it being accessed through [0], [1] ect, i can access it via the date.
            //The dictionary type is string, int - date, number of sales.
            Dictionary<string, int> quantity = new Dictionary<string, int>();

            //Create aconnectionto the MDF file. We only need this ince so its outside my loop
            // string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            //run this code once for each date in my list - in my case 7 times
            foreach (string date in datelist)
            {
                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {
                    //open the SqlConnection
                    myConnection.Open();
                    //the following code uses an SqlCommand base on the SqlConnection
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) AS quantity FROM FactTable JOIN Time ON FactTable.timeId = Time.id WHERE Time.date = @date;", myConnection);
                    command.Parameters.Add(new SqlParameter("date", date));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //if there are rows, it means there were sales
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //this line adds a dictionary item with the key of the date, and the value being the sales number
                                //I could access this after by doing: int numberOfSales = salesCount["06/01/2014"]; - try it and write it to the console to test!
                                quantity.Add(date, Int32.Parse(reader["quantity"].ToString()));
                            }
                        }
                        //if there are no rows it means there were 0 sales, so we also need to handle this!
                        else
                        {
                            quantity.Add(date, 0);
                        }
                        //end of the foreach loop. we now have a (hopefully) filled array

                        //now to bulid a bar chart
                        chart4.DataSource = quantity;
                        chart4.Series[0].XValueMember = "Key";
                        chart4.Series[0].YValueMembers = "Value";
                        chart4.DataBind();
                    }
                }
            }

            //--------------------------------------------------------------------------------------------

            //Create a list to handle the region
            List<string> stateList = new List<string>(new string[] { "Texas", "Illinois", "Pennsylvania", "California", "Georgia", "Kentucky", "Virginia", "Delaware", "Louisiana", "South Carolina" });
            //Create a dictionary to habdle salesCount
            Dictionary<string, int> SaleByState = new Dictionary<string, int>();



            //run the code once for each date in the list
            foreach (string state in stateList)
            {
                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {
                    //Open the SqlConnection
                    myConnection.Open();
                    //The following code use an SqlCommand based on the SqlConnection
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) AS SalesNumber FROM FactTable JOIN Customer " +
                        "ON FactTable.customerId = Customer.Id WHERE Customer.state = @state; ", myConnection);
                    command.Parameters.Add(new SqlParameter("state", state));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //If there are rows, it means there were sales
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                SaleByState.Add(state, Int32.Parse(reader["SalesNumber"].ToString()));
                            }
                        }
                        //if there are no rows it means there were 0 sales
                        else
                        {
                            SaleByState.Add(state, 0);
                        }
                    }
                }
            }
            //End foreach
            chart5.DataSource = SaleByState;
            chart5.Series[0].XValueMember = "Key";
            chart5.Series[0].YValueMembers = "Value";
            chart5.DataBind();

            //-----------------------------------------------------------------------------------------------------

            //This is a hardcoded week - the lowest grade.
            //Ideally this range would come from your database or elsewhere to allow the user to pick which dates they want to see.
            //A good idea could be to create an empty list and then add in the week of dates you need? Up to you!
            //List<string> datelist = new List<string>(new string[] { "01/06/2014", "01/07/2014", "01/08/2014", "01/09/2014", "01/10/2014", "01/11/2014", "01/12/2014" });

            
            List<string> productType = new List<string>(new string[] { "Office Supplies", "Furniture", "Technology" });

            //I need somewhere to hold the information pulled from the database! This is an empty dictionary.
            //I am using a dictionary as I can then manually set my own "key" so rather than it being accessed through [0], [1] ect, i can access it via the date.
            //The dictionary type is string, int - date, number of sales.
            Dictionary<string, double> Sale = new Dictionary<string, double>();

            Dictionary<string, double> salesByProductType = new Dictionary<string, double>();



            //run this code once for each date in my list - in my case 7 times
            foreach (string date in datelist)
            {

                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {
                    //open the SqlConnection
                    myConnection.Open();
                    //the following code uses an SqlCommand base on the SqlConnection
                    SqlCommand command = new SqlCommand("SELECT profit FROM FactTable JOIN Time ON FactTable.timeId = Time.id WHERE Time.date = @date;", myConnection);
                    command.Parameters.Add(new SqlParameter("date", date));


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //if there are rows, it means there were sales
                        if (reader.HasRows)
                        {
                            double gain = 0;
                            while (reader.Read())
                            {

                                //this line adds a dictionary item with the key of the date, and the value being the sales number
                                //I could access this after by doing: int numberOfSales = salesCount["06/01/2014"]; - try it and write it to the console to test!

                                gain = Convert.ToDouble(reader[0].ToString()) + gain;

                            }
                            Sale.Add(date, gain);
                        }
                        //if there are no rows it means there were 0 sales, so we also need to handle this!
                        else
                        {
                            Sale.Add(date, 0);
                        }
                        //end of the foreach loop. we now have a (hopefully) filled array

                        //now to bulid a bar chart
                        chart6.DataSource = Sale;
                        chart6.Series[0].XValueMember = "Key";
                        chart6.Series[0].YValueMembers = "Value";
                        chart6.DataBind();

                        ////or a pie chart                      
                        //pieChart.DataSource = salesCount;
                        //pieChart.Series[0].XValueMember = "Key";
                        //pieChart.Series[0].YValueMembers = "Value";
                        //pieChart.DataBind();


                    }
                }


            }

            foreach (string category in productType)
            {
                double gain = 0;

                foreach (string date in datelist)
                {
                    using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                    {
                        //open the SqlConnection
                        myConnection.Open();
                        //the following code uses an SqlCommand base on the SqlConnection
                        SqlCommand command = new SqlCommand("SELECT profit FROM FactTable JOIN Product ON FactTable.productId = Product.Id JOIN Time ON FactTable.timeId = Time.id WHERE Product.category = @category AND Time.date = @date;", myConnection);
                        command.Parameters.Add(new SqlParameter("category", category));
                        command.Parameters.Add(new SqlParameter("date", date));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            //if there are rows, it means there were sales
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    gain = Convert.ToDouble(reader[0].ToString()) + gain;
                                }

                            }
                            //if there are no rows it means there were 0 sales, so we also need to handle this!
                            else
                            {

                            }


                        }

                    }
                }

                salesByProductType.Add(category, gain);

                chart7.DataSource = salesByProductType;
                chart7.Series[0].XValueMember = "Key";
                chart7.Series[0].YValueMembers = "Value";
                chart7.DataBind();

            }
        }
    


        private void btnQuantityWeekly_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSalesProductType_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonProfit_Click(object sender, EventArgs e)
        {
            //This is a hardcoded week - the lowest grade.
            //Ideally this range would come from your database or elsewhere to allow the user to pick which dates they want to see.
            //A good idea could be to create an empty list and then add in the week of dates you need? Up to you!
            //List<string> datelist = new List<string>(new string[] { "01/06/2014", "01/07/2014", "01/08/2014", "01/09/2014", "01/10/2014", "01/11/2014", "01/12/2014" });

            string selectedDate = Convert.ToDateTime(dateTimePicker.Text).ToString();
            string[] splitedDate = selectedDate.Split(' ');

            string[] arrayDate = splitedDate[0].Split('/');
            int year = Convert.ToInt32(arrayDate[0]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[2]);

            DateTime dateTime = new DateTime(year, month, day);

            string dbDate = dateTime.ToString("M/dd/yyyy");

            List<string> datelist = new List<string>(new string[] { dateTime.ToString("M/dd/yyyy"), dateTime.AddDays(1).ToString("M/dd/yyyy"), dateTime.AddDays(2).ToString("M/dd/yyyy"), dateTime.AddDays(3).ToString("M/dd/yyyy"), dateTime.AddDays(4).ToString("M/dd/yyyy"), dateTime.AddDays(5).ToString("M/dd/yyyy"), dateTime.AddDays(6).ToString("M/dd/yyyy") });

            List<string> productType = new List<string>(new string[] { "Office Supplies", "Furniture", "Technology" });

            //I need somewhere to hold the information pulled from the database! This is an empty dictionary.
            //I am using a dictionary as I can then manually set my own "key" so rather than it being accessed through [0], [1] ect, i can access it via the date.
            //The dictionary type is string, int - date, number of sales.
            Dictionary<string, double> salesCount = new Dictionary<string, double>();

            Dictionary<string, double> salesByProductType = new Dictionary<string, double>();

            //Create aconnectionto the MDF file. We only need this ince so its outside my loop
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            //run this code once for each date in my list - in my case 7 times
            foreach (string date in datelist)
            {

                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {
                    //open the SqlConnection
                    myConnection.Open();
                    //the following code uses an SqlCommand base on the SqlConnection
                    SqlCommand command = new SqlCommand("SELECT profit FROM FactTable JOIN Time ON FactTable.timeId = Time.id WHERE Time.date = @date;", myConnection);
                    command.Parameters.Add(new SqlParameter("date", date));
                    //SqlCommand command2 = new SqlCommand("SELECT COUNT(*) AS numberOfRecord  FROM FactTable JOIN Time ON FactTable.timeId = Time.id WHERE Time.date = @date;", myConnection);
                    //command2.Parameters.Add(new SqlParameter("date", date));

                    //List<int> numberOfRecord = new List<int>();
                    //using (SqlDataReader reader2 = command2.ExecuteReader())
                    //{
                    //    if(reader2.HasRows)
                    //    {
                    //        while(reader2.Read())
                    //        {
                    //            numberOfRecord.Add(Convert.ToInt32(reader2["numberOfRecord"].ToString()));
                    //        }
                    //    }
                    //    else
                    //    {
                    //        numberOfRecord.Add(0);
                    //    }

                    //}

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //if there are rows, it means there were sales
                        if (reader.HasRows)
                        {
                            double gain = 0;
                            while (reader.Read())
                            {

                                //this line adds a dictionary item with the key of the date, and the value being the sales number
                                //I could access this after by doing: int numberOfSales = salesCount["06/01/2014"]; - try it and write it to the console to test!

                                gain = Convert.ToDouble(reader[0].ToString()) + gain;
                                //int n = 0;
                                //double gain = 0;
                                //for (int i = 0; i < numberOfRecord[n]; i++)
                                //{
                                //    
                                //}

                                //n++;
                            }
                            salesCount.Add(date, gain);
                        }
                        //if there are no rows it means there were 0 sales, so we also need to handle this!
                        else
                        {
                            salesCount.Add(date, 0);
                        }
                        //end of the foreach loop. we now have a (hopefully) filled array

                        //now to bulid a bar chart
                        chart6.DataSource = salesCount;
                        chart6.Series[0].XValueMember = "Key";
                        chart6.Series[0].YValueMembers = "Value";
                        chart6.DataBind();

                        ////or a pie chart                      
                        //pieChart.DataSource = salesCount;
                        //pieChart.Series[0].XValueMember = "Key";
                        //pieChart.Series[0].YValueMembers = "Value";
                        //pieChart.DataBind();


                    }
                }


            }

            foreach (string category in productType)
            {
                double gain = 0;

                foreach (string date in datelist)
                {
                    using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                    {
                        //open the SqlConnection
                        myConnection.Open();
                        //the following code uses an SqlCommand base on the SqlConnection
                        SqlCommand command = new SqlCommand("SELECT profit FROM FactTable JOIN Product ON FactTable.productId = Product.Id JOIN Time ON FactTable.timeId = Time.id WHERE Product.category = @category AND Time.date = @date;", myConnection);
                        command.Parameters.Add(new SqlParameter("category", category));
                        command.Parameters.Add(new SqlParameter("date", date));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            //if there are rows, it means there were sales
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    gain = Convert.ToDouble(reader[0].ToString()) + gain;
                                }

                            }
                            //if there are no rows it means there were 0 sales, so we also need to handle this!
                            else
                            {

                            }


                        }

                    }
                }

                salesByProductType.Add(category, gain);

                chart7.DataSource = salesByProductType;
                chart7.Series[0].XValueMember = "Key";
                chart7.Series[0].YValueMembers = "Value";
                chart7.DataBind();

            }
        }

        private void buttonProfit_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}



