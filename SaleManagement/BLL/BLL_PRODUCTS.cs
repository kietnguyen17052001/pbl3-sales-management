using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_PRODUCTS
    {
        private SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        private static BLL_PRODUCTS _Instance;
        public static BLL_PRODUCTS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_PRODUCTS();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_PRODUCTS(){}
        // Lấy danh sách loại hàng hóa đổ vào CBB
        public List<CBBItem> getCBBTypeProduct()
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach(tblLoaiHangHoa typeProduct in DB.tblLoaiHangHoas)
            {
                list.Add(new CBBItem { VALUE = typeProduct.MaLoaiHangHoa, TEXT = typeProduct.TenLoaiHangHoa });
            }
            return list;
        }
        // load data product
        public void LoadDataProduct(DataGridView dgv)
        {
            var product = DB.tblHangHoas.Select(p => new
            {
                p.MaHangHoa,
                p.TenHangHoa,
                p.SoLuong,
                p.tblLoaiHangHoa.TenLoaiHangHoa,
                p.tblNhaSanXuat.TenNhaSanXuat,
                p.GiaNhap,
                p.GiaBan,
                p.MoTa
            });
            dgv.DataSource = product.ToList();
        }
        public Image ByteArrayToImage(byte[] byArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        public Image image(string idProduct)
        {
            var imageProduct = DB.tblHangHoas.Find(idProduct);
            return ByteArrayToImage(imageProduct.HinhAnh.ToArray());
        }
        // add pic
        public void FuncAddPicProduct()
        {
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
        // search product
        public void FuncSearchProduct(DataGridView dgv, string information)
        {
            if (information == "Nhập mã hoặc tên hàng hóa, loại hàng hóa" || String.IsNullOrEmpty(information))
            {
                LoadDataProduct(dgv);
            }
            else
            {
                var getProduct = DB.tblHangHoas.Where(p => p.TenHangHoa.Contains(information) || p.MaHangHoa.Contains(information)
                || p.tblLoaiHangHoa.TenLoaiHangHoa.Contains(information)).Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.tblLoaiHangHoa.TenLoaiHangHoa,
                    p.tblNhaSanXuat.TenNhaSanXuat,
                    p.GiaNhap,
                    p.GiaBan,
                    p.MoTa
                });
                dgv.DataSource = getProduct.ToList();
            }
        }
        // Trả về mã hàng hóa mới khi thực hiện chức năng thêm 
        public string getNewIdProduct(string idTypeProduct)
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
                last = Convert.ToInt32(listSaveId[listSaveId.Count - 1].Replace(idTypeProduct,""));
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
        // get quantity product in database
        public int getQuantityProduct(DataGridView dgv)
        {
            return dgv.Rows.Count;
        }
        // get quantity product by idProduct
        public int getQuantityProductByIdProduct(string idProduct)
        {
            var value = DB.tblHangHoas.Find(idProduct);
            return value.SoLuong;
        }
        //Trả về loại hàng hóa, nhà cung cấp, nhà sản xuất từ dgvITEMS
        public string getText(string name, List<CBBItem> list)
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
