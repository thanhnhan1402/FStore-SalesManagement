namespace SalesWinApp
{
    partial class frmOrders
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
            this.lbOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lbOderDate = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(34, 39);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(66, 20);
            this.lbOrderId.TabIndex = 0;
            this.lbOrderId.Text = "Order ID";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(118, 32);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(185, 27);
            this.txtOrderId.TabIndex = 1;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(118, 92);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(185, 27);
            this.txtMemberId.TabIndex = 3;
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(34, 103);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(84, 20);
            this.lbMemberId.TabIndex = 2;
            this.lbMemberId.Text = "Member ID";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(118, 157);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(185, 27);
            this.txtOrderDate.TabIndex = 5;
            // 
            // lbOderDate
            // 
            this.lbOderDate.AutoSize = true;
            this.lbOderDate.Location = new System.Drawing.Point(34, 168);
            this.lbOderDate.Name = "lbOderDate";
            this.lbOderDate.Size = new System.Drawing.Size(83, 20);
            this.lbOderDate.TabIndex = 4;
            this.lbOderDate.Text = "Order Date";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(480, 35);
            this.txtRequiredDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(185, 27);
            this.txtRequiredDate.TabIndex = 7;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(381, 43);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(105, 20);
            this.lbRequiredDate.TabIndex = 6;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(480, 92);
            this.txtShippedDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(185, 27);
            this.txtShippedDate.TabIndex = 9;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(381, 103);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(100, 20);
            this.lbShippedDate.TabIndex = 8;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(480, 157);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(185, 27);
            this.txtFreight.TabIndex = 11;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(381, 161);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(55, 20);
            this.lbFreight.TabIndex = 10;
            this.lbFreight.Text = "Freight";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AutoGenerateColumns = false;
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.memberIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.requiredDateDataGridViewTextBoxColumn,
            this.shippedDateDataGridViewTextBoxColumn,
            this.freightDataGridViewTextBoxColumn});
            this.dgvOrderList.DataSource = this.orderBindingSource;
            this.dgvOrderList.Location = new System.Drawing.Point(34, 285);
            this.dgvOrderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 25;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(631, 200);
            this.dgvOrderList.TabIndex = 12;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(34, 231);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 31);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(289, 231);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 31);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(575, 231);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(289, 511);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(DataAccess.Models.Order);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // memberIdDataGridViewTextBoxColumn
            // 
            this.memberIdDataGridViewTextBoxColumn.DataPropertyName = "MemberId";
            this.memberIdDataGridViewTextBoxColumn.HeaderText = "MemberId";
            this.memberIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIdDataGridViewTextBoxColumn.Name = "memberIdDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // requiredDateDataGridViewTextBoxColumn
            // 
            this.requiredDateDataGridViewTextBoxColumn.DataPropertyName = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.HeaderText = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requiredDateDataGridViewTextBoxColumn.Name = "requiredDateDataGridViewTextBoxColumn";
            // 
            // shippedDateDataGridViewTextBoxColumn
            // 
            this.shippedDateDataGridViewTextBoxColumn.DataPropertyName = "ShippedDate";
            this.shippedDateDataGridViewTextBoxColumn.HeaderText = "ShippedDate";
            this.shippedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shippedDateDataGridViewTextBoxColumn.Name = "shippedDateDataGridViewTextBoxColumn";
            // 
            // freightDataGridViewTextBoxColumn
            // 
            this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
            this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
            this.freightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 556);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lbOderDate);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lbMemberId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lbOrderId);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Management";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbOrderId;
        private TextBox txtOrderId;
        private TextBox txtMemberId;
        private Label lbMemberId;
        private TextBox txtOrderDate;
        private Label lbOderDate;
        private TextBox txtRequiredDate;
        private Label lbRequiredDate;
        private TextBox txtShippedDate;
        private Label lbShippedDate;
        private TextBox txtFreight;
        private Label lbFreight;
        private DataGridView dgvOrderList;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memberIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn requiredDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shippedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
    }
}