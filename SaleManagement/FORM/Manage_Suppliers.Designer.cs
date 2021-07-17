
namespace SaleManagement.VIEW
{
    partial class FrmManage_Suppliers
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtADDRESS = new System.Windows.Forms.TextBox();
            this.txtPHONE = new System.Windows.Forms.TextBox();
            this.txtNAME_SUPPLIER = new System.Windows.Forms.TextBox();
            this.txtID_SUPPLIER = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSUPPLIER = new System.Windows.Forms.DataGridView();
            this.txtFAX = new System.Windows.Forms.TextBox();
            this.txtID_TAX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHOME = new System.Windows.Forms.Button();
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSUPPLIER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 22);
            this.label10.TabIndex = 78;
            this.label10.Text = "Fax";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMAIL.ForeColor = System.Drawing.Color.Black;
            this.txtEMAIL.Location = new System.Drawing.Point(147, 322);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(237, 29);
            this.txtEMAIL.TabIndex = 77;
            // 
            // txtADDRESS
            // 
            this.txtADDRESS.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADDRESS.ForeColor = System.Drawing.Color.Black;
            this.txtADDRESS.Location = new System.Drawing.Point(147, 277);
            this.txtADDRESS.Name = "txtADDRESS";
            this.txtADDRESS.Size = new System.Drawing.Size(237, 29);
            this.txtADDRESS.TabIndex = 76;
            // 
            // txtPHONE
            // 
            this.txtPHONE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPHONE.ForeColor = System.Drawing.Color.Black;
            this.txtPHONE.Location = new System.Drawing.Point(147, 236);
            this.txtPHONE.Name = "txtPHONE";
            this.txtPHONE.Size = new System.Drawing.Size(237, 29);
            this.txtPHONE.TabIndex = 75;
            this.txtPHONE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFAX_KeyPress);
            // 
            // txtNAME_SUPPLIER
            // 
            this.txtNAME_SUPPLIER.BackColor = System.Drawing.SystemColors.Info;
            this.txtNAME_SUPPLIER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAME_SUPPLIER.ForeColor = System.Drawing.Color.Black;
            this.txtNAME_SUPPLIER.Location = new System.Drawing.Point(147, 195);
            this.txtNAME_SUPPLIER.Name = "txtNAME_SUPPLIER";
            this.txtNAME_SUPPLIER.Size = new System.Drawing.Size(237, 29);
            this.txtNAME_SUPPLIER.TabIndex = 74;
            // 
            // txtID_SUPPLIER
            // 
            this.txtID_SUPPLIER.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtID_SUPPLIER.Enabled = false;
            this.txtID_SUPPLIER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_SUPPLIER.ForeColor = System.Drawing.Color.IndianRed;
            this.txtID_SUPPLIER.Location = new System.Drawing.Point(147, 157);
            this.txtID_SUPPLIER.Name = "txtID_SUPPLIER";
            this.txtID_SUPPLIER.Size = new System.Drawing.Size(237, 29);
            this.txtID_SUPPLIER.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 72;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 71;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 70;
            this.label3.Text = "Số ĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 69;
            this.label6.Text = "Tên NCC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 68;
            this.label7.Text = "Mã NCC";
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(397, 114);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(274, 29);
            this.txtSEARCH.TabIndex = 67;
            this.txtSEARCH.Text = "Nhập tên hoặc mã nhà cung cấp";
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(908, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 26);
            this.label2.TabIndex = 62;
            this.label2.Text = "DANH SÁCH NHÀ CUNG CẤP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvSUPPLIER
            // 
            this.dgvSUPPLIER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSUPPLIER.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSUPPLIER.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSUPPLIER.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSUPPLIER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSUPPLIER.Location = new System.Drawing.Point(398, 157);
            this.dgvSUPPLIER.Name = "dgvSUPPLIER";
            this.dgvSUPPLIER.RowHeadersVisible = false;
            this.dgvSUPPLIER.RowHeadersWidth = 62;
            this.dgvSUPPLIER.RowTemplate.Height = 28;
            this.dgvSUPPLIER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSUPPLIER.Size = new System.Drawing.Size(824, 470);
            this.dgvSUPPLIER.TabIndex = 61;
            this.dgvSUPPLIER.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSUPPLIER_CellClick);
            this.dgvSUPPLIER.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSUPPLIER_CellFormatting);
            // 
            // txtFAX
            // 
            this.txtFAX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFAX.ForeColor = System.Drawing.Color.Black;
            this.txtFAX.Location = new System.Drawing.Point(147, 362);
            this.txtFAX.Name = "txtFAX";
            this.txtFAX.Size = new System.Drawing.Size(237, 29);
            this.txtFAX.TabIndex = 78;
            this.txtFAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFAX_KeyPress);
            // 
            // txtID_TAX
            // 
            this.txtID_TAX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_TAX.ForeColor = System.Drawing.Color.Black;
            this.txtID_TAX.Location = new System.Drawing.Point(147, 404);
            this.txtID_TAX.Name = "txtID_TAX";
            this.txtID_TAX.Size = new System.Drawing.Size(237, 29);
            this.txtID_TAX.TabIndex = 79;
            this.txtID_TAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFAX_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 90;
            this.label8.Text = "Mã số thuế";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Image = global::SaleManagement.Properties.Resources.plus_5_24;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(7, 467);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(122, 64);
            this.btnADD.TabIndex = 83;
            this.btnADD.Text = "Thêm";
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEDIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEDIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDIT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.ForeColor = System.Drawing.Color.White;
            this.btnEDIT.Image = global::SaleManagement.Properties.Resources.edit_3_24;
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.Location = new System.Drawing.Point(135, 467);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(121, 64);
            this.btnEDIT.TabIndex = 84;
            this.btnEDIT.Text = "Sửa";
            this.btnEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT.UseVisualStyleBackColor = false;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBACK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBACK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnBACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBACK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBACK.ForeColor = System.Drawing.Color.White;
            this.btnBACK.Image = global::SaleManagement.Properties.Resources.arrow_121_24;
            this.btnBACK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBACK.Location = new System.Drawing.Point(1058, 6);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(173, 65);
            this.btnBACK.TabIndex = 88;
            this.btnBACK.Text = "Quay lại";
            this.btnBACK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBACK.UseVisualStyleBackColor = false;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAVE.Location = new System.Drawing.Point(262, 467);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(130, 64);
            this.btnSAVE.TabIndex = 86;
            this.btnSAVE.Text = "Lưu";
            this.btnSAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.Color.IndianRed;
            this.btnCANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCEL.Location = new System.Drawing.Point(262, 537);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(130, 56);
            this.btnCANCEL.TabIndex = 87;
            this.btnCANCEL.Text = "Hủy bỏ";
            this.btnCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.IndianRed;
            this.btnDELETE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnDELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.Color.White;
            this.btnDELETE.Image = global::SaleManagement.Properties.Resources.delete_property_24;
            this.btnDELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDELETE.Location = new System.Drawing.Point(7, 537);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(249, 56);
            this.btnDELETE.TabIndex = 85;
            this.btnDELETE.Text = "Xóa nhà cung cấp";
            this.btnDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(677, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(452, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 27);
            this.label1.TabIndex = 140;
            this.label1.Text = "Quản lý thông tin nhà cung cấp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHOME
            // 
            this.btnHOME.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHOME.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHOME.FlatAppearance.BorderSize = 0;
            this.btnHOME.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnHOME.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHOME.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHOME.ForeColor = System.Drawing.Color.White;
            this.btnHOME.Image = global::SaleManagement.Properties.Resources.house_48;
            this.btnHOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHOME.Location = new System.Drawing.Point(5, 6);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(197, 65);
            this.btnHOME.TabIndex = 139;
            this.btnHOME.Text = "Trang chủ";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEXCEL.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEXCEL.FlatAppearance.BorderSize = 0;
            this.btnEXCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnEXCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXCEL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXCEL.ForeColor = System.Drawing.Color.White;
            this.btnEXCEL.Image = global::SaleManagement.Properties.Resources.excel_3_24;
            this.btnEXCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEXCEL.Location = new System.Drawing.Point(730, 103);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(154, 48);
            this.btnEXCEL.TabIndex = 141;
            this.btnEXCEL.Text = "Xuất Excel";
            this.btnEXCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEXCEL.UseVisualStyleBackColor = false;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.IndianRed;
            this.lbQuantity.Location = new System.Drawing.Point(646, 648);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(0, 22);
            this.lbQuantity.TabIndex = 146;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(411, 648);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 22);
            this.label9.TabIndex = 145;
            this.label9.Text = "Số lượng nhà cung cấp:";
            // 
            // FrmManage_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1234, 691);
            this.ControlBox = false;
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtID_TAX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFAX);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtADDRESS);
            this.Controls.Add(this.txtPHONE);
            this.Controls.Add(this.txtNAME_SUPPLIER);
            this.Controls.Add(this.txtID_SUPPLIER);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSUPPLIER);
            this.Name = "FrmManage_Suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSUPPLIER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtADDRESS;
        private System.Windows.Forms.TextBox txtPHONE;
        private System.Windows.Forms.TextBox txtNAME_SUPPLIER;
        private System.Windows.Forms.TextBox txtID_SUPPLIER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSUPPLIER;
        private System.Windows.Forms.TextBox txtFAX;
        private System.Windows.Forms.TextBox txtID_TAX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label label9;
    }
}