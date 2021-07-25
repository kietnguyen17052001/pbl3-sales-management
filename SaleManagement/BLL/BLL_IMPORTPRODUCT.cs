﻿using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_IMPORTPRODUCT
    {
        private N3KTeamEntities db = new N3KTeamEntities();
        private static BLL_IMPORTPRODUCT _instance;
        public static BLL_IMPORTPRODUCT instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_IMPORTPRODUCT();
                }
                return _instance;
            }
            private set { }
        }
        private BLL_IMPORTPRODUCT() { }
        // Load data product from Database
        public void LoadDataProduct(DataGridView dgv)
        {
            var product = db.tblHangHoas.Select(p => new
            {
                p.MaHangHoa,
                p.TenHangHoa,
                p.SoLuong
            });
            dgv.DataSource = product.ToList();
        }
        // set Columns for table invoice
        public DataTable TableInvoice()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[] {
                new DataColumn("MaHangHoa",typeof(string)),
                new DataColumn("TenHangHoa",typeof(string)),
                new DataColumn("SoLuong",typeof(int)),
                new DataColumn("GiaNhap",typeof(string)),
                new DataColumn("TongTien",typeof(string))
            });
            return dataTable;
        }
        // get tblChiTietHoaDonNhapHang
        public tblChiTietHoaDonNhapHang getDetailInvoice(DataRow dataRow, string idInvoice)
        {
            return new tblChiTietHoaDonNhapHang
            {
                MaHoaDonNhap = idInvoice,
                MaHangHoa = dataRow["MaHangHoa"].ToString(),
                SoLuong = Convert.ToInt32(dataRow["SoLuong"]),
                GiaNhap = Convert.ToDouble(dataRow["GiaNhap"]),
                TongTien = Convert.ToDouble(dataRow["TongTien"])
            };
        }
        // Search product from Database
        public void FuncSearchProduct(string information, DataGridView dgv)
        {
            if(information == "Nhập tên hàng hóa" || string.IsNullOrEmpty(information))
            {
                LoadDataProduct(dgv);
            }
            else
            {
                var product = db.tblHangHoas.Where(p => p.TenHangHoa.Contains(information.Trim())).Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong
                });
                dgv.DataSource = product.ToList();
            }
        }
        // Update product quantity
        public void FuncUpdateProductQty(DataTable dataTable, string idProduct, int newQuantity)
        {
            foreach(DataRow dataRow in dataTable.Rows)
            {
                if(dataRow["MaHangHoa"].ToString() == idProduct)
                {
                    dataRow["SoLuong"] = newQuantity;
                    dataRow["TongTien"] = String.Format("{0:n0}", newQuantity * Convert.ToDouble(dataRow["GiaNhap"]));
                }
            }
        }
        // Delete product from DGV invoice
        public void FuncDeleteProduct(List<string> listIDProduct, DataTable dataTable)
        {
            try
            {
                foreach (string idProduct in listIDProduct)
                {
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        if(dataRow["MaHangHoa"].ToString() == idProduct)
                        {
                            dataTable.Rows.Remove(dataRow);
                        }
                    }
                    dataTable.AcceptChanges();
                }
            }
            catch (Exception) { }
        }
        // Payment invoice
        public void FuncPaymentInvoice(tblHoaDonNhapHang invoice, DataTable dataTable)
        {
            db.tblHoaDonNhapHangs.Add(invoice);
            db.SaveChanges();// thêm đơn hàng vào db
            foreach (DataRow dataRow in dataTable.Rows)
            {
                db.tblChiTietHoaDonNhapHangs.Add(getDetailInvoice(dataRow, invoice.MaHoaDonNhap));
                db.SaveChanges();// thêm hóa đơn bán hàng chi tiết
                var product = db.tblHangHoas.Find(dataRow["MaHangHoa"].ToString());
                product.SoLuong += Convert.ToInt32(dataRow["SoLuong"].ToString());
                db.SaveChanges();// thay đổi số lượng hàng hóa sau khi thanh toán
            }
        }
        // Select product
        public void SelectProduct(DataTable dataTable, string idProduct, int quantityOfSelectProduct)
        {
            bool isHas = false;
            var product = db.tblHangHoas.Find(idProduct);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if(dataRow["MaHangHoa"].ToString() == idProduct)
                {
                    isHas = true;
                    dataRow["SoLuong"] = (Convert.ToDouble(dataRow["SoLuong"].ToString()) + quantityOfSelectProduct).ToString();
                    dataRow["TongTien"] = String.Format("{0:n0}",Convert.ToDouble(dataRow["TongTien"].ToString()) + (product.GiaNhap * quantityOfSelectProduct));
                }
            }
            if(isHas == false)
            {
                dataTable.Rows.Add(
                idProduct,
                product.TenHangHoa,
                quantityOfSelectProduct,
                String.Format("{0:n0}", product.GiaNhap),
                String.Format("{0:n0}", quantityOfSelectProduct * product.GiaNhap)
                );
            }
        }
        // Get new id invoice
        public string getNewIdInvoice()
        {
            string idInvoice = "";
            List<tblHoaDonNhapHang> list = db.tblHoaDonNhapHangs.ToList();
            if (list.Count == 0)
            {
                idInvoice = "HDN0001";
            }
            else
            {
                int lastId = Convert.ToInt32(list[list.Count - 1].MaHoaDonNhap.Remove(0, 3));
                if (lastId + 1 < 10)
                {
                    idInvoice = "HDN000" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 100)
                {
                    idInvoice = "HDN00" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 1000)
                {
                    idInvoice = "HDN0" + (lastId + 1).ToString();
                }
            }
            return idInvoice;
        }
        // Get total money for invoice
        public double getTotalMoney(DataTable dataTable)
        {
            double value = 0;
            foreach(DataRow dataRow in dataTable.Rows)
            {
                value += Convert.ToDouble(dataRow["TongTien"].ToString());
            }
            return value;
        }
        // Get into money for invoice
        public double getIntoMoney(DataTable dataTable, double discountMoney, double discountPercent)
        {
            return getTotalMoney(dataTable) - (getTotalMoney(dataTable) * discountPercent / 100) - discountMoney;
        }
    }
}
