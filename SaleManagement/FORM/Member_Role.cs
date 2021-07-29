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
            usernameLogin = _usernameLogin.ToUpper();
            lbWelcome.Text += " " + usernameLogin;
            lbDate.Text += " " + DateTime.Now.ToString("dddd, dd/MM/yyyy");
        }

        private void btnSaleProduct_Click(object sender, EventArgs e)
        {
            FrmInvoice_SaleProduct frmInvoiceSaleProduct = new FrmInvoice_SaleProduct(false, usernameLogin);
            frmInvoiceSaleProduct.Show();
            this.Close();
        }

        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            FrmInvoice_ImportProduct frmInvoiceImportProduct = new FrmInvoice_ImportProduct(false, usernameLogin);
            frmInvoiceImportProduct.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(usernameLogin);
            frmLogin.Show();
            this.Close();
        }

        private void btnListSaleInvoice_Click(object sender, EventArgs e)
        {
            FrmList_SaleInvoice frmListSaleInvoice = new FrmList_SaleInvoice(false, usernameLogin);
            frmListSaleInvoice.Show();
            this.Close();
        }

        private void btnListImportInvoice_Click(object sender, EventArgs e)
        {
            FrmList_ImportInvoice frmListImportInvoice = new FrmList_ImportInvoice(false, usernameLogin);
            frmListImportInvoice.Show();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmChange_Password frmChangePassword = new FrmChange_Password(false, usernameLogin);
            frmChangePassword.Show();
        }
    }
}
