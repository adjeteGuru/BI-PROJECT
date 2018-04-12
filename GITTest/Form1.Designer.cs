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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.buttonGetFromDestinationDb = new System.Windows.Forms.Button();
            this.listBoxFromDb = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxProductFromDestinationDb = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.btnGetFactTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Git clone and pull test!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = ".";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.HorizontalScrollbar = true;
            this.listBoxDates.ItemHeight = 15;
            this.listBoxDates.Location = new System.Drawing.Point(7, 110);
            this.listBoxDates.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.ScrollAlwaysVisible = true;
            this.listBoxDates.Size = new System.Drawing.Size(187, 109);
            this.listBoxDates.TabIndex = 3;
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(7, 63);
            this.btnGetDates.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(100, 27);
            this.btnGetDates.TabIndex = 2;
            this.btnGetDates.Text = "GetDates";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(492, 63);
            this.btnGetProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(136, 27);
            this.btnGetProducts.TabIndex = 4;
            this.btnGetProducts.Text = "GetProducts";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click_1);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.HorizontalScrollbar = true;
            this.listBoxProducts.ItemHeight = 15;
            this.listBoxProducts.Location = new System.Drawing.Point(492, 110);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.ScrollAlwaysVisible = true;
            this.listBoxProducts.Size = new System.Drawing.Size(188, 109);
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
            this.btnOrder.Location = new System.Drawing.Point(11, 252);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(121, 27);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "GetOrder";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.HorizontalScrollbar = true;
            this.listBoxOrder.ItemHeight = 15;
            this.listBoxOrder.Location = new System.Drawing.Point(11, 300);
            this.listBoxOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.ScrollAlwaysVisible = true;
            this.listBoxOrder.Size = new System.Drawing.Size(187, 109);
            this.listBoxOrder.TabIndex = 7;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(249, 252);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(100, 27);
            this.btnCustomer.TabIndex = 8;
            this.btnCustomer.Text = "GetCustomer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.HorizontalScrollbar = true;
            this.listBoxCustomer.ItemHeight = 15;
            this.listBoxCustomer.Location = new System.Drawing.Point(249, 298);
            this.listBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.ScrollAlwaysVisible = true;
            this.listBoxCustomer.Size = new System.Drawing.Size(181, 109);
            this.listBoxCustomer.TabIndex = 9;
            // 
            // buttonGetFromDestinationDb
            // 
            this.buttonGetFromDestinationDb.Location = new System.Drawing.Point(249, 48);
            this.buttonGetFromDestinationDb.Name = "buttonGetFromDestinationDb";
            this.buttonGetFromDestinationDb.Size = new System.Drawing.Size(147, 55);
            this.buttonGetFromDestinationDb.TabIndex = 10;
            this.buttonGetFromDestinationDb.Text = "Get from Destination Db";
            this.buttonGetFromDestinationDb.UseVisualStyleBackColor = true;
            this.buttonGetFromDestinationDb.Click += new System.EventHandler(this.buttonGetFromDestinationDb_Click);
            // 
            // listBoxFromDb
            // 
            this.listBoxFromDb.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxFromDb.FormattingEnabled = true;
            this.listBoxFromDb.HorizontalScrollbar = true;
            this.listBoxFromDb.ItemHeight = 15;
            this.listBoxFromDb.Location = new System.Drawing.Point(249, 110);
            this.listBoxFromDb.Name = "listBoxFromDb";
            this.listBoxFromDb.ScrollAlwaysVisible = true;
            this.listBoxFromDb.Size = new System.Drawing.Size(181, 109);
            this.listBoxFromDb.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 453);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGetFactTable);
            this.tabPage1.Controls.Add(this.listBoxProductFromDestinationDb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBoxProducts);
            this.tabPage1.Controls.Add(this.listBoxCustomer);
            this.tabPage1.Controls.Add(this.btnGetProducts);
            this.tabPage1.Controls.Add(this.listBoxFromDb);
            this.tabPage1.Controls.Add(this.btnCustomer);
            this.tabPage1.Controls.Add(this.btnGetDates);
            this.tabPage1.Controls.Add(this.buttonGetFromDestinationDb);
            this.tabPage1.Controls.Add(this.listBoxDates);
            this.tabPage1.Controls.Add(this.btnOrder);
            this.tabPage1.Controls.Add(this.listBoxOrder);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxProductFromDestinationDb
            // 
            this.listBoxProductFromDestinationDb.FormattingEnabled = true;
            this.listBoxProductFromDestinationDb.ItemHeight = 15;
            this.listBoxProductFromDestinationDb.Location = new System.Drawing.Point(492, 297);
            this.listBoxProductFromDestinationDb.Name = "listBoxProductFromDestinationDb";
            this.listBoxProductFromDestinationDb.Size = new System.Drawing.Size(188, 109);
            this.listBoxProductFromDestinationDb.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.barChart);
            this.tabPage2.Controls.Add(this.pieChart);
            this.tabPage2.Controls.Add(this.buttonLoadData);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // barChart
            // 
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(23, 98);
            this.barChart.Name = "barChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.barChart.Series.Add(series1);
            this.barChart.Size = new System.Drawing.Size(349, 280);
            this.barChart.TabIndex = 2;
            this.barChart.Text = "chart2";
            // 
            // pieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieChart.Legends.Add(legend2);
            this.pieChart.Location = new System.Drawing.Point(441, 98);
            this.pieChart.Name = "pieChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieChart.Series.Add(series2);
            this.pieChart.Size = new System.Drawing.Size(279, 280);
            this.pieChart.TabIndex = 1;
            this.pieChart.Text = "chart1";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(23, 18);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(107, 39);
            this.buttonLoadData.TabIndex = 0;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // btnGetFactTable
            // 
            this.btnGetFactTable.Location = new System.Drawing.Point(492, 252);
            this.btnGetFactTable.Name = "btnGetFactTable";
            this.btnGetFactTable.Size = new System.Drawing.Size(136, 27);
            this.btnGetFactTable.TabIndex = 13;
            this.btnGetFactTable.Text = "GetFactTable";
            this.btnGetFactTable.UseVisualStyleBackColor = true;
            this.btnGetFactTable.Click += new System.EventHandler(this.btnGetFactTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 533);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
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
        private System.Windows.Forms.Button buttonGetFromDestinationDb;
        private System.Windows.Forms.ListBox listBoxFromDb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.ListBox listBoxProductFromDestinationDb;
        private System.Windows.Forms.Button btnGetFactTable;
    }
}

