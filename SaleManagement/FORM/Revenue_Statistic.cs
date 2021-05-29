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

namespace SaleManagement.FORM
{
    public partial class FrmRevenue_Statistic : Form
    {
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        public FrmRevenue_Statistic()
        {
            InitializeComponent();
            cbbYEAR.SelectedIndex = cbbMONTH.SelectedIndex = 0;
            rbYEAR.Checked = true;
            fillChartYear();
        }
        int year, month;
        public void fillChartYear()
        {
            year = Convert.ToInt32(cbbYEAR.SelectedItem.ToString());
            var StatisticByYear = DB.tblHoaDonBanHangs.Where(p => p.NgayBan.Value.Year == year);
            chartSTATISTIC.Series.Clear();
            chartSTATISTIC.Series.Add("Doanh thu");
            chartSTATISTIC.Series["Doanh thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartSTATISTIC.Series["Doanh thu"].Color = Color.OrangeRed;
            double revenue;
            for(int i = 1; i <= 12; i++)
            {
                revenue = 0.0;
                foreach(tblHoaDonBanHang invoice in StatisticByYear)
                {
                    if(invoice.NgayBan.Value.Month == i)
                    {
                        revenue += (double)invoice.SoTien;
                    }
                }
                chartSTATISTIC.Series["Doanh thu"].Points.AddXY(i, revenue);
            } 
        }
        public void fillChartMonth()
        {
            year = Convert.ToInt32(cbbYEAR.SelectedItem.ToString());
            month = Convert.ToInt32(cbbMONTH.SelectedItem.ToString());
            var StatisticByMonth = DB.tblHoaDonBanHangs.Where(p => p.NgayBan.Value.Year == year
            && p.NgayBan.Value.Month == month);
            chartSTATISTIC.Series.Clear();
            chartSTATISTIC.Series.Add("Doanh thu");
            chartSTATISTIC.Series["Doanh thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartSTATISTIC.Series["Doanh thu"].Color = Color.OrangeRed;
            double revenue;
            for (int i = 1; i <= 31; i++)
            {
                revenue = 0.0;
                foreach (tblHoaDonBanHang invoice in StatisticByMonth)
                {
                    if (invoice.NgayBan.Value.Day == i)
                    {
                        revenue += (double)invoice.SoTien;
                    }
                }
                chartSTATISTIC.Series["Doanh thu"].Points.AddXY(i, revenue);
            }
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmStatistic frm = new FrmStatistic();
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
