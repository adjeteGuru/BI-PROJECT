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

            /*
             * TODO: COULD POTENTIALLY BE USED TO PULL MULTIPLE FIELDS FROM A DATATABLE
            while (reader.Read())
            {
                string datesList = "";
                foreach(var i in reader)
                {
                    datesList += i.ToString();
                }
                Dates.Add(datesList);



                Dates.Add(reader[0].ToString() + ", " + reader[1].ToString());
                //Dates.Add(reader[1].ToString());
            }
            */



        }

        private void btnGetProducts_Click(object sender, EventArgs e)
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


                //THIS IS WHERE THE PROGRAM BREAKS
                //SEE IF YOU CAN FIX IT 

                reader = getProducts.ExecuteReader();
                while (reader.Read())
                {

                    //Products.Add(reader[0].ToString());
                    //Products.Add(reader[1].ToString());
                    //Products.Add(reader[2].ToString());
                    //Products.Add(reader[3].ToString());
                    //Products.Add(reader[4].ToString());
                    //Products.Add(reader[5].ToString());
                    Products.Add(reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString() + ", " + reader[3].ToString() + ", " + reader[4].ToString() + ", " + reader[5].ToString());

                }

                //bind the listbox to the list
                listBoxProducts.DataSource = Products;


            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

//use below while loop will work. sorry about that i still didn't not figure out what your while loop mean.
//Anyway, i found that if i try your while loop in the getDates, it will has error too.

//while (reader.Read())
//{
//    Products.Add(reader[0].ToString());
//    Products.Add(reader[1].ToString());
//    Products.Add(reader[2].ToString());
//    Products.Add(reader[3].ToString());
//    Products.Add(reader[4].ToString());
//    Products.Add(reader[5].ToString());
//}

