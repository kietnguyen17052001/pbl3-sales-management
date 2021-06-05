using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_REPORT
    {
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        private static BLL_REPORT _Instance;
        public static BLL_REPORT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_REPORT();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_REPORT() { }
        // get date min in invoice
        public DateTime getDateMin()
        {
            var getDate = DB.tblHoaDonBanHangs.Min(p => p.NgayBan);
            return (DateTime)getDate;
        }
        // load data report
        public void LoadDataReport(DataGridView dgv, DateTime dateFrom, DateTime dateTo)
        {
            var listReport = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateFrom && p.tblHoaDonBanHang.NgayBan <= dateTo).Select(p => new {
                p.MaHangHoa,
                p.tblHangHoa.TenHangHoa,
                p.tblHoaDonBanHang.NgayBan,
                p.tblHoaDonBanHang.tblKhachHang.TenKhachHang,
                p.SoLuong,
                p.DonGia,
                p.GiamGia,
                p.TongTien
            });
            dgv.DataSource = listReport.ToList();
        }
        // doanh số
        public double getRevenue(DateTime dateMin, DateTime dateMax)
        {
            var list = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateMin && p.tblHoaDonBanHang.NgayBan <= dateMax);
            double revenue = 0;
            foreach (tblChiTietHoaDonBanHang invoice_detail in list)
            {
                revenue += (double)invoice_detail.TongTien;
            }
            return revenue;
        }
        // lợi nhuận
        public double getProfit(DateTime dateMin, DateTime dateMax)
        {
            var list = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateMin && p.tblHoaDonBanHang.NgayBan <= dateMax);
            double profit = 0;
            foreach (tblChiTietHoaDonBanHang invoice_detail in list)
            {
                profit += (double)(invoice_detail.TongTien - invoice_detail.SoLuong * invoice_detail.tblHangHoa.GiaNhap);
            }
            return profit;
        }
        // giảm giá
        public double getDiscount(DateTime dateMin, DateTime dateMax)
        {
            var list = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateMin && p.tblHoaDonBanHang.NgayBan <= dateMax);
            double discount = 0;
            foreach (tblChiTietHoaDonBanHang invoice_detail in list)
            {
                discount += (double)((invoice_detail.GiamGia / 100) * (invoice_detail.DonGia * invoice_detail.SoLuong));
            }
            return discount;
        }
        // sản phẩm
        public int getQuantity(DateTime dateMin, DateTime dateMax)
        {
            var list = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateMin && p.tblHoaDonBanHang.NgayBan <= dateMax);
            int quantity = 0;
            foreach (tblChiTietHoaDonBanHang invoice_detail in list)
            {
                quantity += (int)invoice_detail.SoLuong;
            }
            return quantity;
        }
        // hóa đơn
        public int getInvoice(DateTime dateMin, DateTime dateMax)
        {
            var list = DB.tblHoaDonBanHangs.Where(p => p.NgayBan >= dateMin && p.NgayBan <= dateMax);
            int count = 0;
            foreach (tblHoaDonBanHang invoice in list)
            {
                count++;
            }
            return count;
        }
    }
}
