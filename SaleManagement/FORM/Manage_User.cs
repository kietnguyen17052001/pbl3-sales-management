using SaleManagement.BLL;
using SaleManagement.Entity;
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
    public partial class FrmManage_User : Form
    {
        private bool isAdd; // Kiểm tra xem thực hiện chức năng ADD hay EDIT
        private string usernameLogin;
        public FrmManage_User(string _usernameLogin)
        {
            InitializeComponent();
            usernameLogin = _usernameLogin;
            LoadData();
            setCbbRole();
            FormatColumnsHeader();
        }
        // Format columns hearder
        public void FormatColumnsHeader()
        {
            // Set style for ColumnHeader
            dgvLIST_USER.EnableHeadersVisualStyles = false;
            dgvLIST_USER.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvLIST_USER.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLIST_USER.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvLIST_USER.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // Set HearderText
            dgvLIST_USER.Columns[0].HeaderText = "Mã n.dùng";
            dgvLIST_USER.Columns[1].HeaderText = "Tên n.dùng";
            dgvLIST_USER.Columns[2].HeaderText = "Chức vụ";
            dgvLIST_USER.Columns[3].HeaderText = "Ngày sinh";
            dgvLIST_USER.Columns[4].HeaderText = "Giới tính";
            dgvLIST_USER.Columns[5].HeaderText = "Email";
            dgvLIST_USER.Columns[6].HeaderText = "SĐT";
            dgvLIST_USER.Columns[7].HeaderText = "Địa chỉ";
            dgvLIST_USER.Columns[8].HeaderText = "Lương";
        }
        void Disable(bool E)
        {
            txtNameUser.Enabled = E;
            cbbRole.Enabled = E;
            dpDAY.Enabled = E;
            txtEmail.Enabled = E;
            txtPHONE.Enabled = E;
            txtADDRESS.Enabled = E;
            txtSALARY.Enabled = E;
            gbGENDER.Enabled = E;
            btnADD.Enabled = !E;
            btnEDIT.Enabled = !E;
            btnBACK.Enabled = !E;
            btnDELETE.Enabled = !E;
            btnSAVE.Enabled = E;
            btnCANCEL.Enabled = E;
            dgvLIST_USER.Enabled = !E;
        }
        public void ClearCode()
        {
            txtIdUser.Clear();
            txtNameUser.Clear();
            txtEmail.Clear();
            txtPHONE.Clear();
            txtADDRESS.Clear();
            txtSALARY.Clear();
        }
        public void setCbbRole()
        {
            cbbRole.Items.AddRange(BLL_USER.Instance.listRole().ToArray());
        }
        // show data staff
        public void LoadData()
        {
            Disable(false);
            ClearCode();
            BLL_USER.Instance.LoadDataUser(dgvLIST_USER);
            lbQuantity.Text = BLL_USER.Instance.getQuantityUser(dgvLIST_USER).ToString();
        }
        // dgv
        private void dgvLIST_USER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUser.Text = dgvLIST_USER.SelectedRows[0].Cells["MaNguoiDung"].Value.ToString();
            txtNameUser.Text = dgvLIST_USER.SelectedRows[0].Cells["TenNguoiDung"].Value.ToString();
            cbbRole.Text = dgvLIST_USER.SelectedRows[0].Cells["ChucVu"].Value.ToString();
            dpDAY.Value = (DateTime)dgvLIST_USER.SelectedRows[0].Cells["NgaySinh"].Value;
            txtEmail.Text = dgvLIST_USER.SelectedRows[0].Cells["Email"].Value.ToString();
            txtPHONE.Text = dgvLIST_USER.SelectedRows[0].Cells["SoDienThoai"].Value.ToString();
            txtADDRESS.Text = dgvLIST_USER.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            txtSALARY.Text = String.Format("{0:n0}", dgvLIST_USER.SelectedRows[0].Cells["Luong"].Value);
            if (Convert.ToBoolean(dgvLIST_USER.SelectedRows[0].Cells["GioiTinh"].Value.ToString()) == true)
            {
                rbMALE.Checked = true;
            }
            else
            {
                rbFEMALE.Checked = true;
            }
        }
        // Set backgroundColor for row in dgvListStaff
        private void dgvLIST_USER_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvLIST_USER.DefaultCellStyle.BackColor = Color.OldLace;
            dgvLIST_USER.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        // back to FrmQuanLyBanHang
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmMain_Admin frmMainAdmin = new FrmMain_Admin(usernameLogin);
            frmMainAdmin.Show();
            this.Close();
        }
        // export file Excel
        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListUser";
            for (int i = 1; i <= dgvLIST_USER.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvLIST_USER.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvLIST_USER.Rows.Count; i++)
            {
                for (int j = 0; j < dgvLIST_USER.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLIST_USER.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "List User";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        // add new staff
        private void btnADD_Click(object sender, EventArgs e)
        {
            Disable(true);
            ClearCode();
            isAdd = true;
            cbbRole.SelectedIndex = 0;
            txtIdUser.Text = BLL_USER.Instance.getNewIdUser(cbbRole.SelectedItem.ToString());
            rbMALE.Checked = true;
            txtSALARY.Text = "0";
        }
        // edit staff
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIdUser.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Disable(true);
                txtIdUser.Enabled = false;
                isAdd = false;
            }
        }
        private string messageError = "";
        // save change
        private void btnSAVE_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtIdUser.Text.Trim()) || String.IsNullOrEmpty(txtNameUser.Text.Trim())
                || String.IsNullOrEmpty(txtEmail.Text.Trim()) || String.IsNullOrEmpty(txtPHONE.Text.Trim()))
            {
                MessageBox.Show("Mã, tên, email, SĐT người dùng phải được nhập!", "Lỗi thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BLL_USER.Instance.checkEmail(txtEmail.Text.Trim()) && BLL_USER.Instance.checkPhone(txtPHONE.Text.Trim()))
                {
                    tblNguoiDung user = new tblNguoiDung();
                    user.MaNguoiDung = txtIdUser.Text.Trim();
                    user.TenNguoiDung = txtNameUser.Text.Trim();
                    user.MatKhau = BLL_ACCOUNT.Instance.encryptPassword(txtIdUser.Text.Trim());
                    user.ChucVu = cbbRole.SelectedItem.ToString();
                    user.NgaySinh = Convert.ToDateTime(dpDAY.Value.ToShortDateString());
                    user.Email = txtEmail.Text.Trim();
                    user.SoDienThoai = txtPHONE.Text.Trim();
                    user.DiaChi = txtADDRESS.Text.Trim();
                    user.Luong = Convert.ToDouble(txtSALARY.Text);
                    user.GioiTinh = rbMALE.Checked;
                    if (isAdd)
                    {
                        BLL_USER.Instance.FuncAddNewUser(user); // add new user
                        MessageBox.Show("Thêm người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        BLL_USER.Instance.FuncEditUser(user); // edit user
                        MessageBox.Show("Sửa người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                else
                {
                    if (!BLL_USER.Instance.checkPhone(txtPHONE.Text.Trim()) && !BLL_USER.Instance.checkEmail(txtEmail.Text.Trim()))
                    {
                        messageError += "Email và số điện thoại đã được đăng kí!";
                    }
                    else if (!BLL_USER.Instance.checkPhone(txtPHONE.Text.Trim()))
                    {
                        messageError = "Số điện thoại đã được đăng ký!";
                    }
                    else if (!BLL_USER.Instance.checkEmail(txtEmail.Text.Trim()))
                    {
                        messageError = "Email đã được đăng ký!";
                    }
                    MessageBox.Show(messageError, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // delete staff
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIdUser.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<string> listIdUser = new List<string>();
                DataGridViewSelectedRowCollection data = dgvLIST_USER.SelectedRows;
                foreach (DataGridViewRow dataGvr in data)
                {
                    listIdUser.Add(dataGvr.Cells["MaNguoiDung"].Value.ToString());
                }
                DialogResult question = MessageBox.Show("Bạn chắc chắn muốn xóa người dùng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    BLL_USER.Instance.FuncDeleteUser(listIdUser); // delete staff
                    LoadData();
                }
            }
        }
        // search staff
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            BLL_USER.Instance.FuncSearchUser(dgvLIST_USER, txtSEARCH.Text.Trim());
            lbQuantity.Text = BLL_USER.Instance.getQuantityUser(dgvLIST_USER).ToString();
        }
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập mã hoặc tên")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Black;
            }
        }
        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.Text = "Nhập mã hoặc tên";
                txtSEARCH.ForeColor = Color.Silver;
            }
        }
        // cancel
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Disable(false);
            ClearCode();
        }
        // back to FrmQuanLyDuLieu
        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmManage_Data frmManageData = new FrmManage_Data(usernameLogin);
            frmManageData.Show();
            this.Close();
        }
        // KeyPress Event
        private void txtPHONE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtSALARY_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSALARY.Text))
            {
                txtSALARY.Text = "0";
            }
        }

        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnADD.Enabled == false)
            {
                txtIdUser.Text = BLL_USER.Instance.getNewIdUser(cbbRole.SelectedItem.ToString());
            }
        }
    }
}
