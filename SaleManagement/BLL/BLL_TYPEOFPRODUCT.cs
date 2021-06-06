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
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
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
            var getType = DB.tblLoaiHangHoas.Select(p => new
            {
                p.MaLoaiHangHoa,
                p.TenLoaiHangHoa
            });
            dgv.DataSource = getType.ToList();
        }
        // add new type of product
        public void FuncAddNewProduct(tblLoaiHangHoa typeOfProduct)
        {
            DB.tblLoaiHangHoas.Add(typeOfProduct);
            DB.SaveChanges();
        }
        // edit type of product
        public void FuncEditProduct(tblLoaiHangHoa typeOfProduct)
        {
            var getType = DB.tblLoaiHangHoas.Find(typeOfProduct.MaLoaiHangHoa);
            getType.TenLoaiHangHoa = typeOfProduct.TenLoaiHangHoa;
            DB.SaveChanges();
        }
        // search id
        public void FuncSearchTypeProduct(bool isSearchId, string information, DataGridView dgv)
        {
            if (information == "Nhập thông tin cần tìm kiếm" || String.IsNullOrEmpty(information))
            {
                LoadDataTypeOfProduct(dgv);
            }
            else
            {
                if (isSearchId == true)
                {
                    var getType = DB.tblLoaiHangHoas.Where(p => p.MaLoaiHangHoa.Contains(information)).Select(p => new
                    {
                        p.MaLoaiHangHoa,
                        p.TenLoaiHangHoa
                    });
                    dgv.DataSource = getType.ToList();
                }
                else
                {
                    var getType = DB.tblLoaiHangHoas.Where(p => p.TenLoaiHangHoa.Contains(information)).Select(p => new
                    {
                        p.MaLoaiHangHoa,
                        p.TenLoaiHangHoa
                    });
                    dgv.DataSource = getType.ToList();
                }
            }
        }
        // delete type of product
        public void FuncDeleteTypeProduct(List<string> listId)
        {
            foreach(string i in listId)
            {
                foreach(tblLoaiHangHoa typeOfProduct in DB.tblLoaiHangHoas)
                {
                    if(typeOfProduct.MaLoaiHangHoa == i)
                    {
                        DB.tblLoaiHangHoas.Remove(typeOfProduct);
                    }
                }
                DB.SaveChanges();
            }
        }
    }
}
