namespace Demo
{
    partial class QLSanPham
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
            this.clMsp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTsp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCtsx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtctsx = new System.Windows.Forms.TextBox();
            this.txtcl = new System.Windows.Forms.TextBox();
            this.txtdb = new System.Windows.Forms.TextBox();
            this.txtsln = new System.Windows.Forms.TextBox();
            this.txtnn = new System.Windows.Forms.TextBox();
            this.txttt = new System.Windows.Forms.TextBox();
            this.txtgx = new System.Windows.Forms.TextBox();
            this.txtgn = new System.Windows.Forms.TextBox();
            this.txttsp = new System.Windows.Forms.TextBox();
            this.txtmsp = new System.Windows.Forms.TextBox();
            this.lbCtsx = new System.Windows.Forms.Label();
            this.lbCl = new System.Windows.Forms.Label();
            this.lbDb = new System.Windows.Forms.Label();
            this.lbSl = new System.Windows.Forms.Label();
            this.lbNn = new System.Windows.Forms.Label();
            this.lbTt = new System.Windows.Forms.Label();
            this.lbGx = new System.Windows.Forms.Label();
            this.lbGn = new System.Windows.Forms.Label();
            this.lbTsp = new System.Windows.Forms.Label();
            this.lbMsp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.clMsp,
            this.clTsp,
            this.clGn,
            this.clGb,
            this.clTt,
            this.clNn,
            this.clSl,
            this.clDb,
            this.clCl,
            this.clCtsx});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(923, 220);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clMsp
            // 
            this.clMsp.Text = "Mã SP";
            // 
            // clTsp
            // 
            this.clTsp.Text = "Tên sản phẩm";
            this.clTsp.Width = 107;
            // 
            // clGn
            // 
            this.clGn.Text = "Giá nhập";
            this.clGn.Width = 84;
            // 
            // clGb
            // 
            this.clGb.Text = "Giá bán";
            // 
            // clTt
            // 
            this.clTt.Text = "Tình trạng ";
            this.clTt.Width = 85;
            // 
            // clNn
            // 
            this.clNn.Text = "Ngày nhập";
            this.clNn.Width = 93;
            // 
            // clSl
            // 
            this.clSl.Text = "Số lượng";
            this.clSl.Width = 81;
            // 
            // clDb
            // 
            this.clDb.Text = "Đã bán";
            // 
            // clCl
            // 
            this.clCl.Text = "Chất liệu";
            this.clCl.Width = 80;
            // 
            // clCtsx
            // 
            this.clCtsx.Text = "CT sản xuất";
            this.clCtsx.Width = 85;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnNhapLai);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtctsx);
            this.panel1.Controls.Add(this.txtcl);
            this.panel1.Controls.Add(this.txtdb);
            this.panel1.Controls.Add(this.txtsln);
            this.panel1.Controls.Add(this.txtnn);
            this.panel1.Controls.Add(this.txttt);
            this.panel1.Controls.Add(this.txtgx);
            this.panel1.Controls.Add(this.txtgn);
            this.panel1.Controls.Add(this.txttsp);
            this.panel1.Controls.Add(this.txtmsp);
            this.panel1.Controls.Add(this.lbCtsx);
            this.panel1.Controls.Add(this.lbCl);
            this.panel1.Controls.Add(this.lbDb);
            this.panel1.Controls.Add(this.lbSl);
            this.panel1.Controls.Add(this.lbNn);
            this.panel1.Controls.Add(this.lbTt);
            this.panel1.Controls.Add(this.lbGx);
            this.panel1.Controls.Add(this.lbGn);
            this.panel1.Controls.Add(this.lbTsp);
            this.panel1.Controls.Add(this.lbMsp);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(15, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 234);
            this.panel1.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(472, 175);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 44);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.Location = new System.Drawing.Point(802, 88);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(83, 43);
            this.btnDong.TabIndex = 31;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnNhapLai.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhapLai.Location = new System.Drawing.Point(712, 88);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(86, 43);
            this.btnNhapLai.TabIndex = 32;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(366, 175);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 44);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(204, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 44);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(112, 175);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 44);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // txtctsx
            // 
            this.txtctsx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtctsx.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtctsx.Location = new System.Drawing.Point(716, 49);
            this.txtctsx.Name = "txtctsx";
            this.txtctsx.Size = new System.Drawing.Size(162, 23);
            this.txtctsx.TabIndex = 29;
            // 
            // txtcl
            // 
            this.txtcl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcl.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcl.Location = new System.Drawing.Point(716, 12);
            this.txtcl.Name = "txtcl";
            this.txtcl.Size = new System.Drawing.Size(162, 23);
            this.txtcl.TabIndex = 28;
            // 
            // txtdb
            // 
            this.txtdb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdb.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdb.Location = new System.Drawing.Point(437, 123);
            this.txtdb.Name = "txtdb";
            this.txtdb.Size = new System.Drawing.Size(122, 23);
            this.txtdb.TabIndex = 27;
            // 
            // txtsln
            // 
            this.txtsln.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsln.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsln.Location = new System.Drawing.Point(437, 87);
            this.txtsln.Name = "txtsln";
            this.txtsln.Size = new System.Drawing.Size(122, 23);
            this.txtsln.TabIndex = 26;
            // 
            // txtnn
            // 
            this.txtnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnn.Location = new System.Drawing.Point(437, 50);
            this.txtnn.Name = "txtnn";
            this.txtnn.Size = new System.Drawing.Size(122, 23);
            this.txtnn.TabIndex = 25;
            // 
            // txttt
            // 
            this.txttt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttt.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttt.Location = new System.Drawing.Point(437, 16);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(122, 23);
            this.txttt.TabIndex = 30;
            // 
            // txtgx
            // 
            this.txtgx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgx.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgx.Location = new System.Drawing.Point(143, 127);
            this.txtgx.Name = "txtgx";
            this.txtgx.Size = new System.Drawing.Size(122, 23);
            this.txtgx.TabIndex = 24;
            // 
            // txtgn
            // 
            this.txtgn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgn.Location = new System.Drawing.Point(143, 88);
            this.txtgn.Name = "txtgn";
            this.txtgn.Size = new System.Drawing.Size(122, 23);
            this.txtgn.TabIndex = 23;
            // 
            // txttsp
            // 
            this.txttsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttsp.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttsp.Location = new System.Drawing.Point(143, 54);
            this.txttsp.Name = "txttsp";
            this.txttsp.Size = new System.Drawing.Size(122, 23);
            this.txttsp.TabIndex = 22;
            // 
            // txtmsp
            // 
            this.txtmsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmsp.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsp.Location = new System.Drawing.Point(143, 20);
            this.txtmsp.Name = "txtmsp";
            this.txtmsp.Size = new System.Drawing.Size(122, 23);
            this.txtmsp.TabIndex = 21;
            // 
            // lbCtsx
            // 
            this.lbCtsx.AutoSize = true;
            this.lbCtsx.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCtsx.Location = new System.Drawing.Point(618, 54);
            this.lbCtsx.Name = "lbCtsx";
            this.lbCtsx.Size = new System.Drawing.Size(75, 16);
            this.lbCtsx.TabIndex = 19;
            this.lbCtsx.Text = "CT sản xuất";
            // 
            // lbCl
            // 
            this.lbCl.AutoSize = true;
            this.lbCl.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCl.Location = new System.Drawing.Point(618, 20);
            this.lbCl.Name = "lbCl";
            this.lbCl.Size = new System.Drawing.Size(57, 16);
            this.lbCl.TabIndex = 18;
            this.lbCl.Text = "Chất liệu";
            // 
            // lbDb
            // 
            this.lbDb.AutoSize = true;
            this.lbDb.Location = new System.Drawing.Point(341, 130);
            this.lbDb.Name = "lbDb";
            this.lbDb.Size = new System.Drawing.Size(52, 16);
            this.lbDb.TabIndex = 17;
            this.lbDb.Text = "Đã bán ";
            // 
            // lbSl
            // 
            this.lbSl.AutoSize = true;
            this.lbSl.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSl.Location = new System.Drawing.Point(341, 94);
            this.lbSl.Name = "lbSl";
            this.lbSl.Size = new System.Drawing.Size(90, 16);
            this.lbSl.TabIndex = 16;
            this.lbSl.Text = "Số lượng nhập";
            // 
            // lbNn
            // 
            this.lbNn.AutoSize = true;
            this.lbNn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNn.Location = new System.Drawing.Point(341, 57);
            this.lbNn.Name = "lbNn";
            this.lbNn.Size = new System.Drawing.Size(71, 16);
            this.lbNn.TabIndex = 15;
            this.lbNn.Text = "Ngày nhập ";
            // 
            // lbTt
            // 
            this.lbTt.AutoSize = true;
            this.lbTt.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTt.Location = new System.Drawing.Point(340, 23);
            this.lbTt.Name = "lbTt";
            this.lbTt.Size = new System.Drawing.Size(66, 16);
            this.lbTt.TabIndex = 14;
            this.lbTt.Text = "Tình trạng";
            // 
            // lbGx
            // 
            this.lbGx.AutoSize = true;
            this.lbGx.Location = new System.Drawing.Point(37, 134);
            this.lbGx.Name = "lbGx";
            this.lbGx.Size = new System.Drawing.Size(53, 16);
            this.lbGx.TabIndex = 13;
            this.lbGx.Text = "Giá xuất";
            // 
            // lbGn
            // 
            this.lbGn.AutoSize = true;
            this.lbGn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGn.Location = new System.Drawing.Point(33, 95);
            this.lbGn.Name = "lbGn";
            this.lbGn.Size = new System.Drawing.Size(57, 16);
            this.lbGn.TabIndex = 12;
            this.lbGn.Text = "Giá nhập";
            // 
            // lbTsp
            // 
            this.lbTsp.AutoSize = true;
            this.lbTsp.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTsp.Location = new System.Drawing.Point(32, 61);
            this.lbTsp.Name = "lbTsp";
            this.lbTsp.Size = new System.Drawing.Size(93, 16);
            this.lbTsp.TabIndex = 20;
            this.lbTsp.Text = "Tên sản phẩm ";
            // 
            // lbMsp
            // 
            this.lbMsp.AutoSize = true;
            this.lbMsp.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsp.Location = new System.Drawing.Point(32, 27);
            this.lbMsp.Name = "lbMsp";
            this.lbMsp.Size = new System.Drawing.Size(88, 16);
            this.lbMsp.TabIndex = 11;
            this.lbMsp.Text = "Mã sản phẩm ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(12, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 240);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(15, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 105);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demo.Properties.Resources.Animation___1713857060437;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(111, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sản phẩm ";
            // 
            // QLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1042, 617);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QLSanPham";
            this.Text = "QLSanPham";
            this.Load += new System.EventHandler(this.QLSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clMsp;
        private System.Windows.Forms.ColumnHeader clTsp;
        private System.Windows.Forms.ColumnHeader clGn;
        private System.Windows.Forms.ColumnHeader clGb;
        private System.Windows.Forms.ColumnHeader clTt;
        private System.Windows.Forms.ColumnHeader clNn;
        private System.Windows.Forms.ColumnHeader clSl;
        private System.Windows.Forms.ColumnHeader clDb;
        private System.Windows.Forms.ColumnHeader clCl;
        private System.Windows.Forms.ColumnHeader clCtsx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtctsx;
        private System.Windows.Forms.TextBox txtcl;
        private System.Windows.Forms.TextBox txtdb;
        private System.Windows.Forms.TextBox txtsln;
        private System.Windows.Forms.TextBox txtnn;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.TextBox txtgx;
        private System.Windows.Forms.TextBox txtgn;
        private System.Windows.Forms.TextBox txttsp;
        private System.Windows.Forms.TextBox txtmsp;
        private System.Windows.Forms.Label lbCtsx;
        private System.Windows.Forms.Label lbCl;
        private System.Windows.Forms.Label lbDb;
        private System.Windows.Forms.Label lbSl;
        private System.Windows.Forms.Label lbNn;
        private System.Windows.Forms.Label lbTt;
        private System.Windows.Forms.Label lbGx;
        private System.Windows.Forms.Label lbGn;
        private System.Windows.Forms.Label lbTsp;
        private System.Windows.Forms.Label lbMsp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}