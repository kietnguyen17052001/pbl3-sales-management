using SaleManagement.BLL;
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
    public partial class FrmList_ImportInvoice : Form
    {
        private string idInvoice;
        public FrmList_ImportInvoice()
        {
            InitializeComponent();
            Disable(false);
            LoadDGVs();
            FormatColumnHeader();
            setCbb();
            dpFROM.Value = BLL_LISTIMPORTINVOICE.Instance.getDate();
        }
        public void Disable(bool E)
        {
            dpDAY.Enabled = E;
            cbbSTAFF.Enabled = E;
            cbbSUPPLIER.Enabled = E;
        }
        public void setCbb()
        {
            cbbSUPPLIER.Items.AddRange(BLL_SUPPLIER.Instance.ListSupplier().ToArray());
            cbbSTAFF.Items.AddRange(BLL_STAFF.Instance.getCbbStaff().ToArray());
        }
        public void FormatColumnHeader()
        {
            dgvLIST_INVOICE.EnableHeadersVisualStyles = dgvINFO_INVOICE.EnableHeadersVisualStyles = false;
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.BackColor = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.ForeColor = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.Font = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.Padding = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // Set headerText for dgvList_Invoice
            dgvLIST_INVOICE.Columns[0].HeaderText = "Mã h.đơn";
            dgvLIST_INVOICE.Columns[1].HeaderText = "Ngày nhập";
            dgvLIST_INVOICE.Columns[2].HeaderText = "Nhà c.cấp";
            dgvLIST_INVOICE.Columns[3].HeaderText = "Nhân viên";
            dgvLIST_INVOICE.Columns[4].HeaderText = "Giảm giá(VNĐ)";
            dgvLIST_INVOICE.Columns[5].HeaderText = "Thành tiền(VNĐ)";
            // Set headertext for dgvInfo_Invoice
            dgvINFO_INVOICE.Columns[0].HeaderText = "Mã h.hóa";
            dgvINFO_INVOICE.Columns[1].HeaderText = "Tên h.hóa";
            dgvINFO_INVOICE.Columns[2].HeaderText = "Số lượng";
            dgvINFO_INVOICE.Columns[3].HeaderText = "Giá nhập(VNĐ)";
            dgvINFO_INVOICE.Columns[4].HeaderText = "Tổng tiền(VNĐ)";
        }
        private void dgvLIST_INVOICE_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvLIST_INVOICE.DefaultCellStyle.BackColor = Color.Azure;
            dgvLIST_INVOICE.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }

        private void dgvINFO_INVOICE_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvINFO_INVOICE.DefaultCellStyle.BackColor = Color.OldLace;
            dgvINFO_INVOICE.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        private void dgvLIST_INVOICE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idInvoice = dgvLIST_INVOICE.SelectedRows[0].Cells["MaHoaDonNhap"].Value.ToString();
            BLL_LISTIMPORTINVOICE.Instance.LoadDataFrmDetail(dgvINFO_INVOICE, idInvoice);
            txtID_INVOICE.Text = idInvoice;
            cbbSTAFF.Text = BLL_LISTIMPORTINVOICE.Instance.getTextForCbb(dgvLIST_INVOICE.SelectedRows[0].Cells["TenNhanVien"].Value.ToString(), BLL_STAFF.Instance.getCbbStaff());
            cbbSUPPLIER.Text = BLL_LISTIMPORTINVOICE.Instance.getTextForCbb(dgvLIST_INVOICE.SelectedRows[0].Cells["TenNhaCungCap"].Value.ToString(), BLL_SUPPLIER.Instance.ListSupplier());
            dpDAY.Value = Convert.ToDateTime(dgvLIST_INVOICE.SelectedRows[0].Cells["NgayNhap"].Value.ToString());
            txtDISCOUNT.Text = dgvLIST_INVOICE.SelectedRows[0].Cells["GiamGia"].Value.ToString();
            txtPRICE.Text = String.Format("{0:n0}", Convert.ToDouble(dgvLIST_INVOICE.SelectedRows[0].Cells["SoTien"].Value.ToString()));
        }
        public void LoadDGVs()
        {
            BLL_LISTIMPORTINVOICE.Instance.FuncSearchInvoice(dgvLIST_INVOICE, dpFROM.Value, dpTO.Value, txtSEARCH.Text.Trim());
            BLL_LISTIMPORTINVOICE.Instance.LoadDataFrmDetail(dgvINFO_INVOICE, idInvoice);
        }
        // button home
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management frm = new FrmSale_Management();
            frm.Show();
            this.Close();
        }
        // search invoice
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            BLL_LISTIMPORTINVOICE.Instance.FuncSearchInvoice(dgvLIST_INVOICE, dpFROM.Value, dpTO.Value, txtSEARCH.Text.Trim());
        }
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập mã hóa đơn hoặc mã/ tên nhà c.cấp") {
                txtSEARCH.ForeColor = Color.Black;
                txtSEARCH.Text = "";
            }
        }

        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.ForeColor = Color.Silver;
                txtSEARCH.Text = "Nhập mã hóa đơn hoặc mã/ tên nhà c.cấp";
            }
        }
        // export file excel
        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListInvoice";
            for (int i = 1; i <= dgvLIST_INVOICE.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvLIST_INVOICE.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvLIST_INVOICE.Rows.Count; i++)
            {
                for (int j = 0; j < dgvLIST_INVOICE.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLIST_INVOICE.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "List Invoice";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        // button edit invoice (date, staff, supplier)
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            Disable(true);
        }
        // button save change
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_LISTIMPORTINVOICE.Instance.FuncEditInvoice(idInvoice, dpDAY.Value, ((CBBItem)cbbSUPPLIER.SelectedItem).VALUE, ((CBBItem)cbbSTAFF.SelectedItem).VALUE);
                MessageBox.Show("Sửa thành công đơn nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGVs();
            }
            catch (Exception) {
                MessageBox.Show("Sửa thất bại đơn nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // button delete invoice
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            List<string> listIdInvoice = new List<string>();
            DataGridViewSelectedRowCollection data = dgvLIST_INVOICE.SelectedRows;
            foreach(DataGridViewRow dgvRow in data)
            {
                listIdInvoice.Add(dgvRow.Cells["MaHoaDonNhap"].Value.ToString());
            }
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                BLL_LISTIMPORTINVOICE.Instance.FuncDeleteInvoice(listIdInvoice);
                LoadDGVs();
            }
        }
        // button back to frmManage_Data
        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmManage_Data frm = new FrmManage_Data();
            frm.Show();
            this.Close();
        }
        // button add product for invoice
        private void btnADD_PRODUCT_Click(object sender, EventArgs e)
        {

        }
        // button edit quantity
        private void btnEDIT_QUANTITY_Click(object sender, EventArgs e)
        {

        }
        // button delete product
        private void btnDELETE_PRODUCT_Click(object sender, EventArgs e)
        {
            List<string> listIdProduct = new List<string>();
            DataGridViewSelectedRowCollection data = dgvINFO_INVOICE.SelectedRows;
            foreach(DataGridViewRow dgvRow in data)
            {
                listIdProduct.Add(dgvRow.Cells["MaHangHoa"].Value.ToString());
            }
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa hàng hóa này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BLL_LISTIMPORTINVOICE.Instance.FuncDeleteProduct(listIdProduct, idInvoice);
                LoadDGVs();
            }
        }
        private void txtID_INVOICE_TextChanged(object sender, EventArgs e)
        {
            lbIdInvoice.Text = idInvoice;
        }
    }
}
