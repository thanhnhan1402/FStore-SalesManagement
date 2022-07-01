namespace SalesWinApp
{
    partial class frmOrderInfo
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
            this.lbOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.cboMemberId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(17, 28);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(51, 15);
            this.lbOrderId.TabIndex = 0;
            this.lbOrderId.Text = "Order ID";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(111, 25);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(164, 23);
            this.txtOrderId.TabIndex = 1;
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(17, 62);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(66, 15);
            this.lbMemberId.TabIndex = 2;
            this.lbMemberId.Text = "Member ID";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(17, 100);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(64, 15);
            this.lbOrderDate.TabIndex = 4;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(17, 136);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(81, 15);
            this.lbRequiredDate.TabIndex = 6;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(17, 173);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(77, 15);
            this.lbShippedDate.TabIndex = 8;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(111, 207);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(164, 23);
            this.txtFreight.TabIndex = 11;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(17, 210);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(44, 15);
            this.lbFreight.TabIndex = 10;
            this.lbFreight.Text = "Freight";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(111, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(200, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(111, 100);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(165, 23);
            this.dtpOrderDate.TabIndex = 14;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequiredDate.Location = new System.Drawing.Point(111, 136);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(165, 23);
            this.dtpRequiredDate.TabIndex = 15;
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShippedDate.Location = new System.Drawing.Point(110, 173);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(165, 23);
            this.dtpShippedDate.TabIndex = 16;
            // 
            // cboMemberId
            // 
            this.cboMemberId.FormattingEnabled = true;
            this.cboMemberId.Location = new System.Drawing.Point(110, 62);
            this.cboMemberId.Name = "cboMemberId";
            this.cboMemberId.Size = new System.Drawing.Size(165, 23);
            this.cboMemberId.TabIndex = 17;
            // 
            // frmOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 294);
            this.Controls.Add(this.cboMemberId);
            this.Controls.Add(this.dtpShippedDate);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbMemberId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lbOrderId);
            this.Name = "frmOrderInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Info";
            this.Load += new System.EventHandler(this.frmOrderInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbOrderId;
        private TextBox txtOrderId;
        private Label lbMemberId;
        private Label lbOrderDate;
        private Label lbRequiredDate;
        private Label lbShippedDate;
        private TextBox txtFreight;
        private Label lbFreight;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
        private ComboBox cboMemberId;
    }
}