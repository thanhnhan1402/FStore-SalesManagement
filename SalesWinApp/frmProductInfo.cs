using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductInfo : Form
    {
        public frmProductInfo()
        {
            InitializeComponent();
        }
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product ProductInfo { get; set; }

        private void frmProductInfo_Load(object sender, EventArgs e)
        {
            txtProductId.Enabled = false;
            if (InsertOrUpdate)
            {
                txtProductId.Text = ProductInfo.ProductId.ToString();
                txtCategoryId.Text = ProductInfo.CategoryId.ToString();
                txtProductName.Text = ProductInfo.ProductName;
                txtWeight.Text = ProductInfo.Weight;
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtUnitsInStock.Text = ProductInfo.UnitsInStock.ToString();
            } else
            {
                btnSave.Text = "Create";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = true;
            try
            {
                if (InsertOrUpdate)
                {
                    var product_update = new Product
                    {
                        ProductId = int.Parse(txtProductId.Text),
                        CategoryId = Int32.Parse(txtCategoryId.Text),
                        ProductName = txtProductName.Text,
                        Weight = txtWeight.Text,
                        UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                        UnitsInStock = Int32.Parse(txtUnitsInStock.Text)
                    };
                    if (flag)
                    {
                        ProductRepository.UpdateProduct(product_update);
                        MessageBox.Show("Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                } else
                {
                    var new_product = new Product
                    {
                        CategoryId = Int32.Parse(txtCategoryId.Text),
                        ProductName = txtProductName.Text,
                        Weight = txtWeight.Text,
                        UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                        UnitsInStock = Int32.Parse(txtUnitsInStock.Text)
                    };
                    if (flag)
                    {
                        ProductRepository.InsertProduct(new_product);
                        MessageBox.Show("Create Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a product" : "Update product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
