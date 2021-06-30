
namespace SaleManagement.VIEW
{
    partial class FrmManage_Items
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
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLISTPRODUCT = new System.Windows.Forms.DataGridView();
            this.cbbTYPE_OF_PRODUCT = new System.Windows.Forms.ComboBox();
            this.txtQUANTITY = new System.Windows.Forms.TextBox();
            this.txtNAME_PRODUCT = new System.Windows.Forms.TextBox();
            this.txtID_PRODUCT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSALE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBUY = new System.Windows.Forms.TextBox();
            this.gbMota = new System.Windows.Forms.GroupBox();
            this.txtDESCRIBE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnADDPIC = new System.Windows.Forms.Button();
            this.pbIMAGE = new System.Windows.Forms.PictureBox();
            this.btnHOME = new System.Windows.Forms.Button();
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.btnADDTYPE = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnADDPRODUCER = new System.Windows.Forms.Button();
            this.cbbPRODUCERs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTPRODUCT)).BeginInit();
            this.gbMota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMAGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(402, 68);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(360, 27);
            this.txtSEARCH.TabIndex = 67;
            this.txtSEARCH.Text = "Nhập mã hoặc tên hàng hóa, loại hàng hóa";
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(976, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 26);
            this.label2.TabIndex = 62;
            this.label2.Text = "DANH SÁCH HÀNG HÓA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvLISTPRODUCT
            // 
            this.dgvLISTPRODUCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTPRODUCT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLISTPRODUCT.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLISTPRODUCT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTPRODUCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTPRODUCT.Location = new System.Drawing.Point(402, 108);
            this.dgvLISTPRODUCT.Name = "dgvLISTPRODUCT";
            this.dgvLISTPRODUCT.RowHeadersVisible = false;
            this.dgvLISTPRODUCT.RowHeadersWidth = 62;
            this.dgvLISTPRODUCT.RowTemplate.Height = 28;
            this.dgvLISTPRODUCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTPRODUCT.Size = new System.Drawing.Size(836, 518);
            this.dgvLISTPRODUCT.TabIndex = 61;
            this.dgvLISTPRODUCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLISTITEMS_CellClick);
            this.dgvLISTPRODUCT.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLISTITEMS_CellFormatting);
            // 
            // cbbTYPE_OF_PRODUCT
            // 
            this.cbbTYPE_OF_PRODUCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTYPE_OF_PRODUCT.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTYPE_OF_PRODUCT.FormattingEnabled = true;
            this.cbbTYPE_OF_PRODUCT.Location = new System.Drawing.Point(133, 115);
            this.cbbTYPE_OF_PRODUCT.Name = "cbbTYPE_OF_PRODUCT";
            this.cbbTYPE_OF_PRODUCT.Size = new System.Drawing.Size(210, 27);
            this.cbbTYPE_OF_PRODUCT.TabIndex = 97;
            this.cbbTYPE_OF_PRODUCT.SelectedIndexChanged += new System.EventHandler(this.cbbTYPE_OF_ITEMS_SelectedIndexChanged);
            // 
            // txtQUANTITY
            // 
            this.txtQUANTITY.Enabled = false;
            this.txtQUANTITY.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQUANTITY.ForeColor = System.Drawing.Color.Black;
            this.txtQUANTITY.Location = new System.Drawing.Point(133, 236);
            this.txtQUANTITY.Name = "txtQUANTITY";
            this.txtQUANTITY.Size = new System.Drawing.Size(210, 27);
            this.txtQUANTITY.TabIndex = 96;
            this.txtQUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQUANTITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSALE_KeyPress);
            // 
            // txtNAME_PRODUCT
            // 
            this.txtNAME_PRODUCT.BackColor = System.Drawing.SystemColors.Info;
            this.txtNAME_PRODUCT.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAME_PRODUCT.ForeColor = System.Drawing.Color.Black;
            this.txtNAME_PRODUCT.Location = new System.Drawing.Point(133, 155);
            this.txtNAME_PRODUCT.Name = "txtNAME_PRODUCT";
            this.txtNAME_PRODUCT.Size = new System.Drawing.Size(263, 27);
            this.txtNAME_PRODUCT.TabIndex = 95;
            // 
            // txtID_PRODUCT
            // 
            this.txtID_PRODUCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtID_PRODUCT.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_PRODUCT.ForeColor = System.Drawing.Color.IndianRed;
            this.txtID_PRODUCT.Location = new System.Drawing.Point(133, 75);
            this.txtID_PRODUCT.Name = "txtID_PRODUCT";
            this.txtID_PRODUCT.Size = new System.Drawing.Size(210, 27);
            this.txtID_PRODUCT.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 92;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 91;
            this.label3.Text = "Tên HH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 90;
            this.label6.Text = "Loại HH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 89;
            this.label7.Text = "Mã HH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(349, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 19);
            this.label14.TabIndex = 107;
            this.label14.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(349, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 19);
            this.label13.TabIndex = 106;
            this.label13.Text = "VNĐ";
            // 
            // txtSALE
            // 
            this.txtSALE.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtSALE.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSALE.ForeColor = System.Drawing.Color.Black;
            this.txtSALE.Location = new System.Drawing.Point(133, 316);
            this.txtSALE.Name = "txtSALE";
            this.txtSALE.Size = new System.Drawing.Size(210, 27);
            this.txtSALE.TabIndex = 105;
            this.txtSALE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSALE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSALE_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 22);
            this.label10.TabIndex = 104;
            this.label10.Text = "Giá bán";
            // 
            // txtBUY
            // 
            this.txtBUY.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtBUY.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBUY.ForeColor = System.Drawing.Color.Black;
            this.txtBUY.Location = new System.Drawing.Point(133, 277);
            this.txtBUY.Name = "txtBUY";
            this.txtBUY.Size = new System.Drawing.Size(210, 27);
            this.txtBUY.TabIndex = 103;
            this.txtBUY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBUY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSALE_KeyPress);
            // 
            // gbMota
            // 
            this.gbMota.Controls.Add(this.txtDESCRIBE);
            this.gbMota.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMota.Location = new System.Drawing.Point(12, 350);
            this.gbMota.Name = "gbMota";
            this.gbMota.Size = new System.Drawing.Size(196, 218);
            this.gbMota.TabIndex = 101;
            this.gbMota.TabStop = false;
            this.gbMota.Text = "Mô tả";
            // 
            // txtDESCRIBE
            // 
            this.txtDESCRIBE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDESCRIBE.ForeColor = System.Drawing.Color.Black;
            this.txtDESCRIBE.Location = new System.Drawing.Point(6, 25);
            this.txtDESCRIBE.Multiline = true;
            this.txtDESCRIBE.Name = "txtDESCRIBE";
            this.txtDESCRIBE.Size = new System.Drawing.Size(184, 187);
            this.txtDESCRIBE.TabIndex = 28;
            this.txtDESCRIBE.Text = "Nhập mô tả ...";
            this.txtDESCRIBE.Leave += new System.EventHandler(this.txtDESCRIBE_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 22);
            this.label9.TabIndex = 100;
            this.label9.Text = "Giá mua";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(472, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 27);
            this.label1.TabIndex = 123;
            this.label1.Text = "Quản lý thông tin hàng hóa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnADDPIC
            // 
            this.btnADDPIC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADDPIC.FlatAppearance.BorderSize = 0;
            this.btnADDPIC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnADDPIC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnADDPIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDPIC.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDPIC.ForeColor = System.Drawing.Color.White;
            this.btnADDPIC.Location = new System.Drawing.Point(250, 350);
            this.btnADDPIC.Name = "btnADDPIC";
            this.btnADDPIC.Size = new System.Drawing.Size(114, 32);
            this.btnADDPIC.TabIndex = 125;
            this.btnADDPIC.Text = "Thêm ảnh";
            this.btnADDPIC.UseVisualStyleBackColor = false;
            this.btnADDPIC.Click += new System.EventHandler(this.btnADDPIC_Click);
            // 
            // pbIMAGE
            // 
            this.pbIMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIMAGE.Location = new System.Drawing.Point(214, 388);
            this.pbIMAGE.Name = "pbIMAGE";
            this.pbIMAGE.Size = new System.Drawing.Size(179, 180);
            this.pbIMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIMAGE.TabIndex = 124;
            this.pbIMAGE.TabStop = false;
            // 
            // btnHOME
            // 
            this.btnHOME.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btnHOME.Location = new System.Drawing.Point(5, 3);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(197, 60);
            this.btnHOME.TabIndex = 122;
            this.btnHOME.Text = "Trang chủ";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // btnEXCEL
            // 
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
            this.btnEXCEL.Location = new System.Drawing.Point(820, 56);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(154, 46);
            this.btnEXCEL.TabIndex = 121;
            this.btnEXCEL.Text = "Xuất Excel";
            this.btnEXCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEXCEL.UseVisualStyleBackColor = false;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
            // 
            // btnADDTYPE
            // 
            this.btnADDTYPE.BackColor = System.Drawing.SystemColors.Control;
            this.btnADDTYPE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADDTYPE.FlatAppearance.BorderSize = 0;
            this.btnADDTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDTYPE.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDTYPE.ForeColor = System.Drawing.Color.White;
            this.btnADDTYPE.Image = global::SaleManagement.Properties.Resources.plus_5_24__1_;
            this.btnADDTYPE.Location = new System.Drawing.Point(349, 107);
            this.btnADDTYPE.Name = "btnADDTYPE";
            this.btnADDTYPE.Size = new System.Drawing.Size(44, 46);
            this.btnADDTYPE.TabIndex = 118;
            this.btnADDTYPE.UseVisualStyleBackColor = false;
            this.btnADDTYPE.Click += new System.EventHandler(this.btnADDTYPE_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Image = global::SaleManagement.Properties.Resources.plus_5_24;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(6, 574);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(122, 52);
            this.btnADD.TabIndex = 83;
            this.btnADD.Text = "Thêm";
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEDIT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEDIT.FlatAppearance.BorderSize = 0;
            this.btnEDIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEDIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDIT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.ForeColor = System.Drawing.Color.White;
            this.btnEDIT.Image = global::SaleManagement.Properties.Resources.edit_3_24;
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.Location = new System.Drawing.Point(134, 574);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(121, 52);
            this.btnEDIT.TabIndex = 84;
            this.btnEDIT.Text = "Sửa";
            this.btnEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT.UseVisualStyleBackColor = false;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBACK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBACK.FlatAppearance.BorderSize = 0;
            this.btnBACK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBACK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnBACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBACK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBACK.ForeColor = System.Drawing.Color.White;
            this.btnBACK.Image = global::SaleManagement.Properties.Resources.arrow_121_24;
            this.btnBACK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBACK.Location = new System.Drawing.Point(1081, 3);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(160, 60);
            this.btnBACK.TabIndex = 88;
            this.btnBACK.Text = "Quay lại";
            this.btnBACK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBACK.UseVisualStyleBackColor = false;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSAVE.FlatAppearance.BorderSize = 0;
            this.btnSAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAVE.Location = new System.Drawing.Point(260, 574);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(133, 52);
            this.btnSAVE.TabIndex = 86;
            this.btnSAVE.Text = "Lưu";
            this.btnSAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.Color.IndianRed;
            this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCANCEL.FlatAppearance.BorderSize = 0;
            this.btnCANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCEL.Location = new System.Drawing.Point(260, 631);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(133, 49);
            this.btnCANCEL.TabIndex = 87;
            this.btnCANCEL.Text = "Hủy bỏ";
            this.btnCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.IndianRed;
            this.btnDELETE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDELETE.FlatAppearance.BorderSize = 0;
            this.btnDELETE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnDELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.Color.White;
            this.btnDELETE.Image = global::SaleManagement.Properties.Resources.delete_property_24;
            this.btnDELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDELETE.Location = new System.Drawing.Point(6, 630);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(248, 49);
            this.btnDELETE.TabIndex = 85;
            this.btnDELETE.Text = "Xóa hàng hóa";
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
            this.pictureBox1.Location = new System.Drawing.Point(768, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // btnADDPRODUCER
            // 
            this.btnADDPRODUCER.BackColor = System.Drawing.SystemColors.Control;
            this.btnADDPRODUCER.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADDPRODUCER.FlatAppearance.BorderSize = 0;
            this.btnADDPRODUCER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDPRODUCER.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDPRODUCER.ForeColor = System.Drawing.Color.White;
            this.btnADDPRODUCER.Image = global::SaleManagement.Properties.Resources.plus_5_24__1_;
            this.btnADDPRODUCER.Location = new System.Drawing.Point(349, 188);
            this.btnADDPRODUCER.Name = "btnADDPRODUCER";
            this.btnADDPRODUCER.Size = new System.Drawing.Size(44, 44);
            this.btnADDPRODUCER.TabIndex = 140;
            this.btnADDPRODUCER.UseVisualStyleBackColor = false;
            this.btnADDPRODUCER.Click += new System.EventHandler(this.btnADDPRODUCER_Click);
            // 
            // cbbPRODUCERs
            // 
            this.cbbPRODUCERs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPRODUCERs.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPRODUCERs.FormattingEnabled = true;
            this.cbbPRODUCERs.Location = new System.Drawing.Point(133, 197);
            this.cbbPRODUCERs.Name = "cbbPRODUCERs";
            this.cbbPRODUCERs.Size = new System.Drawing.Size(210, 27);
            this.cbbPRODUCERs.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 138;
            this.label5.Text = "Nhà SX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(418, 644);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 22);
            this.label8.TabIndex = 141;
            this.label8.Text = "Số lượng hàng hóa:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.IndianRed;
            this.lbQuantity.Location = new System.Drawing.Point(610, 644);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(0, 22);
            this.lbQuantity.TabIndex = 142;
            // 
            // FrmManage_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1247, 691);
            this.ControlBox = false;
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnADDPRODUCER);
            this.Controls.Add(this.cbbPRODUCERs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnADDPIC);
            this.Controls.Add(this.pbIMAGE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.btnADDTYPE);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSALE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBUY);
            this.Controls.Add(this.gbMota);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbTYPE_OF_PRODUCT);
            this.Controls.Add(this.txtQUANTITY);
            this.Controls.Add(this.txtNAME_PRODUCT);
            this.Controls.Add(this.txtID_PRODUCT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLISTPRODUCT);
            this.Name = "FrmManage_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTPRODUCT)).EndInit();
            this.gbMota.ResumeLayout(false);
            this.gbMota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMAGE)).EndInit();
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
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLISTPRODUCT;
        private System.Windows.Forms.ComboBox cbbTYPE_OF_PRODUCT;
        private System.Windows.Forms.TextBox txtQUANTITY;
        private System.Windows.Forms.TextBox txtNAME_PRODUCT;
        private System.Windows.Forms.TextBox txtID_PRODUCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSALE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBUY;
        private System.Windows.Forms.GroupBox gbMota;
        private System.Windows.Forms.TextBox txtDESCRIBE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnADDTYPE;
        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.PictureBox pbIMAGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnADDPIC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnADDPRODUCER;
        private System.Windows.Forms.ComboBox cbbPRODUCERs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbQuantity;
    }
}