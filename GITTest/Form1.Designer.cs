namespace GITTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            this.btnGetCustomerFromDatabase = new System.Windows.Forms.Button();
            this.listBoxCustomerFromDbNamed = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetFactDB = new System.Windows.Forms.Button();
            this.btnDates = new System.Windows.Forms.Button();
            this.btnGetProductFromDatabase = new System.Windows.Forms.Button();
            this.groupBoxDatabaseTables = new System.Windows.Forms.GroupBox();
            this.listBoxFactTable = new System.Windows.Forms.ListBox();
            this.listBoxDateFromSource = new System.Windows.Forms.ListBox();
            this.listBoxProductFromDbNamed = new System.Windows.Forms.ListBox();
            this.groupBoxDimensionsTables = new System.Windows.Forms.GroupBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.btnDimension = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxDatabaseTables.SuspendLayout();
            this.groupBoxDimensionsTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = ".";
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.ItemHeight = 25;
            this.listBoxDates.Location = new System.Drawing.Point(18, 106);
            this.listBoxDates.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(226, 179);
            this.listBoxDates.TabIndex = 3;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 25;
            this.listBoxProducts.Location = new System.Drawing.Point(0, 365);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(1142, 179);
            this.listBoxProducts.TabIndex = 5;
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.ItemHeight = 25;
            this.listBoxCustomer.Location = new System.Drawing.Point(284, 106);
            this.listBoxCustomer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(858, 179);
            this.listBoxCustomer.TabIndex = 9;
            // 
            // btnGetCustomerFromDatabase
            // 
            this.btnGetCustomerFromDatabase.Location = new System.Drawing.Point(1210, 367);
            this.btnGetCustomerFromDatabase.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetCustomerFromDatabase.Name = "btnGetCustomerFromDatabase";
            this.btnGetCustomerFromDatabase.Size = new System.Drawing.Size(294, 100);
            this.btnGetCustomerFromDatabase.TabIndex = 10;
            this.btnGetCustomerFromDatabase.Text = "GetCustomerFromDatabase";
            this.btnGetCustomerFromDatabase.UseVisualStyleBackColor = true;
            this.btnGetCustomerFromDatabase.Click += new System.EventHandler(this.btnGetCustomerFromDatabase_Click);
            // 
            // listBoxCustomerFromDbNamed
            // 
            this.listBoxCustomerFromDbNamed.FormattingEnabled = true;
            this.listBoxCustomerFromDbNamed.ItemHeight = 25;
            this.listBoxCustomerFromDbNamed.Location = new System.Drawing.Point(12, 656);
            this.listBoxCustomerFromDbNamed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxCustomerFromDbNamed.Name = "listBoxCustomerFromDbNamed";
            this.listBoxCustomerFromDbNamed.Size = new System.Drawing.Size(1076, 154);
            this.listBoxCustomerFromDbNamed.TabIndex = 11;
            this.listBoxCustomerFromDbNamed.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomerFromDbNamed_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2330, 1360);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGetFactDB);
            this.tabPage1.Controls.Add(this.btnDates);
            this.tabPage1.Controls.Add(this.btnGetProductFromDatabase);
            this.tabPage1.Controls.Add(this.groupBoxDatabaseTables);
            this.tabPage1.Controls.Add(this.groupBoxDimensionsTables);
            this.tabPage1.Controls.Add(this.btnDimension);
            this.tabPage1.Controls.Add(this.btnGetCustomerFromDatabase);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(2322, 1322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGetFactDB
            // 
            this.btnGetFactDB.Location = new System.Drawing.Point(2000, 367);
            this.btnGetFactDB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetFactDB.Name = "btnGetFactDB";
            this.btnGetFactDB.Size = new System.Drawing.Size(226, 100);
            this.btnGetFactDB.TabIndex = 18;
            this.btnGetFactDB.Text = "GetFactDatabase";
            this.btnGetFactDB.UseVisualStyleBackColor = true;
            this.btnGetFactDB.Click += new System.EventHandler(this.btnGetFactDB_Click);
            // 
            // btnDates
            // 
            this.btnDates.Location = new System.Drawing.Point(1838, 367);
            this.btnDates.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDates.Name = "btnDates";
            this.btnDates.Size = new System.Drawing.Size(150, 100);
            this.btnDates.TabIndex = 17;
            this.btnDates.Text = "GetDates";
            this.btnDates.UseVisualStyleBackColor = true;
            this.btnDates.Click += new System.EventHandler(this.btnDates_Click);
            // 
            // btnGetProductFromDatabase
            // 
            this.btnGetProductFromDatabase.Location = new System.Drawing.Point(1516, 367);
            this.btnGetProductFromDatabase.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetProductFromDatabase.Name = "btnGetProductFromDatabase";
            this.btnGetProductFromDatabase.Size = new System.Drawing.Size(310, 100);
            this.btnGetProductFromDatabase.TabIndex = 16;
            this.btnGetProductFromDatabase.Text = "GetProductFromDatabase";
            this.btnGetProductFromDatabase.UseVisualStyleBackColor = true;
            this.btnGetProductFromDatabase.Click += new System.EventHandler(this.btnGetProductFromDatabase_Click);
            // 
            // groupBoxDatabaseTables
            // 
            this.groupBoxDatabaseTables.Controls.Add(this.listBoxFactTable);
            this.groupBoxDatabaseTables.Controls.Add(this.listBoxDateFromSource);
            this.groupBoxDatabaseTables.Controls.Add(this.listBoxProductFromDbNamed);
            this.groupBoxDatabaseTables.Controls.Add(this.listBoxCustomerFromDbNamed);
            this.groupBoxDatabaseTables.Location = new System.Drawing.Point(1198, 479);
            this.groupBoxDatabaseTables.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDatabaseTables.Name = "groupBoxDatabaseTables";
            this.groupBoxDatabaseTables.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDatabaseTables.Size = new System.Drawing.Size(1104, 825);
            this.groupBoxDatabaseTables.TabIndex = 14;
            this.groupBoxDatabaseTables.TabStop = false;
            this.groupBoxDatabaseTables.Text = "Database Tables";
            // 
            // listBoxFactTable
            // 
            this.listBoxFactTable.FormattingEnabled = true;
            this.listBoxFactTable.ItemHeight = 25;
            this.listBoxFactTable.Location = new System.Drawing.Point(12, 102);
            this.listBoxFactTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxFactTable.Name = "listBoxFactTable";
            this.listBoxFactTable.Size = new System.Drawing.Size(1076, 179);
            this.listBoxFactTable.TabIndex = 14;
            // 
            // listBoxDateFromSource
            // 
            this.listBoxDateFromSource.FormattingEnabled = true;
            this.listBoxDateFromSource.ItemHeight = 25;
            this.listBoxDateFromSource.Location = new System.Drawing.Point(12, 296);
            this.listBoxDateFromSource.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxDateFromSource.Name = "listBoxDateFromSource";
            this.listBoxDateFromSource.Size = new System.Drawing.Size(236, 179);
            this.listBoxDateFromSource.TabIndex = 13;
            // 
            // listBoxProductFromDbNamed
            // 
            this.listBoxProductFromDbNamed.FormattingEnabled = true;
            this.listBoxProductFromDbNamed.ItemHeight = 25;
            this.listBoxProductFromDbNamed.Location = new System.Drawing.Point(12, 487);
            this.listBoxProductFromDbNamed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxProductFromDbNamed.Name = "listBoxProductFromDbNamed";
            this.listBoxProductFromDbNamed.Size = new System.Drawing.Size(1074, 154);
            this.listBoxProductFromDbNamed.TabIndex = 12;
            // 
            // groupBoxDimensionsTables
            // 
            this.groupBoxDimensionsTables.Controls.Add(this.lblProducts);
            this.groupBoxDimensionsTables.Controls.Add(this.lblCustomers);
            this.groupBoxDimensionsTables.Controls.Add(this.lblDates);
            this.groupBoxDimensionsTables.Controls.Add(this.listBoxDates);
            this.groupBoxDimensionsTables.Controls.Add(this.listBoxProducts);
            this.groupBoxDimensionsTables.Controls.Add(this.listBoxCustomer);
            this.groupBoxDimensionsTables.Location = new System.Drawing.Point(6, 750);
            this.groupBoxDimensionsTables.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDimensionsTables.Name = "groupBoxDimensionsTables";
            this.groupBoxDimensionsTables.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxDimensionsTables.Size = new System.Drawing.Size(1158, 548);
            this.groupBoxDimensionsTables.TabIndex = 13;
            this.groupBoxDimensionsTables.TabStop = false;
            this.groupBoxDimensionsTables.Text = "Dimensions Tables";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(12, 331);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(98, 26);
            this.lblProducts.TabIndex = 12;
            this.lblProducts.Text = "Products";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(304, 75);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(118, 26);
            this.lblCustomers.TabIndex = 11;
            this.lblCustomers.Text = "Customers";
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Location = new System.Drawing.Point(38, 71);
            this.lblDates.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(69, 26);
            this.lblDates.TabIndex = 10;
            this.lblDates.Text = "Dates";
            // 
            // btnDimension
            // 
            this.btnDimension.Location = new System.Drawing.Point(354, 602);
            this.btnDimension.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDimension.Name = "btnDimension";
            this.btnDimension.Size = new System.Drawing.Size(278, 100);
            this.btnDimension.TabIndex = 12;
            this.btnDimension.Text = "Get Dimensions Tables";
            this.btnDimension.UseVisualStyleBackColor = true;
            this.btnDimension.Click += new System.EventHandler(this.btnDimension_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(2322, 1322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2354, 1379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxDatabaseTables.ResumeLayout(false);
            this.groupBoxDimensionsTables.ResumeLayout(false);
            this.groupBoxDimensionsTables.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.ListBox listBoxCustomer;
        private System.Windows.Forms.Button btnGetCustomerFromDatabase;
        private System.Windows.Forms.ListBox listBoxCustomerFromDbNamed;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDimension;
        private System.Windows.Forms.GroupBox groupBoxDatabaseTables;
        private System.Windows.Forms.GroupBox groupBoxDimensionsTables;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Button btnGetProductFromDatabase;
        private System.Windows.Forms.ListBox listBoxProductFromDbNamed;
        private System.Windows.Forms.Button btnDates;
        private System.Windows.Forms.ListBox listBoxDateFromSource;
        private System.Windows.Forms.ListBox listBoxFactTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetFactDB;
    }
}

