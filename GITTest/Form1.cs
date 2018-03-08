using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        private void btnGetDates_Click(object sender, EventArgs e)
        {
            //Create new list to store the results in
            List<string> Dates = new List<string>();
            //clear the listbox
            lstBoxDates.Items.Clear();

            //Create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using(OleDbConnection connection=new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getDates = new OleDbCommand("SELECT [Order Date],[Ship Date] from Sheet1", connection);

                reader = getDates.ExecuteReader();
                while (reader.Read())
                {
                    Dates.Add(reader[0].ToString());
                    Dates.Add(reader[1].ToString());
                }
            }

            //Create a new list for the formatted data
            List<string> DatesFormatted = new List<string>();

            foreach(string date in Dates)
            {
                //Split the string on whitespace and remove anything thats blank
                var dates = date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //Grab the first item(we know this is the date) and add it to our new list
                DatesFormatted.Add(dates[0]);
            }

            //Bind the listbox to the list
            lstBoxDates.DataSource = DatesFormatted;

            
        }

        private void btnGetCustomer_Click_1(object sender, EventArgs e)
        {
            //Create new list to store the results in
            List<string> Customers = new List<string>();
            //clear the listbox
            listBoxCustomer.Items.Clear();

            //Create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getCustomers = new OleDbCommand("SELECT   [Customer ID], [Customer Name], Country, City, State, [Postal Code], Region FROM Sheet1", connection);

                reader = getCustomers.ExecuteReader();
                while (reader.Read())
                {
                    Customers.Add(reader[0].ToString());
                    Customers.Add(reader[1].ToString());
                    Customers.Add(reader[2].ToString());
                    Customers.Add(reader[3].ToString());
                    Customers.Add(reader[4].ToString());
                    Customers.Add(reader[5].ToString());
                    Customers.Add(reader[6].ToString());
                }
            }

            //Create a new list for the formatted data
            List<string> CustomersFormatted = new List<string>();

            foreach (string customer in Customers)
            {
                //Split the string on whitespace and remove anything thats blank
                var customers = customer.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //Grab the first item(we know this is the date) and add it to our new list
                CustomersFormatted.Add(customers[0]);
            }

            //Bind the listbox to the list
            listBoxCustomer.DataSource = CustomersFormatted;
        }
    }
}
