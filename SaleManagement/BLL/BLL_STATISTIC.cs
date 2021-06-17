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
        private SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
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
            return DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateFrom && p.tblHoaDonBanHang.NgayBan <= dateTo);
        }
        // get list product
        public IQueryable<tblHangHoa> getListProductByIdTypeOfProduct(string idTypeOfProduct)
        {
            return DB.tblHangHoas.Where(p => p.MaLoaiHangHoa == idTypeOfProduct);
        }
        // get list typeofproduct
        public IQueryable<tblLoaiHangHoa> getListTypeOfProduct()
        {
            return DB.tblLoaiHangHoas;
        }
        // get list product
        public IQueryable<tblHangHoa> getListProduct()
        {
            return DB.tblHangHoas;
        }
        // get list invoice by year 
        public IQueryable<tblHoaDonBanHang> getListInvoiceByYear(int year)
        {
            return DB.tblHoaDonBanHangs.Where(p => p.NgayBan.Value.Year == year);
        }
        // get list invoice by month in year
        public IQueryable<tblHoaDonBanHang> getListInvoiceByMonthInYear(int year, int month)
        {
            return DB.tblHoaDonBanHangs.Where(p => p.NgayBan.Value.Year == year
            && p.NgayBan.Value.Month == month);
        }
    }
}
