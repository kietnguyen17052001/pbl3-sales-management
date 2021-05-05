
namespace SaleManagement.FORM
{
    partial class FrmCreate_NewCustomer
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
            this.txtADDRESS = new System.Windows.Forms.TextBox();
            this.txtPHONE = new System.Windows.Forms.TextBox();
            this.txtNAME_CUSTOMER = new System.Windows.Forms.TextBox();
            this.txtID_CUSTOMER = new System.Windows.Forms.TextBox();
            this.gbGioitinh = new System.Windows.Forms.GroupBox();
            this.rbFEMALE = new System.Windows.Forms.RadioButton();
            this.rbMALE = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.gbGioitinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtADDRESS
            // 
            this.txtADDRESS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtADDRESS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADDRESS.ForeColor = System.Drawing.Color.Black;
            this.txtADDRESS.Location = new System.Drawing.Point(167, 223);
            this.txtADDRESS.Name = "txtADDRESS";
            this.txtADDRESS.Size = new System.Drawing.Size(253, 28);
            this.txtADDRESS.TabIndex = 51;
            this.txtADDRESS.Enter += new System.EventHandler(this.txtADDRESS_Enter);
            this.txtADDRESS.Leave += new System.EventHandler(this.txtADDRESS_Leave);
            // 
            // txtPHONE
            // 
            this.txtPHONE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPHONE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPHONE.ForeColor = System.Drawing.Color.Black;
            this.txtPHONE.Location = new System.Drawing.Point(167, 181);
            this.txtPHONE.Name = "txtPHONE";
            this.txtPHONE.Size = new System.Drawing.Size(253, 28);
            this.txtPHONE.TabIndex = 50;
            this.txtPHONE.Enter += new System.EventHandler(this.txtPHONE_Enter);
            this.txtPHONE.Leave += new System.EventHandler(this.txtPHONE_Leave);
            // 
            // txtNAME_CUSTOMER
            // 
            this.txtNAME_CUSTOMER.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNAME_CUSTOMER.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAME_CUSTOMER.ForeColor = System.Drawing.Color.Black;
            this.txtNAME_CUSTOMER.Location = new System.Drawing.Point(167, 138);
            this.txtNAME_CUSTOMER.Name = "txtNAME_CUSTOMER";
            this.txtNAME_CUSTOMER.Size = new System.Drawing.Size(253, 28);
            this.txtNAME_CUSTOMER.TabIndex = 49;
            this.txtNAME_CUSTOMER.Enter += new System.EventHandler(this.txtNAME_CUSTOMER_Enter);
            this.txtNAME_CUSTOMER.Leave += new System.EventHandler(this.txtNAME_CUSTOMER_Leave);
            // 
            // txtID_CUSTOMER
            // 
            this.txtID_CUSTOMER.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID_CUSTOMER.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_CUSTOMER.Location = new System.Drawing.Point(167, 92);
            this.txtID_CUSTOMER.Name = "txtID_CUSTOMER";
            this.txtID_CUSTOMER.Size = new System.Drawing.Size(253, 28);
            this.txtID_CUSTOMER.TabIndex = 48;
            // 
            // gbGioitinh
            // 
            this.gbGioitinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbGioitinh.Controls.Add(this.rbFEMALE);
            this.gbGioitinh.Controls.Add(this.rbMALE);
            this.gbGioitinh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGioitinh.Location = new System.Drawing.Point(79, 267);
            this.gbGioitinh.Name = "gbGioitinh";
            this.gbGioitinh.Size = new System.Drawing.Size(220, 128);
            this.gbGioitinh.TabIndex = 47;
            this.gbGioitinh.TabStop = false;
            this.gbGioitinh.Text = "Giới tính";
            // 
            // rbFEMALE
            // 
            this.rbFEMALE.AutoSize = true;
            this.rbFEMALE.Location = new System.Drawing.Point(88, 68);
            this.rbFEMALE.Name = "rbFEMALE";
            this.rbFEMALE.Size = new System.Drawing.Size(61, 25);
            this.rbFEMALE.TabIndex = 1;
            this.rbFEMALE.TabStop = true;
            this.rbFEMALE.Text = "Nữ";
            this.rbFEMALE.UseVisualStyleBackColor = true;
            // 
            // rbMALE
            // 
            this.rbMALE.AutoSize = true;
            this.rbMALE.Location = new System.Drawing.Point(88, 25);
            this.rbMALE.Name = "rbMALE";
            this.rbMALE.Size = new System.Drawing.Size(75, 25);
            this.rbMALE.TabIndex = 0;
            this.rbMALE.TabStop = true;
            this.rbMALE.Text = "Nam";
            this.rbMALE.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Số ĐT";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên KH";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã KH";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(138, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 42;
            this.label1.Text = "THÊM KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCANCEL.BackColor = System.Drawing.Color.IndianRed;
            this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCANCEL.FlatAppearance.BorderSize = 0;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCEL.Location = new System.Drawing.Point(361, 339);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(121, 56);
            this.btnCANCEL.TabIndex = 83;
            this.btnCANCEL.Text = "Hủy bỏ";
            this.btnCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSAVE.FlatAppearance.BorderSize = 0;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAVE.Location = new System.Drawing.Point(361, 278);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(121, 55);
            this.btnSAVE.TabIndex = 82;
            this.btnSAVE.Text = "Lưu";
            this.btnSAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // FrmCreate_NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 440);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.txtADDRESS);
            this.Controls.Add(this.txtPHONE);
            this.Controls.Add(this.txtNAME_CUSTOMER);
            this.Controls.Add(this.txtID_CUSTOMER);
            this.Controls.Add(this.gbGioitinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FrmCreate_NewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_NewCustomer";
            this.gbGioitinh.ResumeLayout(false);
            this.gbGioitinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtADDRESS;
        private System.Windows.Forms.TextBox txtPHONE;
        private System.Windows.Forms.TextBox txtNAME_CUSTOMER;
        private System.Windows.Forms.TextBox txtID_CUSTOMER;
        private System.Windows.Forms.GroupBox gbGioitinh;
        private System.Windows.Forms.RadioButton rbFEMALE;
        private System.Windows.Forms.RadioButton rbMALE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnSAVE;
    }
}