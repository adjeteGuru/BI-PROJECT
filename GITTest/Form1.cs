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

        //Done
        //create function splitDate to allow code to be regroup in block
        private void splitDates(string date)
        {
            //create an item to store a date convert into string then get split up to be individual 
            //string[] arrayDates = DatesFormatted[0].ToString().Split('/');
            string[] arrayDate = date.Split('/');

            // declare variables and convert them 
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);

            ////display day of the week
            //Console.WriteLine("Day of week: " + dateTime.DayOfWeek);

            string dayOfWeek = dateTime.DayOfWeek.ToString();
            int dayOfYear = dateTime.DayOfYear;
            string monthName = dateTime.ToString("MMMM");
            int weekNumber = dayOfYear / 7;
            bool weekend = false;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") weekend = true;

            string dbDate = dateTime.ToString("M/dd/yyyy");

            insertTimeDimension(dbDate, dayOfWeek , day, monthName, month, weekNumber, year, weekend, dayOfYear);
            
           //send to output for test
            //Console.WriteLine("Day: " + arrayDate[0] + " Month: " + arrayDate[1] + " Year: " + arrayDate[2]);
        }

        //create insert function allowing data into destination database
        private void insertTimeDimension(string date, string dayName, int dayNumber, string monthName, int monthNumber, int weekNumber, int year, bool weekend, int dayOfYear )
        {
            //create connection to the MDF file to allow data transfer
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            //create connection to the database
            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //open the sqlConnection
                myConnection.Open();

                //create SqlCommand to check the SqlConnection
                //THIS WAS THE CAUSE OF THE "@Date error" you have been getting = you omitted the FROM in your select statement @ADJETE.
                //SqlCommand command = new SqlCommand("SELECT id Time WHERE date = @date", myConnection);
                SqlCommand command = new SqlCommand("SELECT id FROM Time WHERE date = @date", myConnection);
                //AND FINALLY THIS LINE WAS MISSED!
                command.Parameters.Add(new SqlParameter("date", date));


                //create a variable and assign it to false by default.
                bool exists = false;

                //run the command and read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if there are rows, it means tghe data exists so change the variable.
                    if (reader.HasRows) exists = true;
                }

                //
                if (exists == false)
                {
                    //AND HERE TOO you omitted monthNumber again in both the parameter and the value statement
                    //SqlCommand insertCommand = new SqlCommand("INSERT INTO Time(dayName, dayNumber, monthName, weekNumber, year, weekend, date, dayOfYear)" + 
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Time(dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend, date, dayOfYear)" + 

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

                    //insert the line
                    //int recordsAffected = insertCommand.ExecuteNonQuery();
                    //Console.WriteLine("Records affected: " + recordsAffected);
                }

                //RATHER WAS PUT IN THE WRONG PLACE.
                //command.Parameters.Add(new SqlParameter("date", date));
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

            //split the dates and insert ecery date in the list
            foreach(string date in DatesFormatted)
            {
                splitDates(date);
            }

            //call the function splitDates to display DatesFormatted
            //splitDates(DatesFormatted[0]);

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
                    Customer.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString() + ", " + reader[5].ToString() + ", " + reader[6].ToString());

                }
            }

            //bind the listbox to the list
            listBoxCustomer.DataSource = Customer;
        }
    }


        

    
}

