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
    public partial class frmHistory : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        public int MemberId { get; set; }
        public frmHistory()
        {
            InitializeComponent();
        }
        private void frmHistory_Load(object sender, EventArgs e)
        {
            dgvHistory.DataSource = orderRepository.GetHistory(MemberId);
            dgvHistory.Columns["Member"].Visible = false;
        }
    }

}
