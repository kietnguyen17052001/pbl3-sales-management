using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        // doanh số
        public double GetRevenue(DateTime dateMin, DateTime dateMax)
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
        public double GetProfit(DateTime dateMin, DateTime dateMax)
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
        public double GetDiscount(DateTime dateMin, DateTime dateMax)
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
        public int GetQuantity(DateTime dateMin, DateTime dateMax)
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
        public int GetInvoice(DateTime dateMin, DateTime dateMax)
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
