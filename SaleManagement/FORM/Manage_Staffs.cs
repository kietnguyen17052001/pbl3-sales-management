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
    public partial class FrmManage_Staffs : Form
    {
        private bool isAdd; // Kiểm tra xem thực hiện chức năng ADD hay EDIT
        private string usernamelogin;
        public FrmManage_Staffs(string _usernamelogin)
        {
            InitializeComponent();
            usernamelogin = _usernamelogin;
            setCombobox();    
            Disable(false);
            ShowStaff();
            FormatColumnsHeader();
        }
        // Format columns hearder
        public void FormatColumnsHeader()
        {
            // Set style for ColumnHeader
            dgvLIST_STAFF.EnableHeadersVisualStyles = false;
            dgvLIST_STAFF.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvLIST_STAFF.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLIST_STAFF.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvLIST_STAFF.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // Set HearderText
            dgvLIST_STAFF.Columns[0].HeaderText = "Mã n.viên";
            dgvLIST_STAFF.Columns[1].HeaderText = "Tên n.viên";
            dgvLIST_STAFF.Columns[2].HeaderText = "Vị trí";
            dgvLIST_STAFF.Columns[3].HeaderText = "Ngày sinh";
            dgvLIST_STAFF.Columns[4].HeaderText = "Giới tính";
            dgvLIST_STAFF.Columns[5].HeaderText = "SĐT";
            dgvLIST_STAFF.Columns[6].HeaderText = "Địa chỉ";
            dgvLIST_STAFF.Columns[7].HeaderText = "Lương";
            dgvLIST_STAFF.Columns[8].HeaderText = "Mật Khẩu";
        }
        void Disable(bool E)
        {
            txtNAME_STAFF.Enabled = E;
            txtID_STAFF.Enabled = E;
            cbbPOSITION.Enabled = E;
            dpDAY.Enabled = E;
            txtPHONE.Enabled = E;
            txtADDRESS.Enabled = E;
            txtSALARY.Enabled = E;
            gbGENDER.Enabled = E;
            txtPASSWORD.Enabled = E;
            btnADD.Enabled = !E;
            btnEDIT.Enabled = !E;
            btnBACK.Enabled = !E;
            btnDELETE.Enabled = !E;
            btnSAVE.Enabled = E;
            btnCANCEL.Enabled = E;
        }
        public void setCombobox()
        {
            cbbPOSITION_DETAIL.Items.Add("Tất cả");
            cbbPOSITION_DETAIL.Items.AddRange(BLL_STAFF.Instance.getListPosition().Distinct().ToArray());
            cbbPOSITION.Items.Add("None");
            cbbPOSITION.Items.AddRange(BLL_STAFF.Instance.getListPosition().Distinct().ToArray());
            cbbPOSITION_DETAIL.SelectedIndex = cbbPOSITION.SelectedIndex = 0;
        }
        // show data staff
        public void ShowStaff()
        {
            int index = cbbPOSITION_DETAIL.SelectedIndex;
            string position = cbbPOSITION_DETAIL.SelectedItem.ToString();
            BLL_STAFF.Instance.LoadDataStaff(dgvLIST_STAFF, index, position);
            txtID_STAFF.Clear();
            txtNAME_STAFF.Clear();
            txtPHONE.Clear();
            txtADDRESS.Clear();
            txtSALARY.Clear();
            txtPASSWORD.Clear();
            cbbPOSITION.SelectedIndex = 0;
            lbQuantity.Text = BLL_STAFF.Instance.getQuantityStaff(dgvLIST_STAFF).ToString();
        }
        // dgv
        private void dgvLIST_STAFF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_STAFF.Text = dgvLIST_STAFF.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();
            txtNAME_STAFF.Text = dgvLIST_STAFF.SelectedRows[0].Cells["TenNhanVien"].Value.ToString();
            cbbPOSITION.Text = dgvLIST_STAFF.SelectedRows[0].Cells["ViTri"].Value.ToString();
            dpDAY.Value = (DateTime)dgvLIST_STAFF.SelectedRows[0].Cells["NgaySinh"].Value;
            txtPHONE.Text = dgvLIST_STAFF.SelectedRows[0].Cells["SoDienThoai"].Value.ToString();
            txtADDRESS.Text = dgvLIST_STAFF.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            txtSALARY.Text = String.Format("{0:n0}", dgvLIST_STAFF.SelectedRows[0].Cells["Luong"].Value);
            txtPASSWORD.Text = dgvLIST_STAFF.SelectedRows[0].Cells["MatKhau"].Value.ToString();
            if (Convert.ToBoolean(dgvLIST_STAFF.SelectedRows[0].Cells["GioiTinh"].Value.ToString()) == true)
            {
                rbMALE.Checked = true;
            }
            else
            {
                rbFEMALE.Checked = true;
            }
        }
        // Set backgroundColor for row in dgvListStaff
        private void dgvLIST_STAFF_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvLIST_STAFF.DefaultCellStyle.BackColor = Color.OldLace;
            dgvLIST_STAFF.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        // back to FrmQuanLyBanHang
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmMain_Admin frm = new FrmMain_Admin();
            frm.Show();
            this.Close();
        }
        // show staff
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            ShowStaff();
        }
        // export file Excel
        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListStaff";
            for (int i = 1; i <= dgvLIST_STAFF.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvLIST_STAFF.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvLIST_STAFF.Rows.Count; i++)
            {
                for (int j = 0; j < dgvLIST_STAFF.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLIST_STAFF.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "List Staff";
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
            isAdd = true;
            txtID_STAFF.Text = BLL_STAFF.Instance.getNewIdStaff().ToString();
            txtNAME_STAFF.Clear();
            txtPHONE.Clear();
            rbMALE.Checked = true;
            txtADDRESS.Clear();
            txtSALARY.Clear();
        }
        // edit staff
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            Disable(true);
            txtID_STAFF.Enabled = false;
            isAdd = false;
        }
        // save change
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblTaiKhoan account = new tblTaiKhoan();
            account.ChucVu = "Member";
            tblNhanVien staff = new tblNhanVien();
            account.MaNguoiDung = staff.MaNhanVien = txtID_STAFF.Text;
            staff.TenNhanVien = txtNAME_STAFF.Text;
            staff.ViTri = cbbPOSITION.SelectedItem.ToString();
            staff.NgaySinh = Convert.ToDateTime(dpDAY.Value.ToShortDateString());
            if(rbMALE.Checked == true)
            {
                staff.GioiTinh = true;
            }
            else
            {
                staff.GioiTinh = false;
            }
            staff.SoDienThoai = txtPHONE.Text;
            staff.DiaChi = txtADDRESS.Text;
            staff.Luong = Convert.ToDouble(txtSALARY.Text);
            account.MatKhau = staff.MatKhau = txtPASSWORD.Text;
            if(string.IsNullOrEmpty(staff.MaNhanVien) || string.IsNullOrEmpty(staff.TenNhanVien) || string.IsNullOrEmpty(staff.SoDienThoai) || 
                string.IsNullOrEmpty(staff.DiaChi) || string.IsNullOrEmpty(staff.Luong.ToString()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disable(true);
            }
            else
            {
                if (isAdd)
                {
                    try
                    {
                        BLL_STAFF.Instance.FuncAddNewStaff(staff); // add new staff
                        BLL_ACCOUNT.Instance.FuncAddAccount(account); // add new account for staff
                        MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Disable(false);
                        ShowStaff();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã số nhân viên bị trùng. Vui lòng nhập mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Disable(true);
                    }
                }
                else
                {
                    BLL_STAFF.Instance.FuncEditStaff(staff); // edit staff
                    BLL_ACCOUNT.Instance.FuncEditPassword(account); // edit password
                    MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disable(false);
                    ShowStaff();
                }
                
            } 
        }
        // delete staff
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            List<string> listIdStaff = new List<string>();
            DataGridViewSelectedRowCollection data = dgvLIST_STAFF.SelectedRows;
            foreach(DataGridViewRow dataGvr in data)
            {
                listIdStaff.Add(dataGvr.Cells["MaNhanVien"].Value.ToString());
            }
            DialogResult question = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                BLL_STAFF.Instance.FuncDeleteStaff(listIdStaff); // delete staff
                ShowStaff();
            }
        }
        // search staff
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            BLL_STAFF.Instance.FuncSearchStaff(dgvLIST_STAFF, txtSEARCH.Text.Trim());
            lbQuantity.Text = BLL_STAFF.Instance.getQuantityStaff(dgvLIST_STAFF).ToString();
        }
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập mã hoặc tên nhân viên")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Black;
            }
        }
        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.Text = "Nhập mã hoặc tên nhân viên";
                txtSEARCH.ForeColor = Color.Silver;
            }
        }
        // cancel
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Disable(false);
        }
        // back to FrmQuanLyDuLieu
        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmManage_Data frm = new FrmManage_Data(usernamelogin);
            frm.Show();
            this.Hide();
        }
        // KeyPress Event
        private void txtPHONE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
