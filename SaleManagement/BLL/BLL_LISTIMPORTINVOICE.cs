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
    class BLL_LISTIMPORTINVOICE
    {
        private SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        private static BLL_LISTIMPORTINVOICE _Instance;
        public static BLL_LISTIMPORTINVOICE Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_LISTIMPORTINVOICE();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_LISTIMPORTINVOICE() { }
        // get date in list invoice
        public DateTime getDate()
        {
            var getDate = DB.tblHoaDonNhapHangs.Min(p => p.NgayNhap);
            if (getDate == null)
            {
                return DateTime.Now;
            }
            else
            {
                return (DateTime)getDate;
            }
        }
        // get text for combobox (staff, supplier)
        public string getTextForCbb(string information, List<CBBItem> listCbb)
        {
            string text = null;
            foreach(CBBItem item in listCbb)
            {
                if(item.TEXT == information)
                {
                    text = item.ToString();
                    break;
                }
            }
            return text;
        }
        // load data for DGVs
        public void LoadDataFrmInvoice(DataGridView dgv, DateTime dateFrom, DateTime dateTo)
        {
            var invoice = DB.tblHoaDonNhapHangs.Where(p => p.NgayNhap >= dateFrom && p.NgayNhap <= dateTo).Select(p => new
            {
                p.MaHoaDonNhap,
                p.NgayNhap,
                p.tblNhaCungCap.TenNhaCungCap,
                p.tblNhanVien.TenNhanVien,
                p.GiamGia,
                p.SoTien
            });
            dgv.DataSource = invoice.ToList();
        }
        public void LoadDataFrmDetail(DataGridView dgv, string idInvoice)
        {
            var detail = DB.tblChiTietHoaDonNhapHangs.Where(p => p.MaHoaDonNhap == idInvoice).Select(p => new { 
                p.MaHangHoa,
                p.tblHangHoa.TenHangHoa,
                p.SoLuong,
                p.GiaNhap,
                p.TongTien
            });
            dgv.DataSource = detail.ToList();
        }
        // func search invoice
        public void FuncSearchInvoice(DataGridView dgv, DateTime dateFrom, DateTime dateTo, string information)
        {
            if(information == "Nhập mã hóa đơn hoặc mã/ tên nhà c.cấp" || String.IsNullOrEmpty(information))
            {
                LoadDataFrmInvoice(dgv, dateFrom, dateTo);
            }
            else
            {
                var invoice = DB.tblHoaDonNhapHangs.Where(p => p.MaHoaDonNhap.Contains(information)
                || p.MaNhaCungCap.Contains(information) || p.tblNhaCungCap.TenNhaCungCap.Contains(information)
                && p.NgayNhap >= dateFrom && p.NgayNhap <= dateTo).Select(p => new {
                    p.MaHoaDonNhap,
                    p.NgayNhap,
                    p.tblNhaCungCap.TenNhaCungCap,
                    p.tblNhanVien.TenNhanVien,
                    p.GiamGia,
                    p.SoTien
                });
                dgv.DataSource = invoice.ToList();
            }
        }
        // func edit invoice
        public void FuncEditInvoice(string idInvoice, DateTime dateChange, string idSupplier, string idStaff)
        {
            var invoice = DB.tblHoaDonNhapHangs.Find(idInvoice);
            invoice.NgayNhap = dateChange;
            invoice.MaNhanVien = idStaff;
            invoice.MaNhaCungCap = idSupplier;
            DB.SaveChanges();
        }
        // func delete invoie
        public void FuncDeleteInvoice(string idInvoice)
        {
            var listInvoiceDetail = DB.tblChiTietHoaDonNhapHangs.Where(p => p.MaHoaDonNhap == idInvoice).ToList();
            foreach (tblChiTietHoaDonNhapHang detail in listInvoiceDetail)
            {
                var product = DB.tblHangHoas.Find(detail.MaHangHoa);
                product.SoLuong -= (int)detail.SoLuong;
                DB.tblChiTietHoaDonNhapHangs.Remove(detail);
            }
            DB.tblHoaDonNhapHangs.Remove(DB.tblHoaDonNhapHangs.Find(idInvoice));
            DB.SaveChanges();
        }
        // Check quantity product InvoiceDetail in Invoice
        public bool isValidDeleteInvoice(string idInvoice)
        {
            bool isValid = true;
            var listInvoiceDetail = DB.tblChiTietHoaDonNhapHangs.Where(p => p.MaHoaDonNhap == idInvoice);
            foreach (tblChiTietHoaDonNhapHang invoiceDetail in listInvoiceDetail.ToList())
            {
                if(invoiceDetail.SoLuong > BLL_PRODUCT.Instance.getQuantityProductByIdProduct(invoiceDetail.MaHangHoa))
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
        // Check quantity product for delete product in InvoiceDetail
        public bool isValidDeleteProduct(string idInvoice, string idProduct)
        {
            bool isValid = true;
            var invoiceDetail = DB.tblChiTietHoaDonNhapHangs.Find(idInvoice, idProduct);
            var product = DB.tblHangHoas.Find(idProduct);
            if(invoiceDetail.SoLuong > product.SoLuong)
            {
                isValid = false;
            }
            return isValid;
        }
        public void FuncDeleteProduct(List<string> listIdProduct, string idInvoice)
        {
            foreach(string idProduct in listIdProduct)
            {
                tblChiTietHoaDonNhapHang invoiceDetail = DB.tblChiTietHoaDonNhapHangs.Where(p => p.MaHangHoa == idProduct
                && p.MaHoaDonNhap == idInvoice).SingleOrDefault();
                var product = DB.tblHangHoas.Find(idProduct);
                product.SoLuong -= (int)invoiceDetail.SoLuong;
                var invoice = DB.tblHoaDonNhapHangs.Find(idInvoice);
                invoice.SoTien -= (double)invoiceDetail.TongTien;
                DB.tblChiTietHoaDonNhapHangs.Remove(invoiceDetail);
                DB.SaveChanges();
            }
        }
        // add product
        public void FuncAddProduct(tblChiTietHoaDonNhapHang invoiceDetail, int discount)
        {
            DB.tblChiTietHoaDonNhapHangs.Add(invoiceDetail);
            var product = DB.tblHangHoas.Find(invoiceDetail.MaHangHoa);
            product.SoLuong += (int)invoiceDetail.SoLuong;
            var invoice = DB.tblHoaDonNhapHangs.Find(invoiceDetail.MaHoaDonNhap);
            invoice.GiamGia = discount * (invoice.SoTien + invoiceDetail.TongTien) / 100;
            invoice.SoTien = (invoice.SoTien + invoiceDetail.TongTien) - (discount * (invoice.SoTien + invoiceDetail.TongTien)/100);
            DB.SaveChanges();
        }
        // change quantity product
        public void ChangeQuantityProduct(string idInvoice, string idProduct, int oldQuantity, int newQuantity)
        {
            var product = DB.tblHangHoas.Find(idProduct);
            product.SoLuong = product.SoLuong + newQuantity - oldQuantity;
            //DB.SaveChanges();
            var invoiceDetail = DB.tblChiTietHoaDonNhapHangs.Find(idInvoice, idProduct);
            invoiceDetail.SoLuong = newQuantity;
            invoiceDetail.TongTien = (double)(invoiceDetail.GiaNhap * newQuantity);
            DB.SaveChanges();
            var importInvoice = DB.tblHoaDonNhapHangs.Find(idInvoice);
            importInvoice.SoTien = getPriceInvoice(idInvoice) - importInvoice.GiamGia;
            DB.SaveChanges();
        }
        // get price invoice;
        public double getPriceInvoice(string idInvoice)
        {
            double priceInvoice = 0;
            foreach(tblChiTietHoaDonNhapHang invoiceImport in DB.tblChiTietHoaDonNhapHangs)
            {
                if(invoiceImport.MaHoaDonNhap == idInvoice)
                {
                    priceInvoice += (double)invoiceImport.TongTien;
                }
            }
            return priceInvoice;
        }
        public int getQuantityInvoice(DataGridView dgv)
        {
            return dgv.Rows.Count;
        }
        // get total money
        public double getTotalMoney(DataGridView dgv)
        {
            double value = 0;
            foreach (DataGridViewRow dataRow in dgv.Rows)
            {
                value += Convert.ToDouble(dataRow.Cells["SoTien"].Value.ToString());
            }
            return value;
        }
    }
}
