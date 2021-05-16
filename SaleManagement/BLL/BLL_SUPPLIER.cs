using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_SUPPLIER
    {
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        private static BLL_SUPPLIER _Instance;
        public static BLL_SUPPLIER Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_SUPPLIER();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_SUPPLIER() { }
        // add new supplier
        public void FuncAddNewSupplier(tblNhaCungCap supplier)
        {
            DB.tblNhaCungCaps.Add(supplier);
            DB.SaveChanges();
        }
        public string GetNewIdSupplier()
        {
            string idSupplier;
            List<tblNhaCungCap> list = DB.tblNhaCungCaps.ToList();
            if (list.Count == 0)
            {
                idSupplier = "NCC001";
            }
            else
            {
                int last = Convert.ToInt32(list[list.Count - 1].MaNhaCungCap.Remove(0, 3));
                if (last + 1 < 10)
                {
                    idSupplier = "NCC00" + (last + 1);
                }
                else if (last + 1 < 100)
                {
                    idSupplier = "NCC0" + (last + 1);
                }
                else
                {
                    idSupplier = "NCC" + (last + 1);
                }
            }
            return idSupplier;
        }
    }
}
