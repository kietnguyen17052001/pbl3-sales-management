
namespace SaleManagement.FORM
{
    partial class FrmCreate_NewTypeItem
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
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.txtNameTypeOfProduct = new System.Windows.Forms.TextBox();
            this.txtIdTypeOfProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCANCEL.BackColor = System.Drawing.Color.IndianRed;
            this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCANCEL.FlatAppearance.BorderSize = 0;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCEL.Location = new System.Drawing.Point(273, 257);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(121, 55);
            this.btnCANCEL.TabIndex = 95;
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
            this.btnSAVE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAVE.Location = new System.Drawing.Point(144, 257);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(121, 55);
            this.btnSAVE.TabIndex = 94;
            this.btnSAVE.Text = "Lưu";
            this.btnSAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // txtNameTypeOfProduct
            // 
            this.txtNameTypeOfProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNameTypeOfProduct.BackColor = System.Drawing.SystemColors.Info;
            this.txtNameTypeOfProduct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameTypeOfProduct.ForeColor = System.Drawing.Color.Black;
            this.txtNameTypeOfProduct.Location = new System.Drawing.Point(199, 174);
            this.txtNameTypeOfProduct.Name = "txtNameTypeOfProduct";
            this.txtNameTypeOfProduct.Size = new System.Drawing.Size(253, 28);
            this.txtNameTypeOfProduct.TabIndex = 91;
            // 
            // txtIdTypeOfProduct
            // 
            this.txtIdTypeOfProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdTypeOfProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIdTypeOfProduct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTypeOfProduct.ForeColor = System.Drawing.Color.IndianRed;
            this.txtIdTypeOfProduct.Location = new System.Drawing.Point(199, 113);
            this.txtIdTypeOfProduct.Name = "txtIdTypeOfProduct";
            this.txtIdTypeOfProduct.Size = new System.Drawing.Size(253, 28);
            this.txtIdTypeOfProduct.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tên loại HH";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 85;
            this.label5.Text = "Mã loại HH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(148, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 27);
            this.label6.TabIndex = 121;
            this.label6.Text = "Thêm loại hàng hóa";
            // 
            // FrmCreate_NewTypeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 440);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.txtNameTypeOfProduct);
            this.Controls.Add(this.txtIdTypeOfProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "FrmCreate_NewTypeItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại hàng hóa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.TextBox txtNameTypeOfProduct;
        private System.Windows.Forms.TextBox txtIdTypeOfProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}