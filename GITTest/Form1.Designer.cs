using System;

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
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.btnGetDates = new System.Windows.Forms.Button();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinationDatabaseDataSet1 = new GITTest.DestinationDatabaseDataSet1();
            this.productTableAdapter = new GITTest.DestinationDatabaseDataSet1TableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new GITTest.DestinationDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.destinationDatabaseDataSet2 = new GITTest.DestinationDatabaseDataSet2();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter1 = new GITTest.DestinationDatabaseDataSet2TableAdapters.ProductTableAdapter();
            this.tableAdapterManager1 = new GITTest.DestinationDatabaseDataSet2TableAdapters.TableAdapterManager();
            this.destinationDatabaseDataSet3 = new GITTest.DestinationDatabaseDataSet3();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter2 = new GITTest.DestinationDatabaseDataSet3TableAdapters.ProductTableAdapter();
            this.tableAdapterManager2 = new GITTest.DestinationDatabaseDataSet3TableAdapters.TableAdapterManager();
            this.btnOrder = new System.Windows.Forms.Button();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Git clone and pull test!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.Location = new System.Drawing.Point(5, 77);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(182, 95);
            this.listBoxDates.TabIndex = 3;
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(5, 39);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(75, 23);
            this.btnGetDates.TabIndex = 2;
            this.btnGetDates.Text = "GetDates";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(212, 39);
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
            this.listBoxProducts.Location = new System.Drawing.Point(212, 77);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(637, 95);
            this.listBoxProducts.TabIndex = 5;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.destinationDatabaseDataSet1;
            // 
            // destinationDatabaseDataSet1
            // 
            this.destinationDatabaseDataSet1.DataSetName = "DestinationDatabaseDataSet1";
            this.destinationDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.FactTableTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.TimeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GITTest.DestinationDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // destinationDatabaseDataSet2
            // 
            this.destinationDatabaseDataSet2.DataSetName = "DestinationDatabaseDataSet2";
            this.destinationDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.destinationDatabaseDataSet2;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.FactTableTableAdapter = null;
            this.tableAdapterManager1.ProductTableAdapter = this.productTableAdapter1;
            this.tableAdapterManager1.TimeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = GITTest.DestinationDatabaseDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // destinationDatabaseDataSet3
            // 
            this.destinationDatabaseDataSet3.DataSetName = "DestinationDatabaseDataSet3";
            this.destinationDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            this.productBindingSource2.DataSource = this.destinationDatabaseDataSet3;
            // 
            // productTableAdapter2
            // 
            this.productTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.ProductTableAdapter = this.productTableAdapter2;
            this.tableAdapterManager2.UpdateOrder = GITTest.DestinationDatabaseDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(901, 39);
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
            this.listBoxOrder.Location = new System.Drawing.Point(901, 77);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(188, 95);
            this.listBoxOrder.TabIndex = 7;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(1151, 39);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "GetCustomer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.Location = new System.Drawing.Point(1151, 77);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(280, 95);
            this.listBoxCustomer.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 332);
            this.Controls.Add(this.listBoxCustomer);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.btnGetProducts);
            this.Controls.Add(this.listBoxDates);
            this.Controls.Add(this.btnGetDates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //quick fix
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.ListBox listBoxProducts;
        private DestinationDatabaseDataSet1 destinationDatabaseDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DestinationDatabaseDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private DestinationDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DestinationDatabaseDataSet2 destinationDatabaseDataSet2;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private DestinationDatabaseDataSet2TableAdapters.ProductTableAdapter productTableAdapter1;
        private DestinationDatabaseDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private DestinationDatabaseDataSet3 destinationDatabaseDataSet3;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private DestinationDatabaseDataSet3TableAdapters.ProductTableAdapter productTableAdapter2;
        private DestinationDatabaseDataSet3TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.ListBox listBoxCustomer;
    }
}

