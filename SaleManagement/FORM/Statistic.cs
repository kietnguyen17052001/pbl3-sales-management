﻿using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SaleManagement.FORM
{
    public partial class FrmStatistic : Form
    {
        private Random rand = new Random();
        public FrmStatistic()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            InitializeComponent();
            var getDayMin = DB.tblHoaDonBanHangs.Min(p => p.NgayBan);
            dpFROM.Value = getDayMin.Value;
            fillChart();
        }
        private void fillChart()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            int quantity; // số lượng hiện tại của loại hàng hóa
            double money; // số tiền bán được của loại hàng hóa
            int count = 0; //
            double quantitySale; // số lượng bán được của loại hàng hóa
            chartSCALE.Series["Tỉ lệ %"].IsValueShownAsLabel = true;
            Color randomColor = new Color();
            foreach (tblLoaiHangHoa typeProduct in DB.tblLoaiHangHoas)
            {
                quantitySale = 0; 
                randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                quantity = 0;
                money = 0;
                foreach (tblHangHoa product in DB.tblHangHoas)
                {
                    if (product.MaLoaiHangHoa == typeProduct.MaLoaiHangHoa)
                    {
                        quantity += product.SoLuong;
                    }
                }
                // Biểu đồ số sản phẩm
                chartPRODUCT_QTY.Series["Số sản phẩm"].Points.AddXY(typeProduct.TenLoaiHangHoa, quantity);
                chartPRODUCT_QTY.Series["Số sản phẩm"].Points[count].Color = randomColor;
                chartPRODUCT_QTY.Series["Số sản phẩm"].Points[count].Label = quantity.ToString();
                var list = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dpFROM.Value && p.tblHoaDonBanHang.NgayBan <= dpTO.Value);
                foreach (tblChiTietHoaDonBanHang invoiceDetail in list)
                {
                    if(invoiceDetail.tblHangHoa.MaLoaiHangHoa == typeProduct.MaLoaiHangHoa)
                    {
                        money += (double)invoiceDetail.TongTien;
                        quantitySale += (int)invoiceDetail.SoLuong;
                    }
                }
                // Biểu đồ so sánh
                chartSCALE.Series["Tỉ lệ %"].Points.AddXY(typeProduct.TenLoaiHangHoa, Math.Round((quantitySale / GetAllQuantitySale()) * 100, 2));
                // Biểu đồ tiền bán được
                chartMONEY.Series["Số tiền"].Points.AddXY(typeProduct.TenLoaiHangHoa, money);
                chartMONEY.Series["Số tiền"].Points[count].Color = randomColor;
                chartMONEY.Series["Số tiền"].Points[count].Label = money.ToString();
                count++;
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmSale_Management frm = new FrmSale_Management();
            frm.Show();
            this.Close();
        }
        // Tổng số lượng hàng hóa bán được
        public double GetAllQuantitySale()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            double quantity = 0;
            foreach(tblChiTietHoaDonBanHang invoiceDetail in DB.tblChiTietHoaDonBanHangs)
            {
                quantity += (double)invoiceDetail.SoLuong;
            }
            return quantity;
        }

        private void btnLOAD_Click(object sender, EventArgs e)
        {
            chartMONEY.Series.Clear();
            chartPRODUCT_QTY.Series.Clear();
            chartSCALE.Series.Clear();
            chartMONEY.Series.Add("Số tiền");
            chartPRODUCT_QTY.Series.Add("Số sản phẩm");
            chartSCALE.Series.Add("Tỉ lệ %");
            chartSCALE.Series["Tỉ lệ %"].ChartType = SeriesChartType.Pie;
            chartSCALE.Series["Tỉ lệ %"].LabelBackColor = Color.Black;
            chartSCALE.Series["Tỉ lệ %"].LabelForeColor = Color.White;
            chartMONEY.Series["Số tiền"].LabelBackColor = Color.Black;
            chartMONEY.Series["Số tiền"].LabelForeColor = Color.White;
            chartPRODUCT_QTY.Series["Số sản phẩm"].LabelBackColor = Color.Black;
            chartPRODUCT_QTY.Series["Số sản phẩm"].LabelForeColor = Color.White;
            fillChart();
        }
    }
}
