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
    public partial class FrmMain_Admin : Form
    {
        private string usernameLogin;
        public FrmMain_Admin(string _usernameLogin = null)
        {
            InitializeComponent();
            usernameLogin = _usernameLogin;
            lbWelcome.Text += " " + _usernameLogin;
            lbDate.Text += " " + DateTime.Now.ToString("dddd, dd/MM/yyyy");
        }

        private void btnManage_Data_Click(object sender, EventArgs e)
        {
            FrmManage_Data frmManageData = new FrmManage_Data(usernameLogin);
            frmManageData.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(usernameLogin);
            frmLogin.Show();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport(usernameLogin);
            frmReport.Show();
            this.Close();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            FrmStatistic frmStatistic = new FrmStatistic(usernameLogin);
            frmStatistic.Show();
            this.Close();
        }

        private void btnIntroduce_Click(object sender, EventArgs e)
        {
            FrmIntroduce frmIntroduce = new FrmIntroduce(usernameLogin);
            frmIntroduce.Show();
            this.Close();
        }
        private void btnChange_Password_Click(object sender, EventArgs e)
        {
            FrmChange_Password frmChangePassword = new FrmChange_Password(true, usernameLogin);
            frmChangePassword.Show();
        }
    }
}
