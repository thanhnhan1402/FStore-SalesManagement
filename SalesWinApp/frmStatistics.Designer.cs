namespace SalesWinApp
{
    partial class frmStatistics
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
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvSalesList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOrderDate.Location = new System.Drawing.Point(32, 29);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(200, 23);
            this.dtOrderDate.TabIndex = 0;
            // 
            // dtShippedDate
            // 
            this.dtShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtShippedDate.Location = new System.Drawing.Point(528, 28);
            this.dtShippedDate.Name = "dtShippedDate";
            this.dtShippedDate.Size = new System.Drawing.Size(200, 23);
            this.dtShippedDate.TabIndex = 2;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(339, 30);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dgvSalesList
            // 
            this.dgvSalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesList.Location = new System.Drawing.Point(32, 84);
            this.dgvSalesList.Name = "dgvSalesList";
            this.dgvSalesList.RowTemplate.Height = 25;
            this.dgvSalesList.Size = new System.Drawing.Size(696, 215);
            this.dgvSalesList.TabIndex = 3;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 341);
            this.Controls.Add(this.dgvSalesList);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dtShippedDate);
            this.Controls.Add(this.dtOrderDate);
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dtOrderDate;
        private DateTimePicker dtShippedDate;
        private Button btnReport;
        private DataGridView dgvSalesList;
    }
}