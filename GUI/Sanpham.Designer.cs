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
            this.lbQuanly.Location = new System.Drawing.Point(3, 0);
            this.lbQuanly.Name = "lbQuanly";
            this.lbQuanly.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.lbQuanly.Size = new System.Drawing.Size(1639, 47);
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
            this.pnThongtin.Location = new System.Drawing.Point(3, 50);
            this.pnThongtin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnThongtin.Name = "pnThongtin";
            this.pnThongtin.Size = new System.Drawing.Size(1639, 302);
            this.pnThongtin.TabIndex = 6;
            // 
            // cbTenloaisanpham
            // 
            this.cbTenloaisanpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenloaisanpham.FormattingEnabled = true;
            this.cbTenloaisanpham.Location = new System.Drawing.Point(563, 60);
            this.cbTenloaisanpham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTenloaisanpham.Name = "cbTenloaisanpham";
            this.cbTenloaisanpham.Size = new System.Drawing.Size(212, 24);
            this.cbTenloaisanpham.TabIndex = 30;
            // 
            // cbHangSX
            // 
            this.cbHangSX.FormattingEnabled = true;
            this.cbHangSX.Items.AddRange(new object[] {
            "SAMSUNG",
            "IPHONE",
            "XIAOMI"});
            this.cbHangSX.Location = new System.Drawing.Point(875, 62);
            this.cbHangSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHangSX.Name = "cbHangSX";
            this.cbHangSX.Size = new System.Drawing.Size(212, 24);
            this.cbHangSX.TabIndex = 29;
            // 
            // lbMaLoaiSP
            // 
            this.lbMaLoaiSP.AutoSize = true;
            this.lbMaLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiSP.Location = new System.Drawing.Point(559, 30);
            this.lbMaLoaiSP.Name = "lbMaLoaiSP";
            this.lbMaLoaiSP.Size = new System.Drawing.Size(109, 15);
            this.lbMaLoaiSP.TabIndex = 27;
            this.lbMaLoaiSP.Text = "Tên loại sản phẩm";
            // 
            // tbDonvitinh
            // 
            this.tbDonvitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDonvitinh.Location = new System.Drawing.Point(261, 234);
            this.tbDonvitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDonvitinh.Name = "tbDonvitinh";
            this.tbDonvitinh.Size = new System.Drawing.Size(212, 21);
            this.tbDonvitinh.TabIndex = 26;
            // 
            // btnChon
            // 
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.Location = new System.Drawing.Point(83, 198);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(60, 60);
            this.btnChon.TabIndex = 25;
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // tbMota
            // 
            this.tbMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMota.Location = new System.Drawing.Point(1231, 62);
            this.tbMota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMota.Multiline = true;
            this.tbMota.Name = "tbMota";
            this.tbMota.Size = new System.Drawing.Size(179, 162);
            this.tbMota.TabIndex = 24;
            // 
            // lbMota
            // 
            this.lbMota.AutoSize = true;
            this.lbMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMota.Location = new System.Drawing.Point(1228, 30);
            this.lbMota.Name = "lbMota";
            this.lbMota.Size = new System.Drawing.Size(38, 15);
            this.lbMota.TabIndex = 23;
            this.lbMota.Text = "Mô tả";
            // 
            // tbSoluong
            // 
            this.tbSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoluong.Location = new System.Drawing.Point(875, 153);
            this.tbSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoluong.Name = "tbSoluong";
            this.tbSoluong.Size = new System.Drawing.Size(212, 21);
            this.tbSoluong.TabIndex = 22;
            // 
            // lbSoluong
            // 
            this.lbSoluong.AutoSize = true;
            this.lbSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoluong.Location = new System.Drawing.Point(872, 121);
            this.lbSoluong.Name = "lbSoluong";
            this.lbSoluong.Size = new System.Drawing.Size(56, 15);
            this.lbSoluong.TabIndex = 21;
            this.lbSoluong.Text = "Số lượng";
            // 
            // lbHangSX
            // 
            this.lbHangSX.AutoSize = true;
            this.lbHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHangSX.Location = new System.Drawing.Point(872, 30);
            this.lbHangSX.Name = "lbHangSX";
            this.lbHangSX.Size = new System.Drawing.Size(86, 15);
            this.lbHangSX.TabIndex = 16;
            this.lbHangSX.Text = "Hãng sản xuất";
            // 
            // tbKhuyenmai
            // 
            this.tbKhuyenmai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKhuyenmai.Location = new System.Drawing.Point(563, 234);
            this.tbKhuyenmai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKhuyenmai.Name = "tbKhuyenmai";
            this.tbKhuyenmai.Size = new System.Drawing.Size(212, 21);
            this.tbKhuyenmai.TabIndex = 15;
            // 
            // tbGia
            // 
            this.tbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGia.Location = new System.Drawing.Point(563, 153);
            this.tbGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(212, 21);
            this.tbGia.TabIndex = 14;
            // 
            // lbKhuyenmai
            // 
            this.lbKhuyenmai.AutoSize = true;
            this.lbKhuyenmai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhuyenmai.Location = new System.Drawing.Point(559, 206);
            this.lbKhuyenmai.Name = "lbKhuyenmai";
            this.lbKhuyenmai.Size = new System.Drawing.Size(72, 15);
            this.lbKhuyenmai.TabIndex = 12;
            this.lbKhuyenmai.Text = "Khuyến mãi";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(559, 121);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(26, 15);
            this.lbGia.TabIndex = 11;
            this.lbGia.Text = "Giá";
            // 
            // tbTenSP
            // 
            this.tbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenSP.Location = new System.Drawing.Point(261, 153);
            this.tbTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(212, 21);
            this.tbTenSP.TabIndex = 7;
            // 
            // tbMaSP
            // 
            this.tbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSP.Location = new System.Drawing.Point(261, 62);
            this.tbMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.Size = new System.Drawing.Size(212, 21);
            this.tbMaSP.TabIndex = 6;
            // 
            // lbDonvitinh
            // 
            this.lbDonvitinh.AutoSize = true;
            this.lbDonvitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonvitinh.Location = new System.Drawing.Point(259, 206);
            this.lbDonvitinh.Name = "lbDonvitinh";
            this.lbDonvitinh.Size = new System.Drawing.Size(64, 15);
            this.lbDonvitinh.TabIndex = 5;
            this.lbDonvitinh.Text = "Đơn vị tính";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.Location = new System.Drawing.Point(259, 121);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(86, 15);
            this.lbTenSP.TabIndex = 4;
            this.lbTenSP.Text = "Tên sản phẩm";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSP.Location = new System.Drawing.Point(259, 30);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(83, 15);
            this.lbMaSP.TabIndex = 3;
            this.lbMaSP.Text = "Mã sản phẩm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(55, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 121);
            this.panel2.TabIndex = 1;
            // 
            // lbThongtin
            // 
            this.lbThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtin.Location = new System.Drawing.Point(29, 9);
            this.lbThongtin.Name = "lbThongtin";
            this.lbThongtin.Size = new System.Drawing.Size(223, 25);
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
            this.pnThemSuaXoa.Location = new System.Drawing.Point(3, 358);
            this.pnThemSuaXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnThemSuaXoa.Name = "pnThemSuaXoa";
            this.pnThemSuaXoa.Size = new System.Drawing.Size(1639, 106);
            this.pnThemSuaXoa.TabIndex = 30;
            // 
            // tbTimkiem
            // 
            this.tbTimkiem.BackColor = System.Drawing.Color.White;
            this.tbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimkiem.HideSelection = false;
            this.tbTimkiem.Location = new System.Drawing.Point(875, 34);
            this.tbTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTimkiem.Name = "tbTimkiem";
            this.tbTimkiem.Size = new System.Drawing.Size(452, 21);
            this.tbTimkiem.TabIndex = 8;
            this.tbTimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTimkiem_KeyDown);
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(629, 15);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 75);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(261, 15);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 75);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(83, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhsach.Location = new System.Drawing.Point(4, 480);
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.Size = new System.Drawing.Size(223, 25);
            this.lbDanhsach.TabIndex = 29;
            this.lbDanhsach.Text = "Danh sách sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 508);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1639, 409);
            this.dataGridView1.TabIndex = 31;
            // 
            // Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbDanhsach);
            this.Controls.Add(this.pnThemSuaXoa);
            this.Controls.Add(this.pnThongtin);
            this.Controls.Add(this.lbQuanly);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sanpham";
            this.Size = new System.Drawing.Size(1639, 921);
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