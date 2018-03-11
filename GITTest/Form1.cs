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

                    //insert the line
                    //int recordsAffected = insertCommand.ExecuteNonQuery();
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
                OleDbCommand getProducts = new OleDbCommand("SELECT [Product ID], [Product Name], Quantity, Discount, Category, [Sub-Category] from  Sheet1", connection);

               
                
                reader = getProducts.ExecuteReader();
                while (reader.Read())
                {
                    Products.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString() + ", " + reader[5].ToString());
                }
            }

            //bind the listbox to the list
            listBoxProducts.DataSource = Products;
            
        }

        private void splitProducts(string product)
        {
            //Split the product down and assign it to variables for later use.
            string[] arrayProduct = product.Split(',');
            string category = arrayProduct[4];
            string subcategory = arrayProduct[5];
            string name = arrayProduct[1];

          

            insertProductDimension(category, subcategory, name);
        }

        private void insertProductDimension(string category, string subcategory, string name)
        {
            //create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {

                //open the SqlConnection
                myConnection.Open();
                //The following code uses an SqlCommand based on the SqlConnection.
                SqlCommand command = new SqlCommand("SELECT id FROM Product WHERE name = @name", myConnection);
                command.Parameters.Add(new SqlParameter("name", name));

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
                    SqlCommand insertCommand = new SqlCommand(
                        "INSERT INTO Product (category, subcategory, name)" +
                        "VALUES (@category, @subcategory, @name)", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("category", category));
                    insertCommand.Parameters.Add(new SqlParameter("subcatergory", subcategory));
                    insertCommand.Parameters.Add(new SqlParameter("name", name));
                    

                    //insert the line
                    int productRecordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("product Records affected: " + productRecordsAffected);
                    //insertCommand.ExecuteNonQuery();

                }
            }
        }

    }




}

