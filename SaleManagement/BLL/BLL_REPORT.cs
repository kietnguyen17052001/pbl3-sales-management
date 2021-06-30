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
        private N3KTeamEntities db = new N3KTeamEntities();
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
        // load data report
        public void LoadDataReport(DataGridView dgv, DateTime dateFrom, DateTime dateTo)
        {
            var invoiceDetail = db.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateFrom && p.tblHoaDonBanHang.NgayBan <= dateTo).Select(p => new {
                p.MaHangHoa,
                p.tblHangHoa.TenHangHoa,
                p.tblHoaDonBanHang.NgayBan,
                p.tblHoaDonBanHang.tblKhachHang.TenKhachHang,
                p.SoLuong,
                p.DonGia,
                p.GiamGia,
                p.TongTien
            });
            dgv.DataSource = invoiceDetail.ToList();
        }
        // doanh số
        public double getRevenue(DateTime dateStart, DateTime dateEnd)
        {
            var listInvoiceDetail = db.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateStart && p.tblHoaDonBanHang.NgayBan <= dateEnd);
            double revenue = 0;
            foreach (tblChiTietHoaDonBanHang invoiceDetail in listInvoiceDetail)
            {
                revenue += (double)invoiceDetail.TongTien;
            }
            return revenue;
        }
        // lợi nhuận
        public double getProfit(DateTime dateStart, DateTime dateEnd)
        {
            var listInvoiceDetail = db.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateStart && p.tblHoaDonBanHang.NgayBan <= dateEnd);
            double profit = 0;
            foreach (tblChiTietHoaDonBanHang invoiceDetail in listInvoiceDetail)
            {
                profit += (double)(invoiceDetail.TongTien - invoiceDetail.SoLuong * invoiceDetail.tblHangHoa.GiaNhap);
            }
            return profit;
        }
        // giảm giá
        public double getDiscount(DateTime dateStart, DateTime dateEnd)
        {
            var listInvoiceDetail = db.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateStart && p.tblHoaDonBanHang.NgayBan <= dateEnd);
            double discount = 0;
            foreach (tblChiTietHoaDonBanHang invoiceDetail in listInvoiceDetail)
            {
                discount += (double)((invoiceDetail.GiamGia / 100) * (invoiceDetail.DonGia * invoiceDetail.SoLuong));
            }
            return discount;
        }
        // sản phẩm
        public int getQuantity(DateTime dateStart, DateTime dateEnd)
        {
            var listInvoiceDetail = db.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateStart && p.tblHoaDonBanHang.NgayBan <= dateEnd);
            int quantity = 0;
            foreach (tblChiTietHoaDonBanHang invoiceDetail in listInvoiceDetail)
            {
                quantity += (int)invoiceDetail.SoLuong;
            }
            return quantity;
        }
        // hóa đơn
        public int getInvoice(DateTime dateStart, DateTime dateEnd)
        {
            var listInvoice = db.tblHoaDonBanHangs.Where(p => p.NgayBan >= dateStart && p.NgayBan <= dateEnd);
            return listInvoice.Count();
        }
    }
}
