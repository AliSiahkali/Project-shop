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

namespace Order.Account
{
    public partial class frmAccount : Form
    {
        Modal.Db_ShopOrderEntities db = new Db_ShopOrderEntities();
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            Grid();
        }

        private void Grid()
        {
            rgvUser.DataSource = (db.Tbl_User.ToList());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.Tbl_User.Add(new Tbl_User()
            {

                Username = txtUser.Text,
                Password = txtPassword.Text,
            });
            db.SaveChanges();
            Grid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rgvUser.CurrentRow != null)
            {

                if (MessageBox.Show("ایا مطمعن هستید ؟", "اخطار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int userid = int.Parse(rgvUser.CurrentRow.Cells[0].Value.ToString());
                    var user = (from u in db.Tbl_User where u.UserID == userid select u).First();
                    db.Tbl_User.Remove(user);
                    db.SaveChanges();
                    Grid();
                }
            
            }
        }
    }
}
