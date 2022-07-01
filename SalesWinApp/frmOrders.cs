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
    public partial class frmOrders : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadOrderList();
            dgvOrderList.CellDoubleClick += DgvOrderList_CellDoubleClick;
        }

        private void DgvOrderList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmOrderInfo frmOrderInfo = new frmOrderInfo
            {
                Text = "Update order",
                InsertOrUpdate = true,
                OrderInfo = GetOrderObject(),
                OrderRepository = orderRepository
            };
            frmOrderInfo.ShowDialog();
            LoadOrderList();
            source.Position = source.Count - 1;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrderInfo frmOrderInfo = new frmOrderInfo
            {
                Text = "Create order",
                InsertOrUpdate = false,
                OrderRepository = orderRepository
            };
            frmOrderInfo.ShowDialog();
            LoadOrderList();
            source.Position = source.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                orderRepository.DeleteOrder(order);
                LoadOrderList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete order");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void ClearText()
        {
            txtOrderId.Text = string.Empty;
            txtMemberId.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
            txtFreight.Text = string.Empty;
        }

        private Order GetOrderObject()
        {
            Order order = null;
            try
            {
                order = new Order
                {
                    OrderId = Int32.Parse(txtOrderId.Text),
                    MemberId = Int32.Parse(txtMemberId.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = Decimal.Parse(txtFreight.Text)
                };
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order");
            }
            return order;
        }

        private void LoadOrderList()
        {
            var orders = orderRepository.GetOrderList();
            try
            {
                source = new BindingSource();
                source.DataSource = orders;

                txtOrderId.DataBindings.Clear();
                txtMemberId.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderId.DataBindings.Add("Text", source, "OrderId");
                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;

                if (orders.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }
    }
}
