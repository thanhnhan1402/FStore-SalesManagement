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
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.cboProductId = new System.Windows.Forms.ComboBox();
            this.lbProductId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.gbOrder.SuspendLayout();
            this.gbProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(14, 34);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(51, 15);
            this.lbOrderId.TabIndex = 0;
            this.lbOrderId.Text = "Order ID";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(87, 29);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(162, 23);
            this.txtOrderId.TabIndex = 1;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(87, 74);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(162, 23);
            this.txtMemberId.TabIndex = 3;
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(14, 82);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(66, 15);
            this.lbMemberId.TabIndex = 2;
            this.lbMemberId.Text = "Member ID";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(87, 123);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(162, 23);
            this.txtOrderDate.TabIndex = 5;
            // 
            // lbOderDate
            // 
            this.lbOderDate.AutoSize = true;
            this.lbOderDate.Location = new System.Drawing.Point(14, 131);
            this.lbOderDate.Name = "lbOderDate";
            this.lbOderDate.Size = new System.Drawing.Size(64, 15);
            this.lbOderDate.TabIndex = 4;
            this.lbOderDate.Text = "Order Date";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(404, 31);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(162, 23);
            this.txtRequiredDate.TabIndex = 7;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(317, 37);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(81, 15);
            this.lbRequiredDate.TabIndex = 6;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(404, 74);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(162, 23);
            this.txtShippedDate.TabIndex = 9;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(317, 82);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(77, 15);
            this.lbShippedDate.TabIndex = 8;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(404, 123);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(162, 23);
            this.txtFreight.TabIndex = 11;
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(317, 126);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(44, 15);
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
            this.dgvOrderList.Location = new System.Drawing.Point(32, 394);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 25;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(588, 150);
            this.dgvOrderList.TabIndex = 12;
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
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(DataAccess.Models.Order);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(32, 351);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(144, 351);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(545, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(292, 555);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.txtFreight);
            this.gbOrder.Controls.Add(this.lbOrderId);
            this.gbOrder.Controls.Add(this.txtOrderId);
            this.gbOrder.Controls.Add(this.lbMemberId);
            this.gbOrder.Controls.Add(this.txtMemberId);
            this.gbOrder.Controls.Add(this.lbOderDate);
            this.gbOrder.Controls.Add(this.txtOrderDate);
            this.gbOrder.Controls.Add(this.lbFreight);
            this.gbOrder.Controls.Add(this.lbRequiredDate);
            this.gbOrder.Controls.Add(this.txtShippedDate);
            this.gbOrder.Controls.Add(this.txtRequiredDate);
            this.gbOrder.Controls.Add(this.lbShippedDate);
            this.gbOrder.Location = new System.Drawing.Point(32, 12);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(588, 181);
            this.gbOrder.TabIndex = 17;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order\'s Information";
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.txtDiscount);
            this.gbProduct.Controls.Add(this.lbDiscount);
            this.gbProduct.Controls.Add(this.txtQuantity);
            this.gbProduct.Controls.Add(this.lbQuantity);
            this.gbProduct.Controls.Add(this.txtUnitPrice);
            this.gbProduct.Controls.Add(this.lbUnitPrice);
            this.gbProduct.Controls.Add(this.txtProductName);
            this.gbProduct.Controls.Add(this.lbProductName);
            this.gbProduct.Controls.Add(this.cboProductId);
            this.gbProduct.Controls.Add(this.lbProductId);
            this.gbProduct.Location = new System.Drawing.Point(34, 199);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(586, 134);
            this.gbProduct.TabIndex = 18;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Product\'s Information";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(292, 75);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 23);
            this.txtDiscount.TabIndex = 9;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(202, 78);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(54, 15);
            this.lbDiscount.TabIndex = 8;
            this.lbDiscount.Text = "Discount";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(85, 74);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 23);
            this.txtQuantity.TabIndex = 7;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(13, 77);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(53, 15);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(464, 27);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 23);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(402, 32);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lbUnitPrice.TabIndex = 4;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(292, 29);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(100, 23);
            this.txtProductName.TabIndex = 3;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(202, 32);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(84, 15);
            this.lbProductName.TabIndex = 2;
            this.lbProductName.Text = "Product Name";
            // 
            // cboProductId
            // 
            this.cboProductId.FormattingEnabled = true;
            this.cboProductId.Location = new System.Drawing.Point(85, 29);
            this.cboProductId.Name = "cboProductId";
            this.cboProductId.Size = new System.Drawing.Size(100, 23);
            this.cboProductId.TabIndex = 1;
            this.cboProductId.SelectedIndexChanged += new System.EventHandler(this.cbProductId_SelectedIndexChanged);
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(12, 32);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(63, 15);
            this.lbProductId.TabIndex = 0;
            this.lbProductId.Text = "Product ID";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(448, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(245, 351);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(75, 23);
            this.btnStatistics.TabIndex = 20;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(349, 351);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 21;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 590);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbProduct);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvOrderList);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Management";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            this.ResumeLayout(false);

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
        private GroupBox gbOrder;
        private GroupBox gbProduct;
        private TextBox txtDiscount;
        private Label lbDiscount;
        private TextBox txtQuantity;
        private Label lbQuantity;
        private TextBox txtUnitPrice;
        private Label lbUnitPrice;
        private TextBox txtProductName;
        private Label lbProductName;
        private ComboBox cboProductId;
        private Label lbProductId;
        private Button btnSave;
        private Button btnStatistics;
        private Button btnSort;
    }
}