using SaleManagement.BLL;
using SaleManagement.Entity;
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
        private DateTime dateMin = BLL_LISTSALEINVOICE.Instance.getDate();
        public FrmStatistic()
        {
            InitializeComponent();
            SetCBB();
            if (dateMin == null)
            {
                dpFROM.Value = DateTime.Now;
            }
            else
            {
                dpFROM.Value = dateMin;
            }
            fillChart();
        }
        public void SetCBB()
        {
            cbbTYPEOFPRODUCT.Items.Add(new CBBItem { VALUE = "0", TEXT = "None" });
            cbbTYPEOFPRODUCT.Items.AddRange(BLL_PRODUCTS.Instance.getCBBTypeProduct().ToArray());
            cbbTYPEOFPRODUCT.SelectedIndex = 0;
        }
        public void fillChart()
        {
            lbTIME.Text = "Từ ngày " + dpFROM.Value.ToShortDateString() + " đến ngày " + dpTO.Value.ToShortDateString();
            int quantity; // số lượng hiện tại của loại hàng hóa
            double money; // số tiền bán được của loại hàng hóa
            double quantitySale; // số lượng bán được của loại hàng hóa
            int count = 0; //
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
            chartSCALE.Series["Tỉ lệ %"].IsValueShownAsLabel = true;
            Color randomColor = new Color();
            foreach (tblLoaiHangHoa typeOfProduct in BLL_STATISTIC.instance.getListTypeOfProduct())
            {
                quantitySale = 0; 
                randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                quantity = 0;
                money = 0;
                foreach (tblHangHoa product in BLL_STATISTIC.instance.getListProduct())
                {
                    if (product.MaLoaiHangHoa == typeOfProduct.MaLoaiHangHoa)
                    {
                        quantity += product.SoLuong;
                    }
                }
                // Biểu đồ số sản phẩm
                chartPRODUCT_QTY.Series["Số sản phẩm"].Points.AddXY(typeOfProduct.TenLoaiHangHoa, quantity);
                chartPRODUCT_QTY.Series["Số sản phẩm"].Points[count].Color = randomColor;
                chartPRODUCT_QTY.Series["Số sản phẩm"].Points[count].Label = quantity.ToString();
                //var list = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dpFROM.Value && p.tblHoaDonBanHang.NgayBan <= dpTO.Value);
                
                foreach (tblChiTietHoaDonBanHang invoiceDetail in BLL_STATISTIC.instance.getListInvoiceDetail(dpFROM.Value, dpTO.Value))
                {
                    if(invoiceDetail.tblHangHoa.MaLoaiHangHoa == typeOfProduct.MaLoaiHangHoa)
                    {
                        money += (double)invoiceDetail.TongTien;
                        quantitySale += (int)invoiceDetail.SoLuong;
                    }
                }
                // Biểu đồ so sánh
                chartSCALE.Series["Tỉ lệ %"].Points.AddXY(typeOfProduct.TenLoaiHangHoa, Math.Round((quantitySale / BLL_STATISTIC.instance.getTotalQuantityProduct()) * 100, 2));
                // Biểu đồ tiền bán được
                chartMONEY.Series["Số tiền"].Points.AddXY(typeOfProduct.TenLoaiHangHoa, money);
                chartMONEY.Series["Số tiền"].Points[count].Color = randomColor;
                chartMONEY.Series["Số tiền"].Points[count].Label = money.ToString();
                count++;
            }
        }
        // Thống kê theo loại sản phẩm
        private void btnINFO_Click(object sender, EventArgs e)
        {
            string value = ((CBBItem)cbbTYPEOFPRODUCT.SelectedItem).VALUE;
            string text = ((CBBItem)cbbTYPEOFPRODUCT.SelectedItem).TEXT;
            FrmStatistic_Product frm = new FrmStatistic_Product(dpFROM.Value, dpTO.Value, value, text);
            frm.Show();
            this.Close();
        }
        // Thống kê doanh thu
        private void btnSTATISTIC_Click(object sender, EventArgs e)
        {
            FrmRevenue_Statistic frm = new FrmRevenue_Statistic();
            frm.Show();
            this.Close();
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmMain_Admin frm = new FrmMain_Admin();
            frm.Show();
            this.Close();
        }
        private void btnLOAD_Click(object sender, EventArgs e)
        {
            lbTIME.Text = ""; 
            fillChart();
        }
    }
}
