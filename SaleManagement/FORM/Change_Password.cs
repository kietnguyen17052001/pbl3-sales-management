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
        public FrmChange_Password(string _usernameLogin = null)
        {
            InitializeComponent();
            usernameLogin = _usernameLogin;
        }

        private void txtOldPassword_Enter(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "Nhập mật khẩu cũ")
            {
                txtOldPassword.Text = "";
                txtOldPassword.PasswordChar = '•';
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
                txtNewPassword.PasswordChar = '•';
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
                txtReWriteNewPassword.PasswordChar = '•';
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

        private void txtReWriteNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtReWriteNewPassword.Text != txtNewPassword.Text)
            {
                txtReWriteNewPassword.ForeColor = Color.IndianRed;
            }
            else
            {
                txtReWriteNewPassword.ForeColor = Color.Black;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "Nhập mật khẩu cũ" || txtNewPassword.Text == "Nhập mật khẩu mới"
                || txtReWriteNewPassword.Text == "Nhập lại mật khẩu mới")
            {
                lbWarning.Text = "Thông tin nhập chưa đầy đủ!";
            }
            else if (txtReWriteNewPassword.Text != txtNewPassword.Text)
            {
                lbWarning.Text = "Mật khẩu nhập lại không khớp!";
                txtReWriteNewPassword.Clear();
            }
            else
            {
                // valid old password ?
                if (BLL_ACCOUNT.Instance.isValidOldPassword(usernameLogin, txtOldPassword.Text.Trim()))
                {
                    if (txtNewPassword.Text.Trim() == txtOldPassword.Text.Trim())
                    {
                        lbWarning.Text = "Mật khẩu mới không được trùng với mật khẩu cũ!";
                        txtNewPassword.Text = "Nhập mật khẩu mới";
                        txtReWriteNewPassword.Text = "Nhập lại mật khẩu mới";
                        txtNewPassword.ForeColor = txtReWriteNewPassword.ForeColor = Color.Silver;
                        txtNewPassword.PasswordChar = txtReWriteNewPassword.PasswordChar = '\0';
                    }
                    else
                    {
                        BLL_ACCOUNT.Instance.newPassword(usernameLogin, txtNewPassword.Text.Trim());
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    lbWarning.Text = "Mật khẩu cũ không đúng!";
                    txtOldPassword.Clear();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
