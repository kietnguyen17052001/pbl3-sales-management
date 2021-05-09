using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_ITEMS
    {
        private static BLL_ITEMS _Instance;
        public static BLL_ITEMS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ITEMS();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_ITEMS(){}
        // Lấy danh sách loại hàng hóa đổ vào CBB
        public List<CBBItem> GetCBBTypeProduct()
        {
            List<CBBItem> list = new List<CBBItem>();
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            foreach(tblLoaiHangHoa typeProduct in DB.tblLoaiHangHoas)
            {
                list.Add(new CBBItem { VALUE = typeProduct.MaLoaiHangHoa, TEXT = typeProduct.TenLoaiHangHoa });
            }
            return list;
        }
        // Lấy danh sách nhà cung cấp đổ vào CBB
        public List<CBBItem> GetCBBSupplier()
        {
            List<CBBItem> list = new List<CBBItem>();
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            foreach (tblNhaCungCap supplier in DB.tblNhaCungCaps)
            {
                list.Add(new CBBItem { VALUE = supplier.MaNhaCungCap, TEXT = supplier.TenNhaCungCap });
            }
            return list;
        }
        // Lấy danh sách nhà sản xuất đổ vào CBB
        public List<CBBItem> GetCBBProducer()
        {
            List<CBBItem> list = new List<CBBItem>();
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            foreach (tblNhaSanXuat producer in DB.tblNhaSanXuats)
            {
                list.Add(new CBBItem { VALUE = producer.MaNhaSanXuat, TEXT = producer.TenNhaSanXuat });
            }
            return list;
        }
        // Trả về mã hàng hóa mới khi thực hiện chức năng thêm 
        public string GetNewIdProduct(string ITEM)
        {
            int id, lastId; // last: kí tự cuối trong mã hàng hóa, vd BG1 -> 1
            string first = ""; // fisrt: 2 kí tự đầu trong mã loại hàng hóa, vd BG0X -> BG 
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<string> listSaveId = new List<string>();
            foreach (tblHangHoa HANGHOA in DB.tblHangHoas)
            {
                if (HANGHOA.MaLoaiHangHoa == ITEM)
                {
                    listSaveId.Add(HANGHOA.MaHangHoa);
                }
            }
            if (listSaveId.Count == 0)
            {
                id = 1;
            }
            else
            {
                lastId = Convert.ToInt32(listSaveId[listSaveId.Count -1 ].Substring(listSaveId[listSaveId.Count - 1].Length - 1)); // số cuối trong mã hàng hóa
                first = listSaveId[listSaveId.Count - 1].Remove(listSaveId[listSaveId.Count - 1].LastIndexOf(lastId.ToString()), 1);
                id = lastId + 1;
            }
            return first + id;
        }
        //Trả về loại hàng hóa, nhà cung cấp, nhà sản xuất từ dgvITEMS
        public string GetText(string name, List<CBBItem> list)
        {
            string typeOfProduct = "";
            foreach (CBBItem product in list)
            {
                if (product.TEXT == name)
                {
                    typeOfProduct = product.ToString();
                }
            }
            return typeOfProduct;
        }
    }
}
