using System.Windows.Forms;

namespace GUI
{
    partial class Sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sanpham));
            this.lbQuanly = new System.Windows.Forms.Label();
            this.pnThongtin = new System.Windows.Forms.Panel();
            this.cbTenloaisanpham = new System.Windows.Forms.ComboBox();
            this.cbHangSX = new System.Windows.Forms.ComboBox();
            this.lbMaLoaiSP = new System.Windows.Forms.Label();
            this.tbDonvitinh = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.tbMota = new System.Windows.Forms.TextBox();
            this.lbMota = new System.Windows.Forms.Label();
            this.tbSoluong = new System.Windows.Forms.TextBox();
            this.lbSoluong = new System.Windows.Forms.Label();
            this.lbHangSX = new System.Windows.Forms.Label();
            this.tbKhuyenmai = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.lbKhuyenmai = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.tbMaSP = new System.Windows.Forms.TextBox();
            this.lbDonvitinh = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThongtin = new System.Windows.Forms.Label();
            this.pnThemSuaXoa = new System.Windows.Forms.Panel();
            this.tbTimkiem = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbDanhsach = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnThongtin.SuspendLayout();
            this.pnThemSuaXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuanly
            // 
            this.lbQuanly.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanly.Location = new System.Drawing.Point(2, 0);
            this.lbQuanly.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuanly.Name = "lbQuanly";
            this.lbQuanly.Padding = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.lbQuanly.Size = new System.Drawing.Size(1229, 38);
            this.lbQuanly.TabIndex = 5;
            this.lbQuanly.Text = "Quản lý sản phẩm";
            // 
            // pnThongtin
            // 
            this.pnThongtin.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pnThongtin.Controls.Add(this.cbTenloaisanpham);
            this.pnThongtin.Controls.Add(this.cbHangSX);
            this.pnThongtin.Controls.Add(this.lbMaLoaiSP);
            this.pnThongtin.Controls.Add(this.tbDonvitinh);
            this.pnThongtin.Controls.Add(this.btnChon);
            this.pnThongtin.Controls.Add(this.tbMota);
            this.pnThongtin.Controls.Add(this.lbMota);
            this.pnThongtin.Controls.Add(this.tbSoluong);
            this.pnThongtin.Controls.Add(this.lbSoluong);
            this.pnThongtin.Controls.Add(this.lbHangSX);
            this.pnThongtin.Controls.Add(this.tbKhuyenmai);
            this.pnThongtin.Controls.Add(this.tbGia);
            this.pnThongtin.Controls.Add(this.lbKhuyenmai);
            this.pnThongtin.Controls.Add(this.lbGia);
            this.pnThongtin.Controls.Add(this.tbTenSP);
            this.pnThongtin.Controls.Add(this.tbMaSP);
            this.pnThongtin.Controls.Add(this.lbDonvitinh);
            this.pnThongtin.Controls.Add(this.lbTenSP);
            this.pnThongtin.Controls.Add(this.lbMaSP);
            this.pnThongtin.Controls.Add(this.panel2);
            this.pnThongtin.Controls.Add(this.lbThongtin);
            this.pnThongtin.Location = new System.Drawing.Point(2, 41);
            this.pnThongtin.Margin = new System.Windows.Forms.Padding(2);
            this.pnThongtin.Name = "pnThongtin";
            this.pnThongtin.Size = new System.Drawing.Size(1229, 245);
            this.pnThongtin.TabIndex = 6;
            // 
            // cbTenloaisanpham
            // 
            this.cbTenloaisanpham.FormattingEnabled = true;
            this.cbTenloaisanpham.Location = new System.Drawing.Point(422, 49);
            this.cbTenloaisanpham.Name = "cbTenloaisanpham";
            this.cbTenloaisanpham.Size = new System.Drawing.Size(160, 21);
            this.cbTenloaisanpham.TabIndex = 30;
            // 
            // cbHangSX
            // 
            this.cbHangSX.FormattingEnabled = true;
            this.cbHangSX.Items.AddRange(new object[] {
            "SAMSUNG",
            "IPHONE",
            "XIAOMI"});
            this.cbHangSX.Location = new System.Drawing.Point(656, 50);
            this.cbHangSX.Margin = new System.Windows.Forms.Padding(2);
            this.cbHangSX.Name = "cbHangSX";
            this.cbHangSX.Size = new System.Drawing.Size(160, 21);
            this.cbHangSX.TabIndex = 29;
            // 
            // lbMaLoaiSP
            // 
            this.lbMaLoaiSP.AutoSize = true;
            this.lbMaLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiSP.Location = new System.Drawing.Point(419, 24);
            this.lbMaLoaiSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaLoaiSP.Name = "lbMaLoaiSP";
            this.lbMaLoaiSP.Size = new System.Drawing.Size(109, 15);
            this.lbMaLoaiSP.TabIndex = 27;
            this.lbMaLoaiSP.Text = "Tên loại sản phẩm";
            // 
            // tbDonvitinh
            // 
            this.tbDonvitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDonvitinh.Location = new System.Drawing.Point(196, 190);
            this.tbDonvitinh.Margin = new System.Windows.Forms.Padding(2);
            this.tbDonvitinh.Name = "tbDonvitinh";
            this.tbDonvitinh.Size = new System.Drawing.Size(160, 21);
            this.tbDonvitinh.TabIndex = 26;
            // 
            // btnChon
            // 
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.Location = new System.Drawing.Point(62, 161);
            this.btnChon.Margin = new System.Windows.Forms.Padding(2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(45, 49);
            this.btnChon.TabIndex = 25;
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // tbMota
            // 
            this.tbMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMota.Location = new System.Drawing.Point(923, 50);
            this.tbMota.Margin = new System.Windows.Forms.Padding(2);
            this.tbMota.Multiline = true;
            this.tbMota.Name = "tbMota";
            this.tbMota.Size = new System.Drawing.Size(135, 132);
            this.tbMota.TabIndex = 24;
            // 
            // lbMota
            // 
            this.lbMota.AutoSize = true;
            this.lbMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMota.Location = new System.Drawing.Point(921, 24);
            this.lbMota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMota.Name = "lbMota";
            this.lbMota.Size = new System.Drawing.Size(38, 15);
            this.lbMota.TabIndex = 23;
            this.lbMota.Text = "Mô tả";
            // 
            // tbSoluong
            // 
            this.tbSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoluong.Location = new System.Drawing.Point(656, 124);
            this.tbSoluong.Margin = new System.Windows.Forms.Padding(2);
            this.tbSoluong.Name = "tbSoluong";
            this.tbSoluong.Size = new System.Drawing.Size(160, 21);
            this.tbSoluong.TabIndex = 22;
            // 
            // lbSoluong
            // 
            this.lbSoluong.AutoSize = true;
            this.lbSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluong.Location = new System.Drawing.Point(654, 98);
            this.lbSoluong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoluong.Name = "lbSoluong";
            this.lbSoluong.Size = new System.Drawing.Size(56, 15);
            this.lbSoluong.TabIndex = 21;
            this.lbSoluong.Text = "Số lượng";
            // 
            // lbHangSX
            // 
            this.lbHangSX.AutoSize = true;
            this.lbHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHangSX.Location = new System.Drawing.Point(654, 24);
            this.lbHangSX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHangSX.Name = "lbHangSX";
            this.lbHangSX.Size = new System.Drawing.Size(86, 15);
            this.lbHangSX.TabIndex = 16;
            this.lbHangSX.Text = "Hãng sản xuất";
            // 
            // tbKhuyenmai
            // 
            this.tbKhuyenmai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKhuyenmai.Location = new System.Drawing.Point(422, 190);
            this.tbKhuyenmai.Margin = new System.Windows.Forms.Padding(2);
            this.tbKhuyenmai.Name = "tbKhuyenmai";
            this.tbKhuyenmai.Size = new System.Drawing.Size(160, 21);
            this.tbKhuyenmai.TabIndex = 15;
            // 
            // tbGia
            // 
            this.tbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGia.Location = new System.Drawing.Point(422, 124);
            this.tbGia.Margin = new System.Windows.Forms.Padding(2);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(160, 21);
            this.tbGia.TabIndex = 14;
            // 
            // lbKhuyenmai
            // 
            this.lbKhuyenmai.AutoSize = true;
            this.lbKhuyenmai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhuyenmai.Location = new System.Drawing.Point(419, 167);
            this.lbKhuyenmai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKhuyenmai.Name = "lbKhuyenmai";
            this.lbKhuyenmai.Size = new System.Drawing.Size(72, 15);
            this.lbKhuyenmai.TabIndex = 12;
            this.lbKhuyenmai.Text = "Khuyến mãi";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(419, 98);
            this.lbGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(26, 15);
            this.lbGia.TabIndex = 11;
            this.lbGia.Text = "Giá";
            // 
            // tbTenSP
            // 
            this.tbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenSP.Location = new System.Drawing.Point(196, 124);
            this.tbTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(160, 21);
            this.tbTenSP.TabIndex = 7;
            // 
            // tbMaSP
            // 
            this.tbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSP.Location = new System.Drawing.Point(196, 50);
            this.tbMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.Size = new System.Drawing.Size(160, 21);
            this.tbMaSP.TabIndex = 6;
            // 
            // lbDonvitinh
            // 
            this.lbDonvitinh.AutoSize = true;
            this.lbDonvitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonvitinh.Location = new System.Drawing.Point(194, 167);
            this.lbDonvitinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDonvitinh.Name = "lbDonvitinh";
            this.lbDonvitinh.Size = new System.Drawing.Size(64, 15);
            this.lbDonvitinh.TabIndex = 5;
            this.lbDonvitinh.Text = "Đơn vị tính";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.Location = new System.Drawing.Point(194, 98);
            this.lbTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(86, 15);
            this.lbTenSP.TabIndex = 4;
            this.lbTenSP.Text = "Tên sản phẩm";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSP.Location = new System.Drawing.Point(194, 24);
            this.lbMaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(83, 15);
            this.lbMaSP.TabIndex = 3;
            this.lbMaSP.Text = "Mã sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(41, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 98);
            this.panel2.TabIndex = 1;
            // 
            // lbThongtin
            // 
            this.lbThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtin.Location = new System.Drawing.Point(22, 7);
            this.lbThongtin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThongtin.Name = "lbThongtin";
            this.lbThongtin.Size = new System.Drawing.Size(167, 20);
            this.lbThongtin.TabIndex = 0;
            this.lbThongtin.Text = "Thông tin sản phẩm";
            // 
            // pnThemSuaXoa
            // 
            this.pnThemSuaXoa.BackColor = System.Drawing.Color.White;
            this.pnThemSuaXoa.Controls.Add(this.tbTimkiem);
            this.pnThemSuaXoa.Controls.Add(this.btnExport);
            this.pnThemSuaXoa.Controls.Add(this.btnDelete);
            this.pnThemSuaXoa.Controls.Add(this.btnEdit);
            this.pnThemSuaXoa.Controls.Add(this.btnAdd);
            this.pnThemSuaXoa.Location = new System.Drawing.Point(2, 291);
            this.pnThemSuaXoa.Margin = new System.Windows.Forms.Padding(2);
            this.pnThemSuaXoa.Name = "pnThemSuaXoa";
            this.pnThemSuaXoa.Size = new System.Drawing.Size(1229, 86);
            this.pnThemSuaXoa.TabIndex = 30;
            // 
            // tbTimkiem
            // 
            this.tbTimkiem.BackColor = System.Drawing.Color.White;
            this.tbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimkiem.HideSelection = false;
            this.tbTimkiem.Location = new System.Drawing.Point(656, 28);
            this.tbTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimkiem.Name = "tbTimkiem";
            this.tbTimkiem.Size = new System.Drawing.Size(340, 21);
            this.tbTimkiem.TabIndex = 8;
            this.tbTimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTimkiem_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(472, 12);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(56, 61);
            this.btnExport.TabIndex = 7;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(337, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 61);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(196, 12);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 61);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(62, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 61);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhsach.Location = new System.Drawing.Point(3, 390);
            this.lbDanhsach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.Size = new System.Drawing.Size(167, 20);
            this.lbDanhsach.TabIndex = 29;
            this.lbDanhsach.Text = "Danh sách sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 413);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1229, 332);
            this.dataGridView1.TabIndex = 31;
            // 
            // Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbDanhsach);
            this.Controls.Add(this.pnThemSuaXoa);
            this.Controls.Add(this.pnThongtin);
            this.Controls.Add(this.lbQuanly);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sanpham";
            this.Size = new System.Drawing.Size(1229, 748);
            this.pnThongtin.ResumeLayout(false);
            this.pnThongtin.PerformLayout();
            this.pnThemSuaXoa.ResumeLayout(false);
            this.pnThemSuaXoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQuanly;
        private System.Windows.Forms.Panel pnThongtin;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox tbMota;
        private System.Windows.Forms.Label lbMota;
        private System.Windows.Forms.TextBox tbSoluong;
        private System.Windows.Forms.Label lbSoluong;
        private System.Windows.Forms.Label lbHangSX;
        private System.Windows.Forms.TextBox tbKhuyenmai;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label lbKhuyenmai;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.TextBox tbMaSP;
        private System.Windows.Forms.Label lbDonvitinh;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbThongtin;
        private System.Windows.Forms.TextBox tbDonvitinh;
        private System.Windows.Forms.Label lbMaLoaiSP;
        private System.Windows.Forms.ComboBox cbHangSX;
        private System.Windows.Forms.Panel pnThemSuaXoa;
        private System.Windows.Forms.TextBox tbTimkiem;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbDanhsach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbTenloaisanpham;
    }
}