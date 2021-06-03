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
        private string usernameLogin;
        public FrmSale_Management(string name = null)
        {
            InitializeComponent();
            usernameLogin = name;
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
        
        public void SetStaff()
        {
            this.btnBaoCao.Enabled = false;
            this.btnDoiMatKhau.Enabled = false;
            this.btnThongKe.Enabled = false;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmChange_Password frm = new FrmChange_Password(usernameLogin);
            frm.Show();
        }
    }
}
