using SaleManagement.FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.VIEW
{
    public partial class FrmManage_Data : Form
    {
        private string usernamelogin;
        public FrmManage_Data(string _usernamelogin)
        {
            InitializeComponent();
            usernamelogin = _usernamelogin;
        }

        private void btnSTAFFS_Click(object sender, EventArgs e)
        {
            FrmManage_Staffs frmManageStaff = new FrmManage_Staffs(usernamelogin);
            frmManageStaff.Show();
            this.Close();
        }

        private void btnCUSTOMERS_Click(object sender, EventArgs e)
        {
            FrmManage_Customers frmManageCustomer = new FrmManage_Customers(usernamelogin);
            frmManageCustomer.Show();
            this.Close();
        }

        private void btnPRODUCT_Click(object sender, EventArgs e)
        {
            FrmManage_Items frmManageProduct = new FrmManage_Items(usernamelogin);
            frmManageProduct.Show();
            this.Close();
        }

        private void btnSALE_Click(object sender, EventArgs e)
        {
            FrmInvoice_SaleProduct frmInvoiceSale = new FrmInvoice_SaleProduct(true, usernamelogin);
            frmInvoiceSale.Show();
            this.Close();
        }

        private void btnSUPPLIERS_Click(object sender, EventArgs e)
        {
            FrmManage_Suppliers frmManageSupplier = new FrmManage_Suppliers(usernamelogin);
            frmManageSupplier.Show();
            this.Close();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmMain_Admin frmMainAdmin = new FrmMain_Admin(usernamelogin);
            frmMainAdmin.Show();
            this.Close();
        }

        private void btnLIST_SALEINVOICE_Click(object sender, EventArgs e)
        {
            FrmList_SaleInvoice frmListSale = new FrmList_SaleInvoice(true, usernamelogin);
            frmListSale.Show();
            this.Close();
        }

        private void btnTYPE_PRODUCT_Click(object sender, EventArgs e)
        {
            FrmManage_TypeOfProduct frmManageTypeOfProduct = new FrmManage_TypeOfProduct(usernamelogin);
            frmManageTypeOfProduct.Show();
            this.Close();
        }

        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            FrmInvoice_ImportProduct frmInvoiceImport = new FrmInvoice_ImportProduct(true, usernamelogin);
            frmInvoiceImport.Show();
            this.Close();
        }

        private void btnLIST_IMPORTINVOICE_Click(object sender, EventArgs e)
        {
            FrmList_ImportInvoice frmListImport = new FrmList_ImportInvoice(true, usernamelogin);
            frmListImport.Show();
            this.Close();
        }
    }
}
