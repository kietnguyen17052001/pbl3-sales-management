using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_ITEMS
    {
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
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
            foreach (tblNhaSanXuat producer in DB.tblNhaSanXuats)
            {
                list.Add(new CBBItem { VALUE = producer.MaNhaSanXuat, TEXT = producer.TenNhaSanXuat });
            }
            return list;
        }
        // add new product
        public void FuncAddNewProduct(tblHangHoa product)
        {
            DB.tblHangHoas.Add(product);
            DB.SaveChanges();
        }
        // edit product
        public void FuncEditProduct(tblHangHoa product)
        {
            var getProduct = DB.tblHangHoas.Find(product.MaHangHoa);
            getProduct.TenHangHoa = product.TenHangHoa;
            getProduct.SoLuong = product.SoLuong;
            getProduct.GiaBan = product.GiaBan;
            getProduct.GiaNhap = product.GiaNhap;
            getProduct.MaLoaiHangHoa = product.MaLoaiHangHoa;
            getProduct.MaNhaCungCap = product.MaNhaCungCap;
            getProduct.MaNhaSanXuat = product.MaNhaSanXuat;
            //getProduct.HinhAnh = product.HinhAnh;
            DB.SaveChanges();
        }
        // delete product
        public void FuncDeleteProduct(List<string> listIdProduct)
        {
            foreach (string i in listIdProduct)
            {
                foreach (tblHangHoa product in DB.tblHangHoas)
                {
                    if (product.MaHangHoa == i)
                    {
                        DB.tblHangHoas.Remove(product);
                    }
                }
                DB.SaveChanges();
            }
        }
        // search name
        public void FuncSearchName(DataGridView dgv, string name)
        {
            var getProduct = DB.tblHangHoas.Where(p => p.TenHangHoa.Contains(name)).Select(p => new
            {
                p.MaHangHoa,
                p.TenHangHoa,
                p.SoLuong,
                p.tblLoaiHangHoa.TenLoaiHangHoa,
                p.tblNhaCungCap.TenNhaCungCap,
                p.tblNhaSanXuat.TenNhaSanXuat,
                p.GiaNhap,
                p.GiaBan,
            });
            dgv.DataSource = getProduct.ToList();
        }
        // search id
        public void FuncSearchId(DataGridView dgv, string id)
        {
            var getProduct = DB.tblHangHoas.Where(p => p.MaHangHoa.Contains(id)).Select(p => new
            {
                p.MaHangHoa,
                p.TenHangHoa,
                p.SoLuong,
                p.tblLoaiHangHoa.TenLoaiHangHoa,
                p.tblNhaCungCap.TenNhaCungCap,
                p.tblNhaSanXuat.TenNhaSanXuat,
                p.GiaNhap,
                p.GiaBan,
            });
            dgv.DataSource = getProduct.ToList();
        }
        // Trả về mã hàng hóa mới khi thực hiện chức năng thêm 
        public string GetNewIdProduct(string idTypeProduct)
        {
            string idProduct = "";
            int last; // số cuối trong mã
            List<string> listSaveId = new List<string>();
            foreach (tblHangHoa HANGHOA in DB.tblHangHoas)
            {
                if (HANGHOA.MaLoaiHangHoa == idTypeProduct)
                {
                    listSaveId.Add(HANGHOA.MaHangHoa);
                }
            }
            
            int index = idTypeProduct.IndexOf("0"); // xác định vị trí của số 0 trong mã loại hàng hóa
            idTypeProduct = idTypeProduct.Remove(index, 2); // xác từ số 0 2 kí tự : BG0X --> BG
            if (listSaveId.Count == 0)
            {
                idProduct = idTypeProduct + "0001";
            }
            else
            {
                string lastNum = listSaveId[listSaveId.Count - 1];
                last = Convert.ToInt32(lastNum.Substring(lastNum.Length - 1));
                if (last + 1 < 10)
                {
                    idProduct = idTypeProduct + "000" + (last + 1);
                }
                else if (last + 1 < 100)
                {
                    idProduct = idTypeProduct + "00" + (last + 1);
                }
                else if (last + 1 < 1000)
                {
                    idProduct = idTypeProduct + "0" + (last + 1);
                }
            }
            return idProduct;
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
