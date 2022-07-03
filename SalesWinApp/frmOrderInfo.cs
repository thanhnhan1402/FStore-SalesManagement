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
    public partial class frmOrderInfo : Form
    {
        public frmOrderInfo()
        {
            InitializeComponent();
        }
        public IMemberRepository memberRepository = new MemberRepository();    
        public IOrderRepository OrderRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Order OrderInfo { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = true;
            try
            {
               if (InsertOrUpdate)
                {
                    var order_update = new Order()
                    {
                        OrderId = int.Parse(txtOrderId.Text),
                        MemberId = Int32.Parse(cboMemberId.Text),
                        OrderDate = dtpOrderDate.Value,
                        RequiredDate = dtpRequiredDate.Value,
                        ShippedDate = dtpShippedDate.Value,
                        Freight = Decimal.Parse(txtFreight.Text)
                    };
                    if (flag)
                    {
                        OrderRepository.UpdateOrder(order_update);
                        MessageBox.Show("Update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }  else
                {
                    var new_order = new Order()
                    {
                        MemberId = Int32.Parse(cboMemberId.Text),
                        OrderDate = dtpOrderDate.Value,
                        RequiredDate = dtpRequiredDate.Value,
                        ShippedDate = dtpShippedDate.Value,
                        Freight = Decimal.Parse(txtFreight.Text)
                    };
                    if (flag)
                    {
                        OrderRepository.InsertOrder(new_order);
                        MessageBox.Show("Create successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new order" : "Update an order");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmOrderInfo_Load(object sender, EventArgs e)
         {
            foreach(var member in memberRepository.GetMemberList())
            {
                cboMemberId.Items.Add(member.MemberId);
            }
            cboMemberId.SelectedIndex = 0;
            txtOrderId.Enabled = false;
            cboMemberId.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate)
            {
                txtOrderId.Text = OrderInfo.OrderId.ToString();
                cboMemberId.Text = OrderInfo.MemberId.ToString();
                dtpOrderDate.Value = OrderInfo.OrderDate;
                dtpRequiredDate.Value = (DateTime)OrderInfo.RequiredDate; 
                dtpShippedDate.Value = (DateTime)OrderInfo.ShippedDate;
                txtFreight.Text = OrderInfo.Freight.ToString();
            } else
            {
                btnSave.Text = "Create";
            }
        }
    }
}
