using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Order.Modal;
using System.Data.SqlClient;


namespace Order
{
    public partial class Form1 : Form
    {
        Modal.Db_ShopOrderEntities db = new Db_ShopOrderEntities();         
        public Form1()
        {
            InitializeComponent();
        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var user=(from u in db.Tbl_User where u.Username==txtusername.Text && u.Password==txtpassword.Text select u).Any();  
                
            if (user)
            {
                this.Hide();
            frmMain fa= new frmMain();
                fa.ShowDialog();
                this.Hide();
            }
            else {
            MessageBox.Show("اطلاعات شما تایید نشد");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
