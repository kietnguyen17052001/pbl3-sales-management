
namespace SaleManagement.FORM
{
    partial class FrmEdit_Quantity
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
            this.SuspendLayout();
            // 
            // txtNEW_QUANTITY
            // 
            this.txtNEW_QUANTITY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNEW_QUANTITY.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNEW_QUANTITY.ForeColor = System.Drawing.Color.Silver;
            this.txtNEW_QUANTITY.Location = new System.Drawing.Point(244, 187);
            this.txtNEW_QUANTITY.Name = "txtNEW_QUANTITY";
            this.txtNEW_QUANTITY.Size = new System.Drawing.Size(203, 30);
            this.txtNEW_QUANTITY.TabIndex = 91;
            this.txtNEW_QUANTITY.Text = "Nhập số lượng mới";
            this.txtNEW_QUANTITY.Enter += new System.EventHandler(this.txtNEW_QUANTITY_Enter);
            this.txtNEW_QUANTITY.Leave += new System.EventHandler(this.txtNEW_QUANTITY_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
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
            this.btnSAVE.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAVE.Location = new System.Drawing.Point(128, 250);
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
            this.btnCANCEL.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCEL.Location = new System.Drawing.Point(265, 252);
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
            this.txtPRODUCT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRODUCT.ForeColor = System.Drawing.Color.Black;
            this.txtPRODUCT.Location = new System.Drawing.Point(244, 77);
            this.txtPRODUCT.Multiline = true;
            this.txtPRODUCT.Name = "txtPRODUCT";
            this.txtPRODUCT.Size = new System.Drawing.Size(203, 55);
            this.txtPRODUCT.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 95;
            this.label2.Text = "Hàng hóa";
            // 
            // txtQUANTITY
            // 
            this.txtQUANTITY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQUANTITY.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQUANTITY.ForeColor = System.Drawing.Color.Black;
            this.txtQUANTITY.Location = new System.Drawing.Point(244, 144);
            this.txtQUANTITY.Name = "txtQUANTITY";
            this.txtQUANTITY.Size = new System.Drawing.Size(203, 30);
            this.txtQUANTITY.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 97;
            this.label3.Text = "Số lượng";
            // 
            // FrmEdit_Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.txtQUANTITY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPRODUCT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.txtNEW_QUANTITY);
            this.Controls.Add(this.label1);
            this.Name = "FrmEdit_Quantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Quantity";
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
    }
}