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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.destinationDatabaseDataSet1 = new GITTest.DestinationDatabaseDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetDates = new System.Windows.Forms.Button();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            this.btnGetCustomerFromDatabase = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new GITTest.DestinationDatabaseDataSet2TableAdapters.TableAdapterManager();
            this.customerTableAdapter1 = new GITTest.DestinationDatabaseDataSet2TableAdapters.CustomerTableAdapter();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new GITTest.DestinationDatabaseDataSet1TableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new GITTest.DestinationDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.destinationDatabaseDataSet2 = new GITTest.DestinationDatabaseDataSet2();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxCustomerFromDbNamed = new System.Windows.Forms.ListBox();
            this.sheet1TableAdapter1 = new GITTest.Data_set_1DataSetTableAdapters.Sheet1TableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDimension = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Git clone and pull test!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(8, 272);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(91, 23);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "GetOrder";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.Location = new System.Drawing.Point(8, 298);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(188, 95);
            this.listBoxOrder.TabIndex = 7;
            // 
            // destinationDatabaseDataSet1
            // 
            this.destinationDatabaseDataSet1.DataSetName = "DestinationDatabaseDataSet1";
            this.destinationDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ".";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(6, 19);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(75, 23);
            this.btnGetDates.TabIndex = 2;
            this.btnGetDates.Text = "GetDates";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.Location = new System.Drawing.Point(6, 46);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(182, 95);
            this.listBoxDates.TabIndex = 3;
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(7, 146);
            this.btnGetProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(102, 23);
            this.btnGetProducts.TabIndex = 4;
            this.btnGetProducts.Text = "GetProducts";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click_1);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(7, 172);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(203, 95);
            this.listBoxProducts.TabIndex = 5;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(7, 399);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(86, 23);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "GetCustomer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.Location = new System.Drawing.Point(7, 432);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(351, 95);
            this.listBoxCustomer.TabIndex = 9;
            // 
            // btnGetCustomerFromDatabase
            // 
            this.btnGetCustomerFromDatabase.Location = new System.Drawing.Point(439, 399);
            this.btnGetCustomerFromDatabase.Name = "btnGetCustomerFromDatabase";
            this.btnGetCustomerFromDatabase.Size = new System.Drawing.Size(147, 23);
            this.btnGetCustomerFromDatabase.TabIndex = 10;
            this.btnGetCustomerFromDatabase.Text = "GetCustomerFromDatabase";
            this.btnGetCustomerFromDatabase.UseVisualStyleBackColor = true;
            this.btnGetCustomerFromDatabase.Click += new System.EventHandler(this.btnGetCustomerFromDatabase_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomerTableAdapter = this.customerTableAdapter1;
            this.tableAdapterManager1.FactTableTableAdapter = null;
            this.tableAdapterManager1.ProductTableAdapter = null;
            this.tableAdapterManager1.TimeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = GITTest.DestinationDatabaseDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.destinationDatabaseDataSet1;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.UpdateOrder = GITTest.DestinationDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // destinationDatabaseDataSet2
            // 
            this.destinationDatabaseDataSet2.DataSetName = "DestinationDatabaseDataSet2";
            this.destinationDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.destinationDatabaseDataSet2;
            // 
            // listBoxCustomerFromDbNamed
            // 
            this.listBoxCustomerFromDbNamed.FormattingEnabled = true;
            this.listBoxCustomerFromDbNamed.Location = new System.Drawing.Point(439, 432);
            this.listBoxCustomerFromDbNamed.Name = "listBoxCustomerFromDbNamed";
            this.listBoxCustomerFromDbNamed.Size = new System.Drawing.Size(561, 95);
            this.listBoxCustomerFromDbNamed.TabIndex = 11;
            // 
            // sheet1TableAdapter1
            // 
            this.sheet1TableAdapter1.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 566);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDimension);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBoxCustomerFromDbNamed);
            this.tabPage1.Controls.Add(this.btnGetDates);
            this.tabPage1.Controls.Add(this.btnGetCustomerFromDatabase);
            this.tabPage1.Controls.Add(this.listBoxDates);
            this.tabPage1.Controls.Add(this.listBoxCustomer);
            this.tabPage1.Controls.Add(this.btnGetProducts);
            this.tabPage1.Controls.Add(this.btnCustomer);
            this.tabPage1.Controls.Add(this.listBoxProducts);
            this.tabPage1.Controls.Add(this.listBoxOrder);
            this.tabPage1.Controls.Add(this.btnOrder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDimension
            // 
            this.btnDimension.Location = new System.Drawing.Point(539, 54);
            this.btnDimension.Name = "btnDimension";
            this.btnDimension.Size = new System.Drawing.Size(101, 40);
            this.btnDimension.TabIndex = 12;
            this.btnDimension.Text = "GetDimension";
            this.btnDimension.UseVisualStyleBackColor = true;
            this.btnDimension.Click += new System.EventHandler(this.btnDimension_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox listBoxOrder;
        private DestinationDatabaseDataSet1 destinationDatabaseDataSet1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.ListBox listBoxCustomer;
        private System.Windows.Forms.Button btnGetCustomerFromDatabase;
        private DestinationDatabaseDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private DestinationDatabaseDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DestinationDatabaseDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private DestinationDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DestinationDatabaseDataSet2 destinationDatabaseDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.ListBox listBoxCustomerFromDbNamed;
        private Data_set_1DataSetTableAdapters.Sheet1TableAdapter sheet1TableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDimension;
    }
}

