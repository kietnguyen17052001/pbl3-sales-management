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
    public partial class FrmList_SaleInvoice : Form
    {
        private string idInvoice, idProduct, nameProduct;
        private int quantityProduct;
        private bool isAdmin;
        private string usernameLogin;
        public FrmList_SaleInvoice(bool _isAdmin, string _usernameLogin)
        {
            InitializeComponent();
            isAdmin = _isAdmin;
            usernameLogin = _usernameLogin;
            if (isAdmin == false)
            {
                btnFrmData.Enabled = btnEditInvoice.Enabled = btnDeleteInvoice.Enabled = btnSaveChange.Enabled = false;
            }
            setCombobox();
            dpFROM.Value = BLL_LISTSALEINVOICE.Instance.getDate();
            LoadDGVs(txtSEARCH.Text.Trim());
            FormatColumnHeader();
        }
        // Format ColumnHeader
        public void FormatColumnHeader()
        {
            // Set style for columnHeader dgvListInvoice and dgvInfo_Invoice
            dgvLIST_INVOICE.EnableHeadersVisualStyles = dgvINFO_INVOICE.EnableHeadersVisualStyles = false;
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.BackColor = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.ForeColor = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.Font = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.Padding = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // Set headerText for dgvList_Invoice
            dgvLIST_INVOICE.Columns[0].HeaderText = "Mã h.đơn";
            dgvLIST_INVOICE.Columns[1].HeaderText = "Ngày bán";
            dgvLIST_INVOICE.Columns[2].HeaderText = "Nhân viên";
            dgvLIST_INVOICE.Columns[3].HeaderText = "Khách hàng";
            dgvLIST_INVOICE.Columns[4].HeaderText = "Thành tiền(VNĐ)";
            dgvLIST_INVOICE.Columns[5].HeaderText = "Giảm giá(VNĐ)";
            // Set headertext for dgvInfo_Invoice
            dgvINFO_INVOICE.Columns[0].HeaderText = "Mã h.hóa";
            dgvINFO_INVOICE.Columns[1].HeaderText = "Tên h.hóa";
            dgvINFO_INVOICE.Columns[2].HeaderText = "Số lượng";
            dgvINFO_INVOICE.Columns[3].HeaderText = "Giá(VNĐ)";
            dgvINFO_INVOICE.Columns[4].HeaderText = "Giảm giá(%)";
            dgvINFO_INVOICE.Columns[5].HeaderText = "Tổng tiền(VNĐ)";
        }
        public void ClearCode()
        {
            txtID_INVOICE.Clear();
            txtDISCOUNT.Clear();
            txtPRICE_.Clear();
            lbIdInvoice.Text = null;
        }
        public void Disable(bool E)
        {
            dpDAY.Enabled = E;
            cbbCUSTOMER.Enabled = E;
            cbbSTAFF.Enabled = E;
            txtDISCOUNT.Enabled = E;
            btnSaveChange.Enabled = E;
            btnEditInvoice.Enabled = btnDeleteInvoice.Enabled = !E;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                FrmMain_Admin frmMainAdmin = new FrmMain_Admin(usernameLogin);
                frmMainAdmin.Show();
            }
            else
            {
                FrmMain_Member frmMainMember = new FrmMain_Member(usernameLogin);
                frmMainMember.Show();
            }
            this.Close();
        }
        // event CellClick in dgvListInvoice
        private void dgvLIST_INVOICE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLIST_INVOICE.Rows.Count > 0)
            {
                idInvoice = dgvLIST_INVOICE.SelectedRows[0].Cells["MaHoaDonBan"].Value.ToString();
                txtID_INVOICE.Text = idInvoice;
                dpDAY.Value = Convert.ToDateTime(dgvLIST_INVOICE.SelectedRows[0].Cells["NgayBan"].Value.ToString());
                cbbSTAFF.Text = BLL_LISTSALEINVOICE.Instance.getTextForCbb(dgvLIST_INVOICE.SelectedRows[0].Cells["TenNhanVien"].Value.ToString(), BLL_STAFF.Instance.getCbbStaff());
                cbbCUSTOMER.Text = BLL_LISTSALEINVOICE.Instance.getTextForCbb(dgvLIST_INVOICE.SelectedRows[0].Cells["TenKhachHang"].Value.ToString(), BLL_CUSTOMER.Instance.getCbbCustomer());
                txtPRICE_.Text = String.Format("{0:n0}", dgvLIST_INVOICE.SelectedRows[0].Cells["SoTien"].Value);
                txtDISCOUNT.Text = String.Format("{0:n0}", dgvLIST_INVOICE.SelectedRows[0].Cells["GiamGia"].Value);
                BLL_LISTSALEINVOICE.Instance.LoadDataFrmDetail(dgvINFO_INVOICE, idInvoice);
            }
        }
        // set BackColor and Font for DGV
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
        // set data for combobox
        public void setCombobox()
        {
            cbbSTAFF.Items.AddRange(BLL_STAFF.Instance.getCbbStaff().ToArray());
            cbbCUSTOMER.Items.AddRange(BLL_CUSTOMER.Instance.getCbbCustomer().ToArray());
        }
        // Liệt kê hóa đơn theo cbbStaff_Detail
        public void LoadDGVs(string invoiceInformation)
        {
            Disable(false);
            ClearCode();
            BLL_LISTSALEINVOICE.Instance.FuncSearchInvoice(dgvLIST_INVOICE, dpFROM.Value, dpTO.Value, invoiceInformation);
            BLL_LISTSALEINVOICE.Instance.LoadDataFrmDetail(dgvINFO_INVOICE, null);
            lbQuantity.Text = BLL_LISTSALEINVOICE.Instance.getQuantityInvoice(dgvLIST_INVOICE).ToString();
            lbTotalMoney.Text = String.Format("{0:n0}", BLL_LISTSALEINVOICE.Instance.getTotalMoney(dgvLIST_INVOICE));
        }
        // Search invoice
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            LoadDGVs(txtSEARCH.Text.Trim());
        }
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập mã hóa đơn hoặc mã/ tên khách hàng")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Black;
            }
        }
        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.Text = "Nhập mã hóa đơn hoặc mã/ tên khách hàng";
                txtSEARCH.ForeColor = Color.Silver;
            }
        }
        // Export Excel
        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListInvoice";
            for(int i = 1; i <= dgvLIST_INVOICE.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvLIST_INVOICE.Columns[i - 1].HeaderText;
            }
            for(int i = 0; i < dgvLIST_INVOICE.Rows.Count; i++)
            {
                for(int j = 0; j < dgvLIST_INVOICE.Columns.Count; j++)
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

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_INVOICE.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Disable(true);
            }
        }
        // Save changes
        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_LISTSALEINVOICE.Instance.FuncEditInvoice(idInvoice, dpDAY.Value, ((CBBItem)cbbSTAFF.SelectedItem).VALUE, ((CBBItem)cbbCUSTOMER.SelectedItem).VALUE, Convert.ToDouble(txtDISCOUNT.Text));
                MessageBox.Show("Sửa thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGVs(txtSEARCH.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Delete invoice
        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_INVOICE.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<string> listIdInvoice = new List<string>();
                DataGridViewSelectedRowCollection data = dgvLIST_INVOICE.SelectedRows;
                foreach (DataGridViewRow dgvRow in data)
                {
                    listIdInvoice.Add(dgvRow.Cells["MaHoaDonBan"].Value.ToString());
                }
                DialogResult result = MessageBox.Show("Bạn chắc chắn xóa hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BLL_LISTSALEINVOICE.Instance.FuncDeleteInvoice(listIdInvoice); // delete invoice
                    LoadDGVs(txtSEARCH.Text.Trim());
                }
            }
        }
        // back to frmQuanLyDuLieu
        private void btnData_Click(object sender, EventArgs e)
        {
            FrmManage_Data frmMangageData = new FrmManage_Data(usernameLogin);
            frmMangageData.Show();
            this.Close();
        }
        // Add product for invoice
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_INVOICE.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần thêm hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmAdd_NewProduct frmAddNewProduct = new FrmAdd_NewProduct(idInvoice, true);
                frmAddNewProduct.d += new FrmAdd_NewProduct.myDel(LoadDGVs);
                frmAddNewProduct.Show();
                LoadDGVs(txtSEARCH.Text.Trim());
            }
        }
        // Delete product in invoice
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            List<string> listIdProduct = new List<string>();
            DataGridViewSelectedRowCollection data = dgvINFO_INVOICE.SelectedRows;
            if (data.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa hàng hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (dgvINFO_INVOICE.Rows.Count == data.Count)
                    {
                        List<String> listIdInvoice = new List<string>();
                        listIdInvoice.Add(idInvoice);
                        BLL_LISTSALEINVOICE.Instance.FuncDeleteInvoice(listIdInvoice);
                    }
                    else
                    {
                        foreach (DataGridViewRow dgvRow in data)
                        {
                            listIdProduct.Add(dgvRow.Cells["MaHangHoa"].Value.ToString());
                        }
                        BLL_LISTSALEINVOICE.Instance.FuncDeleteProduct(listIdProduct, idInvoice); // delete product
                    }
                    LoadDGVs(txtSEARCH.Text.Trim());
                }
            }
        }
        // Edit quantity product
        private void btnEditQuantityProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_INVOICE.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                nameProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["TenHangHoa"].Value.ToString();
                quantityProduct = Convert.ToInt32(dgvINFO_INVOICE.SelectedRows[0].Cells["SoLuong"].Value.ToString());
                idProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
                FrmEditQuantityProduct_ListInvoice frmEditQuantityProduct = new FrmEditQuantityProduct_ListInvoice(idInvoice, idProduct, nameProduct, quantityProduct, true);
                frmEditQuantityProduct.d += new FrmEditQuantityProduct_ListInvoice.myDel(LoadDGVs);
                frmEditQuantityProduct.Show();
            }
        }
        // Print invoice
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_INVOICE.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("N3K STORE", new Font("Tahoma", 20, FontStyle.Bold), Brushes.Black, new Point(340, 50));
            e.Graphics.DrawString("54 NGUYỄN LƯƠNG BẰNG", new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(280, 100));
            e.Graphics.DrawString("0911.888.999", new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(350, 120));
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Tahoma", 19, FontStyle.Bold), Brushes.Black, new Point(270, 180));
            e.Graphics.DrawString("NVTN: " + cbbSTAFF.SelectedItem.ToString(), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(270, 220));
            e.Graphics.DrawString("Khách hàng: " + cbbCUSTOMER.SelectedItem.ToString(), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(270, 250));
            e.Graphics.DrawString("Số hóa đơn: " + txtID_INVOICE.Text, new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(200, 300));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(450, 300));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, 350));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(10, 400));
            e.Graphics.DrawString("SL", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(360, 400));
            e.Graphics.DrawString("Đơn giá", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(440, 400));
            e.Graphics.DrawString("K/Mãi", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(580, 400));
            e.Graphics.DrawString("Thành tiền", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(700, 400));
            int distance = 400;
            string str;
            double totalMoney = 0; // Tổng tiền đơn hàng
            foreach (DataGridViewRow dgvRow in dgvINFO_INVOICE.Rows)
            {
                totalMoney += Convert.ToDouble(dgvRow.Cells["TongTien"].Value.ToString());
                distance += 50;
                str = "";
                if (dgvRow.Cells["TenHangHoa"].Value.ToString().Length > 30)
                {
                    str += dgvRow.Cells["TenHangHoa"].Value.ToString().Substring(31);
                    dgvRow.Cells["TenHangHoa"].Value = dgvRow.Cells["TenHangHoa"].Value.ToString().Replace(str, "");
                }
                e.Graphics.DrawString(dgvRow.Cells["TenHangHoa"].Value.ToString() + "\n" + str, new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(10, distance));
                e.Graphics.DrawString(dgvRow.Cells["SoLuong"].Value.ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(370, distance));
                e.Graphics.DrawString(dgvRow.Cells["DonGia"].Value.ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(450, distance));
                e.Graphics.DrawString(dgvRow.Cells["GiamGia"].Value.ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(590, distance));
                e.Graphics.DrawString(dgvRow.Cells["TongTien"].Value.ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(710, distance));
            }
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50));
            e.Graphics.DrawString("Tổng tiền ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 2));
            e.Graphics.DrawString(String.Format("{0:n0}",totalMoney), new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 2));
            e.Graphics.DrawString("Giảm giá ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 3));
            e.Graphics.DrawString(txtDISCOUNT.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 3));
            e.Graphics.DrawString("Tổng thanh toán ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 4));
            e.Graphics.DrawString(txtPRICE_.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 4));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50 * 5));
            e.Graphics.DrawString("Cảm ơn và hẹn gặp lại quý khách!", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(250, distance + 50 * 6));
        }

        // Load dgv when valuechange datetimepickers
        private void dpTO_ValueChanged(object sender, EventArgs e)
        {
            LoadDGVs(txtSEARCH.Text.Trim());
        }   
        private void txtID_INVOICE_TextChanged(object sender, EventArgs e)
        {
            lbIdInvoice.Text = idInvoice;
        }
    }
}
