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
        private DateTime dateStart = BLL_LISTSALEINVOICE.Instance.getDate();
        private string usernamelogin;
        public FrmStatistic(string _usernamelogin)
        {
            InitializeComponent();
            usernamelogin = _usernamelogin;
            setCombobox();
            if (dateStart == null)
            {
                dpFROM.Value = DateTime.Now;
            }
            else
            {
                dpFROM.Value = dateStart;
            }
            fillChart();
        }
        public void setCombobox()
        {
            cbbTYPEOFPRODUCT.Items.Add(new CBBItem { VALUE = "0", TEXT = "None" });
            cbbTYPEOFPRODUCT.Items.AddRange(BLL_PRODUCT.Instance.getCBBTypeProduct().ToArray());
            cbbTYPEOFPRODUCT.SelectedIndex = 0;
        }
        public void fillChart()
        {
            lbTIME.Text = "Từ ngày " + dpFROM.Value.ToShortDateString() + " đến ngày " + dpTO.Value.ToShortDateString();
            int quantityTypeOfProduct; // số lượng hiện tại của loại hàng hóa
            double sellMoneyTypeOfProduct; // số tiền bán được của loại hàng hóa
            double sellQuantityTypeOfProduct; // số lượng bán được của loại hàng hóa
            int count = 0; //
            chartMONEY.Series.Clear();
            chartPRODUCT_QTY.Series.Clear();
            chartSCALE.Series.Clear();
            chartMONEY.Series.Add("Số tiền");
            chartPRODUCT_QTY.Series.Add("Số sản phẩm");
            chartSCALE.Series.Add("Tỉ lệ %");
            chartSCALE.Series["Tỉ lệ %"].ChartType = SeriesChartType.Pie;
            chartSCALE.Series["Tỉ lệ %"].LabelForeColor = chartMONEY.Series["Số tiền"].LabelForeColor = chartPRODUCT_QTY.Series["Số sản phẩm"].LabelForeColor = Color.IndianRed;
            chartSCALE.Series["Tỉ lệ %"].Font = chartMONEY.Series["Số tiền"].Font = chartPRODUCT_QTY.Series["Số sản phẩm"].Font = new Font("Tahoma", 8, FontStyle.Bold);
            chartMONEY.Series["Số tiền"].LabelBackColor = chartPRODUCT_QTY.Series["Số sản phẩm"].LabelBackColor = chartSCALE.Series["Tỉ lệ %"].LabelBackColor = Color.White;
            chartSCALE.Series["Tỉ lệ %"].IsValueShownAsLabel = true;
            foreach (tblLoaiHangHoa typeOfProduct in BLL_STATISTIC.instance.getListTypeOfProduct())
            {
                quantityTypeOfProduct = BLL_STATISTIC.instance.getQuantityOfEachTypeOfProduct(typeOfProduct);
                sellQuantityTypeOfProduct = BLL_STATISTIC.instance.getSellQuantityOfEachTypeOfProduct(typeOfProduct, dpFROM.Value, dpTO.Value);
                sellMoneyTypeOfProduct = BLL_STATISTIC.instance.getSellMoneyOfEachTypeOfProduct(typeOfProduct, dpFROM.Value, dpTO.Value);
                // Biểu đồ số sản phẩm
                chartPRODUCT_QTY.Series["Số sản phẩm"].Points.AddXY(typeOfProduct.TenLoaiHangHoa, quantityTypeOfProduct);
                chartPRODUCT_QTY.Series["Số sản phẩm"].Points[count].Label = quantityTypeOfProduct.ToString();
                // Biểu đồ so sánh
                chartSCALE.Series["Tỉ lệ %"].Points.AddXY(typeOfProduct.TenLoaiHangHoa, Math.Round((sellQuantityTypeOfProduct / BLL_STATISTIC.instance.getTotalQuantityProduct(dpFROM.Value, dpTO.Value)) * 100, 2));
                // Biểu đồ tiền bán được
                chartMONEY.Series["Số tiền"].Points.AddXY(typeOfProduct.TenLoaiHangHoa, sellMoneyTypeOfProduct);
                chartMONEY.Series["Số tiền"].Points[count].Label = sellMoneyTypeOfProduct.ToString();
                count++;
            }
        }
        // Thống kê theo loại sản phẩm
        private void btnINFO_Click(object sender, EventArgs e)
        {
            string value = ((CBBItem)cbbTYPEOFPRODUCT.SelectedItem).VALUE;
            string text = ((CBBItem)cbbTYPEOFPRODUCT.SelectedItem).TEXT;
            FrmStatistic_Product frm = new FrmStatistic_Product(dpFROM.Value, dpTO.Value, value, text, usernamelogin);
            frm.Show();
            this.Close();
        }
        // Thống kê doanh thu
        private void btnSTATISTIC_Click(object sender, EventArgs e)
        {
            FrmRevenue_Statistic frm = new FrmRevenue_Statistic(usernamelogin);
            frm.Show();
            this.Close();
        }
        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmMain_Admin frm = new FrmMain_Admin(usernamelogin);
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
