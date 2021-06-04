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
    public partial class FrmManage_Suppliers : Form
    {
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        bool isAdd; // add?
        public FrmManage_Suppliers()
        {
            InitializeComponent();
            ShowData();
            setStyleAndHearderText();
            Disable(false);
        }
        public void setStyleAndHearderText()
        {
            // set style
            dgvSUPPLIER.EnableHeadersVisualStyles = false;
            dgvSUPPLIER.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvSUPPLIER.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSUPPLIER.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvSUPPLIER.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // set headerText
            dgvSUPPLIER.Columns[0].HeaderText = "Mã NCC";
            dgvSUPPLIER.Columns[1].HeaderText = "Tên NCC";
            dgvSUPPLIER.Columns[2].HeaderText = "Địa chỉ";
            dgvSUPPLIER.Columns[3].HeaderText = "Email";
            dgvSUPPLIER.Columns[4].HeaderText = "Fax";
            dgvSUPPLIER.Columns[5].HeaderText = "Số điện thoại";
            dgvSUPPLIER.Columns[6].HeaderText = "Mã số thuế";
        }
        // func show data 
        public void ShowData()
        {
            var getListSupplier = DB.tblNhaCungCaps.Select(p => new
            {
                p.MaNhaCungCap,
                p.TenNhaCungCap,
                p.DiaChi,
                p.Email,
                p.Fax,
                p.SoDienThoai,
                p.MaSoThue
            });
            dgvSUPPLIER.DataSource = getListSupplier.ToList();
        }
        // disable
        public void Disable(bool E)
        {
            txtID_SUPPLIER.Enabled = E;
            txtNAME_SUPPLIER.Enabled = E;
            txtPHONE.Enabled = E;
            txtADDRESS.Enabled = E;
            txtEMAIL.Enabled = E;
            txtFAX.Enabled = E;
            txtID_TAX.Enabled = E;
            btnADD.Enabled = !E;
            btnEDIT.Enabled = !E;
            btnBACK.Enabled = !E;
            btnDELETE.Enabled = !E;
            btnSAVE.Enabled = E;
            btnCANCEL.Enabled = E;
        }
        private void dgvSUPPLIER_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvSUPPLIER.DefaultCellStyle.BackColor = Color.OldLace;
            dgvSUPPLIER.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }

        private void dgvSUPPLIER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_SUPPLIER.Text = dgvSUPPLIER.SelectedRows[0].Cells["MaNhaCungCap"].Value.ToString();
            txtNAME_SUPPLIER.Text = dgvSUPPLIER.SelectedRows[0].Cells["TenNhaCungCap"].Value.ToString();
            txtADDRESS.Text = dgvSUPPLIER.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            txtEMAIL.Text = dgvSUPPLIER.SelectedRows[0].Cells["Email"].Value.ToString();
            txtPHONE.Text = dgvSUPPLIER.SelectedRows[0].Cells["SoDienThoai"].Value.ToString();
            txtFAX.Text = dgvSUPPLIER.SelectedRows[0].Cells["Fax"].Value.ToString();
            txtID_TAX.Text = dgvSUPPLIER.SelectedRows[0].Cells["MaSoThue"].Value.ToString();
        }
        // back FrmQuanLyBanHang
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management frm = new FrmSale_Management();
            frm.Show();
            this.Close();
        }
        // search name or id supplier and load form
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            BLL_SUPPLIER.Instance.FuncSearchSupplier(dgvSUPPLIER, txtSEARCH.Text.Trim());
            if(txtSEARCH.Text == "Nhập tên hoặc mã nhà cung cấp")
            {
                ShowData();
            }
        }
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập tên hoặc mã nhà cung cấp")
            {
                txtSEARCH.ForeColor = Color.Black;
                txtSEARCH.Text = "";
            }
        }
        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.ForeColor = Color.Silver;
                txtSEARCH.Text = "Nhập tên hoặc mã nhà cung cấp";
            }
        }
        // export file Excel
        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListSupplier";
            for (int i = 1; i <= dgvSUPPLIER.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvSUPPLIER.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvSUPPLIER.Rows.Count; i++)
            {
                for (int j = 0; j < dgvSUPPLIER.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvSUPPLIER.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "List Supplier";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        // add new supplier
        private void btnADD_Click(object sender, EventArgs e)
        {
            Disable(true);
            isAdd = true;
            txtID_SUPPLIER.Text = BLL_SUPPLIER.Instance.GetNewIdSupplier();
            txtNAME_SUPPLIER.Clear();
            txtPHONE.Clear();
            txtEMAIL.Clear();
            txtFAX.Clear();
            txtADDRESS.Clear();
            txtID_TAX.Clear();
        }
        // edit supplier
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            Disable(true);
            txtID_SUPPLIER.Enabled = false;
            isAdd = false;
        }
        // save change
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblNhaCungCap supplier = new tblNhaCungCap();
            if (string.IsNullOrEmpty(txtNAME_SUPPLIER.Text) || string.IsNullOrEmpty(txtADDRESS.Text) || string.IsNullOrEmpty(txtPHONE.Text) ||
                string.IsNullOrEmpty(txtEMAIL.Text) || string.IsNullOrEmpty(txtFAX.Text) || string.IsNullOrEmpty(txtID_TAX.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disable(true);
            }
            else
            {
                supplier.MaNhaCungCap = txtID_SUPPLIER.Text;
                supplier.TenNhaCungCap = txtNAME_SUPPLIER.Text;
                supplier.DiaChi = txtADDRESS.Text;
                supplier.SoDienThoai = txtPHONE.Text;
                supplier.Email = txtEMAIL.Text;
                supplier.Fax = txtFAX.Text;
                supplier.MaSoThue = Convert.ToInt32(txtID_TAX.Text);
                if (isAdd)
                {
                    try
                    {
                        BLL_SUPPLIER.Instance.FuncAddNewSupplier(supplier); // add new supplier
                        MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Disable(false);
                        ShowData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã số nhà cung cấp bị trùng. Vui lòng nhập mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Disable(true);
                    }
                }
                else
                {
                    BLL_SUPPLIER.Instance.FuncEditSupplier(supplier); // edit staff
                    MessageBox.Show("Sửa nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disable(false);
                    ShowData();
                }
            }
        }
        // delete supplier
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            List<string> listID = new List<String>();
            DataGridViewSelectedRowCollection data = dgvSUPPLIER.SelectedRows;
            foreach(DataGridViewRow dgvRow in data)
            {
                listID.Add(dgvRow.Cells["MaNhaCungCap"].Value.ToString());
            }
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BLL_SUPPLIER.Instance.FuncDeleteSupplier(listID);
                ShowData();
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
            DialogResult result = MessageBox.Show("Bạn chắc chắn quay lại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FrmManage_Data frm = new FrmManage_Data();
                frm.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }
        // KeyPress Event
        private void txtFAX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
