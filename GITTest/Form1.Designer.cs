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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            this.btnGetCustomerFromDatabase = new System.Windows.Forms.Button();
            this.listBoxCustomerFromDbNamed = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDates = new System.Windows.Forms.Button();
            this.btnGetProductFromDatabase = new System.Windows.Forms.Button();
            this.groupBoxDatabaseTables = new System.Windows.Forms.GroupBox();
            this.listBoxDateFromSource = new System.Windows.Forms.ListBox();
            this.listBoxProductFromDbNamed = new System.Windows.Forms.ListBox();
            this.groupBoxDimensionsTables = new System.Windows.Forms.GroupBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblDates = new System.Windows.Forms.Label();
            this.btnDimension = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnLoadData1 = new System.Windows.Forms.Button();
            this.BarChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxDatabaseTables.SuspendLayout();
            this.groupBoxDimensionsTables.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = ".";
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.ItemHeight = 12;
            this.listBoxDates.Location = new System.Drawing.Point(9, 51);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(115, 88);
            this.listBoxDates.TabIndex = 3;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 12;
            this.listBoxProducts.Location = new System.Drawing.Point(0, 175);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(573, 88);
            this.listBoxProducts.TabIndex = 5;
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.ItemHeight = 12;
            this.listBoxCustomer.Location = new System.Drawing.Point(142, 51);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(431, 88);
            this.listBoxCustomer.TabIndex = 9;
            // 
            // btnGetCustomerFromDatabase
            // 
            this.btnGetCustomerFromDatabase.Location = new System.Drawing.Point(605, 220);
            this.btnGetCustomerFromDatabase.Name = "btnGetCustomerFromDatabase";
            this.btnGetCustomerFromDatabase.Size = new System.Drawing.Size(147, 48);
            this.btnGetCustomerFromDatabase.TabIndex = 10;
            this.btnGetCustomerFromDatabase.Text = "GetCustomerFromDatabase";
            this.btnGetCustomerFromDatabase.UseVisualStyleBackColor = true;
            this.btnGetCustomerFromDatabase.Click += new System.EventHandler(this.btnGetCustomerFromDatabase_Click);
            // 
            // listBoxCustomerFromDbNamed
            // 
            this.listBoxCustomerFromDbNamed.FormattingEnabled = true;
            this.listBoxCustomerFromDbNamed.ItemHeight = 12;
            this.listBoxCustomerFromDbNamed.Location = new System.Drawing.Point(12, 274);
            this.listBoxCustomerFromDbNamed.Name = "listBoxCustomerFromDbNamed";
            this.listBoxCustomerFromDbNamed.Size = new System.Drawing.Size(540, 76);
            this.listBoxCustomerFromDbNamed.TabIndex = 11;
            this.listBoxCustomerFromDbNamed.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomerFromDbNamed_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1165, 653);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDates);
            this.tabPage1.Controls.Add(this.btnGetProductFromDatabase);
            this.tabPage1.Controls.Add(this.groupBoxDatabaseTables);
            this.tabPage1.Controls.Add(this.groupBoxDimensionsTables);
            this.tabPage1.Controls.Add(this.btnDimension);
            this.tabPage1.Controls.Add(this.btnGetCustomerFromDatabase);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1157, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDates
            // 
            this.btnDates.Location = new System.Drawing.Point(920, 220);
            this.btnDates.Name = "btnDates";
            this.btnDates.Size = new System.Drawing.Size(75, 48);
            this.btnDates.TabIndex = 17;
            this.btnDates.Text = "GetDates";
            this.btnDates.UseVisualStyleBackColor = true;
            this.btnDates.Click += new System.EventHandler(this.btnDates_Click);
            // 
            // btnGetProductFromDatabase
            // 
            this.btnGetProductFromDatabase.Location = new System.Drawing.Point(758, 220);
            this.btnGetProductFromDatabase.Name = "btnGetProductFromDatabase";
            this.btnGetProductFromDatabase.Size = new System.Drawing.Size(155, 48);
            this.btnGetProductFromDatabase.TabIndex = 16;
            this.btnGetProductFromDatabase.Text = "GetProductFromDatabase";
            this.btnGetProductFromDatabase.UseVisualStyleBackColor = true;
            this.btnGetProductFromDatabase.Click += new System.EventHandler(this.btnGetProductFromDatabase_Click);
            // 
            // groupBoxDatabaseTables
            // 
            this.groupBoxDatabaseTables.Controls.Add(this.listBoxDateFromSource);
            this.groupBoxDatabaseTables.Controls.Add(this.listBoxProductFromDbNamed);
            this.groupBoxDatabaseTables.Controls.Add(this.listBoxCustomerFromDbNamed);
            this.groupBoxDatabaseTables.Location = new System.Drawing.Point(599, 273);
            this.groupBoxDatabaseTables.Name = "groupBoxDatabaseTables";
            this.groupBoxDatabaseTables.Size = new System.Drawing.Size(552, 353);
            this.groupBoxDatabaseTables.TabIndex = 14;
            this.groupBoxDatabaseTables.TabStop = false;
            this.groupBoxDatabaseTables.Text = "Database Tables";
            // 
            // listBoxDateFromSource
            // 
            this.listBoxDateFromSource.FormattingEnabled = true;
            this.listBoxDateFromSource.ItemHeight = 12;
            this.listBoxDateFromSource.Location = new System.Drawing.Point(12, 88);
            this.listBoxDateFromSource.Name = "listBoxDateFromSource";
            this.listBoxDateFromSource.Size = new System.Drawing.Size(120, 100);
            this.listBoxDateFromSource.TabIndex = 13;
            // 
            // listBoxProductFromDbNamed
            // 
            this.listBoxProductFromDbNamed.FormattingEnabled = true;
            this.listBoxProductFromDbNamed.ItemHeight = 12;
            this.listBoxProductFromDbNamed.Location = new System.Drawing.Point(12, 193);
            this.listBoxProductFromDbNamed.Name = "listBoxProductFromDbNamed";
            this.listBoxProductFromDbNamed.Size = new System.Drawing.Size(539, 76);
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
            this.groupBoxDimensionsTables.Location = new System.Drawing.Point(3, 360);
            this.groupBoxDimensionsTables.Name = "groupBoxDimensionsTables";
            this.groupBoxDimensionsTables.Size = new System.Drawing.Size(579, 263);
            this.groupBoxDimensionsTables.TabIndex = 13;
            this.groupBoxDimensionsTables.TabStop = false;
            this.groupBoxDimensionsTables.Text = "Dimensions Tables";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(6, 159);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(53, 12);
            this.lblProducts.TabIndex = 12;
            this.lblProducts.Text = "Products";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(152, 36);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(59, 12);
            this.lblCustomers.TabIndex = 11;
            this.lblCustomers.Text = "Customers";
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Location = new System.Drawing.Point(19, 34);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(35, 12);
            this.lblDates.TabIndex = 10;
            this.lblDates.Text = "Dates";
            // 
            // btnDimension
            // 
            this.btnDimension.Location = new System.Drawing.Point(177, 289);
            this.btnDimension.Name = "btnDimension";
            this.btnDimension.Size = new System.Drawing.Size(139, 48);
            this.btnDimension.TabIndex = 12;
            this.btnDimension.Text = "Get Dimensions Tables";
            this.btnDimension.UseVisualStyleBackColor = true;
            this.btnDimension.Click += new System.EventHandler(this.btnDimension_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PieChart);
            this.tabPage2.Controls.Add(this.BarChart);
            this.tabPage2.Controls.Add(this.btnLoadData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1157, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(8, 6);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // BarChart
            // 
            chartArea2.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.BarChart.Legends.Add(legend2);
            this.BarChart.Location = new System.Drawing.Point(116, 131);
            this.BarChart.Name = "BarChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.BarChart.Series.Add(series2);
            this.BarChart.Size = new System.Drawing.Size(300, 300);
            this.BarChart.TabIndex = 1;
            this.BarChart.Text = "BarChart";
            // 
            // PieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PieChart.Legends.Add(legend1);
            this.PieChart.Location = new System.Drawing.Point(441, 131);
            this.PieChart.Name = "PieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PieChart.Series.Add(series1);
            this.PieChart.Size = new System.Drawing.Size(300, 300);
            this.PieChart.TabIndex = 2;
            this.PieChart.Text = "PieChart";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BarChart1);
            this.tabPage3.Controls.Add(this.btnLoadData1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1157, 627);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnLoadData1
            // 
            this.btnLoadData1.Location = new System.Drawing.Point(0, 0);
            this.btnLoadData1.Name = "btnLoadData1";
            this.btnLoadData1.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData1.TabIndex = 0;
            this.btnLoadData1.Text = "Load Data";
            this.btnLoadData1.UseVisualStyleBackColor = true;
            this.btnLoadData1.Click += new System.EventHandler(this.btnLoadData1_Click);
            // 
            // BarChart1
            // 
            chartArea3.Name = "ChartArea1";
            this.BarChart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.BarChart1.Legends.Add(legend3);
            this.BarChart1.Location = new System.Drawing.Point(49, 89);
            this.BarChart1.Name = "BarChart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.BarChart1.Series.Add(series3);
            this.BarChart1.Size = new System.Drawing.Size(300, 300);
            this.BarChart1.TabIndex = 1;
            this.BarChart1.Text = "BarChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 662);
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
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarChart1)).EndInit();
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
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart1;
        private System.Windows.Forms.Button btnLoadData1;
    }
}

