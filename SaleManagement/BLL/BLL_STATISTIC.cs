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
        public int getTotalQuantityProduct(DateTime dateFrom, DateTime dateTo)
        {
            int quantity = 0;
            foreach (tblChiTietHoaDonBanHang invoiceDetail in getListInvoiceDetail(dateFrom, dateTo))
            {
                quantity += (int)invoiceDetail.SoLuong;
            }
            return quantity;
        }
        // get list invoice_detail
        public IQueryable<tblChiTietHoaDonBanHang> getListInvoiceDetail(DateTime dateFrom, DateTime dateTo)
        {
            return db.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateFrom && p.tblHoaDonBanHang.NgayBan <= dateTo);
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
        // get list invoice by year 
        public IQueryable<tblHoaDonBanHang> getListInvoiceByYear(int year)
        {
            return db.tblHoaDonBanHangs.Where(p => p.NgayBan.Value.Year == year);
        }
        // get list invoice by month in year
        public IQueryable<tblHoaDonBanHang> getListInvoiceByMonthInYear(int year, int month)
        {
            return db.tblHoaDonBanHangs.Where(p => p.NgayBan.Value.Year == year
            && p.NgayBan.Value.Month == month);
        }
        // get revenue in year
        public double getRevenueYear(int year, int month)
        {
            double revenue = 0;
            foreach (tblHoaDonBanHang invoice in getListInvoiceByYear(year))
            {
                if (invoice.NgayBan.Value.Month == month)
                {
                    revenue += (double)invoice.SoTien;
                }
            }
            return revenue;
        }
        // get revenue in month
        public double getRevenueMonth(int year, int month, int day)
        {
            double revenue = 0;
            foreach (tblHoaDonBanHang invoice in BLL_STATISTIC.instance.getListInvoiceByMonthInYear(year, month))
            {
                if (invoice.NgayBan.Value.Day == day)
                {
                    revenue += (double)invoice.SoTien;
                }
            }
            return revenue;
        }
        // get quantity of each type of product
        public int getQuantityOfEachTypeOfProduct(tblLoaiHangHoa typeOfProduct)
        {
            int quantity = 0;
            foreach (tblHangHoa product in db.tblHangHoas)
            {
                if (product.MaLoaiHangHoa == typeOfProduct.MaLoaiHangHoa)
                {
                    quantity += (int)product.SoLuong;
                }
            }
            return quantity;
        }
        // get sale quantity of each type of product
        public int getSellQuantityOfEachTypeOfProduct(tblLoaiHangHoa typeOfProduct, DateTime dateStart, DateTime dateEnd)
        {
            int selleQuantity = 0;   
            foreach (tblChiTietHoaDonBanHang invoiceDetail in getListInvoiceDetail(dateStart, dateEnd))
            {
                if (invoiceDetail.tblHangHoa.MaLoaiHangHoa == typeOfProduct.MaLoaiHangHoa)
                {
                    selleQuantity += (int)invoiceDetail.SoLuong;
                }
            }
            return selleQuantity;
        }
        // get sale money of each type of product
        public double getSellMoneyOfEachTypeOfProduct(tblLoaiHangHoa typeOfProduct, DateTime dateStart, DateTime dateEnd)
        {
            double sellMoney = 0;
            foreach (tblChiTietHoaDonBanHang invoiceDetail in getListInvoiceDetail(dateStart, dateEnd))
            {
                if (invoiceDetail.tblHangHoa.MaLoaiHangHoa == typeOfProduct.MaLoaiHangHoa)
                {
                    sellMoney += (double)invoiceDetail.TongTien;
                }
            }
            return sellMoney;
        }
        // get sell quantity of each product
        public int getSellQuantityOfEachProduct(tblHangHoa product, DateTime dateStart, DateTime dateEnd)
        {
            int sellQuantity = 0;
            foreach (tblChiTietHoaDonBanHang invoiceDetail in getListInvoiceDetail(dateStart, dateEnd))
            {
                if (invoiceDetail.MaHangHoa == product.MaHangHoa)
                {
                    sellQuantity += (int)invoiceDetail.SoLuong;
                }
            }
            return sellQuantity;
        }
        // get sell money of each product
        public double getSellMoneyOfEachProduct(tblHangHoa product, DateTime dateStart, DateTime dateEnd)
        {
            double sellMoney = 0;
            foreach (tblChiTietHoaDonBanHang invoiceDetail in getListInvoiceDetail(dateStart, dateEnd))
            {
                if (invoiceDetail.MaHangHoa == product.MaHangHoa)
                {
                    sellMoney += (double)invoiceDetail.TongTien;
                }
            }
            return sellMoney;
        }
    }
}
