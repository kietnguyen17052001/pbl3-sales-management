using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_LISTINVOICE
    {
        private static BLL_LISTINVOICE _Instance;
        public static BLL_LISTINVOICE Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_LISTINVOICE();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_LISTINVOICE() { }
        public string GetStaff(string nameStaff)
        {
            string staff = "";
            foreach(CBBItem cbbitem in BLL_CREATEINVOICE.Instance.GetCbb_Staff())
            {
                if(cbbitem.TEXT == nameStaff)
                {
                    staff = cbbitem.ToString();
                    break;
                }
            }
            return staff;
        }
        public string GetCustomer(string nameCustomer)
        {
            string customer = "";
            foreach (CBBItem cbbitem in BLL_CREATEINVOICE.Instance.GetCbb_Customer())
            {
                if (cbbitem.TEXT == nameCustomer)
                {
                    customer = cbbitem.ToString();
                    break;
                }
            }
            return customer;
        }
        public double GetPriceInvoice(string idInvoice)
        {
            double price = 0;
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
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
