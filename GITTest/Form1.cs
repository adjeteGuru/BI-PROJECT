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
            lstBoxDates.DataSource = Dates;

            
        }
    }
}
