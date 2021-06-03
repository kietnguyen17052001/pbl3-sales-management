using SaleManagement.FORM;
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

namespace SaleManagement
{
    public partial class FrmSale_Management : Form
    {
        public FrmSale_Management()
        {
            InitializeComponent();
        }

        private void btnQuanLyDuLieu_Click(object sender, EventArgs e)
        {
            FrmManage_Data frm = new FrmManage_Data();
            frm.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmReport frm = new FrmReport();
            frm.Show();
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmStatistic frm = new FrmStatistic();
            frm.Show();
            this.Close();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            FrmIntroduce frm = new FrmIntroduce();
            frm.Show();
            this.Close();
        }
    }
}
