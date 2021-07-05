using SaleManagement.BLL;
using SaleManagement.Entity;
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

namespace SaleManagement.FORM
{
    public partial class FrmManage_TypeOfProduct : Form
    {
        private bool isAdd; // true: add, false: edit customer
        private string usernamelogin;
        public FrmManage_TypeOfProduct(string _usernamelogin)
        {
            InitializeComponent();
            usernamelogin = _usernamelogin;
            ShowDataTypeOfProduct();
            FormatColumnHeader();
        }
        public void FormatColumnHeader()
        {
            // Set style for ColumnHeader 
            dgvLISTTYPE.EnableHeadersVisualStyles = false;
            dgvLISTTYPE.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvLISTTYPE.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLISTTYPE.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvLISTTYPE.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // Set HeaderText
            dgvLISTTYPE.Columns[0].HeaderText = "Mã loại h.hóa";
            dgvLISTTYPE.Columns[1].HeaderText = "Tên loại h.hóa";
        }
        public void ClearCode()
        {
            txtID_TYPEPRODUCT.Clear();
            txtNAME_TYPEPRODUCT.Clear();
        }
        public void Disable(bool E)
        {
            txtID_TYPEPRODUCT.Enabled = E;
            txtNAME_TYPEPRODUCT.Enabled = E;
            btnSAVE.Enabled = E;
            btnCANCEL.Enabled = E;
            btnADD.Enabled = btnEDIT.Enabled = btnDELETE.Enabled = !E;
        }
        // func show type of product
        public void ShowDataTypeOfProduct()
        {
            Disable(false);
            ClearCode();
            BLL_TYPEOFPRODUCT.Instance.LoadDataTypeOfProduct(dgvLISTTYPE);
        }
        // click
        private void dgvLISTTYPE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_TYPEPRODUCT.Text = dgvLISTTYPE.SelectedRows[0].Cells["MaLoaiHangHoa"].Value.ToString();
            txtNAME_TYPEPRODUCT.Text = dgvLISTTYPE.SelectedRows[0].Cells["TenLoaiHangHoa"].Value.ToString();
        }
        // set BackColor and Font for DGV
        private void dgvLISTTYPE_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvLISTTYPE.DefaultCellStyle.BackColor = Color.OldLace;
            dgvLISTTYPE.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        // Button home -> back to frmQuanLyBanHang
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmMain_Admin frmMainAdmin = new FrmMain_Admin(usernamelogin);
            frmMainAdmin.Show();
            this.Close();
        }
        // Button show list type of product
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            ShowDataTypeOfProduct();
        }
        // export file excel
        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListTypeOfProduct";
            for(int i = 1; i <= dgvLISTTYPE.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvLISTTYPE.Columns[i - 1].HeaderText;
            }
            for(int i = 0; i < dgvLISTTYPE.Rows.Count; i++)
            {
                for(int j = 0; j < dgvLISTTYPE.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLISTTYPE.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "List Type of Product";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        // add type
        private void btnADD_Click(object sender, EventArgs e)
        {
            isAdd = true;
            Disable(true);
            ClearCode();
        }
        // edit type 
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_TYPEPRODUCT.Text))
            {
                MessageBox.Show("Vui lòng chọn loại hàng hóa muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Disable(true);
                txtID_TYPEPRODUCT.Enabled = false;
                isAdd = false;
            }
        }
        // save 
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblLoaiHangHoa typeOfProduct = new tblLoaiHangHoa();
            typeOfProduct.MaLoaiHangHoa = txtID_TYPEPRODUCT.Text.Trim();
            typeOfProduct.TenLoaiHangHoa = txtNAME_TYPEPRODUCT.Text.Trim();
            if (String.IsNullOrEmpty(typeOfProduct.MaLoaiHangHoa) && !String.IsNullOrEmpty(typeOfProduct.TenLoaiHangHoa))
            {
                MessageBox.Show("Mã loại hàng hóa trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable(true);
            }
            else if (!String.IsNullOrEmpty(typeOfProduct.MaLoaiHangHoa) && String.IsNullOrEmpty(typeOfProduct.TenLoaiHangHoa))
            {
                MessageBox.Show("Tên loại hàng hóa trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable(true);
            }
            else if (String.IsNullOrEmpty(typeOfProduct.MaLoaiHangHoa) && String.IsNullOrEmpty(typeOfProduct.TenLoaiHangHoa))
            {
                MessageBox.Show("Mã và tên loại hàng hóa trống!", "Lỗi nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable(true);
            }
            else
            {
                if (isAdd)
                {
                    try
                    {
                        BLL_TYPEOFPRODUCT.Instance.FuncAddNewProduct(typeOfProduct);
                        MessageBox.Show("Thêm loại hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowDataTypeOfProduct();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã loại hàng hóa đã tồn tại", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    BLL_TYPEOFPRODUCT.Instance.FuncAddNewProduct(typeOfProduct);
                    MessageBox.Show("Sửa loại hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowDataTypeOfProduct();
                }
            }
        }
        // delete type of product
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_TYPEPRODUCT.Text))
            {
                MessageBox.Show("Vui lòng chọn loại hàng hóa muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<string> listIdType = new List<string>();
                DataGridViewSelectedRowCollection data = dgvLISTTYPE.SelectedRows;
                foreach (DataGridViewRow dgvRow in data)
                {
                    listIdType.Add(dgvRow.Cells["MaLoaiHangHoa"].Value.ToString());
                }
                DialogResult result = MessageBox.Show("Bạn chắc chắn xóa loại hàng hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BLL_TYPEOFPRODUCT.Instance.FuncDeleteTypeProduct(listIdType);
                    ShowDataTypeOfProduct();
                }
            }
        }
        // cancel func add or edit
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Disable(false);
        }
        // back FrmManage_data
        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmManage_Data frmManageData = new FrmManage_Data(usernamelogin);
            frmManageData.Show();
            this.Close();
        }
        // search type of product
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập mã hoặc tên loại hàng hóa")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Black;
            }
        }

        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.Text = "Nhập mã hoặc tên loại hàng hóa";
                txtSEARCH.ForeColor = Color.Silver;
            }
        }

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            BLL_TYPEOFPRODUCT.Instance.FuncSearchTypeProduct(dgvLISTTYPE, txtSEARCH.Text.Trim());
        }
    }
}
