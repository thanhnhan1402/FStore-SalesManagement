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
    public partial class frmMain : Form
    {
        frmMembers frmMembers;
        frmOrders frmOrders;
        frmProducts frmProducts;
        public frmMain()
        {
            InitializeComponent();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (frmMembers == null)
            //{
            //    frmMembers = new frmMembers();
            //    frmMembers.MdiParent = this;
            //    frmMembers.Show();
            //} 
            //else
            //{
            //    frmMembers.Activate();
            //}
            frmMembers = new frmMembers();
            frmMembers.MdiParent = this;
            frmMembers.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (frmProducts == null)
            //{
            //    frmProducts = new frmProducts();
            //    frmProducts.MdiParent = this;
            //    frmProducts.Show();
            //}
            //else
            //{
            //    frmProducts.Activate();
            //}
            frmProducts = new frmProducts();
            frmProducts.MdiParent = this;
            frmProducts.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (frmOrders == null)
            //{
            //    frmOrders = new frmOrders();
            //    frmOrders.MdiParent = this;
            //    frmOrders.Show();
            //} 
            //else
            //{
            //    frmOrders.Activate();
            //}
            frmOrders = new frmOrders();
            frmOrders.MdiParent = this;
            frmOrders.Show();
        }
    }
}
