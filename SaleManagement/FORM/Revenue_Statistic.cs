using SaleManagement.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.FORM
{
    public partial class FrmRevenue_Statistic : Form
    {
        private string usernamelogin;
        public FrmRevenue_Statistic(string _usernamelogin)
        {
            InitializeComponent();
            usernamelogin = _usernamelogin;
            cbbYEAR.SelectedIndex = cbbMONTH.SelectedIndex = 0;
            rbYEAR.Checked = true;
            fillChartYear();
        }
        private int year, month;
        public void fillChartYear()
        {
            year = Convert.ToInt32(cbbYEAR.SelectedItem.ToString());
            chartSTATISTIC.Series.Clear();
            chartSTATISTIC.Series.Add("Doanh thu");
            chartSTATISTIC.Series["Doanh thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartSTATISTIC.Series["Doanh thu"].Color = Color.Red;
            double revenue;
            for(int i = 1; i <= 12; i++)
            {
                revenue = BLL_STATISTIC.instance.getRevenueYear(year, i);
                chartSTATISTIC.Series["Doanh thu"].Points.AddXY("Th" + i, revenue);
            } 
        }
        public void fillChartMonth()
        {
            year = Convert.ToInt32(cbbYEAR.SelectedItem.ToString());
            month = Convert.ToInt32(cbbMONTH.SelectedItem.ToString());
            chartSTATISTIC.Series.Clear();
            chartSTATISTIC.Series.Add("Doanh thu");
            chartSTATISTIC.Series["Doanh thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartSTATISTIC.Series["Doanh thu"].Color = Color.Red;
            double revenue;
            for (int i = 1; i <= 31; i++)
            {
                revenue = BLL_STATISTIC.instance.getRevenueMonth(year, month, i);
                chartSTATISTIC.Series["Doanh thu"].Points.AddXY("Ng" + i, revenue);
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmStatistic frm = new FrmStatistic(usernamelogin);
            frm.Show();
            this.Close();
        }

        private void btnSHOW_Click(object sender, EventArgs e)
        {
            if (rbYEAR.Checked == true)
            {
                fillChartYear();
            }
            else
            {
                fillChartMonth();
            }
        }
    }
}
