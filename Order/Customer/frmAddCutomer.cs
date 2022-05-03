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
    public partial class frmAddCutomer : Form
    {
        Modal.Db_ShopOrderEntities db = new Db_ShopOrderEntities();
        public int idcustomer = 0;
        public frmAddCutomer()
        {
            InitializeComponent();
        }
        private void frmAddCutomer_Load(object sender, EventArgs e)
        {
            if (idcustomer != 0)
            {
                var cutomer = (from u in db.Tbl_Customer where u.CustomerID == idcustomer select u).First();
                txtName.Text = cutomer.Name;
                txtFamily.Text = cutomer.Family;
                txtMobile.Text = cutomer.Mobile;
                txtAdress.Text = cutomer.adress;
                txtNote.Text = cutomer.Note;



            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idcustomer == 0)
            {
                db.Tbl_Customer.Add(new Tbl_Customer()
                {

                    Name = txtName.Text,
                    Family = txtFamily.Text,
                    FullName = txtName.Text + " " + txtFamily.Text,
                    Mobile = txtMobile.Text,
                    adress = txtAdress.Text,
                    Note = txtNote.Text,
                });
                db.SaveChanges();
                DialogResult = DialogResult.OK;

            }
            else {
                var cutomer = (from u in db.Tbl_Customer where u.CustomerID == idcustomer select u).First();
                cutomer.Name = txtName.Text;
                cutomer.Family = txtFamily.Text;
                cutomer.Mobile = txtMobile.Text;
                cutomer.adress = txtAdress.Text;
                cutomer.Note = txtNote.Text;
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

     
    }
}
