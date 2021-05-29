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
    public partial class FrmManage_List_Invoice : Form
    {
        string idInvoice;
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        public FrmManage_List_Invoice()
        {
            InitializeComponent();
            disable(false);
            SetCBB();
            var dateMin = DB.tblHoaDonBanHangs.Min(p => p.NgayBan);
            if (dateMin != null)
            {
                dpFROM.Value = dateMin.Value;
            }
            ShowList();
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
            dgvLIST_INVOICE.Columns[4].HeaderText = "Số tiền(VNĐ)";
            dgvLIST_INVOICE.Columns[5].HeaderText = "Giảm giá(VNĐ)";
            // Set headertext for dgvInfo_Invoice
            dgvINFO_INVOICE.Columns[0].HeaderText = "Mã h.hóa";
            dgvINFO_INVOICE.Columns[1].HeaderText = "Tên h.hóa";
            dgvINFO_INVOICE.Columns[2].HeaderText = "Số lượng";
            dgvINFO_INVOICE.Columns[3].HeaderText = "Giá(VNĐ)";
            dgvINFO_INVOICE.Columns[4].HeaderText = "Giảm giá(%)";
            dgvINFO_INVOICE.Columns[5].HeaderText = "Tổng tiền(VNĐ)";
        }
        public void disable(bool E)
        {
            txtID_INVOICE.Enabled = E;
            dpDAY.Enabled = E;
            cbbCUSTOMER.Enabled = E;
            cbbSTAFF.Enabled = E;
            txtPRICE_.Enabled = E;
            txtDISCOUNT.Enabled = E;
            btnSAVE.Enabled = E;
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management frm = new FrmSale_Management();
            frm.Show();
            this.Close();
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
        public void SetCBB()
        {
            cbbSTAFF_DETAIL.Items.Add(new CBBItem { VALUE = "0", TEXT = "Tất cả"});
            cbbSTAFF_DETAIL.Items.AddRange(BLL_CREATEINVOICE.Instance.GetCbb_Staff().ToArray());
            cbbSTAFF.Items.AddRange(BLL_CREATEINVOICE.Instance.GetCbb_Staff().ToArray());
            cbbCUSTOMER.Items.AddRange(BLL_CREATEINVOICE.Instance.GetCbb_Customer().ToArray());
            cbbSTAFF_DETAIL.SelectedIndex = 0;
        }
        // Liệt kê hóa đơn theo cbbStaff_Detail
        public void ShowListInvoice()
        {
            if (cbbSTAFF_DETAIL.SelectedIndex == 0)
            {
                var getInvoice = DB.tblHoaDonBanHangs.Where(p => p.NgayBan >= dpFROM.Value && p.NgayBan <= dpTO.Value).Select(p => new {
                    p.MaHoaDonBan,
                    p.NgayBan,
                    p.tblNhanVien.TenNhanVien,
                    p.tblKhachHang.TenKhachHang,
                    p.SoTien,
                    p.GiamGia
                });
                dgvLIST_INVOICE.DataSource = getInvoice.ToList();
            }
            else
            {
                var getInvoice = DB.tblHoaDonBanHangs.Where(p => p.MaNhanVien == ((CBBItem)cbbSTAFF_DETAIL.SelectedItem).VALUE && p.NgayBan >= dpFROM.Value && p.NgayBan <= dpTO.Value).Select(p => new {
                    p.MaHoaDonBan,
                    p.NgayBan,
                    p.tblNhanVien.TenNhanVien,
                    p.tblKhachHang.TenKhachHang,
                    p.SoTien,
                    p.GiamGia
                });
                dgvLIST_INVOICE.DataSource = getInvoice.ToList();
            }
        }
        // Liệt kê thông tin đơn hàng dựa vào mã hóa đơn từ dgvList_Invoice
        public void ShowInfoInvoice(string idInvoice)
        {
            var infoInvoice = DB.tblChiTietHoaDonBanHangs.Where(p => p.MaHoaDonBan == idInvoice).Select(p => new {
                p.MaHangHoa,
                p.tblHangHoa.TenHangHoa,
                p.SoLuong,
                p.DonGia,
                p.GiamGia,
                p.TongTien
            });
            dgvINFO_INVOICE.DataSource = infoInvoice.ToList();
        }
        // set data for txt, cbb
        public void SetData_Dgv()
        {
            idInvoice = dgvLIST_INVOICE.SelectedRows[0].Cells["MaHoaDonBan"].Value.ToString();
            var invoice = DB.tblHoaDonBanHangs.Find(idInvoice);
            txtID_INVOICE.Text = invoice.MaHoaDonBan;
            dpDAY.Value = (DateTime)invoice.NgayBan;
            cbbSTAFF.Text = BLL_LISTINVOICE.Instance.GetStaff(invoice.tblNhanVien.TenNhanVien);
            cbbCUSTOMER.Text = BLL_LISTINVOICE.Instance.GetCustomer(invoice.tblKhachHang.TenKhachHang);
            txtPRICE_.Text = String.Format("{0:n0}", dgvLIST_INVOICE.SelectedRows[0].Cells["SoTien"].Value);
            txtDISCOUNT.Text = String.Format("{0:n0}", dgvLIST_INVOICE.SelectedRows[0].Cells["GiamGia"].Value);
            ShowInfoInvoice(idInvoice);
        }
        // Func show listInvoice and infoInvoice
        public void ShowList()
        {
            ShowListInvoice();
            idInvoice = dgvLIST_INVOICE.Rows[0].Cells["MaHoaDonBan"].Value.ToString();
            ShowInfoInvoice(idInvoice);
        }
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            ShowList();
        }
        private void dgvLIST_INVOICE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetData_Dgv();
        }
        // Export Excel
        private void btnEXCEL_Click(object sender, EventArgs e)
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

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            disable(true);
            txtID_INVOICE.Enabled = false;
        }
        // Save changes
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            tblHoaDonBanHang invoice = new tblHoaDonBanHang();
            invoice.MaHoaDonBan = txtID_INVOICE.Text;
            invoice.NgayBan = Convert.ToDateTime(dpDAY.Value);
            invoice.MaNhanVien = ((CBBItem)cbbSTAFF.SelectedItem).VALUE;
            invoice.MaKhachHang = ((CBBItem)cbbCUSTOMER.SelectedItem).VALUE;
            BLL_LISTINVOICE.Instance.FuncEditInvoice(invoice); // edit invoice
            MessageBox.Show("Sửa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show();
            disable(false);
        }
        // Delete invoice
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            List<string> listIdInvoice = new List<string>();
            DataGridViewSelectedRowCollection data = dgvLIST_INVOICE.SelectedRows;
            foreach(DataGridViewRow dataGvr in data)
            {
                listIdInvoice.Add(dataGvr.Cells["MaHoaDonBan"].Value.ToString());
            }
            DialogResult question = MessageBox.Show("Bạn chắc chắn xóa hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                BLL_LISTINVOICE.Instance.FuncDeleteInvoice(listIdInvoice); // delete invoice
                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                ShowListInvoice();
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn chắc chắn quay lại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                FrmManage_Data frm = new FrmManage_Data();
                frm.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }
        // Search invoice
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            // Tìm kiếm theo mã đơn, mã khách hoặc tên khách hàng
            BLL_LISTINVOICE.Instance.FuncSearchInvoice(dgvLIST_INVOICE, txtSEARCH.Text.Trim()); // search invoice
        }
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if(txtSEARCH.Text == "Nhập mã hóa đơn hoặc mã/ tên khách hàng")
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
        // Add product for invoice
        private void btnADD_PRODUCT_Click(object sender, EventArgs e)
        {
            FrmAdd_NewProduct frm = new FrmAdd_NewProduct(idInvoice);
            frm.Show();
            ShowList();
        }
        // Func set new Quantity for product in invoice
        public void setNewQuantity(int _newQuantity)
        {
            string idProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            var getInvoiceDetail = DB.tblChiTietHoaDonBanHangs.Find(idInvoice, idProduct);
            getInvoiceDetail.SoLuong = _newQuantity;
            getInvoiceDetail.TongTien = getInvoiceDetail.DonGia * _newQuantity - getInvoiceDetail.DonGia * _newQuantity * getInvoiceDetail.GiamGia/100; // thay đổi số tiền của chi tiết hóa đơn sau khi thay đổi số lượng mới
            DB.SaveChanges();
            var getInvoice = DB.tblHoaDonBanHangs.Find(idInvoice);
            getInvoice.SoTien = BLL_LISTINVOICE.Instance.GetPriceInvoice(idInvoice) - getInvoice.GiamGia;
            DB.SaveChanges();
            ShowList();
        }
        // Edit quantity product
        private void btnEDIT_QUANTITY_Click(object sender, EventArgs e)
        {
            string nameProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["TenHangHoa"].Value.ToString();
            int oldQuantity = Convert.ToInt32(dgvINFO_INVOICE.SelectedRows[0].Cells["SoLuong"].Value.ToString());
            string idProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            FrmEdit_Quantity frm = new FrmEdit_Quantity(idProduct, nameProduct, oldQuantity);
            frm.d += new FrmEdit_Quantity.myDEL(setNewQuantity);
            frm.Show();
        }
        // Delete product in invoice
        private void btnDELETE_PRODUCT_Click(object sender, EventArgs e)
        {
            List<string> listIdProduct = new List<string>();
            DataGridViewSelectedRowCollection data = dgvINFO_INVOICE.SelectedRows;
            foreach(DataGridViewRow dataGVR in data)
            {
                listIdProduct.Add(dataGVR.Cells["MaHangHoa"].Value.ToString());
            }
            BLL_LISTINVOICE.Instance.FuncDeleteProduct(listIdProduct, idInvoice); // delete product
            ShowList();
        }
    }
}
