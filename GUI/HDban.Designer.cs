namespace GUI
{
    partial class HDban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HDban));
            this.lbQuanly = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.gbThongtinchung = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.tbTongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnThemSuaXoa = new System.Windows.Forms.Panel();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbThanhtien = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbThongtinSP = new System.Windows.Forms.GroupBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.tbKhuyenmai = new System.Windows.Forms.TextBox();
            this.lbKhuyenmai = new System.Windows.Forms.Label();
            this.tbSoluong = new System.Windows.Forms.TextBox();
            this.lbSoluong = new System.Windows.Forms.Label();
            this.tbTensp = new System.Windows.Forms.TextBox();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.dtaGVdanhsachHD = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtaGVdanhsachchitiet = new System.Windows.Forms.DataGridView();
            this.gbThongtinchung.SuspendLayout();
            this.pnThemSuaXoa.SuspendLayout();
            this.gbThongtinSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVdanhsachHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVdanhsachchitiet)).BeginInit();
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
            this.lbQuanly.TabIndex = 23;
            this.lbQuanly.Text = "Quản lý hóa đơn bán ";
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.Location = new System.Drawing.Point(52, 188);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(113, 18);
            this.lbHoten.TabIndex = 10;
            this.lbHoten.Text = "Tên khách hàng";
            // 
            // tbHoten
            // 
            this.tbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoten.Location = new System.Drawing.Point(55, 238);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(212, 24);
            this.tbHoten.TabIndex = 11;
            // 
            // gbThongtinchung
            // 
            this.gbThongtinchung.Controls.Add(this.dateTimePicker1);
            this.gbThongtinchung.Controls.Add(this.label2);
            this.gbThongtinchung.Controls.Add(this.lbTenNV);
            this.gbThongtinchung.Controls.Add(this.tbTenNV);
            this.gbThongtinchung.Controls.Add(this.tbTongtien);
            this.gbThongtinchung.Controls.Add(this.label3);
            this.gbThongtinchung.Controls.Add(this.tbMaHD);
            this.gbThongtinchung.Controls.Add(this.label1);
            this.gbThongtinchung.Controls.Add(this.tbHoten);
            this.gbThongtinchung.Controls.Add(this.lbHoten);
            this.gbThongtinchung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongtinchung.Location = new System.Drawing.Point(24, 78);
            this.gbThongtinchung.Name = "gbThongtinchung";
            this.gbThongtinchung.Size = new System.Drawing.Size(709, 415);
            this.gbThongtinchung.TabIndex = 1;
            this.gbThongtinchung.TabStop = false;
            this.gbThongtinchung.Text = "Thông tin chung";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 24);
            this.dateTimePicker1.TabIndex = 37;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ngày lập";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(386, 58);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(99, 18);
            this.lbTenNV.TabIndex = 35;
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // tbTenNV
            // 
            this.tbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNV.Location = new System.Drawing.Point(389, 109);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(212, 24);
            this.tbTenNV.TabIndex = 24;
            // 
            // tbTongtien
            // 
            this.tbTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongtien.Location = new System.Drawing.Point(55, 357);
            this.tbTongtien.Name = "tbTongtien";
            this.tbTongtien.Size = new System.Drawing.Size(212, 24);
            this.tbTongtien.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tổng tiền";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHD.Location = new System.Drawing.Point(55, 109);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(212, 24);
            this.tbMaHD.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã hóa đơn";
            // 
            // pnThemSuaXoa
            // 
            this.pnThemSuaXoa.BackColor = System.Drawing.Color.White;
            this.pnThemSuaXoa.Controls.Add(this.btnInHD);
            this.pnThemSuaXoa.Controls.Add(this.btnDelete);
            this.pnThemSuaXoa.Controls.Add(this.btnAdd);
            this.pnThemSuaXoa.Location = new System.Drawing.Point(0, 529);
            this.pnThemSuaXoa.Margin = new System.Windows.Forms.Padding(0);
            this.pnThemSuaXoa.Name = "pnThemSuaXoa";
            this.pnThemSuaXoa.Size = new System.Drawing.Size(1644, 106);
            this.pnThemSuaXoa.TabIndex = 24;
            // 
            // btnInHD
            // 
            this.btnInHD.FlatAppearance.BorderSize = 0;
            this.btnInHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.Image")));
            this.btnInHD.Location = new System.Drawing.Point(785, 16);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(75, 75);
            this.btnInHD.TabIndex = 26;
            this.btnInHD.UseVisualStyleBackColor = true;
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
            // lbThanhtien
            // 
            this.lbThanhtien.AutoSize = true;
            this.lbThanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhtien.Location = new System.Drawing.Point(429, 58);
            this.lbThanhtien.Name = "lbThanhtien";
            this.lbThanhtien.Size = new System.Drawing.Size(76, 18);
            this.lbThanhtien.TabIndex = 33;
            this.lbThanhtien.Text = "Thành tiền";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(432, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 24);
            this.textBox2.TabIndex = 34;
            // 
            // gbThongtinSP
            // 
            this.gbThongtinSP.Controls.Add(this.tbGia);
            this.gbThongtinSP.Controls.Add(this.lbGia);
            this.gbThongtinSP.Controls.Add(this.tbKhuyenmai);
            this.gbThongtinSP.Controls.Add(this.lbKhuyenmai);
            this.gbThongtinSP.Controls.Add(this.tbSoluong);
            this.gbThongtinSP.Controls.Add(this.lbSoluong);
            this.gbThongtinSP.Controls.Add(this.tbTensp);
            this.gbThongtinSP.Controls.Add(this.lbTenSP);
            this.gbThongtinSP.Controls.Add(this.textBox2);
            this.gbThongtinSP.Controls.Add(this.lbThanhtien);
            this.gbThongtinSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongtinSP.Location = new System.Drawing.Point(764, 78);
            this.gbThongtinSP.Name = "gbThongtinSP";
            this.gbThongtinSP.Size = new System.Drawing.Size(709, 415);
            this.gbThongtinSP.TabIndex = 38;
            this.gbThongtinSP.TabStop = false;
            this.gbThongtinSP.Text = "Thông tin sản phẩm";
            // 
            // tbGia
            // 
            this.tbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGia.Location = new System.Drawing.Point(55, 357);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(212, 24);
            this.tbGia.TabIndex = 45;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(52, 309);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(31, 18);
            this.lbGia.TabIndex = 44;
            this.lbGia.Text = "Giá";
            // 
            // tbKhuyenmai
            // 
            this.tbKhuyenmai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKhuyenmai.Location = new System.Drawing.Point(432, 238);
            this.tbKhuyenmai.Name = "tbKhuyenmai";
            this.tbKhuyenmai.Size = new System.Drawing.Size(212, 24);
            this.tbKhuyenmai.TabIndex = 43;
            // 
            // lbKhuyenmai
            // 
            this.lbKhuyenmai.AutoSize = true;
            this.lbKhuyenmai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhuyenmai.Location = new System.Drawing.Point(429, 188);
            this.lbKhuyenmai.Name = "lbKhuyenmai";
            this.lbKhuyenmai.Size = new System.Drawing.Size(85, 18);
            this.lbKhuyenmai.TabIndex = 42;
            this.lbKhuyenmai.Text = "Khuyến mãi";
            // 
            // tbSoluong
            // 
            this.tbSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoluong.Location = new System.Drawing.Point(55, 238);
            this.tbSoluong.Name = "tbSoluong";
            this.tbSoluong.Size = new System.Drawing.Size(212, 24);
            this.tbSoluong.TabIndex = 41;
            // 
            // lbSoluong
            // 
            this.lbSoluong.AutoSize = true;
            this.lbSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluong.Location = new System.Drawing.Point(52, 188);
            this.lbSoluong.Name = "lbSoluong";
            this.lbSoluong.Size = new System.Drawing.Size(67, 18);
            this.lbSoluong.TabIndex = 40;
            this.lbSoluong.Text = "Số lượng";
            // 
            // tbTensp
            // 
            this.tbTensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTensp.Location = new System.Drawing.Point(55, 109);
            this.tbTensp.Name = "tbTensp";
            this.tbTensp.Size = new System.Drawing.Size(212, 24);
            this.tbTensp.TabIndex = 39;
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.Location = new System.Drawing.Point(52, 58);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(102, 18);
            this.lbTenSP.TabIndex = 38;
            this.lbTenSP.Text = "Tên sản phẩm";
            // 
            // dtaGVdanhsachHD
            // 
            this.dtaGVdanhsachHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGVdanhsachHD.Location = new System.Drawing.Point(0, 695);
            this.dtaGVdanhsachHD.Name = "dtaGVdanhsachHD";
            this.dtaGVdanhsachHD.RowHeadersWidth = 51;
            this.dtaGVdanhsachHD.RowTemplate.Height = 24;
            this.dtaGVdanhsachHD.Size = new System.Drawing.Size(811, 225);
            this.dtaGVdanhsachHD.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 30);
            this.label4.TabIndex = 38;
            this.label4.Text = "Danh sách hóa đơn";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(869, 662);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 30);
            this.label5.TabIndex = 40;
            this.label5.Text = "Danh sách chi tiết hóa đơn";
            // 
            // dtaGVdanhsachchitiet
            // 
            this.dtaGVdanhsachchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGVdanhsachchitiet.Location = new System.Drawing.Point(873, 695);
            this.dtaGVdanhsachchitiet.Name = "dtaGVdanhsachchitiet";
            this.dtaGVdanhsachchitiet.RowHeadersWidth = 51;
            this.dtaGVdanhsachchitiet.RowTemplate.Height = 24;
            this.dtaGVdanhsachchitiet.Size = new System.Drawing.Size(771, 225);
            this.dtaGVdanhsachchitiet.TabIndex = 41;
            // 
            // HDban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtaGVdanhsachchitiet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtaGVdanhsachHD);
            this.Controls.Add(this.gbThongtinSP);
            this.Controls.Add(this.pnThemSuaXoa);
            this.Controls.Add(this.lbQuanly);
            this.Controls.Add(this.gbThongtinchung);
            this.Name = "HDban";
            this.Size = new System.Drawing.Size(1644, 920);
            this.gbThongtinchung.ResumeLayout(false);
            this.gbThongtinchung.PerformLayout();
            this.pnThemSuaXoa.ResumeLayout(false);
            this.gbThongtinSP.ResumeLayout(false);
            this.gbThongtinSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVdanhsachHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVdanhsachchitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQuanly;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.GroupBox gbThongtinchung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTongtien;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnThemSuaXoa;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Label lbThanhtien;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbThongtinSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.TextBox tbTensp;
        private System.Windows.Forms.Label lbSoluong;
        private System.Windows.Forms.TextBox tbSoluong;
        private System.Windows.Forms.Label lbKhuyenmai;
        private System.Windows.Forms.TextBox tbKhuyenmai;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.DataGridView dtaGVdanhsachHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtaGVdanhsachchitiet;
    }
}
