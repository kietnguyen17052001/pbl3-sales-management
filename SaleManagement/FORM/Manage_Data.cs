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

        private void btnITEMS_Click(object sender, EventArgs e)
        {
            FrmManage_Items frm = new FrmManage_Items();
            frm.Show();
            this.Close();
        }

        private void btnBILL_Click(object sender, EventArgs e)
        {
            FrmBill frm = new FrmBill();
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
            FrmSale_Management frm = new FrmSale_Management();
            frm.Show();
            this.Close();
        }

        private void btnLIST_BILLS_Click(object sender, EventArgs e)
        {
            FrmManage_List_Invoice frm = new FrmManage_List_Invoice();
            frm.Show();
            this.Close();
        }

        private void btnTYPE_ITEMS_Click(object sender, EventArgs e)
        {
            FrmManage_TypeOfProduct frm = new FrmManage_TypeOfProduct();
            frm.Show();
            this.Close();
        }
    }
}
