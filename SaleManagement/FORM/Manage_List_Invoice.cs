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
        public FrmManage_List_Invoice()
        {
            InitializeComponent();
            SetCBB();
            ShowInvoice();   
            txtAMOUNT.Enabled = false;
            txtPRICE.Enabled = false;
            disable(false);
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
        // Tổng tiền tất cả hóa đơn
        public double GetAllPrice()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            double price = 0;
            foreach(tblHoaDonBanHang invoice in DB.tblHoaDonBanHangs)
            {
                price += Convert.ToDouble(invoice.SoTien);
            }
            return price;
        }
        // cbb nhân viên thu ngân
        public void SetCBB()
        {
            cbbSTAFF_DETAIL.Items.Add(new CBBItem { VALUE = "0", TEXT = "Tất cả"});
            cbbSTAFF_DETAIL.Items.AddRange(BLL_CREATEINVOICE.Instance.GetCbb_Staff().ToArray());
            cbbSTAFF.Items.AddRange(BLL_CREATEINVOICE.Instance.GetCbb_Staff().ToArray());
            cbbCUSTOMER.Items.AddRange(BLL_CREATEINVOICE.Instance.GetCbb_Customer().ToArray());
            cbbSTAFF_DETAIL.SelectedIndex = 0;
        }
        // Liệt kê hóa đơn theo cbbStaff_Detail
        public void ShowInvoice()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            if (cbbSTAFF_DETAIL.SelectedIndex == 0)
            {
                var getInvoice = DB.tblHoaDonBanHangs.Select(p => new {
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
                var getInvoice = DB.tblHoaDonBanHangs.Where(p => p.MaNhanVien == ((CBBItem)cbbSTAFF_DETAIL.SelectedItem).VALUE).Select(p => new {
                    p.MaHoaDonBan,
                    p.NgayBan,
                    p.tblNhanVien.TenNhanVien,
                    p.tblKhachHang.TenKhachHang,
                    p.SoTien,
                    p.GiamGia
                });
                dgvLIST_INVOICE.DataSource = getInvoice.ToList();
            }
            dgvINFO_INVOICE.DataSource = null;
            txtAMOUNT.Text = dgvLIST_INVOICE.Rows.Count.ToString(); // gán số lượng cho txtAmount
            txtPRICE.Text = String.Format("{0:n0}", GetAllPrice()); // gán giá trị cho txtPrice
        }
        // Liệt kê thông tin đơn hàng dựa vào mã hóa đơn từ dgvList_Invoice
        public void ShowInfoInvoice(string idInvoice)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
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
        public void SetData_Dgv()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            idInvoice = dgvLIST_INVOICE.SelectedRows[0].Cells["MaHoaDonBan"].Value.ToString();
            var invoice = DB.tblHoaDonBanHangs.Find(idInvoice);
            txtID_INVOICE.Text = invoice.MaHoaDonBan;
            dpDAY.Value = (DateTime)invoice.NgayBan;
            cbbSTAFF.Text = BLL_LISTINVOICE.Instance.GetStaff(invoice.tblNhanVien.TenNhanVien);
            cbbCUSTOMER.Text = BLL_LISTINVOICE.Instance.GetCustomer(invoice.tblKhachHang.TenKhachHang);
            txtPRICE_.Text = String.Format("{0:n0}", invoice.SoTien);
            txtDISCOUNT.Text = String.Format("{0:n0}", invoice.GiamGia);
            ShowInfoInvoice(idInvoice);
        }
        public void Show(string idInvoice)
        {
            ShowInvoice();
            ShowInfoInvoice(idInvoice);
        }
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            Show(idInvoice);
        }
        private void dgvLIST_INVOICE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetData_Dgv();
        }
        // Xuất list Invoice ra file excel
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

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var invoice = DB.tblHoaDonBanHangs.Find(txtID_INVOICE.Text);
            invoice.NgayBan = Convert.ToDateTime(dpDAY.Value);
            invoice.MaNhanVien = ((CBBItem)cbbSTAFF.SelectedItem).VALUE;
            invoice.MaKhachHang = ((CBBItem)cbbCUSTOMER.SelectedItem).VALUE;
            DB.SaveChanges();
            MessageBox.Show("Sửa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowInvoice();
            disable(false);
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<string> listIdInvoice = new List<string>();
            DataGridViewSelectedRowCollection data = dgvLIST_INVOICE.SelectedRows;
            foreach(DataGridViewRow dataGvr in data)
            {
                listIdInvoice.Add(dataGvr.Cells["MaHoaDonBan"].Value.ToString());
            }
            foreach(string i in listIdInvoice)
            {
                foreach(tblHoaDonBanHang invoice in DB.tblHoaDonBanHangs) // xóa đơn hàng có mã đơn = i
                {
                    if (invoice.MaHoaDonBan == i)
                    {
                        DB.tblHoaDonBanHangs.Remove(invoice);
                        foreach (tblChiTietHoaDonBanHang invoiceDetail in DB.tblChiTietHoaDonBanHangs) // xóa chi tiết đơn hàng có mã đơn = i
                        {
                            if (invoiceDetail.MaHoaDonBan == i)
                            {
                                DB.tblChiTietHoaDonBanHangs.Remove(invoiceDetail);
                                foreach (tblHangHoa product in DB.tblHangHoas) // thay đổi số lượng hàng hóa sau khi xóa chi tiết đơn hàng
                                {
                                    if (product.MaHangHoa == invoiceDetail.MaHangHoa)
                                    {
                                        product.SoLuong += (int)invoiceDetail.SoLuong;
                                    }
                                }
                            }
                        }
                    } 
                }
                DB.SaveChanges();
                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowInvoice();
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

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            string content = txtSEARCH.Text;
            // Tìm kiếm theo mã đơn, mã khách hoặc tên khách hàng
            var listInvoice = DB.tblHoaDonBanHangs.Where(p => p.MaHoaDonBan.Contains(content) || p.MaKhachHang.Contains(content)
            || p.tblKhachHang.TenKhachHang.Contains(content)).Select(p => new {
                p.MaHoaDonBan,
                p.NgayBan,
                p.tblNhanVien.TenNhanVien,
                p.tblKhachHang.TenKhachHang,
                p.SoTien,
                p.GiamGia
            });
            dgvLIST_INVOICE.DataSource = listInvoice.ToList();
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
        private void btnADD_PRODUCT_Click(object sender, EventArgs e)
        {
            FrmAdd_NewProduct frm = new FrmAdd_NewProduct(idInvoice);
            frm.d += new FrmAdd_NewProduct.myDEL(Show);
            frm.Show();   
        }
        public void setNewQuantity(int _newQuantity)
        {
            string idProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var getInvoiceDetail = DB.tblChiTietHoaDonBanHangs.Find(idInvoice, idProduct);
            getInvoiceDetail.SoLuong = _newQuantity;
            getInvoiceDetail.TongTien = getInvoiceDetail.DonGia * _newQuantity - getInvoiceDetail.DonGia * _newQuantity * getInvoiceDetail.GiamGia/100; // thay đổi số tiền của chi tiết hóa đơn sau khi thay đổi số lượng mới
            DB.SaveChanges();
            var getInvoice = DB.tblHoaDonBanHangs.Find(idInvoice);
            getInvoice.SoTien = BLL_LISTINVOICE.Instance.GetPriceInvoice(idInvoice) - getInvoice.GiamGia;
            DB.SaveChanges();
            Show(idInvoice);
        }
        // Thay đổi số lượng hàng hóa
        private void btnEDIT_QUANTITY_Click(object sender, EventArgs e)
        {
            string nameProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["TenHangHoa"].Value.ToString();
            int oldQuantity = Convert.ToInt32(dgvINFO_INVOICE.SelectedRows[0].Cells["SoLuong"].Value.ToString());
            string idProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            FrmEdit_Quantity frm = new FrmEdit_Quantity(idProduct, nameProduct, oldQuantity);
            frm.d += new FrmEdit_Quantity.myDEL(setNewQuantity);
            frm.Show();
        }

        private void btnDELETE_PRODUCT_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<string> listIdProduct = new List<string>();
            DataGridViewSelectedRowCollection data = dgvINFO_INVOICE.SelectedRows;
            foreach(DataGridViewRow dataGVR in data)
            {
                listIdProduct.Add(dataGVR.Cells["MaHangHoa"].Value.ToString());
            }
            foreach(string i in listIdProduct)
            {
                foreach(tblChiTietHoaDonBanHang invoiceDetail in DB.tblChiTietHoaDonBanHangs)
                {
                    if(invoiceDetail.MaHoaDonBan == idInvoice && invoiceDetail.MaHangHoa == i)
                    {
                        DB.tblChiTietHoaDonBanHangs.Remove(invoiceDetail);
                        var product = DB.tblHangHoas.Find(i);
                        product.SoLuong += (int)invoiceDetail.SoLuong;
                    }
                }
                DB.SaveChanges();
            }
            var invoice = DB.tblHoaDonBanHangs.Find(idInvoice);
            invoice.SoTien = BLL_LISTINVOICE.Instance.GetPriceInvoice(idInvoice);
            DB.SaveChanges();
            Show(idInvoice);
        }
    }
}
