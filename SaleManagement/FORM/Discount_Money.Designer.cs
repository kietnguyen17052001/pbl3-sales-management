﻿
namespace SaleManagement.FORM
{
    partial class FrmDiscount_Money
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDISCOUNT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 87;
            this.label2.Text = "VNĐ";
            // 
            // txtDISCOUNT
            // 
            this.txtDISCOUNT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDISCOUNT.BackColor = System.Drawing.SystemColors.Info;
            this.txtDISCOUNT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDISCOUNT.ForeColor = System.Drawing.Color.Silver;
            this.txtDISCOUNT.Location = new System.Drawing.Point(169, 50);
            this.txtDISCOUNT.Name = "txtDISCOUNT";
            this.txtDISCOUNT.Size = new System.Drawing.Size(203, 29);
            this.txtDISCOUNT.TabIndex = 86;
            this.txtDISCOUNT.Text = "Nhập số tiền";
            this.txtDISCOUNT.TextChanged += new System.EventHandler(this.txtDISCOUNT_TextChanged);
            this.txtDISCOUNT.Enter += new System.EventHandler(this.txtDISCOUNT_Enter);
            this.txtDISCOUNT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDISCOUNT_KeyPress);
            this.txtDISCOUNT.Leave += new System.EventHandler(this.txtDISCOUNT_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 85;
            this.label1.Text = "Giảm";
            // 
            // btnSAVE
            // 
            this.btnSAVE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSAVE.FlatAppearance.BorderSize = 0;
            this.btnSAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAVE.Location = new System.Drawing.Point(142, 119);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(121, 48);
            this.btnSAVE.TabIndex = 88;
            this.btnSAVE.Text = "Lưu";
            this.btnSAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCANCEL.BackColor = System.Drawing.Color.IndianRed;
            this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCANCEL.FlatAppearance.BorderSize = 0;
            this.btnCANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCEL.Location = new System.Drawing.Point(271, 119);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(121, 48);
            this.btnCANCEL.TabIndex = 89;
            this.btnCANCEL.Text = "Hủy bỏ";
            this.btnCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // FrmDiscount_Money
            // 
            this.AcceptButton = this.btnSAVE;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 215);
            this.ControlBox = false;
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDISCOUNT);
            this.Controls.Add(this.label1);
            this.Name = "FrmDiscount_Money";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảm tiền cho hóa đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDISCOUNT;
        private System.Windows.Forms.Label label1;
    }
}