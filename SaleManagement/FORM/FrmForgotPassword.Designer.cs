
namespace SaleManagement.FORM
{
    partial class FrmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForgotPassword));
            this.lbWarning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReWriteNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCancelChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearchResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.BackColor = System.Drawing.Color.White;
            this.lbWarning.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.lbWarning.Location = new System.Drawing.Point(233, 542);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 22);
            this.lbWarning.TabIndex = 22;
            this.lbWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(389, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "N3K";
            // 
            // txtReWriteNewPassword
            // 
            this.txtReWriteNewPassword.Enabled = false;
            this.txtReWriteNewPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReWriteNewPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtReWriteNewPassword.Location = new System.Drawing.Point(208, 487);
            this.txtReWriteNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReWriteNewPassword.Multiline = true;
            this.txtReWriteNewPassword.Name = "txtReWriteNewPassword";
            this.txtReWriteNewPassword.Size = new System.Drawing.Size(373, 45);
            this.txtReWriteNewPassword.TabIndex = 18;
            this.txtReWriteNewPassword.Text = "Nhập lại mật khẩu mới";
            this.txtReWriteNewPassword.TextChanged += new System.EventHandler(this.txtReWriteNewPassword_TextChanged);
            this.txtReWriteNewPassword.Enter += new System.EventHandler(this.txtReWriteNewPassword_Enter);
            this.txtReWriteNewPassword.Leave += new System.EventHandler(this.txtReWriteNewPassword_Leave);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Enabled = false;
            this.txtNewPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtNewPassword.Location = new System.Drawing.Point(208, 421);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(373, 45);
            this.txtNewPassword.TabIndex = 17;
            this.txtNewPassword.Text = "Nhập mật khẩu mới";
            this.txtNewPassword.Enter += new System.EventHandler(this.txtNewPassword_Enter);
            this.txtNewPassword.Leave += new System.EventHandler(this.txtNewPassword_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Silver;
            this.txtPhone.Location = new System.Drawing.Point(208, 256);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(373, 45);
            this.txtPhone.TabIndex = 16;
            this.txtPhone.Text = "Nhập số điện thoại";
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quên mật khẩu";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(120, 487);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 45);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(120, 421);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 45);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::SaleManagement.Properties.Resources.phone_call;
            this.pictureBox3.Location = new System.Drawing.Point(120, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 45);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // btnCancelChange
            // 
            this.btnCancelChange.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelChange.Enabled = false;
            this.btnCancelChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCancelChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCancelChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelChange.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChange.ForeColor = System.Drawing.Color.White;
            this.btnCancelChange.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCancelChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelChange.Location = new System.Drawing.Point(384, 582);
            this.btnCancelChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelChange.Name = "btnCancelChange";
            this.btnCancelChange.Size = new System.Drawing.Size(136, 55);
            this.btnCancelChange.TabIndex = 20;
            this.btnCancelChange.Text = "Hủy bỏ";
            this.btnCancelChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelChange.UseVisualStyleBackColor = false;
            this.btnCancelChange.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(238, 582);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 55);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::SaleManagement.Properties.Resources.cart_8_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(315, 123);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 58);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(97, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 580);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = global::SaleManagement.Properties.Resources.email;
            this.pictureBox6.Location = new System.Drawing.Point(120, 193);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(68, 45);
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(208, 193);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(373, 45);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Text = "Nhập email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCancelSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSearch.ForeColor = System.Drawing.Color.White;
            this.btnCancelSearch.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCancelSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelSearch.Location = new System.Drawing.Point(384, 355);
            this.btnCancelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(136, 55);
            this.btnCancelSearch.TabIndex = 29;
            this.btnCancelSearch.Text = "Hủy bỏ";
            this.btnCancelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelSearch.UseVisualStyleBackColor = false;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::SaleManagement.Properties.Resources.search_12_241;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(238, 355);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 55);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbSearchResult
            // 
            this.lbSearchResult.AutoSize = true;
            this.lbSearchResult.BackColor = System.Drawing.Color.White;
            this.lbSearchResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchResult.ForeColor = System.Drawing.Color.IndianRed;
            this.lbSearchResult.Location = new System.Drawing.Point(234, 316);
            this.lbSearchResult.Name = "lbSearchResult";
            this.lbSearchResult.Size = new System.Drawing.Size(0, 22);
            this.lbSearchResult.TabIndex = 30;
            this.lbSearchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmForgotPassword
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaleManagement.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(766, 690);
            this.ControlBox = false;
            this.Controls.Add(this.lbSearchResult);
            this.Controls.Add(this.btnCancelSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.btnCancelChange);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtReWriteNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Button btnCancelChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtReWriteNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbSearchResult;
    }
}