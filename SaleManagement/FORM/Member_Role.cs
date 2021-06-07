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
        public FrmMain_Member()
        {
            InitializeComponent();
        }

        private void btnSaleProduct_Click(object sender, EventArgs e)
        {
            FrmInvoice_SaleProduct frm = new FrmInvoice_SaleProduct(false);
            frm.Show();
            this.Close();
        }

        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            FrmInvoice_ImportProduct frm = new FrmInvoice_ImportProduct(false);
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
            FrmIntroduce frm = new FrmIntroduce(false);
            frm.Show();
            this.Close();
        }
    }
}
