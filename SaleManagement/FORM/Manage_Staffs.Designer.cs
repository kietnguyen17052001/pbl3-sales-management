
namespace SaleManagement.VIEW
{
    partial class FrmManage_Staffs
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
            this.dgvLIST_STAFF = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbPOSITION_DETAIL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID_STAFF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHOME = new System.Windows.Forms.Button();
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.txtNAME_STAFF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbPOSITION = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPHONE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtADDRESS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbGENDER = new System.Windows.Forms.GroupBox();
            this.rbFEMALE = new System.Windows.Forms.RadioButton();
            this.rbMALE = new System.Windows.Forms.RadioButton();
            this.txtSALARY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dpDAY = new System.Windows.Forms.DateTimePicker();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST_STAFF)).BeginInit();
            this.gbGENDER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLIST_STAFF
            // 
            this.dgvLIST_STAFF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLIST_STAFF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLIST_STAFF.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLIST_STAFF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLIST_STAFF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLIST_STAFF.Location = new System.Drawing.Point(398, 135);
            this.dgvLIST_STAFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLIST_STAFF.Name = "dgvLIST_STAFF";
            this.dgvLIST_STAFF.RowHeadersVisible = false;
            this.dgvLIST_STAFF.RowHeadersWidth = 62;
            this.dgvLIST_STAFF.RowTemplate.Height = 28;
            this.dgvLIST_STAFF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLIST_STAFF.Size = new System.Drawing.Size(824, 490);
            this.dgvLIST_STAFF.TabIndex = 29;
            this.dgvLIST_STAFF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLIST_STAFF_CellClick);
            this.dgvLIST_STAFF.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLIST_STAFF_CellFormatting);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(960, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "DANH SÁCH NHÂN VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(813, 643);
            this.txtSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(356, 29);
            this.txtSEARCH.TabIndex = 38;
            this.txtSEARCH.Text = "Nhập mã hoặc tên nhân viên";
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Vị trí";
            // 
            // cbbPOSITION_DETAIL
            // 
            this.cbbPOSITION_DETAIL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPOSITION_DETAIL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPOSITION_DETAIL.FormattingEnabled = true;
            this.cbbPOSITION_DETAIL.Location = new System.Drawing.Point(453, 92);
            this.cbbPOSITION_DETAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPOSITION_DETAIL.Name = "cbbPOSITION_DETAIL";
            this.cbbPOSITION_DETAIL.Size = new System.Drawing.Size(211, 30);
            this.cbbPOSITION_DETAIL.TabIndex = 36;
            this.cbbPOSITION_DETAIL.SelectedIndexChanged += new System.EventHandler(this.cbbPOSITION_DETAIL_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "Mã NV";
            // 
            // txtID_STAFF
            // 
            this.txtID_STAFF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtID_STAFF.Enabled = false;
            this.txtID_STAFF.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_STAFF.ForeColor = System.Drawing.Color.IndianRed;
            this.txtID_STAFF.Location = new System.Drawing.Point(133, 97);
            this.txtID_STAFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_STAFF.Name = "txtID_STAFF";
            this.txtID_STAFF.Size = new System.Drawing.Size(244, 27);
            this.txtID_STAFF.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(474, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 27);
            this.label1.TabIndex = 124;
            this.label1.Text = "Quản lý thông tin nhân viên";
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
            this.btnHOME.Location = new System.Drawing.Point(4, 6);
            this.btnHOME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(197, 65);
            this.btnHOME.TabIndex = 123;
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
            this.btnEXCEL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXCEL.ForeColor = System.Drawing.Color.White;
            this.btnEXCEL.Image = global::SaleManagement.Properties.Resources.excel_3_24;
            this.btnEXCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEXCEL.Location = new System.Drawing.Point(670, 80);
            this.btnEXCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(154, 48);
            this.btnEXCEL.TabIndex = 122;
            this.btnEXCEL.Text = "Xuất Excel";
            this.btnEXCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEXCEL.UseVisualStyleBackColor = false;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
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
            this.btnADD.Location = new System.Drawing.Point(4, 559);
            this.btnADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(122, 59);
            this.btnADD.TabIndex = 54;
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
            this.btnEDIT.Location = new System.Drawing.Point(133, 559);
            this.btnEDIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(122, 59);
            this.btnEDIT.TabIndex = 55;
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
            this.btnBACK.Location = new System.Drawing.Point(1063, 6);
            this.btnBACK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(168, 65);
            this.btnBACK.TabIndex = 59;
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
            this.btnSAVE.Location = new System.Drawing.Point(260, 559);
            this.btnSAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(132, 59);
            this.btnSAVE.TabIndex = 57;
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
            this.btnCANCEL.Location = new System.Drawing.Point(260, 624);
            this.btnCANCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(132, 55);
            this.btnCANCEL.TabIndex = 58;
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
            this.btnDELETE.Location = new System.Drawing.Point(4, 624);
            this.btnDELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(251, 55);
            this.btnDELETE.TabIndex = 56;
            this.btnDELETE.Text = "Xóa nhân viên";
            this.btnDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // txtNAME_STAFF
            // 
            this.txtNAME_STAFF.BackColor = System.Drawing.SystemColors.Info;
            this.txtNAME_STAFF.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAME_STAFF.ForeColor = System.Drawing.Color.Black;
            this.txtNAME_STAFF.Location = new System.Drawing.Point(133, 134);
            this.txtNAME_STAFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNAME_STAFF.Name = "txtNAME_STAFF";
            this.txtNAME_STAFF.Size = new System.Drawing.Size(244, 27);
            this.txtNAME_STAFF.TabIndex = 139;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 138;
            this.label6.Text = "Tên NV";
            // 
            // cbbPOSITION
            // 
            this.cbbPOSITION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPOSITION.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPOSITION.FormattingEnabled = true;
            this.cbbPOSITION.Location = new System.Drawing.Point(133, 172);
            this.cbbPOSITION.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPOSITION.Name = "cbbPOSITION";
            this.cbbPOSITION.Size = new System.Drawing.Size(244, 27);
            this.cbbPOSITION.TabIndex = 141;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 22);
            this.label10.TabIndex = 140;
            this.label10.Text = "Vị trí";
            // 
            // txtPHONE
            // 
            this.txtPHONE.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPHONE.ForeColor = System.Drawing.Color.Black;
            this.txtPHONE.Location = new System.Drawing.Point(133, 251);
            this.txtPHONE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPHONE.Name = "txtPHONE";
            this.txtPHONE.Size = new System.Drawing.Size(244, 27);
            this.txtPHONE.TabIndex = 145;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 144;
            this.label3.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 142;
            this.label4.Text = "Ngày sinh";
            // 
            // txtADDRESS
            // 
            this.txtADDRESS.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADDRESS.Location = new System.Drawing.Point(133, 290);
            this.txtADDRESS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtADDRESS.Name = "txtADDRESS";
            this.txtADDRESS.Size = new System.Drawing.Size(244, 27);
            this.txtADDRESS.TabIndex = 147;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 146;
            this.label9.Text = "Địa chỉ";
            // 
            // gbGENDER
            // 
            this.gbGENDER.Controls.Add(this.rbFEMALE);
            this.gbGENDER.Controls.Add(this.rbMALE);
            this.gbGENDER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGENDER.Location = new System.Drawing.Point(34, 408);
            this.gbGENDER.Name = "gbGENDER";
            this.gbGENDER.Size = new System.Drawing.Size(343, 130);
            this.gbGENDER.TabIndex = 148;
            this.gbGENDER.TabStop = false;
            this.gbGENDER.Text = "Giới tính";
            // 
            // rbFEMALE
            // 
            this.rbFEMALE.AutoSize = true;
            this.rbFEMALE.Location = new System.Drawing.Point(95, 80);
            this.rbFEMALE.Name = "rbFEMALE";
            this.rbFEMALE.Size = new System.Drawing.Size(62, 26);
            this.rbFEMALE.TabIndex = 153;
            this.rbFEMALE.TabStop = true;
            this.rbFEMALE.Text = "Nữ";
            this.rbFEMALE.UseVisualStyleBackColor = true;
            // 
            // rbMALE
            // 
            this.rbMALE.AutoSize = true;
            this.rbMALE.Location = new System.Drawing.Point(95, 39);
            this.rbMALE.Name = "rbMALE";
            this.rbMALE.Size = new System.Drawing.Size(77, 26);
            this.rbMALE.TabIndex = 152;
            this.rbMALE.TabStop = true;
            this.rbMALE.Text = "Nam";
            this.rbMALE.UseVisualStyleBackColor = true;
            // 
            // txtSALARY
            // 
            this.txtSALARY.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSALARY.Location = new System.Drawing.Point(133, 329);
            this.txtSALARY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSALARY.Name = "txtSALARY";
            this.txtSALARY.Size = new System.Drawing.Size(244, 27);
            this.txtSALARY.TabIndex = 150;
            this.txtSALARY.Text = "0";
            this.txtSALARY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSALARY.TextChanged += new System.EventHandler(this.txtSALARY_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 149;
            this.label5.Text = "Lương";
            // 
            // dpDAY
            // 
            this.dpDAY.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDAY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDAY.Location = new System.Drawing.Point(133, 211);
            this.dpDAY.Name = "dpDAY";
            this.dpDAY.Size = new System.Drawing.Size(244, 27);
            this.dpDAY.TabIndex = 151;
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtPASSWORD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASSWORD.Location = new System.Drawing.Point(133, 371);
            this.txtPASSWORD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(244, 27);
            this.txtPASSWORD.TabIndex = 153;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 22);
            this.label11.TabIndex = 152;
            this.label11.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(1175, 632);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 154;
            this.pictureBox1.TabStop = false;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.IndianRed;
            this.lbQuantity.Location = new System.Drawing.Point(630, 646);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(0, 22);
            this.lbQuantity.TabIndex = 156;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(426, 646);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 22);
            this.label12.TabIndex = 155;
            this.label12.Text = "Số lượng nhân viên:";
            // 
            // FrmManage_Staffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1234, 691);
            this.ControlBox = false;
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dpDAY);
            this.Controls.Add(this.txtSALARY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbGENDER);
            this.Controls.Add(this.txtADDRESS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPHONE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbPOSITION);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNAME_STAFF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.txtID_STAFF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.cbbPOSITION_DETAIL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLIST_STAFF);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmManage_Staffs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST_STAFF)).EndInit();
            this.gbGENDER.ResumeLayout(false);
            this.gbGENDER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLIST_STAFF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbPOSITION_DETAIL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID_STAFF;
        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNAME_STAFF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbPOSITION;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPHONE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtADDRESS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbGENDER;
        private System.Windows.Forms.TextBox txtSALARY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpDAY;
        private System.Windows.Forms.RadioButton rbFEMALE;
        private System.Windows.Forms.RadioButton rbMALE;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label label12;
    }
}