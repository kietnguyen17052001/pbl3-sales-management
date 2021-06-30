using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_TYPEOFPRODUCT
    {
        private N3KTeamEntities db = new N3KTeamEntities();
        private static BLL_TYPEOFPRODUCT _Instance;
        public static BLL_TYPEOFPRODUCT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_TYPEOFPRODUCT();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_TYPEOFPRODUCT() { }
        // load data type of product
        public void LoadDataTypeOfProduct(DataGridView dgv)
        {
            var getType = db.tblLoaiHangHoas.Select(p => new
            {
                p.MaLoaiHangHoa,
                p.TenLoaiHangHoa
            });
            dgv.DataSource = getType.ToList();
        }
        // add new type of product
        public void FuncAddNewProduct(tblLoaiHangHoa typeOfProduct)
        {
            db.tblLoaiHangHoas.Add(typeOfProduct);
            db.SaveChanges();
        }
        // edit type of product
        public void FuncEditProduct(tblLoaiHangHoa _typeOfProduct)
        {
            var typeOfProduct = db.tblLoaiHangHoas.Find(_typeOfProduct.MaLoaiHangHoa);
            typeOfProduct.TenLoaiHangHoa = _typeOfProduct.TenLoaiHangHoa;
            db.SaveChanges();
        }
        // search id
        public void FuncSearchTypeProduct(DataGridView dgv, string information)
        {
            if (information == "Nhập mã hoặc tên loại hàng hóa" || String.IsNullOrEmpty(information))
            {
                LoadDataTypeOfProduct(dgv);
            }
            else
            {
                var typeOfProduct = db.tblLoaiHangHoas.Where(p => p.MaLoaiHangHoa.Contains(information)
            || p.TenLoaiHangHoa.Contains(information)).Select(p => new
            {
                p.MaLoaiHangHoa,
                p.TenLoaiHangHoa
            });
                dgv.DataSource = typeOfProduct.ToList();
            }
        }
        // delete type of product
        public void FuncDeleteTypeProduct(List<string> listId)
        {
            var typeOfProduct = new tblLoaiHangHoa();
            foreach(string idProduct in listId)
            {
                typeOfProduct = db.tblLoaiHangHoas.Find(idProduct);
                db.tblLoaiHangHoas.Remove(typeOfProduct);
                db.SaveChanges();
            }
        }
    }
}
