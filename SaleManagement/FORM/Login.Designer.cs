
namespace SaleManagement.FORM
{
    partial class FrmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtUSER = new System.Windows.Forms.TextBox();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSTAFF = new System.Windows.Forms.Button();
            this.btnADMIN = new System.Windows.Forms.Button();
            this.lbINFO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(57, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 481);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập hệ thống";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::SaleManagement.Properties.Resources.contacts_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(236, 246);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 58);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::SaleManagement.Properties.Resources.key_4_32;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(236, 354);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 58);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // txtUSER
            // 
            this.txtUSER.BackColor = System.Drawing.Color.White;
            this.txtUSER.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSER.ForeColor = System.Drawing.Color.Silver;
            this.txtUSER.Location = new System.Drawing.Point(333, 254);
            this.txtUSER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUSER.Multiline = true;
            this.txtUSER.Name = "txtUSER";
            this.txtUSER.Size = new System.Drawing.Size(199, 50);
            this.txtUSER.TabIndex = 6;
            this.txtUSER.Text = "Nhập tài khoản";
            this.txtUSER.Enter += new System.EventHandler(this.txtUSER_Enter);
            this.txtUSER.Leave += new System.EventHandler(this.txtUSER_Leave);
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.BackColor = System.Drawing.Color.White;
            this.txtPASSWORD.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASSWORD.ForeColor = System.Drawing.Color.Silver;
            this.txtPASSWORD.Location = new System.Drawing.Point(333, 362);
            this.txtPASSWORD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPASSWORD.Multiline = true;
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(199, 50);
            this.txtPASSWORD.TabIndex = 7;
            this.txtPASSWORD.Text = "Nhập mật khẩu";
            this.txtPASSWORD.Enter += new System.EventHandler(this.txtPASSWORD_Enter);
            this.txtPASSWORD.Leave += new System.EventHandler(this.txtPASSWORD_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(399, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "N3K";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = global::SaleManagement.Properties.Resources.cart_8_32;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(325, 156);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 58);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // btnSTAFF
            // 
            this.btnSTAFF.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSTAFF.FlatAppearance.BorderSize = 0;
            this.btnSTAFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTAFF.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTAFF.ForeColor = System.Drawing.Color.White;
            this.btnSTAFF.Image = global::SaleManagement.Properties.Resources.shopping_basket_24;
            this.btnSTAFF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSTAFF.Location = new System.Drawing.Point(403, 500);
            this.btnSTAFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSTAFF.Name = "btnSTAFF";
            this.btnSTAFF.Size = new System.Drawing.Size(182, 70);
            this.btnSTAFF.TabIndex = 11;
            this.btnSTAFF.Text = "Bán hàng";
            this.btnSTAFF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSTAFF.UseVisualStyleBackColor = false;
            this.btnSTAFF.Click += new System.EventHandler(this.btnSTAFF_Click);
            // 
            // btnADMIN
            // 
            this.btnADMIN.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADMIN.FlatAppearance.BorderSize = 0;
            this.btnADMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADMIN.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADMIN.ForeColor = System.Drawing.Color.White;
            this.btnADMIN.Image = global::SaleManagement.Properties.Resources.statistics_24;
            this.btnADMIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADMIN.Location = new System.Drawing.Point(216, 500);
            this.btnADMIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADMIN.Name = "btnADMIN";
            this.btnADMIN.Size = new System.Drawing.Size(181, 70);
            this.btnADMIN.TabIndex = 10;
            this.btnADMIN.Text = "Quản lý";
            this.btnADMIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnADMIN.UseVisualStyleBackColor = false;
            this.btnADMIN.Click += new System.EventHandler(this.btnADMIN_Click);
            // 
            // lbINFO
            // 
            this.lbINFO.AutoSize = true;
            this.lbINFO.BackColor = System.Drawing.Color.White;
            this.lbINFO.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINFO.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbINFO.Location = new System.Drawing.Point(220, 452);
            this.lbINFO.Name = "lbINFO";
            this.lbINFO.Size = new System.Drawing.Size(0, 28);
            this.lbINFO.TabIndex = 12;
            this.lbINFO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaleManagement.Properties.Resources.backgroundLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 675);
            this.Controls.Add(this.lbINFO);
            this.Controls.Add(this.btnSTAFF);
            this.Controls.Add(this.btnADMIN);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.txtUSER);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtUSER;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnSTAFF;
        private System.Windows.Forms.Button btnADMIN;
        private System.Windows.Forms.Label lbINFO;
    }
}