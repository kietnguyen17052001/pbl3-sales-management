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
        private bool isAdmin;
        public FrmChange_Password(bool _isAdmin, string _usernameLogin = null)
        {
            InitializeComponent();
            usernameLogin = _usernameLogin;
            isAdmin = _isAdmin;
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
            if(txtReWriteNewPassword.Text != txtNewPassword.Text)
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
            if(txtOldPassword.Text == "Nhập mật khẩu cũ")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!","Lỗi nhập mật khẩu",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(txtNewPassword.Text == "Nhập mật khẩu mới")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Lỗi nhập mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtReWriteNewPassword.Text == "Nhập lại mật khẩu mới")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới!", "Lỗi nhập mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtReWriteNewPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi nhập mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReWriteNewPassword.Clear();
            }
            else
            {
                bool flag = BLL_ACCOUNT.Instance.ChangePasswordUser(isAdmin, usernameLogin, txtOldPassword.Text.Trim(), txtNewPassword.Text.Trim());
                if (flag)
                {
                    if (txtNewPassword.Text == txtOldPassword.Text)
                    {
                        MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!", "Lỗi nhập mật khẩu mới", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNewPassword.Clear();
                        txtReWriteNewPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi nhập mật khẩu cũ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
