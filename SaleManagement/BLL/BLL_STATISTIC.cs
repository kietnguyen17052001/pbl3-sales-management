using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_STATISTIC
    {
        private N3KTeamEntities db = new N3KTeamEntities();
        private static BLL_STATISTIC _instance;
        public static BLL_STATISTIC instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BLL_STATISTIC();
                }
                return _instance;
            }
            private set { }
        }
        private BLL_STATISTIC(){}
        // get quantity product in database dFrom->dTo
        public int getTotalQuantityProductSold(DateTime dateStart, DateTime dateEnd)
        {
            int quantity = Convert.ToInt32(getListInvoiceDetail(dateStart, dateEnd).Sum(p => p.SoLuong));
            return quantity;
        }
        // get list invoice_detail
        public IQueryable<tblChiTietHoaDonBanHang> getListInvoiceDetail(DateTime dateStart, DateTime dateEnd)
        {
            return db.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateStart && p.tblHoaDonBanHang.NgayBan <= dateEnd);
        }
        // get list product
        public IQueryable<tblHangHoa> getListProductByIdTypeOfProduct(string idTypeOfProduct)
        {
            return db.tblHangHoas.Where(p => p.MaLoaiHangHoa == idTypeOfProduct);
        }
        // get list typeofproduct
        public IQueryable<tblLoaiHangHoa> getListTypeOfProduct()
        {
            return db.tblLoaiHangHoas;
        }
        // get revenue in year
        public double getRevenueYear(int year, int month)
        {
            double revenue = Convert.ToDouble(db.tblHoaDonBanHangs.Where(p => p.NgayBan.Value.Year == year
            && p.NgayBan.Value.Month == month).Sum(p => p.SoTien));
            return revenue;
        }
        // get revenue in month
        public double getRevenueMonth(int year, int month, int day)
        {
            double revenue = Convert.ToDouble(db.tblHoaDonBanHangs.Where(p => p.NgayBan.Value.Year == year
            && p.NgayBan.Value.Month == month && p.NgayBan.Value.Day == day).Sum(p => p.SoTien));
            return revenue;
        }
        // get quantity of each type of product
        public int getQuantityOfEachTypeOfProduct(tblLoaiHangHoa typeOfProduct)
        {
            int quantity = Convert.ToInt32(db.tblHangHoas.Where(
                p => p.MaLoaiHangHoa == typeOfProduct.MaLoaiHangHoa).Sum(p => p.SoLuong));
            return quantity;
        }
        // get sale quantity of each type of product
        public int getSellQuantityOfEachTypeOfProduct(tblLoaiHangHoa typeOfProduct, DateTime dateStart, DateTime dateEnd)
        {
            int sellQuantity = Convert.ToInt32(getListInvoiceDetail(dateStart, dateEnd).Where(
                p => p.tblHangHoa.MaLoaiHangHoa == typeOfProduct.MaLoaiHangHoa).Sum(p => p.SoLuong));
            return sellQuantity;
        }
        // get sale money of each type of product
        public double getSellMoneyOfEachTypeOfProduct(tblLoaiHangHoa typeOfProduct, DateTime dateStart, DateTime dateEnd)
        {
            double sellMoney = Convert.ToDouble(getListInvoiceDetail(dateStart, dateEnd).Where(
                p => p.tblHangHoa.MaLoaiHangHoa == typeOfProduct.MaLoaiHangHoa).Sum(p => p.TongTien));
            return sellMoney;
        }
        // get sell quantity of each product
        public int getSellQuantityOfEachProduct(tblHangHoa product, DateTime dateStart, DateTime dateEnd)
        {
            int sellQuantity = Convert.ToInt32(getListInvoiceDetail(dateStart, dateEnd).Where(
                p => p.MaHangHoa == product.MaHangHoa).Sum(p => p.SoLuong));
            return sellQuantity;
        }
        // get sell money of each product
        public double getSellMoneyOfEachProduct(tblHangHoa product, DateTime dateStart, DateTime dateEnd)
        {
            double sellMoney = Convert.ToDouble(getListInvoiceDetail(dateStart, dateEnd).Where(
                p => p.MaHangHoa == product.MaHangHoa).Sum(p => p.TongTien));
            return sellMoney;
        }
    }
}
