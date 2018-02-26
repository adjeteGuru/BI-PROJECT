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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.btnGetDates = new System.Windows.Forms.Button();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Git clone and pull test!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.ItemHeight = 25;
            this.listBoxDates.Location = new System.Drawing.Point(10, 148);
            this.listBoxDates.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(360, 179);
            this.listBoxDates.TabIndex = 3;
            // 
            // btnGetDates
            // 
            this.btnGetDates.Location = new System.Drawing.Point(10, 75);
            this.btnGetDates.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetDates.Name = "btnGetDates";
            this.btnGetDates.Size = new System.Drawing.Size(150, 44);
            this.btnGetDates.TabIndex = 2;
            this.btnGetDates.Text = "GetDates";
            this.btnGetDates.UseVisualStyleBackColor = true;
            this.btnGetDates.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(424, 75);
            this.btnGetProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(204, 44);
            this.btnGetProducts.TabIndex = 4;
            this.btnGetProducts.Text = "GetProducts";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            //this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 25;
            this.listBoxProducts.Location = new System.Drawing.Point(424, 148);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(402, 179);
            this.listBoxProducts.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 638);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.btnGetProducts);
            this.Controls.Add(this.listBoxDates);
            this.Controls.Add(this.btnGetDates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.Button btnGetDates;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.ListBox listBoxProducts;
    }
}

