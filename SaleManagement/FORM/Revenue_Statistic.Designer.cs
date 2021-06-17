
namespace SaleManagement.FORM
{
    partial class FrmRevenue_Statistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label6 = new System.Windows.Forms.Label();
            this.chartSTATISTIC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSHOW = new System.Windows.Forms.Button();
            this.rbYEAR = new System.Windows.Forms.RadioButton();
            this.rbMONTH = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbYEAR = new System.Windows.Forms.ComboBox();
            this.cbbMONTH = new System.Windows.Forms.ComboBox();
            this.btnHOME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSTATISTIC)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(496, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 31);
            this.label6.TabIndex = 122;
            this.label6.Text = "Thống kê doanh thu";
            // 
            // chartSTATISTIC
            // 
            this.chartSTATISTIC.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartSTATISTIC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSTATISTIC.Legends.Add(legend1);
            this.chartSTATISTIC.Location = new System.Drawing.Point(28, 55);
            this.chartSTATISTIC.Name = "chartSTATISTIC";
            this.chartSTATISTIC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSTATISTIC.Series.Add(series1);
            this.chartSTATISTIC.Size = new System.Drawing.Size(1182, 438);
            this.chartSTATISTIC.TabIndex = 125;
            this.chartSTATISTIC.Text = "chart1";
            // 
            // btnSHOW
            // 
            this.btnSHOW.BackColor = System.Drawing.Color.Tomato;
            this.btnSHOW.FlatAppearance.BorderSize = 0;
            this.btnSHOW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSHOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHOW.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHOW.ForeColor = System.Drawing.Color.White;
            this.btnSHOW.Location = new System.Drawing.Point(448, 608);
            this.btnSHOW.Name = "btnSHOW";
            this.btnSHOW.Size = new System.Drawing.Size(347, 55);
            this.btnSHOW.TabIndex = 143;
            this.btnSHOW.Text = "Xem tăng trưởng doanh thu";
            this.btnSHOW.UseVisualStyleBackColor = false;
            this.btnSHOW.Click += new System.EventHandler(this.btnSHOW_Click);
            // 
            // rbYEAR
            // 
            this.rbYEAR.AutoSize = true;
            this.rbYEAR.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYEAR.Location = new System.Drawing.Point(448, 545);
            this.rbYEAR.Name = "rbYEAR";
            this.rbYEAR.Size = new System.Drawing.Size(355, 28);
            this.rbYEAR.TabIndex = 144;
            this.rbYEAR.TabStop = true;
            this.rbYEAR.Text = "Thống kê theo tháng trong năm";
            this.rbYEAR.UseVisualStyleBackColor = true;
            // 
            // rbMONTH
            // 
            this.rbMONTH.AutoSize = true;
            this.rbMONTH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMONTH.Location = new System.Drawing.Point(840, 545);
            this.rbMONTH.Name = "rbMONTH";
            this.rbMONTH.Size = new System.Drawing.Size(361, 28);
            this.rbMONTH.TabIndex = 145;
            this.rbMONTH.TabStop = true;
            this.rbMONTH.Text = "Thống kê theo ngày trong tháng";
            this.rbMONTH.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 146;
            this.label1.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(208, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 147;
            this.label2.Text = "Tháng";
            // 
            // cbbYEAR
            // 
            this.cbbYEAR.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbYEAR.FormattingEnabled = true;
            this.cbbYEAR.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018"});
            this.cbbYEAR.Location = new System.Drawing.Point(43, 557);
            this.cbbYEAR.Name = "cbbYEAR";
            this.cbbYEAR.Size = new System.Drawing.Size(79, 27);
            this.cbbYEAR.TabIndex = 148;
            // 
            // cbbMONTH
            // 
            this.cbbMONTH.Font = new System.Drawing.Font("Tahoma", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMONTH.FormattingEnabled = true;
            this.cbbMONTH.Items.AddRange(new object[] {
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cbbMONTH.Location = new System.Drawing.Point(213, 557);
            this.cbbMONTH.Name = "cbbMONTH";
            this.cbbMONTH.Size = new System.Drawing.Size(82, 27);
            this.cbbMONTH.TabIndex = 149;
            // 
            // btnHOME
            // 
            this.btnHOME.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHOME.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHOME.FlatAppearance.BorderSize = 0;
            this.btnHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHOME.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHOME.ForeColor = System.Drawing.Color.White;
            this.btnHOME.Image = global::SaleManagement.Properties.Resources.arrow_121_24;
            this.btnHOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHOME.Location = new System.Drawing.Point(1082, 3);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(152, 47);
            this.btnHOME.TabIndex = 150;
            this.btnHOME.Text = "Quay lại";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // FrmRevenue_Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 691);
            this.ControlBox = false;
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.cbbMONTH);
            this.Controls.Add(this.cbbYEAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbMONTH);
            this.Controls.Add(this.rbYEAR);
            this.Controls.Add(this.btnSHOW);
            this.Controls.Add(this.chartSTATISTIC);
            this.Controls.Add(this.label6);
            this.Name = "FrmRevenue_Statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.chartSTATISTIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSTATISTIC;
        private System.Windows.Forms.Button btnSHOW;
        private System.Windows.Forms.RadioButton rbYEAR;
        private System.Windows.Forms.RadioButton rbMONTH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbYEAR;
        private System.Windows.Forms.ComboBox cbbMONTH;
        private System.Windows.Forms.Button btnHOME;
    }
}