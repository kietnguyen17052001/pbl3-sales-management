using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_LISTIMPORTINVOICE
    {
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
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
            DateTime date = new DateTime();
            var dateMin = DB.tblHoaDonNhapHangs.Min(p => p.NgayNhap);
            date = dateMin.Value;
            return date;
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
            if(information == "Nhập mã hóa đơn hoặc mã/ tên nhà c.cấp" || string.IsNullOrEmpty(information))
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
        public void FuncDeleteInvoice(List<string> listIdInvoice)
        {
            foreach(string idInvoice in listIdInvoice)
            {
                foreach(tblHoaDonNhapHang invoice in DB.tblHoaDonNhapHangs)
                {
                    if(invoice.MaHoaDonNhap == idInvoice)
                    {
                        DB.tblHoaDonNhapHangs.Remove(invoice);
                        foreach(tblChiTietHoaDonNhapHang detail in DB.tblChiTietHoaDonNhapHangs)
                        {
                            if(detail.MaHoaDonNhap == idInvoice)
                            {
                                DB.tblChiTietHoaDonNhapHangs.Remove(detail);
                                var product = DB.tblHangHoas.Find(detail.MaHangHoa);
                                product.SoLuong -= (int)detail.SoLuong;
                            }
                        }
                    }
                }
                DB.SaveChanges();
            }
        }
        public void FuncDeleteProduct(List<string> listIdProduct, string idInvoice)
        {
            foreach(string idProduct in listIdProduct)
            {
                foreach(tblChiTietHoaDonNhapHang detail in DB.tblChiTietHoaDonNhapHangs)
                {
                    if(detail.MaHoaDonNhap == idInvoice && detail.MaHangHoa == idProduct)
                    {
                        DB.tblChiTietHoaDonNhapHangs.Remove(detail);
                        var product = DB.tblHangHoas.Find(idProduct);
                        product.SoLuong -= (int)detail.SoLuong;
                        var invoice = DB.tblHoaDonNhapHangs.Find(idInvoice);
                        invoice.SoTien -= (double)detail.TongTien;
                    }
                }
                DB.SaveChanges();
            }
        }
    }
}
