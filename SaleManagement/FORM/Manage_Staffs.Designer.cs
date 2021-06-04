
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
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnSHOW = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbPOSITION_DETAIL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID_STAFF = new System.Windows.Forms.TextBox();
            this.txtNAME_STAFF = new System.Windows.Forms.TextBox();
            this.txtPHONE = new System.Windows.Forms.TextBox();
            this.txtADDRESS = new System.Windows.Forms.TextBox();
            this.txtSALARY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbMALE = new System.Windows.Forms.RadioButton();
            this.rbFEMALE = new System.Windows.Forms.RadioButton();
            this.gbGENDER = new System.Windows.Forms.GroupBox();
            this.cbbPOSITION = new System.Windows.Forms.ComboBox();
            this.dpDAY = new System.Windows.Forms.DateTimePicker();
            this.rbID_STAFF = new System.Windows.Forms.RadioButton();
            this.rbNAME_STAFF = new System.Windows.Forms.RadioButton();
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.btnHOME = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.txtSEARCH.Location = new System.Drawing.Point(891, 649);
            this.txtSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(274, 29);
            this.txtSEARCH.TabIndex = 38;
            this.txtSEARCH.Text = "Nhập thông tin cần tìm kiếm";
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD.FlatAppearance.BorderSize = 0;
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
            this.btnBACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBACK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBACK.ForeColor = System.Drawing.Color.White;
            this.btnBACK.Image = global::SaleManagement.Properties.Resources.arrow_121_24;
            this.btnBACK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBACK.Location = new System.Drawing.Point(260, 624);
            this.btnBACK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(132, 55);
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
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCEL.Location = new System.Drawing.Point(133, 624);
            this.btnCANCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(122, 55);
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
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.Color.White;
            this.btnDELETE.Image = global::SaleManagement.Properties.Resources.delete_property_24;
            this.btnDELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDELETE.Location = new System.Drawing.Point(4, 624);
            this.btnDELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(122, 55);
            this.btnDELETE.TabIndex = 56;
            this.btnDELETE.Text = "Xóa";
            this.btnDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnSHOW
            // 
            this.btnSHOW.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSHOW.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSHOW.FlatAppearance.BorderSize = 0;
            this.btnSHOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHOW.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHOW.ForeColor = System.Drawing.Color.White;
            this.btnSHOW.Image = global::SaleManagement.Properties.Resources.activity_feed_24;
            this.btnSHOW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSHOW.Location = new System.Drawing.Point(640, 80);
            this.btnSHOW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSHOW.Name = "btnSHOW";
            this.btnSHOW.Size = new System.Drawing.Size(119, 49);
            this.btnSHOW.TabIndex = 34;
            this.btnSHOW.Text = "Liệt kê";
            this.btnSHOW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSHOW.UseVisualStyleBackColor = false;
            this.btnSHOW.Click += new System.EventHandler(this.btnSHOW_Click);
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
            this.cbbPOSITION_DETAIL.Size = new System.Drawing.Size(181, 30);
            this.cbbPOSITION_DETAIL.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "Mã NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tên NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Số ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 43;
            this.label5.Text = "Lương";
            // 
            // txtID_STAFF
            // 
            this.txtID_STAFF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_STAFF.Location = new System.Drawing.Point(133, 135);
            this.txtID_STAFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_STAFF.Name = "txtID_STAFF";
            this.txtID_STAFF.Size = new System.Drawing.Size(237, 29);
            this.txtID_STAFF.TabIndex = 44;
            // 
            // txtNAME_STAFF
            // 
            this.txtNAME_STAFF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAME_STAFF.ForeColor = System.Drawing.Color.Black;
            this.txtNAME_STAFF.Location = new System.Drawing.Point(133, 175);
            this.txtNAME_STAFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNAME_STAFF.Name = "txtNAME_STAFF";
            this.txtNAME_STAFF.Size = new System.Drawing.Size(237, 29);
            this.txtNAME_STAFF.TabIndex = 45;
            // 
            // txtPHONE
            // 
            this.txtPHONE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPHONE.ForeColor = System.Drawing.Color.Black;
            this.txtPHONE.Location = new System.Drawing.Point(133, 215);
            this.txtPHONE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPHONE.Name = "txtPHONE";
            this.txtPHONE.Size = new System.Drawing.Size(237, 29);
            this.txtPHONE.TabIndex = 46;
            this.txtPHONE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPHONE_KeyPress);
            // 
            // txtADDRESS
            // 
            this.txtADDRESS.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADDRESS.ForeColor = System.Drawing.Color.Black;
            this.txtADDRESS.Location = new System.Drawing.Point(133, 252);
            this.txtADDRESS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtADDRESS.Name = "txtADDRESS";
            this.txtADDRESS.Size = new System.Drawing.Size(237, 29);
            this.txtADDRESS.TabIndex = 47;
            // 
            // txtSALARY
            // 
            this.txtSALARY.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSALARY.ForeColor = System.Drawing.Color.Black;
            this.txtSALARY.Location = new System.Drawing.Point(133, 295);
            this.txtSALARY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSALARY.Name = "txtSALARY";
            this.txtSALARY.Size = new System.Drawing.Size(237, 29);
            this.txtSALARY.TabIndex = 48;
            this.txtSALARY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPHONE_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 22);
            this.label10.TabIndex = 49;
            this.label10.Text = "Vị trí";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 22);
            this.label9.TabIndex = 50;
            this.label9.Text = "Ngày sinh";
            // 
            // rbMALE
            // 
            this.rbMALE.AutoSize = true;
            this.rbMALE.Location = new System.Drawing.Point(65, 25);
            this.rbMALE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMALE.Name = "rbMALE";
            this.rbMALE.Size = new System.Drawing.Size(77, 26);
            this.rbMALE.TabIndex = 0;
            this.rbMALE.TabStop = true;
            this.rbMALE.Text = "Nam";
            this.rbMALE.UseVisualStyleBackColor = true;
            // 
            // rbFEMALE
            // 
            this.rbFEMALE.AutoSize = true;
            this.rbFEMALE.Location = new System.Drawing.Point(65, 65);
            this.rbFEMALE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFEMALE.Name = "rbFEMALE";
            this.rbFEMALE.Size = new System.Drawing.Size(62, 26);
            this.rbFEMALE.TabIndex = 1;
            this.rbFEMALE.TabStop = true;
            this.rbFEMALE.Text = "Nữ";
            this.rbFEMALE.UseVisualStyleBackColor = true;
            // 
            // gbGENDER
            // 
            this.gbGENDER.Controls.Add(this.rbFEMALE);
            this.gbGENDER.Controls.Add(this.rbMALE);
            this.gbGENDER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGENDER.Location = new System.Drawing.Point(29, 431);
            this.gbGENDER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGENDER.Name = "gbGENDER";
            this.gbGENDER.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGENDER.Size = new System.Drawing.Size(325, 108);
            this.gbGENDER.TabIndex = 51;
            this.gbGENDER.TabStop = false;
            this.gbGENDER.Text = "Giới tính";
            // 
            // cbbPOSITION
            // 
            this.cbbPOSITION.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPOSITION.FormattingEnabled = true;
            this.cbbPOSITION.Location = new System.Drawing.Point(133, 338);
            this.cbbPOSITION.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPOSITION.Name = "cbbPOSITION";
            this.cbbPOSITION.Size = new System.Drawing.Size(237, 30);
            this.cbbPOSITION.TabIndex = 52;
            // 
            // dpDAY
            // 
            this.dpDAY.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDAY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDAY.Location = new System.Drawing.Point(133, 382);
            this.dpDAY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpDAY.Name = "dpDAY";
            this.dpDAY.Size = new System.Drawing.Size(236, 29);
            this.dpDAY.TabIndex = 53;
            // 
            // rbID_STAFF
            // 
            this.rbID_STAFF.AutoSize = true;
            this.rbID_STAFF.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbID_STAFF.Location = new System.Drawing.Point(686, 652);
            this.rbID_STAFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbID_STAFF.Name = "rbID_STAFF";
            this.rbID_STAFF.Size = new System.Drawing.Size(86, 23);
            this.rbID_STAFF.TabIndex = 60;
            this.rbID_STAFF.TabStop = true;
            this.rbID_STAFF.Text = "Mã NV";
            this.rbID_STAFF.UseVisualStyleBackColor = true;
            // 
            // rbNAME_STAFF
            // 
            this.rbNAME_STAFF.AutoSize = true;
            this.rbNAME_STAFF.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNAME_STAFF.Location = new System.Drawing.Point(775, 652);
            this.rbNAME_STAFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNAME_STAFF.Name = "rbNAME_STAFF";
            this.rbNAME_STAFF.Size = new System.Drawing.Size(93, 23);
            this.rbNAME_STAFF.TabIndex = 61;
            this.rbNAME_STAFF.TabStop = true;
            this.rbNAME_STAFF.Text = "Tên NV";
            this.rbNAME_STAFF.UseVisualStyleBackColor = true;
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEXCEL.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEXCEL.FlatAppearance.BorderSize = 0;
            this.btnEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXCEL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXCEL.ForeColor = System.Drawing.Color.White;
            this.btnEXCEL.Image = global::SaleManagement.Properties.Resources.excel_3_24;
            this.btnEXCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEXCEL.Location = new System.Drawing.Point(765, 80);
            this.btnEXCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(154, 48);
            this.btnEXCEL.TabIndex = 122;
            this.btnEXCEL.Text = "Xuất Excel";
            this.btnEXCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEXCEL.UseVisualStyleBackColor = false;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
            // 
            // btnHOME
            // 
            this.btnHOME.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHOME.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHOME.FlatAppearance.BorderSize = 0;
            this.btnHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHOME.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHOME.ForeColor = System.Drawing.Color.White;
            this.btnHOME.Image = global::SaleManagement.Properties.Resources.house_48;
            this.btnHOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHOME.Location = new System.Drawing.Point(1025, 12);
            this.btnHOME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(197, 65);
            this.btnHOME.TabIndex = 123;
            this.btnHOME.Text = "Trang chủ";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(518, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 124;
            this.label1.Text = "Quản lý nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(1174, 639);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(47, 48);
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // FrmManage_Staffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1234, 691);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.rbNAME_STAFF);
            this.Controls.Add(this.rbID_STAFF);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.dpDAY);
            this.Controls.Add(this.cbbPOSITION);
            this.Controls.Add(this.gbGENDER);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSALARY);
            this.Controls.Add(this.txtADDRESS);
            this.Controls.Add(this.txtPHONE);
            this.Controls.Add(this.txtNAME_STAFF);
            this.Controls.Add(this.txtID_STAFF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.cbbPOSITION_DETAIL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSHOW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLIST_STAFF);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmManage_Staffs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Staffs";
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
        private System.Windows.Forms.Button btnSHOW;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID_STAFF;
        private System.Windows.Forms.TextBox txtNAME_STAFF;
        private System.Windows.Forms.TextBox txtPHONE;
        private System.Windows.Forms.TextBox txtADDRESS;
        private System.Windows.Forms.TextBox txtSALARY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbMALE;
        private System.Windows.Forms.RadioButton rbFEMALE;
        private System.Windows.Forms.GroupBox gbGENDER;
        private System.Windows.Forms.ComboBox cbbPOSITION;
        private System.Windows.Forms.DateTimePicker dpDAY;
        private System.Windows.Forms.RadioButton rbID_STAFF;
        private System.Windows.Forms.RadioButton rbNAME_STAFF;
        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}