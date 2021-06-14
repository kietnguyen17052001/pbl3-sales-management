using SaleManagement.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.FORM
{
    public partial class FrmMain_Member : Form
    {
        private string usernameLogin;
        public FrmMain_Member(string _usernameLogin)
        {
            InitializeComponent();
            usernameLogin = _usernameLogin;
            lbWelcome.Text += " " + usernameLogin;
            lbDate.Text += " " + DateTime.Now.ToString("dddd, dd/MM/yyyy");
        }

        private void btnSaleProduct_Click(object sender, EventArgs e)
        {
            FrmInvoice_SaleProduct frm = new FrmInvoice_SaleProduct(false, usernameLogin);
            frm.Show();
            this.Close();
        }

        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            FrmInvoice_ImportProduct frm = new FrmInvoice_ImportProduct(false, usernameLogin);
            frm.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Close();
        }

        private void btnIntroduce_Click(object sender, EventArgs e)
        {
            FrmIntroduce frm = new FrmIntroduce(false, usernameLogin);
            frm.Show();
            this.Close();
        }

        private void btnList_SaleInvoice_Click(object sender, EventArgs e)
        {
            FrmList_SaleInvoice frm = new FrmList_SaleInvoice(false, usernameLogin);
            frm.Show();
            this.Close();
        }

        private void btnList_ImportInvoice_Click(object sender, EventArgs e)
        {
            FrmList_ImportInvoice frm = new FrmList_ImportInvoice(false, usernameLogin);
            frm.Show();
            this.Close();
        }
    }
}
