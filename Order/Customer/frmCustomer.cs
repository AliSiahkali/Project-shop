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

namespace Order.Customer
{
    public partial class frmCustomer : Form

    {
        Modal.Db_ShopOrderEntities db = new Db_ShopOrderEntities();
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Grid();
        }

        private void Grid()
        {
            rgvCustomer.DataSource = (from c in db.Tbl_Customer select c).ToList();
        }

        private void rgvCustomer_Click(object sender, EventArgs e)
        {

        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void commandBarButton1_Click(object sender, EventArgs e)
        {
            if((new frmAddCutomer()).ShowDialog() == DialogResult.OK)
            {
            Grid();
            MessageBox.Show("اطلاعات جدید با موفقیت ثبت گردید");
            }
           
        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
            if (rgvCustomer.CurrentRow != null)
            {
                int cutomerid = int.Parse(rgvCustomer.CurrentRow.Cells[0].Value.ToString());
            if  (new frmAddCutomer(){idcustomer=cutomerid}.ShowDialog() == DialogResult.OK)
            {
            
            Grid();
            MessageBox.Show("اطلاعات با موفقیت ویرایش شد");
            }
            }
        }

        private void commandBarButton3_Click(object sender, EventArgs e)
        {
            if (rgvCustomer.CurrentRow != null)
            {
                int cutomerid = int.Parse(rgvCustomer.CurrentRow.Cells[0].Value.ToString());
                var customer = (from u in db.Tbl_Customer where u.CustomerID == cutomerid select u).First();
                db.Tbl_Customer.Remove(customer);
                db.SaveChanges();
                Grid();
                MessageBox.Show("اطلاعات با موفقیت حذف گردید");
            }
        }
    }
}
