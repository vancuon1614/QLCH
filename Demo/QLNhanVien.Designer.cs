namespace Demo
{
    partial class QLNhanVien
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clViTri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenDangNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMatKhau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtVt = new System.Windows.Forms.TextBox();
            this.txtNs = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtTnv = new System.Windows.Forms.TextBox();
            this.txtMnv = new System.Windows.Forms.TextBox();
            this.lbNs = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbGt = new System.Windows.Forms.Label();
            this.lbTnv = new System.Windows.Forms.Label();
            this.lbMk = new System.Windows.Forms.Label();
            this.lbTdn = new System.Windows.Forms.Label();
            this.lbVt = new System.Windows.Forms.Label();
            this.btnMnv = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaNV,
            this.clTenNV,
            this.clNgaySinh,
            this.clGioitinh,
            this.clViTri,
            this.clSdt,
            this.clTenDangNhap,
            this.clMatKhau});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 17);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(916, 257);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clMaNV
            // 
            this.clMaNV.Text = "MaNV";
            this.clMaNV.Width = 97;
            // 
            // clTenNV
            // 
            this.clTenNV.Text = "TenNV";
            this.clTenNV.Width = 74;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.DisplayIndex = 4;
            this.clNgaySinh.Text = "Ngày sinh";
            this.clNgaySinh.Width = 94;
            // 
            // clGioitinh
            // 
            this.clGioitinh.DisplayIndex = 5;
            this.clGioitinh.Text = "Giới tính";
            this.clGioitinh.Width = 93;
            // 
            // clViTri
            // 
            this.clViTri.DisplayIndex = 2;
            this.clViTri.Text = "Vị trí ";
            this.clViTri.Width = 93;
            // 
            // clSdt
            // 
            this.clSdt.DisplayIndex = 3;
            this.clSdt.Text = "Số điện thoại";
            this.clSdt.Width = 111;
            // 
            // clTenDangNhap
            // 
            this.clTenDangNhap.Text = "Tên đăng nhập";
            this.clTenDangNhap.Width = 127;
            // 
            // clMatKhau
            // 
            this.clMatKhau.Text = "Mật khẩu";
            this.clMatKhau.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(25, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 263);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnNhapLai);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.rdbNu);
            this.panel2.Controls.Add(this.rdbNam);
            this.panel2.Controls.Add(this.txtTk);
            this.panel2.Controls.Add(this.txtMk);
            this.panel2.Controls.Add(this.txtVt);
            this.panel2.Controls.Add(this.txtNs);
            this.panel2.Controls.Add(this.txtSdt);
            this.panel2.Controls.Add(this.txtTnv);
            this.panel2.Controls.Add(this.txtMnv);
            this.panel2.Controls.Add(this.lbNs);
            this.panel2.Controls.Add(this.lbSdt);
            this.panel2.Controls.Add(this.lbGt);
            this.panel2.Controls.Add(this.lbTnv);
            this.panel2.Controls.Add(this.lbMk);
            this.panel2.Controls.Add(this.lbTdn);
            this.panel2.Controls.Add(this.lbVt);
            this.panel2.Controls.Add(this.btnMnv);
            this.panel2.Location = new System.Drawing.Point(25, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 221);
            this.panel2.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLuu.Location = new System.Drawing.Point(800, 142);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 43);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDong.Location = new System.Drawing.Point(696, 142);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(86, 43);
            this.btnDong.TabIndex = 47;
            this.btnDong.Text = "Đóng ";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnNhapLai.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNhapLai.Location = new System.Drawing.Point(592, 142);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(90, 43);
            this.btnNhapLai.TabIndex = 46;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSua.Location = new System.Drawing.Point(339, 155);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 43);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.Location = new System.Drawing.Point(217, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 43);
            this.btnXoa.TabIndex = 43;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.Location = new System.Drawing.Point(84, 155);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 43);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(211, 111);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(44, 20);
            this.rdbNu.TabIndex = 31;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(148, 111);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(54, 20);
            this.rdbNam.TabIndex = 30;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtTk
            // 
            this.txtTk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTk.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTk.Location = new System.Drawing.Point(696, 26);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(190, 23);
            this.txtTk.TabIndex = 39;
            // 
            // txtMk
            // 
            this.txtMk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMk.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk.Location = new System.Drawing.Point(696, 67);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(190, 23);
            this.txtMk.TabIndex = 41;
            // 
            // txtVt
            // 
            this.txtVt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVt.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVt.Location = new System.Drawing.Point(397, 108);
            this.txtVt.Name = "txtVt";
            this.txtVt.Size = new System.Drawing.Size(149, 23);
            this.txtVt.TabIndex = 37;
            // 
            // txtNs
            // 
            this.txtNs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNs.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNs.Location = new System.Drawing.Point(397, 67);
            this.txtNs.Name = "txtNs";
            this.txtNs.Size = new System.Drawing.Size(138, 23);
            this.txtNs.TabIndex = 35;
            // 
            // txtSdt
            // 
            this.txtSdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSdt.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(397, 26);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(138, 23);
            this.txtSdt.TabIndex = 33;
            // 
            // txtTnv
            // 
            this.txtTnv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTnv.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTnv.Location = new System.Drawing.Point(148, 67);
            this.txtTnv.Name = "txtTnv";
            this.txtTnv.Size = new System.Drawing.Size(125, 23);
            this.txtTnv.TabIndex = 28;
            // 
            // txtMnv
            // 
            this.txtMnv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMnv.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMnv.Location = new System.Drawing.Point(148, 26);
            this.txtMnv.Name = "txtMnv";
            this.txtMnv.Size = new System.Drawing.Size(125, 23);
            this.txtMnv.TabIndex = 26;
            // 
            // lbNs
            // 
            this.lbNs.AutoSize = true;
            this.lbNs.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNs.Location = new System.Drawing.Point(299, 74);
            this.lbNs.Name = "lbNs";
            this.lbNs.Size = new System.Drawing.Size(62, 16);
            this.lbNs.TabIndex = 34;
            this.lbNs.Text = "Ngày sinh";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.Location = new System.Drawing.Point(299, 33);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(82, 16);
            this.lbSdt.TabIndex = 32;
            this.lbSdt.Text = "Số điện thoại";
            // 
            // lbGt
            // 
            this.lbGt.AutoSize = true;
            this.lbGt.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGt.Location = new System.Drawing.Point(41, 115);
            this.lbGt.Name = "lbGt";
            this.lbGt.Size = new System.Drawing.Size(53, 16);
            this.lbGt.TabIndex = 29;
            this.lbGt.Text = "Giới tính";
            // 
            // lbTnv
            // 
            this.lbTnv.AutoSize = true;
            this.lbTnv.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTnv.Location = new System.Drawing.Point(41, 74);
            this.lbTnv.Name = "lbTnv";
            this.lbTnv.Size = new System.Drawing.Size(89, 16);
            this.lbTnv.TabIndex = 27;
            this.lbTnv.Text = "Tên Nhân viên";
            // 
            // lbMk
            // 
            this.lbMk.AutoSize = true;
            this.lbMk.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMk.Location = new System.Drawing.Point(589, 74);
            this.lbMk.Name = "lbMk";
            this.lbMk.Size = new System.Drawing.Size(59, 16);
            this.lbMk.TabIndex = 40;
            this.lbMk.Text = "Mật khẩu";
            // 
            // lbTdn
            // 
            this.lbTdn.AutoSize = true;
            this.lbTdn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTdn.Location = new System.Drawing.Point(589, 33);
            this.lbTdn.Name = "lbTdn";
            this.lbTdn.Size = new System.Drawing.Size(93, 16);
            this.lbTdn.TabIndex = 38;
            this.lbTdn.Text = "Tên đăng nhập";
            // 
            // lbVt
            // 
            this.lbVt.AutoSize = true;
            this.lbVt.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVt.Location = new System.Drawing.Point(299, 115);
            this.lbVt.Name = "lbVt";
            this.lbVt.Size = new System.Drawing.Size(38, 16);
            this.lbVt.TabIndex = 36;
            this.lbVt.Text = "Vị trí ";
            // 
            // btnMnv
            // 
            this.btnMnv.AutoSize = true;
            this.btnMnv.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMnv.Location = new System.Drawing.Point(41, 33);
            this.btnMnv.Name = "btnMnv";
            this.btnMnv.Size = new System.Drawing.Size(83, 16);
            this.btnMnv.TabIndex = 25;
            this.btnMnv.Text = "Mã nhân viên";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(25, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 100);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(116, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhân viên ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demo.Properties.Resources.Animation___1713857132201;
            this.pictureBox2.Location = new System.Drawing.Point(3, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 608);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clMaNV;
        private System.Windows.Forms.ColumnHeader clTenNV;
        private System.Windows.Forms.ColumnHeader clViTri;
        private System.Windows.Forms.ColumnHeader clSdt;
        private System.Windows.Forms.ColumnHeader clNgaySinh;
        private System.Windows.Forms.ColumnHeader clGioitinh;
        private System.Windows.Forms.ColumnHeader clTenDangNhap;
        private System.Windows.Forms.ColumnHeader clMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtVt;
        private System.Windows.Forms.TextBox txtNs;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTnv;
        private System.Windows.Forms.TextBox txtMnv;
        private System.Windows.Forms.Label lbNs;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Label lbGt;
        private System.Windows.Forms.Label lbTnv;
        private System.Windows.Forms.Label lbMk;
        private System.Windows.Forms.Label lbTdn;
        private System.Windows.Forms.Label lbVt;
        private System.Windows.Forms.Label btnMnv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}