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
            FrmManage_Staffs FRM = new FrmManage_Staffs();
            FRM.Show();
            this.Close();
        }

        private void btnCUSTOMERS_Click(object sender, EventArgs e)
        {
            FrmManage_Customers FRM = new FrmManage_Customers();
            FRM.Show();
            this.Close();
        }

        private void btnITEMS_Click(object sender, EventArgs e)
        {
            FrmManage_Items FRM = new FrmManage_Items();
            FRM.Show();
            this.Close();
        }

        private void btnBILL_Click(object sender, EventArgs e)
        {
            FrmBill FRM = new FrmBill();
            FRM.Show();
            this.Close();
        }

        private void btnSUPPLIERS_Click(object sender, EventArgs e)
        {
            FrmManage_Suppliers FRM = new FrmManage_Suppliers();
            FRM.Show();
            this.Close();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmSale_Management FRM = new FrmSale_Management();
            FRM.Show();
            this.Close();
        }

        private void btnManage_Warehouse_Click(object sender, EventArgs e)
        {
            FrmManage_Warehouse FRM = new FrmManage_Warehouse();
            FRM.Show();
            this.Close();
        }
    }
}
