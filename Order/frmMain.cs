using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order.Modal;
using System.Data.SqlClient;
using Order.Customer;
using Order.Product;
using Order.Account;

namespace Order
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer fa = new frmCustomer();
            fa.ShowDialog();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            frmProduct fa = new frmProduct();
            fa.ShowDialog();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            frmAccount fa = new frmAccount();
            fa.ShowDialog();
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            frmProduct fa = new frmProduct();
            fa.ShowDialog();
        }

        private void radButtonElement4_Click(object sender, EventArgs e)
        {
            frmCustomer fa = new frmCustomer();
            fa.ShowDialog();
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            frmAccount fa = new frmAccount();
            fa.ShowDialog();
        }
    }
}
