using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_PRODUCER
    {
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        private static BLL_PRODUCER _Instance;
        public static BLL_PRODUCER Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_PRODUCER();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_PRODUCER() { }
        public List<CBBItem> getCbbProducer()
        {
            List<CBBItem> listProducer = new List<CBBItem>();
            foreach(tblNhaSanXuat producer in DB.tblNhaSanXuats)
            {
                listProducer.Add(new CBBItem { VALUE = producer.MaNhaSanXuat, TEXT = producer.TenNhaSanXuat });
            }
            return listProducer;
        }
        public void FuncAddProducer(tblNhaSanXuat producer)
        {
            DB.tblNhaSanXuats.Add(producer);
            DB.SaveChanges();
        }
        public string getNewIDProducer()
        {
            string idProducer;
            int lastId;
            List<tblNhaSanXuat> listIdProducer = DB.tblNhaSanXuats.ToList();
            if(listIdProducer == null)
            {
                idProducer = "NSX001";
            }
            else
            {
                lastId = Convert.ToInt32(listIdProducer[listIdProducer.Count - 1].MaNhaSanXuat.Remove(0, 3));
                if(lastId + 1 < 10)
                {
                    idProducer = "NSX00" + (lastId + 1);
                }
                else if(lastId + 1 < 100)
                {
                    idProducer = "NSX0" + (lastId + 1);
                }
                else
                {
                    idProducer = "NSX" + (lastId + 1);
                }
            }
            return idProducer;
        }
    }
}
