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
    public partial class frmStatistics : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        public frmStatistics()
        {
            InitializeComponent();
            LoadDateTimePicker();
        }
        #region events
        private void btnReport_Click(object sender, EventArgs e)
        {
            DateTime orderDate = dtOrderDate.Value;
            DateTime shippedDate = dtShippedDate.Value;
            dgvSalesList.DataSource = orderRepository.GetStatistics(orderDate, shippedDate);
            dgvSalesList.Columns["Member"].Visible = false;
            dgvSalesList.Columns["OrderDetails"].Visible = false;
        }

        #endregion
        #region methods

        private void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtOrderDate.Value = new DateTime(today.Year, today.Month, 1);
            dtShippedDate.Value = dtOrderDate.Value.AddMonths(1).AddDays(-1);
        }

        #endregion

    }
}
