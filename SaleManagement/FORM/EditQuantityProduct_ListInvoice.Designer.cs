
namespace SaleManagement.FORM
{
    partial class FrmEditQuantityProduct_ListInvoice
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
            this.txtNEW_QUANTITY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.txtPRODUCT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQUANTITY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSTATUS = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbQUANTITY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNEW_QUANTITY
            // 
            this.txtNEW_QUANTITY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNEW_QUANTITY.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNEW_QUANTITY.ForeColor = System.Drawing.Color.Black;
            this.txtNEW_QUANTITY.Location = new System.Drawing.Point(263, 188);
            this.txtNEW_QUANTITY.Name = "txtNEW_QUANTITY";
            this.txtNEW_QUANTITY.Size = new System.Drawing.Size(203, 32);
            this.txtNEW_QUANTITY.TabIndex = 91;
            this.txtNEW_QUANTITY.TextChanged += new System.EventHandler(this.txtNEW_QUANTITY_TextChanged);
            this.txtNEW_QUANTITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNEW_QUANTITY_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 90;
            this.label1.Text = "Số lượng mới";
            // 
            // btnSAVE
            // 
            this.btnSAVE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSAVE.FlatAppearance.BorderSize = 0;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAVE.Location = new System.Drawing.Point(126, 280);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(121, 48);
            this.btnSAVE.TabIndex = 93;
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
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCEL.Location = new System.Drawing.Point(263, 282);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(121, 46);
            this.btnCANCEL.TabIndex = 94;
            this.btnCANCEL.Text = "Hủy bỏ";
            this.btnCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // txtPRODUCT
            // 
            this.txtPRODUCT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPRODUCT.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRODUCT.ForeColor = System.Drawing.Color.Black;
            this.txtPRODUCT.Location = new System.Drawing.Point(263, 12);
            this.txtPRODUCT.Multiline = true;
            this.txtPRODUCT.Name = "txtPRODUCT";
            this.txtPRODUCT.Size = new System.Drawing.Size(203, 87);
            this.txtPRODUCT.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "Hàng hóa";
            // 
            // txtQUANTITY
            // 
            this.txtQUANTITY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQUANTITY.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQUANTITY.ForeColor = System.Drawing.Color.Black;
            this.txtQUANTITY.Location = new System.Drawing.Point(262, 141);
            this.txtQUANTITY.Name = "txtQUANTITY";
            this.txtQUANTITY.Size = new System.Drawing.Size(203, 32);
            this.txtQUANTITY.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 97;
            this.label3.Text = "Số lượng cũ";
            // 
            // lbSTATUS
            // 
            this.lbSTATUS.AutoSize = true;
            this.lbSTATUS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSTATUS.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbSTATUS.Location = new System.Drawing.Point(150, 235);
            this.lbSTATUS.Name = "lbSTATUS";
            this.lbSTATUS.Size = new System.Drawing.Size(0, 27);
            this.lbSTATUS.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(68, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 144;
            this.label4.Text = "Số lượng";
            // 
            // lbQUANTITY
            // 
            this.lbQUANTITY.AutoSize = true;
            this.lbQUANTITY.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQUANTITY.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbQUANTITY.Location = new System.Drawing.Point(258, 104);
            this.lbQUANTITY.Name = "lbQUANTITY";
            this.lbQUANTITY.Size = new System.Drawing.Size(0, 24);
            this.lbQUANTITY.TabIndex = 145;
            // 
            // FrmEditQuantityProduct_ListInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 340);
            this.Controls.Add(this.lbQUANTITY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSTATUS);
            this.Controls.Add(this.txtQUANTITY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPRODUCT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.txtNEW_QUANTITY);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditQuantityProduct_ListInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa số lượng hàng hóa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.TextBox txtNEW_QUANTITY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPRODUCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQUANTITY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSTATUS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbQUANTITY;
    }
}