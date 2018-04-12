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
            this.btnGetFactTable = new System.Windows.Forms.Button();
            this.btnDates = new System.Windows.Forms.Button();
            this.btnGetProductFromDatabase = new System.Windows.Forms.Button();
            this.groupBoxDatabaseTables = new System.Windows.Forms.GroupBox();
            this.listBoxFactTableSource = new System.Windows.Forms.ListBox();
            this.listBoxDateFromSource = new System.Windows.Forms.ListBox();
            this.listBoxProductFromDbNamed = new System.Windows.Forms.ListBox();
            this.groupBoxDimensionsTables = new System.Windows.Forms.GroupBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.btnDimension = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFactable = new System.Windows.Forms.Label();
            this.listBoxFactable = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxDatabaseTables.SuspendLayout();
            this.groupBoxDimensionsTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ".";
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.Location = new System.Drawing.Point(6, 157);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(115, 95);
            this.listBoxDates.TabIndex = 3;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(-3, 270);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(573, 95);
            this.listBoxProducts.TabIndex = 5;
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.Location = new System.Drawing.Point(148, 157);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(425, 95);
            this.listBoxCustomer.TabIndex = 9;
            // 
            // btnGetCustomerFromDatabase
            // 
            this.btnGetCustomerFromDatabase.Location = new System.Drawing.Point(599, 189);
            this.btnGetCustomerFromDatabase.Name = "btnGetCustomerFromDatabase";
            this.btnGetCustomerFromDatabase.Size = new System.Drawing.Size(147, 52);
            this.btnGetCustomerFromDatabase.TabIndex = 10;
            this.btnGetCustomerFromDatabase.Text = "GetCustomerFromDatabase";
            this.btnGetCustomerFromDatabase.UseVisualStyleBackColor = true;
            this.btnGetCustomerFromDatabase.Click += new System.EventHandler(this.btnGetCustomerFromDatabase_Click);
            // 
            // listBoxCustomerFromDbNamed
            // 
            this.listBoxCustomerFromDbNamed.FormattingEnabled = true;
            this.listBoxCustomerFromDbNamed.Location = new System.Drawing.Point(11, 343);
            this.listBoxCustomerFromDbNamed.Name = "listBoxCustomerFromDbNamed";
            this.listBoxCustomerFromDbNamed.Size = new System.Drawing.Size(540, 82);
            this.listBoxCustomerFromDbNamed.TabIndex = 11;
            this.listBoxCustomerFromDbNamed.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomerFromDbNamed_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1165, 707);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGetFactTable);
            this.tabPage1.Controls.Add(this.btnDates);
            this.tabPage1.Controls.Add(this.btnGetProductFromDatabase);
            this.tabPage1.Controls.Add(this.groupBoxDatabaseTables);
            this.tabPage1.Controls.Add(this.groupBoxDimensionsTables);
            this.tabPage1.Controls.Add(this.btnDimension);
            this.tabPage1.Controls.Add(this.btnGetCustomerFromDatabase);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1157, 681);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnGetFactTable
            // 
            this.btnGetFactTable.Location = new System.Drawing.Point(995, 189);
            this.btnGetFactTable.Name = "btnGetFactTable";
            this.btnGetFactTable.Size = new System.Drawing.Size(90, 52);
            this.btnGetFactTable.TabIndex = 18;
            this.btnGetFactTable.Text = "GetFactTable";
            this.btnGetFactTable.UseVisualStyleBackColor = true;
            this.btnGetFactTable.Click += new System.EventHandler(this.btnGetFactTable_Click);
            // 
            // btnDates
            // 
            this.btnDates.Location = new System.Drawing.Point(914, 189);
            this.btnDates.Name = "btnDates";
            this.btnDates.Size = new System.Drawing.Size(75, 52);
            this.btnDates.TabIndex = 17;
            this.btnDates.Text = "GetDates";
            this.btnDates.UseVisualStyleBackColor = true;
            this.btnDates.Click += new System.EventHandler(this.btnDates_Click);
            // 
            // btnGetProductFromDatabase
            // 
            this.btnGetProductFromDatabase.Location = new System.Drawing.Point(752, 189);
            this.btnGetProductFromDatabase.Name = "btnGetProductFromDatabase";
            this.btnGetProductFromDatabase.Size = new System.Drawing.Size(155, 52);
            this.btnGetProductFromDatabase.TabIndex = 16;
            this.btnGetProductFromDatabase.Text = "GetProductFromDatabase";
            this.btnGetProductFromDatabase.UseVisualStyleBackColor = true;
            this.btnGetProductFromDatabase.Click += new System.EventHandler(this.btnGetProductFromDatabase_Click);
            // 
            // groupBoxDatabaseTables
            // 
            this.groupBoxDatabaseTables.Controls.Add(this.listBoxFactTableSource);
            this.groupBoxDatabaseTables.Controls.Add(this.listBoxDateFromSource);
            this.groupBoxDatabaseTables.Controls.Add(this.listBoxProductFromDbNamed);
            this.groupBoxDatabaseTables.Controls.Add(this.listBoxCustomerFromDbNamed);
            this.groupBoxDatabaseTables.Location = new System.Drawing.Point(599, 247);
            this.groupBoxDatabaseTables.Name = "groupBoxDatabaseTables";
            this.groupBoxDatabaseTables.Size = new System.Drawing.Size(552, 431);
            this.groupBoxDatabaseTables.TabIndex = 14;
            this.groupBoxDatabaseTables.TabStop = false;
            this.groupBoxDatabaseTables.Text = "Database Tables";
            // 
            // listBoxFactTableSource
            // 
            this.listBoxFactTableSource.FormattingEnabled = true;
            this.listBoxFactTableSource.Location = new System.Drawing.Point(11, 42);
            this.listBoxFactTableSource.Name = "listBoxFactTableSource";
            this.listBoxFactTableSource.Size = new System.Drawing.Size(535, 95);
            this.listBoxFactTableSource.TabIndex = 14;
            // 
            // listBoxDateFromSource
            // 
            this.listBoxDateFromSource.FormattingEnabled = true;
            this.listBoxDateFromSource.Location = new System.Drawing.Point(11, 158);
            this.listBoxDateFromSource.Name = "listBoxDateFromSource";
            this.listBoxDateFromSource.Size = new System.Drawing.Size(535, 82);
            this.listBoxDateFromSource.TabIndex = 13;
            // 
            // listBoxProductFromDbNamed
            // 
            this.listBoxProductFromDbNamed.FormattingEnabled = true;
            this.listBoxProductFromDbNamed.Location = new System.Drawing.Point(11, 246);
            this.listBoxProductFromDbNamed.Name = "listBoxProductFromDbNamed";
            this.listBoxProductFromDbNamed.Size = new System.Drawing.Size(539, 82);
            this.listBoxProductFromDbNamed.TabIndex = 12;
            // 
            // groupBoxDimensionsTables
            // 
            this.groupBoxDimensionsTables.Controls.Add(this.listBoxFactable);
            this.groupBoxDimensionsTables.Controls.Add(this.lblFactable);
            this.groupBoxDimensionsTables.Controls.Add(this.lblProducts);
            this.groupBoxDimensionsTables.Controls.Add(this.lblCustomers);
            this.groupBoxDimensionsTables.Controls.Add(this.lblDates);
            this.groupBoxDimensionsTables.Controls.Add(this.listBoxDates);
            this.groupBoxDimensionsTables.Controls.Add(this.listBoxProducts);
            this.groupBoxDimensionsTables.Controls.Add(this.listBoxCustomer);
            this.groupBoxDimensionsTables.Location = new System.Drawing.Point(3, 305);
            this.groupBoxDimensionsTables.Name = "groupBoxDimensionsTables";
            this.groupBoxDimensionsTables.Size = new System.Drawing.Size(579, 370);
            this.groupBoxDimensionsTables.TabIndex = 13;
            this.groupBoxDimensionsTables.TabStop = false;
            this.groupBoxDimensionsTables.Text = "Dimensions Tables";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(3, 255);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 12;
            this.lblProducts.Text = "Products";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(145, 137);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(56, 13);
            this.lblCustomers.TabIndex = 11;
            this.lblCustomers.Text = "Customers";
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Location = new System.Drawing.Point(5, 137);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(35, 13);
            this.lblDates.TabIndex = 10;
            this.lblDates.Text = "Dates";
            // 
            // btnDimension
            // 
            this.btnDimension.Location = new System.Drawing.Point(170, 247);
            this.btnDimension.Name = "btnDimension";
            this.btnDimension.Size = new System.Drawing.Size(139, 52);
            this.btnDimension.TabIndex = 12;
            this.btnDimension.Text = "Get Dimensions Tables";
            this.btnDimension.UseVisualStyleBackColor = true;
            this.btnDimension.Click += new System.EventHandler(this.btnDimension_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1157, 681);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblFactable
            // 
            this.lblFactable.AutoSize = true;
            this.lblFactable.Location = new System.Drawing.Point(6, 16);
            this.lblFactable.Name = "lblFactable";
            this.lblFactable.Size = new System.Drawing.Size(48, 13);
            this.lblFactable.TabIndex = 19;
            this.lblFactable.Text = "Factable";
            // 
            // listBoxFactable
            // 
            this.listBoxFactable.FormattingEnabled = true;
            this.listBoxFactable.Location = new System.Drawing.Point(3, 39);
            this.listBoxFactable.Name = "listBoxFactable";
            this.listBoxFactable.Size = new System.Drawing.Size(567, 95);
            this.listBoxFactable.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 717);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Button btnGetFactTable;
        private System.Windows.Forms.ListBox listBoxFactTableSource;
        private System.Windows.Forms.ListBox listBoxFactable;
        private System.Windows.Forms.Label lblFactable;
    }
}

