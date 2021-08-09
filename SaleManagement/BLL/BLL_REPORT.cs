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
        public void LoadDataReport(DataGridView dgv, DateTime dateStart, DateTime dateEnd)
        {
            var invoiceDetail = db.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateStart && p.tblHoaDonBanHang.NgayBan <= dateEnd).Select(p => new {
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
        public IQueryable<tblChiTietHoaDonBanHang> getListInvoiceDetail(DateTime dateStart, DateTime dateEnd)
        {
            return db.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateStart && p.tblHoaDonBanHang.NgayBan <= dateEnd);
        }
        // doanh số
        public double getRevenue(DateTime dateStart, DateTime dateEnd)
        {
            double revenue = Convert.ToDouble(getListInvoiceDetail(dateStart, dateEnd).Sum(p => p.TongTien));
            return revenue;
        }
        // lợi nhuận
        public double getProfit(DateTime dateStart, DateTime dateEnd)
        {
            double profit = 0;
            foreach (tblChiTietHoaDonBanHang invoiceDetail in getListInvoiceDetail(dateStart, dateEnd))
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
            int quantity = Convert.ToInt32(getListInvoiceDetail(dateStart, dateEnd).Sum(p => p.SoLuong));
            return quantity;
        }
        // hóa đơn
        public int getInvoice(DateTime dateStart, DateTime dateEnd)
        {
            return getListInvoiceDetail(dateStart, dateEnd).Count();
        }
    }
}
