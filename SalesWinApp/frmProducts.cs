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
    public partial class frmProducts : Form
    {
        IEnumerable<Product> proList;
        IProductRepository productRepository = new ProductRepository();
        int id, unitPrice, units_in_stock; 
        bool isNumber;
        BindingSource source;
        public frmProducts()
        {     
            InitializeComponent();
            rdID.Checked = true;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProductList();
            dgvProductList.CellDoubleClick += DgvProductList_CellDoubleClick;
        }

        private void DgvProductList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmProductInfo frmProductInfo = new frmProductInfo
            {
                Text = "Update Product",
                InsertOrUpdate = true,
                ProductInfo = GetProductObject(),
                ProductRepository = productRepository
            }; 
            frmProductInfo.ShowDialog();
            LoadProductList();
            source.Position = source.Count - 1;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductInfo frmProductInfo = new frmProductInfo
            {
                Text = "Create Product",
                InsertOrUpdate = false,
                ProductRepository = productRepository
            };
            frmProductInfo.ShowDialog();
            LoadProductList();
            source.Position = source.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                productRepository.DeleteProduct(product);
                LoadProductList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete product");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text;
            var list = new List<Product>();
            if(rdName.Checked)
            {
                proList = productRepository.GetProductsByName(keyword);
                LoadSearchProductsList(proList); 
            }
            else if(rdID.Checked)
            {
                isNumber = Int32.TryParse(keyword, out id);
                if (!isNumber)
                {
                    MessageBox.Show("ID must be a number", "Wrong input", MessageBoxButtons.OK);
                }
                else
                {
                    var product = productRepository.GetProductByID(id);
                    if(product == null)
                    {
                        MessageBox.Show("Product does not exist", "Search failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        list.Add(product);
                        LoadSearchProductsList(list);
                    }
                }
            }
            else if(rdUnitPrice.Checked)
            {
                isNumber = Int32.TryParse(keyword, out unitPrice);
                if (!isNumber)
                {
                    MessageBox.Show("Unit price must be a number", "Wrong input", MessageBoxButtons.OK);
                }
                else
                {
                    proList = productRepository.GetProductsByUnitPrice(unitPrice);
                    LoadSearchProductsList(proList);
                }
            }
            else if(rdUnitsInStock.Checked)
            {
                isNumber = Int32.TryParse(keyword, out units_in_stock);
                if (!isNumber)
                {
                    MessageBox.Show("Unit in stock must be a number", "Wrong input", MessageBoxButtons.OK);
                }
                else
                {
                    proList = productRepository.GetProductsByUnitsInStock(units_in_stock);
                    LoadSearchProductsList(proList);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void ClearText()
        {
            txtProductId.Text = string.Empty;
            txtCategoryId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
        }

        private Product GetProductObject()
        {
            Product product = null;
            try
            {
                product = new Product
                {
                    ProductId = Int32.Parse(txtProductId.Text),
                    CategoryId = Int32.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = Int32.Parse(txtUnitsInStock.Text)
                };
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }


        private void LoadProductList()
        {
            var products = productRepository.GetAllProducts();
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                txtProductId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;

                if (products.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                } else
                {
                    btnDelete.Enabled = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }
        private void LoadSearchProductsList(IEnumerable<Product> proList)
        {
            dgvProductList.DataSource = null;
            try
            {
                source = new BindingSource();
                source.DataSource = proList;

                txtProductId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                if(proList.Count() > 0)
                {
                    txtProductId.DataBindings.Add("Text", source, "ProductId");
                    txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                    txtProductName.DataBindings.Add("Text", source, "ProductName");
                    txtWeight.DataBindings.Add("Text", source, "Weight");
                    txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                    txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                    btnDelete.Enabled = true;

                    dgvProductList.DataSource = source;
                }
                else
                {
                    ClearText();
                    btnDelete.Enabled = false;
                    MessageBox.Show("Product does not exist", "Search failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }
    }
}
