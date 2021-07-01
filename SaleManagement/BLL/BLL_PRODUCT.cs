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
    class BLL_PRODUCT
    {
        private N3KTeamEntities db = new N3KTeamEntities();
        private static BLL_PRODUCT _Instance;
        public static BLL_PRODUCT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_PRODUCT();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_PRODUCT(){}
        // Lấy danh sách loại hàng hóa đổ vào CBB
        public List<CBBItem> getCBBTypeProduct()
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach(tblLoaiHangHoa typeProduct in db.tblLoaiHangHoas)
            {
                list.Add(new CBBItem { VALUE = typeProduct.MaLoaiHangHoa, TEXT = typeProduct.TenLoaiHangHoa });
            }
            return list;
        }
        // load data product
        public void LoadDataProduct(DataGridView dgv)
        {
            var product = db.tblHangHoas.Select(p => new
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
        // load data product in form AddProduct_Invoice
        public void LoadDataProductInFrmAddProduct(DataGridView dgv, bool isListSale)
        {
            if (isListSale) // for FrmListSaleProduct
            {
                var product = db.tblHangHoas.Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.GiaBan
                });
                dgv.DataSource = product.ToList();
            }
            else // for FrmListImportProduct
            {
                var product = db.tblHangHoas.Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.GiaNhap
                });
                dgv.DataSource = product.ToList();
            }
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
            var imageProduct = db.tblHangHoas.Find(idProduct);
            return ByteArrayToImage(imageProduct.HinhAnh.ToArray());
        }
        // add new product
        public void FuncAddNewProduct(tblHangHoa product)
        {
            db.tblHangHoas.Add(product);
            db.SaveChanges();
        }
        // edit product
        public void FuncEditProduct(tblHangHoa _product)
        {
            var product = db.tblHangHoas.Find(_product.MaHangHoa);
            product.TenHangHoa = _product.TenHangHoa;
            product.SoLuong = _product.SoLuong;
            product.GiaBan = _product.GiaBan;
            product.GiaNhap = _product.GiaNhap;
            product.MaLoaiHangHoa = _product.MaLoaiHangHoa;
            product.MaNhaSanXuat = _product.MaNhaSanXuat;
            product.MoTa = _product.MoTa;
            db.SaveChanges();
        }
        // delete product
        public void FuncDeleteProduct(List<string> listIdProduct)
        {
            var product = new tblHangHoa();
            foreach (string idProduct in listIdProduct)
            {
                product = db.tblHangHoas.Find(idProduct);
                db.tblHangHoas.Remove(product);
                db.SaveChanges();
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
                var product = db.tblHangHoas.Where(p => p.TenHangHoa.Contains(information) || p.MaHangHoa.Contains(information)
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
                dgv.DataSource = product.ToList();
            }
        }
        // search product in form AddProduct
        public void FuncSearchProductInFrmAddProduct(DataGridView dgv, string information, bool isListSale)
        {
            if (information == "Nhập mã hoặc tên hàng hóa, loại hàng hóa" || String.IsNullOrEmpty(information))
            {
                LoadDataProductInFrmAddProduct(dgv, isListSale);
            }
            else
            {
                if (isListSale)
                {
                    var product = db.tblHangHoas.Where(p => p.TenHangHoa.Contains(information) || p.MaHangHoa.Contains(information)
                    || p.tblLoaiHangHoa.TenLoaiHangHoa.Contains(information)).Select(p => new
                    {
                        p.MaHangHoa,
                        p.TenHangHoa,
                        p.SoLuong,
                        p.GiaBan,
                    });
                    dgv.DataSource = product.ToList();
                }
                else
                {
                    var product = db.tblHangHoas.Where(p => p.TenHangHoa.Contains(information) || p.MaHangHoa.Contains(information)
                    || p.tblLoaiHangHoa.TenLoaiHangHoa.Contains(information)).Select(p => new
                    {
                        p.MaHangHoa,
                        p.TenHangHoa,
                        p.SoLuong,
                        p.GiaNhap,
                    });
                    dgv.DataSource = product.ToList();
                }
            }
        }
        // Trả về mã hàng hóa mới khi thực hiện chức năng thêm 
        public string getNewIdProduct(string idTypeProduct)
        {
            string idProduct = "";
            int last; // số cuối trong mã
            List<string> listIdProduct = new List<string>();
            foreach (tblHangHoa product in db.tblHangHoas)
            {
                if (product.MaLoaiHangHoa == idTypeProduct)
                {
                    listIdProduct.Add(product.MaHangHoa);
                }
            }
            
            int index = idTypeProduct.IndexOf("0"); // xác định vị trí của số 0 trong mã loại hàng hóa
            idTypeProduct = idTypeProduct.Remove(index, 2); // xác từ số 0 2 kí tự : BG0X --> BG
            if (listIdProduct.Count == 0)
            {
                idProduct = idTypeProduct + "0001";
            }
            else
            {
                last = Convert.ToInt32(listIdProduct[listIdProduct.Count - 1].Replace(idTypeProduct,""));
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
        public int getQuantityProductByIdProduct(string idProduct)
        {
            var product = db.tblHangHoas.Find(idProduct);
            return (int)product.SoLuong;
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
