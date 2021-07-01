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
    public partial class FrmManage_Customers : Form
    {
        private bool isAdd; // true: add new customer, false: edit customer
        private string usernamelogin;
        public FrmManage_Customers(string _usernamelogin)
        {
            InitializeComponent();
            usernamelogin = _usernamelogin;
            LoadData();
            FormatColumnHeader();
        }
        // Format column header
        public void FormatColumnHeader()
        {
            // Set style for ColumnHeader
            dgvLISTCUSTOMER.EnableHeadersVisualStyles = false;
            dgvLISTCUSTOMER.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvLISTCUSTOMER.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLISTCUSTOMER.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvLISTCUSTOMER.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // Set HearderText
            dgvLISTCUSTOMER.Columns[0].HeaderText = "Mã k.hàng";
            dgvLISTCUSTOMER.Columns[1].HeaderText = "Tên k.hàng";
            dgvLISTCUSTOMER.Columns[2].HeaderText = "Giới tính";
            dgvLISTCUSTOMER.Columns[3].HeaderText = "SĐT";
            dgvLISTCUSTOMER.Columns[4].HeaderText = "Địa chỉ";
        }
        // Disable button, textbox
        public void Disable(bool E)
        {
            txtNAME_CUSTOMER.Enabled = E;
            txtID_CUSTOMER.Enabled = E;
            txtPHONE.Enabled = E;
            txtADDRESS.Enabled = E;
            gbGENDER.Enabled = E;
            btnADD.Enabled = !E;
            btnEDIT.Enabled = !E;
            btnBACK.Enabled = !E;
            btnDELETE.Enabled = !E;
            btnSAVE.Enabled = E;
            btnCANCEL.Enabled = E;
        }
        public void ClearCode()
        {
            txtID_CUSTOMER.Clear();
            txtNAME_CUSTOMER.Clear();
            txtPHONE.Clear();
            txtADDRESS.Clear();
        }
        // func show customers
        public void LoadData()
        {
            Disable(false);
            ClearCode();
            BLL_CUSTOMER.Instance.LoadData(dgvLISTCUSTOMER);
            lbQuantity.Text = BLL_CUSTOMER.Instance.getQuantityCustomer(dgvLISTCUSTOMER).ToString();
        }
        // Set backColor for row in dgvListCustomer
        private void dgvLISTCUSTOMER_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvLISTCUSTOMER.DefaultCellStyle.BackColor = Color.OldLace;
            dgvLISTCUSTOMER.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        // Đổ dữ liêu từ row vào các txt
        private void dgvLISTCUSTOMER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_CUSTOMER.Text = dgvLISTCUSTOMER.SelectedRows[0].Cells["MaKhachHang"].Value.ToString();
            txtNAME_CUSTOMER.Text = dgvLISTCUSTOMER.SelectedRows[0].Cells["TenKhachHang"].Value.ToString();
            txtPHONE.Text = dgvLISTCUSTOMER.SelectedRows[0].Cells["SoDienThoai"].Value.ToString();
            txtADDRESS.Text = dgvLISTCUSTOMER.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            if (Convert.ToBoolean(dgvLISTCUSTOMER.SelectedRows[0].Cells["GioiTinh"].Value) == true)
            {
                rbMALE.Checked = true;
            }
            else
            {
                rbFEMALE.Checked = true;
            }
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmMain_Admin frmMainAdmin = new FrmMain_Admin(usernamelogin);
            frmMainAdmin.Show();
            this.Close();
        }
        // Button show customes
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        // Export file Excel
        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListCustomer";
            for (int i = 1; i <= dgvLISTCUSTOMER.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvLISTCUSTOMER.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvLISTCUSTOMER.Rows.Count; i++)
            {
                for (int j = 0; j < dgvLISTCUSTOMER.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLISTCUSTOMER.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "List Customer";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        // Button Add customer
        private void btnADD_Click(object sender, EventArgs e)
        {
            Disable(true);
            ClearCode();
            isAdd = true; // thêm
            txtID_CUSTOMER.Text = BLL_CUSTOMER.Instance.getNewIdCustomer().ToString(); // gọi hàm tự điền mã số khách hàng từ BLL_CUSTOMER
        }
        // Button Edit customer
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_CUSTOMER.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Disable(true);
                txtID_CUSTOMER.Enabled = false;
                isAdd = false; // sửa
            }
        }
        // Button Save changes
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblKhachHang customer = new tblKhachHang();
            customer.MaKhachHang = txtID_CUSTOMER.Text.Trim();
            customer.TenKhachHang = txtNAME_CUSTOMER.Text.Trim();
            customer.SoDienThoai = txtPHONE.Text.Trim();
            customer.DiaChi = txtADDRESS.Text.Trim();
            customer.GioiTinh = rbMALE.Checked;
            if (String.IsNullOrEmpty(customer.MaKhachHang) && !String.IsNullOrEmpty(customer.TenKhachHang))
            {
                MessageBox.Show("Mã khách hàng trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable(true);
            }
            else if (!String.IsNullOrEmpty(customer.MaKhachHang) && String.IsNullOrEmpty(customer.TenKhachHang))
            {
                MessageBox.Show("Tên khách hàng trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable(true);
            }
            else if (String.IsNullOrEmpty(customer.MaKhachHang) && String.IsNullOrEmpty(customer.TenKhachHang))
            {
                MessageBox.Show("Mã và tên khách hàng trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable(true);
            }
            else
            {
                if (isAdd)
                {
                    try
                    {
                        BLL_CUSTOMER.Instance.FuncAddNewCustomer(customer); // add new customer 
                        MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã số khách hàng đã tồn tại", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Disable(true);
                    }
                }
                else
                {
                    BLL_CUSTOMER.Instance.FuncEditCustomer(customer); // edit customer
                    MessageBox.Show("Sửa khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }
        // Delete customer
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_CUSTOMER.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<string> listIdCustomer = new List<string>();
                DataGridViewSelectedRowCollection data = dgvLISTCUSTOMER.SelectedRows;
                foreach (DataGridViewRow dataGvr in data)
                {
                    listIdCustomer.Add(dataGvr.Cells["MaKhachHang"].Value.ToString());
                }
                DialogResult question = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    BLL_CUSTOMER.Instance.FuncDeleteCustomer(listIdCustomer); // delete customer
                    LoadData();
                }
            }
        }
        // Cancel
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Disable(false);
            ClearCode();
        }
        // Back to frmQuanLyDuLieu
        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmManage_Data frmManageData = new FrmManage_Data(usernamelogin);
            frmManageData.Show();
            this.Close();
        }
        // search customer
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            BLL_CUSTOMER.Instance.FuncSearchCustomer(dgvLISTCUSTOMER, txtSEARCH.Text.Trim());
            lbQuantity.Text = BLL_CUSTOMER.Instance.getQuantityCustomer(dgvLISTCUSTOMER).ToString();
        }
        // input information
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập mã hoặc tên khách hàng")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Black;
            }
        }

        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.Text = "Nhập mã hoặc tên khách hàng";
                txtSEARCH.ForeColor = Color.Silver;
            }
        }
        // KeyPress Event
        private void txtPHONE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
