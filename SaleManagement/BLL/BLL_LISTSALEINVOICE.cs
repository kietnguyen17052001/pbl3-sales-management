using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_LISTSALEINVOICE
    {
        private SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        private static BLL_LISTSALEINVOICE _Instance;
        public static BLL_LISTSALEINVOICE Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_LISTSALEINVOICE();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_LISTSALEINVOICE() { }
        public DateTime getDate()
        {
            var getDate = DB.tblHoaDonBanHangs.Min(p => p.NgayBan);
            return (DateTime)getDate;
        }
        // load data for from Invoice
        public void LoadDataFrmInvoice(DataGridView dgv, DateTime dateFrom, DateTime dateTo)
        {
            var invoice = DB.tblHoaDonBanHangs.Where(p => p.NgayBan >= dateFrom && p.NgayBan <= dateTo).Select(p => new {
                p.MaHoaDonBan,
                p.NgayBan,
                p.tblNhanVien.TenNhanVien,
                p.tblKhachHang.TenKhachHang,
                p.SoTien,
                p.GiamGia
            });
            dgv.DataSource = invoice.ToList();
        }
        // load data for from Invoice_Detail
        public void LoadDataFrmDetail(DataGridView dgv, string idInvoice)
        {
            var detail = DB.tblChiTietHoaDonBanHangs.Where(p => p.MaHoaDonBan == idInvoice).Select(p => new {
                p.MaHangHoa,
                p.tblHangHoa.TenHangHoa,
                p.SoLuong,
                p.DonGia,
                p.GiamGia,
                p.TongTien
            });
            dgv.DataSource = detail.ToList();
        }
        // search invoice
        public void FuncSearchInvoice(DataGridView dgv, DateTime dateFrom, DateTime dateTo, string content)
        {
            if (content == "Nhập mã hóa đơn hoặc mã/ tên khách hàng" || String.IsNullOrEmpty(content))
            {
                LoadDataFrmInvoice(dgv, dateFrom, dateTo);
            }
            else
            {
                var listInvoice = DB.tblHoaDonBanHangs.Where(p => p.MaHoaDonBan.Contains(content) || p.MaKhachHang.Contains(content)
                || p.tblKhachHang.TenKhachHang.Contains(content) && p.NgayBan >= dateFrom && p.NgayBan <= dateTo).Select(p => new {
                    p.MaHoaDonBan,
                    p.NgayBan,
                    p.tblNhanVien.TenNhanVien,
                    p.tblKhachHang.TenKhachHang,
                    p.SoTien,
                    p.GiamGia
                });
                dgv.DataSource = listInvoice.ToList();
            }
        }
        // edit invoice
        public void FuncEditInvoice(string idInvoice, DateTime dateChange, string idStaff, string idCustomer)
        {
            var getInvoice = DB.tblHoaDonBanHangs.Find(idInvoice);
            getInvoice.NgayBan = dateChange;
            getInvoice.MaNhanVien = idStaff;
            getInvoice.MaKhachHang = idCustomer;
            DB.SaveChanges();
        }
        public void FuncDeleteInvoice(List<string> listIdInvoice)
        {
            foreach (string idInvoice in listIdInvoice)
            {
                foreach (tblHoaDonBanHang invoice in DB.tblHoaDonBanHangs) // xóa đơn hàng có mã đơn = i
                {
                    if (invoice.MaHoaDonBan == idInvoice)
                    {
                        DB.tblHoaDonBanHangs.Remove(invoice);
                        foreach (tblChiTietHoaDonBanHang invoiceDetail in DB.tblChiTietHoaDonBanHangs) // xóa chi tiết đơn hàng có mã đơn = i
                        {
                            if (invoiceDetail.MaHoaDonBan == idInvoice)
                            {
                                DB.tblChiTietHoaDonBanHangs.Remove(invoiceDetail);
                                var product = DB.tblHangHoas.Find(invoiceDetail.MaHangHoa);
                                product.SoLuong += (int)invoiceDetail.SoLuong;
                            }
                        }
                    }
                }
                DB.SaveChanges();
            }
        }
        // delete product - invoice 
        public void FuncDeleteProduct(List<string> listIdProduct, string idInvoice)
        {
            foreach (string idProduct in listIdProduct)
            {
                foreach (tblChiTietHoaDonBanHang invoiceDetail in DB.tblChiTietHoaDonBanHangs)
                {
                    if (invoiceDetail.MaHoaDonBan == idInvoice && invoiceDetail.MaHangHoa == idProduct)
                    {
                        DB.tblChiTietHoaDonBanHangs.Remove(invoiceDetail);
                        var product = DB.tblHangHoas.Find(idProduct);
                        product.SoLuong += (int)invoiceDetail.SoLuong;
                        var invoice = DB.tblHoaDonBanHangs.Find(idInvoice);
                        invoice.SoTien -= (double)invoiceDetail.TongTien;
                    }
                }
                DB.SaveChanges();
            }
        }
        // get text for combobox (staff, customer)
        public string getTextForCbb(string information, List<CBBItem> listCbb)
        {
            string text = null;
            foreach (CBBItem item in listCbb)
            {
                if (item.TEXT == information)
                {
                    text = item.ToString();
                    break;
                }
            }
            return text;
        }
        // set new quantity for product 
        public void ChangeQuantityProduct(int quantityProduct, int newQuantity, string idInvoice, string idProduct)
        {
            var getInvoiceDetail = DB.tblChiTietHoaDonBanHangs.Find(idInvoice, idProduct);
            getInvoiceDetail.SoLuong = newQuantity;
            getInvoiceDetail.TongTien = getInvoiceDetail.DonGia * newQuantity - getInvoiceDetail.DonGia * newQuantity * getInvoiceDetail.GiamGia / 100; // thay đổi số tiền của chi tiết hóa đơn sau khi thay đổi số lượng mới
            var product = DB.tblHangHoas.Find(idProduct);
            product.SoLuong += (quantityProduct - newQuantity);
            DB.SaveChanges();
            var getInvoice = DB.tblHoaDonBanHangs.Find(idInvoice);
            getInvoice.SoTien = BLL_LISTSALEINVOICE.Instance.getPriceInvoice(idInvoice) - getInvoice.GiamGia;
            DB.SaveChanges();
        }
        public double getPriceInvoice(string idInvoice)
        {
            double price = 0;
            foreach(tblChiTietHoaDonBanHang invoiceDetail in DB.tblChiTietHoaDonBanHangs)
            {
                if (invoiceDetail.MaHoaDonBan == idInvoice)
                {
                    price += Convert.ToDouble(invoiceDetail.TongTien);
                }
            }
            return price;
        }
    }
}
