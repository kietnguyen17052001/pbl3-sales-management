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
        public FrmManage_Data()
        {
            InitializeComponent();
        }

        private void btnSTAFFS_Click(object sender, EventArgs e)
        {
            FrmManage_Staffs frm = new FrmManage_Staffs();
            frm.Show();
            this.Close();
        }

        private void btnCUSTOMERS_Click(object sender, EventArgs e)
        {
            FrmManage_Customers frm = new FrmManage_Customers();
            frm.Show();
            this.Close();
        }

        private void btnPRODUCT_Click(object sender, EventArgs e)
        {
            FrmManage_Items frm = new FrmManage_Items();
            frm.Show();
            this.Close();
        }

        private void btnSALE_Click(object sender, EventArgs e)
        {
            FrmInvoice_SaleProduct frm = new FrmInvoice_SaleProduct(true, null);
            frm.Show();
            this.Close();
        }

        private void btnSUPPLIERS_Click(object sender, EventArgs e)
        {
            FrmManage_Suppliers frm = new FrmManage_Suppliers();
            frm.Show();
            this.Close();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmMain_Admin frm = new FrmMain_Admin();
            frm.Show();
            this.Close();
        }

        private void btnLIST_SALEINVOICE_Click(object sender, EventArgs e)
        {
            FrmList_SaleInvoice frm = new FrmList_SaleInvoice(true, null);
            frm.Show();
            this.Close();
        }

        private void btnTYPE_PRODUCT_Click(object sender, EventArgs e)
        {
            FrmManage_TypeOfProduct frm = new FrmManage_TypeOfProduct();
            frm.Show();
            this.Close();
        }

        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            FrmInvoice_ImportProduct frm = new FrmInvoice_ImportProduct(true, null);
            frm.Show();
            this.Close();
        }

        private void btnLIST_IMPORTINVOICE_Click(object sender, EventArgs e)
        {
            FrmList_ImportInvoice frm = new FrmList_ImportInvoice(true, null);
            frm.Show();
            this.Close();
        }
    }
}
