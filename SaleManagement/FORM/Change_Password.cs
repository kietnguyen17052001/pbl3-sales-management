using SaleManagement.BLL;
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
    public partial class FrmChange_Password : Form
    {
        private string usernameLogin;
        public FrmChange_Password(string name = null)
        {
            InitializeComponent();
            usernameLogin = name;
        }

        private void txtOldPassword_Enter(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "Nhập mật khẩu cũ")
            {
                txtOldPassword.Text = "";
                txtOldPassword.PasswordChar = '*';
                txtOldPassword.ForeColor = Color.Black;
            }
        }

        private void txtOldPassword_Leave(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "")
            {
                txtOldPassword.PasswordChar = '\0';
                txtOldPassword.Text = "Nhập mật khẩu cũ";
                txtOldPassword.ForeColor = Color.Silver;
            }
        }

        private void txtNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "Nhập mật khẩu mới")
            {
                txtNewPassword.Text = "";
                txtNewPassword.PasswordChar = '*';
                txtNewPassword.ForeColor = Color.Black;
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                txtNewPassword.PasswordChar = '\0';
                txtNewPassword.Text = "Nhập mật khẩu mới";
                txtNewPassword.ForeColor = Color.Silver;
            }
        }

        private void txtReWriteNewPassword_Enter(object sender, EventArgs e)
        {
            if (txtReWriteNewPassword.Text == "Nhập lại mật khẩu mới")
            {
                txtReWriteNewPassword.Text = "";
                txtReWriteNewPassword.PasswordChar = '*';
                txtReWriteNewPassword.ForeColor = Color.Black;
            }
        }

        private void txtReWriteNewPassword_Leave(object sender, EventArgs e)
        {
            if (txtReWriteNewPassword.Text == "")
            {
                txtReWriteNewPassword.PasswordChar = '\0';
                txtReWriteNewPassword.Text = "Nhập lại mật khẩu mới";
                txtReWriteNewPassword.ForeColor = Color.Silver;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtNewPassword.Text != txtReWriteNewPassword.Text)
            {
                lbWarning.ForeColor = Color.IndianRed;
                lbWarning.Text = "Mật khẩu nhập lại không khớp!";
            }
            else
            {
                bool flag = BLL_CHANGEPASSWORD.Instance.ChangePassword(usernameLogin, 
                                                                           txtOldPassword.Text, 
                                                                           txtNewPassword.Text);
                if(flag)
                {
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
