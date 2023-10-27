using System.Windows.Forms;

namespace GUI
{
    partial class Nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhanvien));
            this.lbQuanly = new System.Windows.Forms.Label();
            this.pnThongtin = new System.Windows.Forms.Panel();
            this.btnChon = new System.Windows.Forms.Button();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.tbMatkhau = new System.Windows.Forms.TextBox();
            this.lbMatkhau = new System.Windows.Forms.Label();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbSđt = new System.Windows.Forms.TextBox();
            this.cbLoaiNV = new System.Windows.Forms.ComboBox();
            this.lbCMND = new System.Windows.Forms.Label();
            this.lbSđt = new System.Windows.Forms.Label();
            this.lbLoaiNV = new System.Windows.Forms.Label();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThongtin = new System.Windows.Forms.Label();
            this.pnThemSuaXoa = new System.Windows.Forms.Panel();
            this.tbTimkiem = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtaGVNV = new System.Windows.Forms.DataGridView();
            this.lbDanhsach = new System.Windows.Forms.Label();
            this.pnThongtin.SuspendLayout();
            this.pnThemSuaXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuanly
            // 
            this.lbQuanly.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanly.Location = new System.Drawing.Point(0, 0);
            this.lbQuanly.Margin = new System.Windows.Forms.Padding(0);
            this.lbQuanly.Name = "lbQuanly";
            this.lbQuanly.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.lbQuanly.Size = new System.Drawing.Size(1644, 47);
            this.lbQuanly.TabIndex = 4;
            this.lbQuanly.Text = "Quản lý nhân viên";
            // 
            // pnThongtin
            // 
            this.pnThongtin.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pnThongtin.Controls.Add(this.btnChon);
            this.pnThongtin.Controls.Add(this.tbDiachi);
            this.pnThongtin.Controls.Add(this.lbDiachi);
            this.pnThongtin.Controls.Add(this.tbMatkhau);
            this.pnThongtin.Controls.Add(this.lbMatkhau);
            this.pnThongtin.Controls.Add(this.rb2);
            this.pnThongtin.Controls.Add(this.rb1);
            this.pnThongtin.Controls.Add(this.lbGioitinh);
            this.pnThongtin.Controls.Add(this.tbEmail);
            this.pnThongtin.Controls.Add(this.lbEmail);
            this.pnThongtin.Controls.Add(this.tbCMND);
            this.pnThongtin.Controls.Add(this.tbSđt);
            this.pnThongtin.Controls.Add(this.cbLoaiNV);
            this.pnThongtin.Controls.Add(this.lbCMND);
            this.pnThongtin.Controls.Add(this.lbSđt);
            this.pnThongtin.Controls.Add(this.lbLoaiNV);
            this.pnThongtin.Controls.Add(this.dtNgaysinh);
            this.pnThongtin.Controls.Add(this.tbTenNV);
            this.pnThongtin.Controls.Add(this.tbMaNV);
            this.pnThongtin.Controls.Add(this.lbNgaysinh);
            this.pnThongtin.Controls.Add(this.lbTenNV);
            this.pnThongtin.Controls.Add(this.lbMaNV);
            this.pnThongtin.Controls.Add(this.panel2);
            this.pnThongtin.Controls.Add(this.lbThongtin);
            this.pnThongtin.Location = new System.Drawing.Point(0, 50);
            this.pnThongtin.Margin = new System.Windows.Forms.Padding(0);
            this.pnThongtin.Name = "pnThongtin";
            this.pnThongtin.Size = new System.Drawing.Size(1644, 302);
            this.pnThongtin.TabIndex = 5;
            // 
            // btnChon
            // 
            this.btnChon.FlatAppearance.BorderSize = 0;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.Location = new System.Drawing.Point(83, 198);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(70, 70);
            this.btnChon.TabIndex = 25;
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // tbDiachi
            // 
            this.tbDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiachi.Location = new System.Drawing.Point(1316, 63);
            this.tbDiachi.Multiline = true;
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(179, 112);
            this.tbDiachi.TabIndex = 24;
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiachi.Location = new System.Drawing.Point(1313, 30);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(53, 18);
            this.lbDiachi.TabIndex = 23;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // tbMatkhau
            // 
            this.tbMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatkhau.Location = new System.Drawing.Point(986, 232);
            this.tbMatkhau.Name = "tbMatkhau";
            this.tbMatkhau.Size = new System.Drawing.Size(212, 24);
            this.tbMatkhau.TabIndex = 22;
            // 
            // lbMatkhau
            // 
            this.lbMatkhau.AutoSize = true;
            this.lbMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatkhau.Location = new System.Drawing.Point(983, 205);
            this.lbMatkhau.Name = "lbMatkhau";
            this.lbMatkhau.Size = new System.Drawing.Size(73, 18);
            this.lbMatkhau.TabIndex = 21;
            this.lbMatkhau.Text = "Mật khẩu ";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(1102, 155);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(45, 20);
            this.rb2.TabIndex = 20;
            this.rb2.TabStop = true;
            this.rb2.Text = "Nữ";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(986, 155);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(57, 20);
            this.rb1.TabIndex = 19;
            this.rb1.TabStop = true;
            this.rb1.Text = "Nam";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioitinh.Location = new System.Drawing.Point(983, 121);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(62, 18);
            this.lbGioitinh.TabIndex = 18;
            this.lbGioitinh.Text = "Giới tính";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(986, 61);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(212, 24);
            this.tbEmail.TabIndex = 17;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(983, 30);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(45, 18);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "Email";
            // 
            // tbCMND
            // 
            this.tbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCMND.Location = new System.Drawing.Point(649, 232);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(212, 24);
            this.tbCMND.TabIndex = 15;
            // 
            // tbSđt
            // 
            this.tbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSđt.Location = new System.Drawing.Point(649, 151);
            this.tbSđt.Name = "tbSđt";
            this.tbSđt.Size = new System.Drawing.Size(212, 24);
            this.tbSđt.TabIndex = 14;
            // 
            // cbLoaiNV
            // 
            this.cbLoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiNV.FormattingEnabled = true;
            this.cbLoaiNV.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbLoaiNV.Location = new System.Drawing.Point(649, 61);
            this.cbLoaiNV.Name = "cbLoaiNV";
            this.cbLoaiNV.Size = new System.Drawing.Size(212, 26);
            this.cbLoaiNV.TabIndex = 13;
            this.cbLoaiNV.Text = "Quản lý";
            // 
            // lbCMND
            // 
            this.lbCMND.AutoSize = true;
            this.lbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMND.Location = new System.Drawing.Point(646, 205);
            this.lbCMND.Name = "lbCMND";
            this.lbCMND.Size = new System.Drawing.Size(54, 18);
            this.lbCMND.TabIndex = 12;
            this.lbCMND.Text = "CMND";
            // 
            // lbSđt
            // 
            this.lbSđt.AutoSize = true;
            this.lbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSđt.Location = new System.Drawing.Point(646, 121);
            this.lbSđt.Name = "lbSđt";
            this.lbSđt.Size = new System.Drawing.Size(94, 18);
            this.lbSđt.TabIndex = 11;
            this.lbSđt.Text = "Số điện thoại";
            // 
            // lbLoaiNV
            // 
            this.lbLoaiNV.AutoSize = true;
            this.lbLoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiNV.Location = new System.Drawing.Point(646, 30);
            this.lbLoaiNV.Name = "lbLoaiNV";
            this.lbLoaiNV.Size = new System.Drawing.Size(102, 18);
            this.lbLoaiNV.TabIndex = 10;
            this.lbLoaiNV.Text = "Loại nhân viên";
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaysinh.Location = new System.Drawing.Point(261, 232);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(273, 24);
            this.dtNgaysinh.TabIndex = 9;
            // 
            // tbTenNV
            // 
            this.tbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNV.Location = new System.Drawing.Point(261, 152);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(212, 24);
            this.tbTenNV.TabIndex = 7;
            // 
            // tbMaNV
            // 
            this.tbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNV.Location = new System.Drawing.Point(261, 61);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(212, 24);
            this.tbMaNV.TabIndex = 6;
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaysinh.Location = new System.Drawing.Point(258, 205);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(73, 18);
            this.lbNgaysinh.TabIndex = 5;
            this.lbNgaysinh.Text = "Ngày sinh";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(258, 121);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(99, 18);
            this.lbTenNV.TabIndex = 4;
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(258, 30);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(95, 18);
            this.lbMaNV.TabIndex = 3;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(55, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 120);
            this.panel2.TabIndex = 1;
            // 
            // lbThongtin
            // 
            this.lbThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtin.Location = new System.Drawing.Point(29, 9);
            this.lbThongtin.Name = "lbThongtin";
            this.lbThongtin.Size = new System.Drawing.Size(223, 25);
            this.lbThongtin.TabIndex = 0;
            this.lbThongtin.Text = "Thông tin nhân viên";
            // 
            // pnThemSuaXoa
            // 
            this.pnThemSuaXoa.BackColor = System.Drawing.Color.White;
            this.pnThemSuaXoa.Controls.Add(this.tbTimkiem);
            this.pnThemSuaXoa.Controls.Add(this.btnExport);
            this.pnThemSuaXoa.Controls.Add(this.btnDelete);
            this.pnThemSuaXoa.Controls.Add(this.btnEdit);
            this.pnThemSuaXoa.Controls.Add(this.btnAdd);
            this.pnThemSuaXoa.Location = new System.Drawing.Point(0, 355);
            this.pnThemSuaXoa.Margin = new System.Windows.Forms.Padding(0);
            this.pnThemSuaXoa.Name = "pnThemSuaXoa";
            this.pnThemSuaXoa.Size = new System.Drawing.Size(1644, 106);
            this.pnThemSuaXoa.TabIndex = 16;
            // 
            // tbTimkiem
            // 
            this.tbTimkiem.BackColor = System.Drawing.Color.White;
            this.tbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimkiem.HideSelection = false;
            this.tbTimkiem.Location = new System.Drawing.Point(875, 35);
            this.tbTimkiem.Multiline = true;
            this.tbTimkiem.Name = "tbTimkiem";
            this.tbTimkiem.Size = new System.Drawing.Size(452, 47);
            this.tbTimkiem.TabIndex = 8;
            this.tbTimkiem.Text = "Tìm kiếm\r\n\r\n";
            this.tbTimkiem.Enter += new System.EventHandler(this.tbTimkiem_Enter);
            this.tbTimkiem.Leave += new System.EventHandler(this.tbTimkiem_Leave);
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(629, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 75);
            this.btnExport.TabIndex = 7;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(449, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 75);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(261, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 75);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(83, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dtaGVNV
            // 
            this.dtaGVNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtaGVNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGVNV.Location = new System.Drawing.Point(0, 461);
            this.dtaGVNV.Margin = new System.Windows.Forms.Padding(0);
            this.dtaGVNV.Name = "dtaGVNV";
            this.dtaGVNV.RowHeadersWidth = 51;
            this.dtaGVNV.RowTemplate.Height = 24;
            this.dtaGVNV.Size = new System.Drawing.Size(1644, 447);
            this.dtaGVNV.TabIndex = 17;
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhsach.Location = new System.Drawing.Point(3, 479);
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.Size = new System.Drawing.Size(223, 25);
            this.lbDanhsach.TabIndex = 29;
            this.lbDanhsach.Text = "Danh sách nhân viên";
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDanhsach);
            this.Controls.Add(this.dtaGVNV);
            this.Controls.Add(this.pnThemSuaXoa);
            this.Controls.Add(this.pnThongtin);
            this.Controls.Add(this.lbQuanly);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Nhanvien";
            this.Size = new System.Drawing.Size(1644, 920);
            this.pnThongtin.ResumeLayout(false);
            this.pnThongtin.PerformLayout();
            this.pnThemSuaXoa.ResumeLayout(false);
            this.pnThemSuaXoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQuanly;
        private System.Windows.Forms.Panel pnThongtin;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbSđt;
        private System.Windows.Forms.ComboBox cbLoaiNV;
        private System.Windows.Forms.Label lbCMND;
        private System.Windows.Forms.Label lbSđt;
        private System.Windows.Forms.Label lbLoaiNV;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbThongtin;
        private System.Windows.Forms.Panel pnThemSuaXoa;
        private System.Windows.Forms.DataGridView dtaGVNV;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label lbGioitinh;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbMatkhau;
        private System.Windows.Forms.Label lbMatkhau;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.TextBox tbDiachi;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnExport;
        private Button btnDelete;
        private Button btnChon;
        private TextBox tbTimkiem;
        private Label lbDanhsach;
    }
    
}
