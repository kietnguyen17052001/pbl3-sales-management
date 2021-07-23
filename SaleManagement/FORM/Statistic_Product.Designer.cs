
namespace SaleManagement.FORM
{
    partial class FrmStatistic_Product
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label6 = new System.Windows.Forms.Label();
            this.lbINFO = new System.Windows.Forms.Label();
            this.charMONEY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPRODUCT_QTY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHOME = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbQUANTITY = new System.Windows.Forms.Label();
            this.lbMONEY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.charMONEY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPRODUCT_QTY)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(496, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 27);
            this.label6.TabIndex = 122;
            this.label6.Text = "Thống kê sản phẩm";
            // 
            // lbINFO
            // 
            this.lbINFO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbINFO.AutoSize = true;
            this.lbINFO.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINFO.ForeColor = System.Drawing.Color.Black;
            this.lbINFO.Location = new System.Drawing.Point(323, 66);
            this.lbINFO.Name = "lbINFO";
            this.lbINFO.Size = new System.Drawing.Size(0, 27);
            this.lbINFO.TabIndex = 123;
            this.lbINFO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // charMONEY
            // 
            this.charMONEY.BackColor = System.Drawing.SystemColors.Control;
            this.charMONEY.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea3.Name = "ChartArea1";
            this.charMONEY.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.charMONEY.Legends.Add(legend3);
            this.charMONEY.Location = new System.Drawing.Point(4, 135);
            this.charMONEY.Name = "charMONEY";
            this.charMONEY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.White;
            series3.LabelForeColor = System.Drawing.Color.IndianRed;
            series3.Legend = "Legend1";
            series3.Name = "Số tiền bán được";
            this.charMONEY.Series.Add(series3);
            this.charMONEY.Size = new System.Drawing.Size(594, 368);
            this.charMONEY.TabIndex = 125;
            this.charMONEY.Text = "chart1";
            // 
            // chartPRODUCT_QTY
            // 
            this.chartPRODUCT_QTY.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.chartPRODUCT_QTY.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPRODUCT_QTY.Legends.Add(legend4);
            this.chartPRODUCT_QTY.Location = new System.Drawing.Point(616, 135);
            this.chartPRODUCT_QTY.Name = "chartPRODUCT_QTY";
            this.chartPRODUCT_QTY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.LabelBackColor = System.Drawing.Color.White;
            series4.LabelForeColor = System.Drawing.Color.IndianRed;
            series4.Legend = "Legend1";
            series4.Name = "Số sản phẩm bán được";
            this.chartPRODUCT_QTY.Series.Add(series4);
            this.chartPRODUCT_QTY.Size = new System.Drawing.Size(627, 368);
            this.chartPRODUCT_QTY.TabIndex = 126;
            this.chartPRODUCT_QTY.Text = "chart1";
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
            this.btnHOME.Location = new System.Drawing.Point(1082, 9);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(152, 47);
            this.btnHOME.TabIndex = 131;
            this.btnHOME.Text = "Quay lại";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 134;
            this.label1.Text = "Tổng sản phẩm: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 27);
            this.label2.TabIndex = 135;
            this.label2.Text = "Tổng tiền: ";
            // 
            // lbQUANTITY
            // 
            this.lbQUANTITY.AutoSize = true;
            this.lbQUANTITY.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQUANTITY.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbQUANTITY.Location = new System.Drawing.Point(613, 561);
            this.lbQUANTITY.Name = "lbQUANTITY";
            this.lbQUANTITY.Size = new System.Drawing.Size(0, 27);
            this.lbQUANTITY.TabIndex = 136;
            // 
            // lbMONEY
            // 
            this.lbMONEY.AutoSize = true;
            this.lbMONEY.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMONEY.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbMONEY.Location = new System.Drawing.Point(613, 620);
            this.lbMONEY.Name = "lbMONEY";
            this.lbMONEY.Size = new System.Drawing.Size(0, 27);
            this.lbMONEY.TabIndex = 137;
            // 
            // FrmStatistic_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 715);
            this.ControlBox = false;
            this.Controls.Add(this.lbMONEY);
            this.Controls.Add(this.lbQUANTITY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.chartPRODUCT_QTY);
            this.Controls.Add(this.charMONEY);
            this.Controls.Add(this.lbINFO);
            this.Controls.Add(this.label6);
            this.Name = "FrmStatistic_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.charMONEY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPRODUCT_QTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbINFO;
        private System.Windows.Forms.DataVisualization.Charting.Chart charMONEY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPRODUCT_QTY;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbQUANTITY;
        private System.Windows.Forms.Label lbMONEY;
    }
}