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
    public partial class FrmForgotPassword : Form
    {
        private string usernameLogin;
        public FrmForgotPassword()
        {
            InitializeComponent();
        }

        // search user
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Nhập email" || txtPhone.Text == "Nhập số điện thoại")
            {
                lbSearchResult.Text = "Vui lòng điền thông tin";
            }
            else
            {
                if (BLL_ACCOUNT.Instance.checkEmailAndPhone(txtEmail.Text.Trim(), txtPhone.Text.Trim()))
                {
                    usernameLogin = BLL_ACCOUNT.Instance.getUsername(txtEmail.Text.Trim(), txtPhone.Text.Trim());
                    lbSearchResult.ForeColor = Color.SteelBlue;
                    lbSearchResult.Text = "Tìm thấy người dùng : " + usernameLogin;
                    txtNewPassword.Enabled = txtReWriteNewPassword.Enabled = btnSave.Enabled = btnCancelChange.Enabled = true;
                }
                else
                {
                    lbSearchResult.ForeColor = Color.IndianRed;
                    lbSearchResult.Text = "Không tìm thấy người dùng";
                    txtEmail.Clear();
                    txtPhone.Clear();
                }
            }
        }

        // save all
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "Nhập mật khẩu mới" || txtReWriteNewPassword.Text == "Nhập lại mật khẩu mới")
            {
                lbWarning.ForeColor = Color.IndianRed;
                lbWarning.Text = "Chưa điền đủ thông tin!";
            }
            else
            {
                if (txtNewPassword.Text.Trim() != txtReWriteNewPassword.Text.Trim())
                {
                    lbWarning.Text = "Mật khẩu nhập lại không khớp!";
                    txtReWriteNewPassword.Clear();
                }
                else
                {
                    BLL_ACCOUNT.Instance.newPassword(usernameLogin, txtNewPassword.Text.Trim());
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        // out
        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ...
        private void txtReWriteNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtReWriteNewPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                txtReWriteNewPassword.ForeColor = Color.IndianRed;
            }
            else
            {
                txtReWriteNewPassword.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Nhập email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Nhập email";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Nhập số điện thoại")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Nhập số điện thoại";
                txtPhone.ForeColor = Color.Silver;
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
    }
}
