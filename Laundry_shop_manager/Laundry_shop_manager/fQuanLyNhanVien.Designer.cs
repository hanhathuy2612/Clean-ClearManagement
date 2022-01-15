namespace Laundry_shop_manager
{
    partial class fQuanLyNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnDataQuanLyTaiKhoan = new System.Windows.Forms.Panel();
            this.dgvListNhanVien = new System.Windows.Forms.DataGridView();
            this.lbThemTaiKhoan = new System.Windows.Forms.Label();
            this.txbHoVaTen = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.lbTImTheoTenNhanVien = new System.Windows.Forms.Label();
            this.txbSearchName = new System.Windows.Forms.TextBox();
            this.lbHoVaTen = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.lbTenTaiKhoanThemTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhauThemTaiKhoan = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.icbtRefresh = new FontAwesome.Sharp.IconButton();
            this.lbPathAnhDD = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIdNhanVien = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbIdAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.icbtEdit = new FontAwesome.Sharp.IconButton();
            this.icbtAdd = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSearchSDT = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ibtTimTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDataQuanLyTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDataQuanLyTaiKhoan
            // 
            this.pnDataQuanLyTaiKhoan.Controls.Add(this.dgvListNhanVien);
            this.pnDataQuanLyTaiKhoan.Location = new System.Drawing.Point(9, 383);
            this.pnDataQuanLyTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnDataQuanLyTaiKhoan.Name = "pnDataQuanLyTaiKhoan";
            this.pnDataQuanLyTaiKhoan.Size = new System.Drawing.Size(1559, 287);
            this.pnDataQuanLyTaiKhoan.TabIndex = 0;
            // 
            // dgvListNhanVien
            // 
            this.dgvListNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NgaySinh,
            this.ChuVu,
            this.SDT,
            this.DiaChi,
            this.TenNv});
            this.dgvListNhanVien.Location = new System.Drawing.Point(4, 4);
            this.dgvListNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListNhanVien.Name = "dgvListNhanVien";
            this.dgvListNhanVien.RowHeadersWidth = 51;
            this.dgvListNhanVien.Size = new System.Drawing.Size(1551, 279);
            this.dgvListNhanVien.TabIndex = 0;
            this.dgvListNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListNhanVien_CellClick);
            this.dgvListNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbThemTaiKhoan
            // 
            this.lbThemTaiKhoan.AutoSize = true;
            this.lbThemTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThemTaiKhoan.Location = new System.Drawing.Point(637, 18);
            this.lbThemTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThemTaiKhoan.Name = "lbThemTaiKhoan";
            this.lbThemTaiKhoan.Size = new System.Drawing.Size(245, 35);
            this.lbThemTaiKhoan.TabIndex = 1;
            this.lbThemTaiKhoan.Text = "Quản lý nhân viên";
            this.lbThemTaiKhoan.Click += new System.EventHandler(this.lbThemTaiKhoan_Click);
            // 
            // txbHoVaTen
            // 
            this.txbHoVaTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbHoVaTen.Location = new System.Drawing.Point(165, 62);
            this.txbHoVaTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbHoVaTen.Name = "txbHoVaTen";
            this.txbHoVaTen.Size = new System.Drawing.Size(192, 30);
            this.txbHoVaTen.TabIndex = 4;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbDiaChi.Location = new System.Drawing.Point(165, 102);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(296, 30);
            this.txbDiaChi.TabIndex = 5;
            // 
            // lbTImTheoTenNhanVien
            // 
            this.lbTImTheoTenNhanVien.AutoSize = true;
            this.lbTImTheoTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTImTheoTenNhanVien.Location = new System.Drawing.Point(19, 46);
            this.lbTImTheoTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTImTheoTenNhanVien.Name = "lbTImTheoTenNhanVien";
            this.lbTImTheoTenNhanVien.Size = new System.Drawing.Size(117, 23);
            this.lbTImTheoTenNhanVien.TabIndex = 6;
            this.lbTImTheoTenNhanVien.Text = "Tìm theo tên";
            // 
            // txbSearchName
            // 
            this.txbSearchName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchName.Location = new System.Drawing.Point(167, 43);
            this.txbSearchName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSearchName.Name = "txbSearchName";
            this.txbSearchName.Size = new System.Drawing.Size(191, 30);
            this.txbSearchName.TabIndex = 7;
            // 
            // lbHoVaTen
            // 
            this.lbHoVaTen.AutoSize = true;
            this.lbHoVaTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHoVaTen.Location = new System.Drawing.Point(19, 66);
            this.lbHoVaTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoVaTen.Name = "lbHoVaTen";
            this.lbHoVaTen.Size = new System.Drawing.Size(91, 23);
            this.lbHoVaTen.TabIndex = 8;
            this.lbHoVaTen.Text = "Họ và tên";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChi.Location = new System.Drawing.Point(19, 105);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(73, 23);
            this.lbDiaChi.TabIndex = 9;
            this.lbDiaChi.Text = "Địa chỉ ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSDT.Location = new System.Drawing.Point(19, 145);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(118, 23);
            this.lbSDT.TabIndex = 10;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // txbSDT
            // 
            this.txbSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSDT.Location = new System.Drawing.Point(165, 142);
            this.txbSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(192, 30);
            this.txbSDT.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(19, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ngày sinh";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChucVu.Location = new System.Drawing.Point(19, 224);
            this.lbChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(80, 23);
            this.lbChucVu.TabIndex = 14;
            this.lbChucVu.Text = "Chức vụ";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "admin",
            "ketoan",
            "nhanvien",
            "xuong"});
            this.cbbChucVu.Location = new System.Drawing.Point(165, 220);
            this.cbbChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(192, 30);
            this.cbbChucVu.TabIndex = 15;
            // 
            // lbTenTaiKhoanThemTaiKhoan
            // 
            this.lbTenTaiKhoanThemTaiKhoan.AutoSize = true;
            this.lbTenTaiKhoanThemTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenTaiKhoanThemTaiKhoan.Location = new System.Drawing.Point(19, 71);
            this.lbTenTaiKhoanThemTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenTaiKhoanThemTaiKhoan.Name = "lbTenTaiKhoanThemTaiKhoan";
            this.lbTenTaiKhoanThemTaiKhoan.Size = new System.Drawing.Size(94, 23);
            this.lbTenTaiKhoanThemTaiKhoan.TabIndex = 16;
            this.lbTenTaiKhoanThemTaiKhoan.Text = "Tài khoản";
            // 
            // lbMatKhauThemTaiKhoan
            // 
            this.lbMatKhauThemTaiKhoan.AutoSize = true;
            this.lbMatKhauThemTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMatKhauThemTaiKhoan.Location = new System.Drawing.Point(19, 111);
            this.lbMatKhauThemTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatKhauThemTaiKhoan.Name = "lbMatKhauThemTaiKhoan";
            this.lbMatKhauThemTaiKhoan.Size = new System.Drawing.Size(91, 23);
            this.lbMatKhauThemTaiKhoan.TabIndex = 17;
            this.lbMatKhauThemTaiKhoan.Text = "Mật khẩu";
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbUserName.Location = new System.Drawing.Point(167, 68);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(191, 30);
            this.txbUserName.TabIndex = 18;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPassWord.Location = new System.Drawing.Point(167, 108);
            this.txbPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '*';
            this.txbPassWord.Size = new System.Drawing.Size(191, 30);
            this.txbPassWord.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.icbtRefresh);
            this.groupBox1.Controls.Add(this.lbPathAnhDD);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dtpkNgaySinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbIdNhanVien);
            this.groupBox1.Controls.Add(this.lbHoVaTen);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.icbtEdit);
            this.groupBox1.Controls.Add(this.txbHoVaTen);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.icbtAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbChucVu);
            this.groupBox1.Controls.Add(this.txbSDT);
            this.groupBox1.Controls.Add(this.lbChucVu);
            this.groupBox1.Location = new System.Drawing.Point(4, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1139, 258);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // icbtRefresh
            // 
            this.icbtRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icbtRefresh.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.icbtRefresh.IconColor = System.Drawing.Color.Black;
            this.icbtRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtRefresh.IconSize = 35;
            this.icbtRefresh.Location = new System.Drawing.Point(964, 202);
            this.icbtRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icbtRefresh.Name = "icbtRefresh";
            this.icbtRefresh.Size = new System.Drawing.Size(149, 46);
            this.icbtRefresh.TabIndex = 30;
            this.icbtRefresh.Text = "Làm mới";
            this.icbtRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtRefresh.UseVisualStyleBackColor = true;
            this.icbtRefresh.Click += new System.EventHandler(this.icbtRefresh_Click);
            // 
            // lbPathAnhDD
            // 
            this.lbPathAnhDD.AutoSize = true;
            this.lbPathAnhDD.Location = new System.Drawing.Point(509, 177);
            this.lbPathAnhDD.Name = "lbPathAnhDD";
            this.lbPathAnhDD.Size = new System.Drawing.Size(89, 17);
            this.lbPathAnhDD.TabIndex = 29;
            this.lbPathAnhDD.Text = "chưa có hình";
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(495, 202);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(165, 46);
            this.iconButton1.TabIndex = 28;
            this.iconButton1.Text = "Chọn ảnh";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(495, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(165, 185);
            this.dtpkNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(192, 22);
            this.dtpkNgaySinh.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "ID";
            // 
            // txbIdNhanVien
            // 
            this.txbIdNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbIdNhanVien.Location = new System.Drawing.Point(165, 23);
            this.txbIdNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbIdNhanVien.Name = "txbIdNhanVien";
            this.txbIdNhanVien.ReadOnly = true;
            this.txbIdNhanVien.Size = new System.Drawing.Size(76, 30);
            this.txbIdNhanVien.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbIdAccount);
            this.groupBox2.Controls.Add(this.lbTenTaiKhoanThemTaiKhoan);
            this.groupBox2.Controls.Add(this.txbUserName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbPassWord);
            this.groupBox2.Controls.Add(this.lbMatKhauThemTaiKhoan);
            this.groupBox2.Location = new System.Drawing.Point(703, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(395, 155);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lập tài khoản";
            // 
            // txbIdAccount
            // 
            this.txbIdAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbIdAccount.Location = new System.Drawing.Point(167, 27);
            this.txbIdAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbIdAccount.Name = "txbIdAccount";
            this.txbIdAccount.ReadOnly = true;
            this.txbIdAccount.Size = new System.Drawing.Size(85, 30);
            this.txbIdAccount.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(19, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID";
            // 
            // icbtEdit
            // 
            this.icbtEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icbtEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.icbtEdit.IconColor = System.Drawing.Color.Black;
            this.icbtEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtEdit.IconSize = 35;
            this.icbtEdit.Location = new System.Drawing.Point(835, 202);
            this.icbtEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icbtEdit.Name = "icbtEdit";
            this.icbtEdit.Size = new System.Drawing.Size(121, 46);
            this.icbtEdit.TabIndex = 23;
            this.icbtEdit.Text = "Sửa";
            this.icbtEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtEdit.UseVisualStyleBackColor = true;
            this.icbtEdit.Click += new System.EventHandler(this.icbtEdit_Click);
            // 
            // icbtAdd
            // 
            this.icbtAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icbtAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icbtAdd.IconColor = System.Drawing.Color.Black;
            this.icbtAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtAdd.IconSize = 35;
            this.icbtAdd.Location = new System.Drawing.Point(703, 202);
            this.icbtAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icbtAdd.Name = "icbtAdd";
            this.icbtAdd.Size = new System.Drawing.Size(121, 46);
            this.icbtAdd.TabIndex = 22;
            this.icbtAdd.Text = "Thêm";
            this.icbtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtAdd.UseVisualStyleBackColor = true;
            this.icbtAdd.Click += new System.EventHandler(this.icbtAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tìm theo SĐT";
            // 
            // txbSearchSDT
            // 
            this.txbSearchSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchSDT.Location = new System.Drawing.Point(164, 84);
            this.txbSearchSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSearchSDT.Name = "txbSearchSDT";
            this.txbSearchSDT.Size = new System.Drawing.Size(191, 30);
            this.txbSearchSDT.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTImTheoTenNhanVien);
            this.groupBox3.Controls.Add(this.ibtTimTaiKhoan);
            this.groupBox3.Controls.Add(this.txbSearchName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txbSearchSDT);
            this.groupBox3.Location = new System.Drawing.Point(1149, 84);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(395, 258);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm nhân viên";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ibtTimTaiKhoan
            // 
            this.ibtTimTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ibtTimTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtTimTaiKhoan.IconColor = System.Drawing.Color.Black;
            this.ibtTimTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtTimTaiKhoan.IconSize = 35;
            this.ibtTimTaiKhoan.Location = new System.Drawing.Point(1, 160);
            this.ibtTimTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibtTimTaiKhoan.Name = "ibtTimTaiKhoan";
            this.ibtTimTaiKhoan.Size = new System.Drawing.Size(393, 48);
            this.ibtTimTaiKhoan.TabIndex = 27;
            this.ibtTimTaiKhoan.Text = "Tìm";
            this.ibtTimTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtTimTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtTimTaiKhoan.UseVisualStyleBackColor = true;
            this.ibtTimTaiKhoan.Click += new System.EventHandler(this.ibtTimTaiKhoan_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_NV";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // ChuVu
            // 
            this.ChuVu.DataPropertyName = "ChuVu";
            this.ChuVu.HeaderText = "Chức Vụ";
            this.ChuVu.MinimumWidth = 6;
            this.ChuVu.Name = "ChuVu";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // TenNv
            // 
            this.TenNv.DataPropertyName = "TenNV";
            this.TenNv.HeaderText = "Họ tên";
            this.TenNv.MinimumWidth = 6;
            this.TenNv.Name = "TenNv";
            // 
            // fQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbThemTaiKhoan);
            this.Controls.Add(this.pnDataQuanLyTaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fQuanLyNhanVien";
            this.Size = new System.Drawing.Size(1580, 673);
            this.pnDataQuanLyTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDataQuanLyTaiKhoan;
        private System.Windows.Forms.Label lbThemTaiKhoan;
        private System.Windows.Forms.TextBox txbHoVaTen;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.DataGridView dgvListNhanVien;
        private System.Windows.Forms.Label lbTImTheoTenNhanVien;
        private System.Windows.Forms.TextBox txbSearchName;
        private System.Windows.Forms.Label lbHoVaTen;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label lbTenTaiKhoanThemTaiKhoan;
        private System.Windows.Forms.Label lbMatKhauThemTaiKhoan;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton icbtAdd;
        private FontAwesome.Sharp.IconButton icbtEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSearchSDT;
        private FontAwesome.Sharp.IconButton ibtTimTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIdNhanVien;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lbPathAnhDD;
        private FontAwesome.Sharp.IconButton icbtRefresh;
        private System.Windows.Forms.TextBox txbIdAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNv;
    }
}
