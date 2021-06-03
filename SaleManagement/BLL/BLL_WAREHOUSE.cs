using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_WAREHOUSE
    {
        private static BLL_WAREHOUSE _Instance;

        public static BLL_WAREHOUSE Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_WAREHOUSE();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_WAREHOUSE() { }
        public DataTable createListItem()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MaHangHoa", typeof(string)),
                new DataColumn("TenHangHoa", typeof(string)),
                new DataColumn("GiaNhap",typeof(double)),
                new DataColumn("SoLuong", typeof(int)),
                new DataColumn("TienGiam", typeof(double)),
                new DataColumn("ThanhTien(VND)",typeof(double))
            });
            return dt;
        }
        public List<CBBItem> getCBB_Staff()
        {
            SALEMANAGEMENT_DB db = new SALEMANAGEMENT_DB();
            List<CBBItem> LIST = new List<CBBItem>();
            foreach(tblNhanVien NhanVien in db.tblNhanViens.ToList())
            {
                if(NhanVien.ViTri == "Kho")
                {
                    LIST.Add(new CBBItem { VALUE = NhanVien.MaNhanVien, TEXT = NhanVien.TenNhanVien });
                }
            }
            return LIST;
        }
        public List<CBBItem> getCBB_Item()
        {
            SALEMANAGEMENT_DB db = new SALEMANAGEMENT_DB();
            List<CBBItem> list = new List<CBBItem>();
            foreach (tblLoaiHangHoa LOAIHANGHOA in db.tblLoaiHangHoas)
            {
                list.Add(new CBBItem { VALUE = LOAIHANGHOA.MaLoaiHangHoa, TEXT = LOAIHANGHOA.TenLoaiHangHoa });
            }
            return list;
        }
        public double ThanhTien(DataTable dt)
        {
            double ThanhTien = 0;
            foreach(DataRow i in dt.Rows)
            {
                ThanhTien += Convert.ToDouble(i["GiaNhap"]) * Convert.ToInt32("SoLuong") - Convert.ToDouble("TienGiam");
            }
            return ThanhTien;
        }
        public int countItem(DataTable dt)
        {
            int count = 0;
            foreach(DataRow i in dt.Rows)
            {
                count += Convert.ToInt32(i["SoLuong"].ToString());
            }
            return count;
        }
        public double GetAllAMOUNT(DataTable dt)
        {
            double TongTien = 0;
            foreach(DataRow i in dt.Rows)
            {
                TongTien += Convert.ToDouble(i["ThanhTien(VND)"].ToString());
            }
            return TongTien;
        }
        public List<CBBItem> getCBB_NhaCungCap()
        {
            SALEMANAGEMENT_DB db = new SALEMANAGEMENT_DB();
            List<CBBItem> LIST = new List<CBBItem>();
            foreach(tblNhaCungCap NhaCungCap in db.tblNhaCungCaps.ToList())
            {
                LIST.Add(new CBBItem { TEXT = NhaCungCap.TenNhaCungCap, VALUE = NhaCungCap.MaNhaCungCap });
            }
            return LIST;
        }
        public void addItemToList(DataTable dt,params object[] obj)
        {
            int SoLuong;
            double SoTien;
            double TienGiam;
            bool CHECK = true;
            foreach (DataRow i in dt.Rows)
            {
                SoTien = Convert.ToDouble(i["ThanhTien(VND)"].ToString());
                SoLuong = Convert.ToInt32(i["SoLuong"].ToString());
                TienGiam = Convert.ToDouble(i["TienGiam"].ToString());
                if (i["TenHangHoa"].ToString() == obj[1].ToString())
                {
                    CHECK = false;
                    SoLuong += Convert.ToInt32(obj[3].ToString());
                    TienGiam += Convert.ToDouble(obj[4].ToString());
                    SoTien += Convert.ToDouble(obj[5].ToString());
                    i["SoLuong"] = SoLuong.ToString();
                    i["TienGiam"] = String.Format("{0:n0}",TienGiam.ToString());
                    i["ThanhTien(VND)"] = String.Format("{0:n0}", SoTien.ToString());
                }
            }
            if (CHECK)
            {
                dt.Rows.Add(new object[] { obj[0], obj[1], String.Format("{0:n0}", obj[2]), obj[3],String.Format("{0:n0}", obj[4]), String.Format("{0:n0}",obj[5]) });
            }
        }
        public void EditItem(DataTable dt,params object[] obj)
        {
            foreach(DataRow i in dt.Rows)
            {
                if (i["MaHangHoa"] == obj[0])
                {
                    i["TenHangHoa"] = obj[1];
                    i["GiaNhap"] = String.Format("{0:n0}",obj[2]);
                    i["SoLuong"] = obj[3];
                    i["TienGiam"] = String.Format("{0:n0}", obj[4]);
                    i["ThanhTien(VND)"] = (Convert.ToInt32(obj[3]) * Convert.ToDouble(obj[2]) - Convert.ToDouble(obj[4])).ToString();
                }
            }
        }
    }
}
