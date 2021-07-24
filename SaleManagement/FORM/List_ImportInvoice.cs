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
        private string idInvoice, idProduct, nameProduct;
        private int quantityProduct;
        private bool isAdmin;
        private string usernameLogin;
        public FrmList_ImportInvoice(bool _isAdmin, string _usernameLogin)
        {
            InitializeComponent();
            isAdmin = _isAdmin;
            usernameLogin = _usernameLogin;
            if (isAdmin == false)
            {
                btnFrmData.Enabled = btnEditInvoice.Enabled = btnDeleteInvoice.Enabled = btnSaveChange.Enabled = false;
            }
            setCombobox();
            dpFROM.Value = BLL_LISTIMPORTINVOICE.Instance.getDate();
            LoadDGVs(txtSEARCH.Text.Trim());
            FormatColumnHeader();
        }
        public void ClearCode()
        {
            txtID_INVOICE.Clear();
            txtDISCOUNT.Clear();
            txtPRICE.Clear();
            lbIdInvoice.Text = null;
        }
        public void Disable(bool E)
        {
            dpDAY.Enabled = E;
            cbbSTAFF.Enabled = E;
            cbbSUPPLIER.Enabled = E;
            txtDISCOUNT.Enabled = E;
            btnSaveChange.Enabled = E;
            btnEditInvoice.Enabled = btnDeleteInvoice.Enabled = !E;
        }
        public void setCombobox()
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
        // event CellClick DgvListInvoice
        private void dgvLIST_INVOICE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvLIST_INVOICE.Rows.Count > 0)
            {
                idInvoice = dgvLIST_INVOICE.SelectedRows[0].Cells["MaHoaDonNhap"].Value.ToString();
                BLL_LISTIMPORTINVOICE.Instance.LoadDataFrmDetail(dgvINFO_INVOICE, idInvoice);
                txtID_INVOICE.Text = idInvoice;
                cbbSTAFF.Text = BLL_LISTIMPORTINVOICE.Instance.getTextForCbb(dgvLIST_INVOICE.SelectedRows[0].Cells["TenNhanVien"].Value.ToString(), BLL_STAFF.Instance.getCbbStaff());
                cbbSUPPLIER.Text = BLL_LISTIMPORTINVOICE.Instance.getTextForCbb(dgvLIST_INVOICE.SelectedRows[0].Cells["TenNhaCungCap"].Value.ToString(), BLL_SUPPLIER.Instance.ListSupplier());
                dpDAY.Value = Convert.ToDateTime(dgvLIST_INVOICE.SelectedRows[0].Cells["NgayNhap"].Value.ToString());
                txtDISCOUNT.Text = String.Format("{0:n0}", Convert.ToDouble(dgvLIST_INVOICE.SelectedRows[0].Cells["GiamGia"].Value.ToString()));
                txtPRICE.Text = String.Format("{0:n0}", Convert.ToDouble(dgvLIST_INVOICE.SelectedRows[0].Cells["SoTien"].Value.ToString()));
            }
        }
        public void LoadDGVs(string invoiceInformation)
        {
            Disable(false);
            ClearCode();
            BLL_LISTIMPORTINVOICE.Instance.FuncSearchInvoice(dgvLIST_INVOICE, dpFROM.Value, dpTO.Value, invoiceInformation);
            BLL_LISTIMPORTINVOICE.Instance.LoadDataFrmDetail(dgvINFO_INVOICE, null);
            lbQuantity.Text = BLL_LISTIMPORTINVOICE.Instance.getQuantityInvoice(dgvLIST_INVOICE).ToString();
            lbTotalMoney.Text = String.Format("{0:n0}", BLL_LISTIMPORTINVOICE.Instance.getTotalMoney(dgvLIST_INVOICE));
        }
        // button home
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
        // search invoice
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            LoadDGVs(txtSEARCH.Text.Trim());
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
        private void btnExport_Click(object sender, EventArgs e)
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
        // button save change
        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_LISTIMPORTINVOICE.Instance.FuncEditInvoice(idInvoice, dpDAY.Value, ((CBBItem)cbbSUPPLIER.SelectedItem).VALUE, ((CBBItem)cbbSTAFF.SelectedItem).VALUE, Convert.ToDouble(txtDISCOUNT.Text));
                MessageBox.Show("Sửa thành công đơn nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDGVs(txtSEARCH.Text.Trim());
            }
            catch (Exception) {
                MessageBox.Show("Sửa thất bại đơn nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // button delete invoice
        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_INVOICE.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string message = "";
                string invoiceInformation;
                List<string> listIdInvoice = new List<string>();
                DataGridViewSelectedRowCollection data = dgvLIST_INVOICE.SelectedRows;
                foreach (DataGridViewRow dgvRow in data)
                {
                    listIdInvoice.Add(dgvRow.Cells["MaHoaDonNhap"].Value.ToString());
                }
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (string idInvoice in listIdInvoice)
                    {
                        if (BLL_LISTIMPORTINVOICE.Instance.isValidDeleteInvoice(idInvoice))
                        {
                            BLL_LISTIMPORTINVOICE.Instance.FuncDeleteInvoice(idInvoice);
                            LoadDGVs(txtSEARCH.Text.Trim());
                        }
                        else
                        {
                            invoiceInformation = "Xóa hóa đơn thất bại. Kiểm tra lại số lượng của hàng hóa trong kho của hóa đơn: ";
                            message += invoiceInformation + idInvoice + "\n";
                            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        // button back to frmManage_Data
        private void btnFrmData_Click(object sender, EventArgs e)
        {
            FrmManage_Data frmManageData = new FrmManage_Data(usernameLogin);
            frmManageData.Show();
            this.Close();
        }
        // button add product for invoice
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_INVOICE.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần thêm hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmAdd_NewProduct frmAddNewProduct = new FrmAdd_NewProduct(idInvoice, false);
                frmAddNewProduct.d += new FrmAdd_NewProduct.myDel(LoadDGVs);
                frmAddNewProduct.Show();
            }
        }
        // button edit quantity
        private void btnEditQuantityProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID_INVOICE.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                idProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
                nameProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["TenHangHoa"].Value.ToString();
                quantityProduct = Convert.ToInt32(dgvINFO_INVOICE.SelectedRows[0].Cells["SoLuong"].Value.ToString());
                FrmEditQuantityProduct_ListInvoice frmEditQuantityProduct = new FrmEditQuantityProduct_ListInvoice(idInvoice, idProduct, nameProduct, quantityProduct, false);
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
            e.Graphics.DrawString("HÓA ĐƠN NHẬP HÀNG", new Font("Tahoma", 19, FontStyle.Bold), Brushes.Black, new Point(270, 180));
            e.Graphics.DrawString("Nhân viên: " + cbbSTAFF.SelectedItem.ToString(), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(260, 220));
            e.Graphics.DrawString("Nhà cung cấp: " + cbbSUPPLIER.Text, new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(260, 250));
            e.Graphics.DrawString("Số hóa đơn: " + txtID_INVOICE.Text, new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(190, 300));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(450, 300));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, 350));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(10, 400));
            e.Graphics.DrawString("SL", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(360, 400));
            e.Graphics.DrawString("Giá nhập", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(440, 400));
            e.Graphics.DrawString("Thành tiền", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(580, 400));
            int distance = 400;
            string str;
            double totalMoney = 0;
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
                e.Graphics.DrawString(dgvRow.Cells["GiaNhap"].Value.ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(450, distance));
                e.Graphics.DrawString(dgvRow.Cells["TongTien"].Value.ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(590, distance));
            }
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50));
            e.Graphics.DrawString("Tổng tiền ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 2));
            e.Graphics.DrawString(String.Format("{0:n0}",totalMoney), new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 2));
            e.Graphics.DrawString("Giảm giá ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 3));
            e.Graphics.DrawString(txtDISCOUNT.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 3));
            e.Graphics.DrawString("Tổng thanh toán ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 4));
            e.Graphics.DrawString(txtPRICE.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 4));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50 * 5));
            e.Graphics.DrawString("Cảm ơn và hẹn gặp lại!", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(250, distance + 50 * 6));
        }

        // Load dgv when valuechange datetimepickers
        private void dpTO_ValueChanged(object sender, EventArgs e)
        {
            LoadDGVs(txtSEARCH.Text.Trim());
        }

        // delete product
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string message = ""; string invoiceInformation;
            bool flag = true;
            List<string> listIdProduct = new List<string>();
            DataGridViewSelectedRowCollection data = dgvINFO_INVOICE.SelectedRows;
            if (data.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult answer = MessageBox.Show("Bạn chắc chắn muốn xóa hàng hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    foreach(DataGridViewRow dgvRow in data)
                    {
                        if (BLL_LISTIMPORTINVOICE.Instance.isValidDeleteProduct(idInvoice, dgvRow.Cells["MaHangHoa"].Value.ToString()))
                        {
                            listIdProduct.Add(dgvRow.Cells["MaHangHoa"].Value.ToString());
                        }
                        else
                        {
                            flag = false;
                            invoiceInformation = "Số lượng trong kho của hàng hóa: " + dgvRow.Cells["MaHangHoa"].Value.ToString() + " không đủ để trả NCC\n";
                            message += invoiceInformation;
                        }
                    }
                    if(flag == false && data.Count == 1)
                    {
                        MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(flag == false && data.Count > 1)
                    {
                        MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BLL_LISTIMPORTINVOICE.Instance.FuncDeleteProduct(listIdProduct, idInvoice);
                    }
                    else if(flag == true && data.Count == dgvINFO_INVOICE.Rows.Count)
                    {
                        BLL_LISTIMPORTINVOICE.Instance.FuncDeleteInvoice(idInvoice);
                    }
                    else
                    {
                        BLL_LISTIMPORTINVOICE.Instance.FuncDeleteProduct(listIdProduct, idInvoice);
                    }
                    LoadDGVs(txtID_INVOICE.Text.Trim());
                } 
            }
        }
        private void txtID_INVOICE_TextChanged(object sender, EventArgs e)
        {
            lbIdInvoice.Text = idInvoice;
        }
    }
}
