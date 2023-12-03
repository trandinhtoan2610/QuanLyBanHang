namespace GUI
{
    partial class Nhaphang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhaphang));
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbkhuyenmai = new System.Windows.Forms.TextBox();
            this.tbsoluong = new System.Windows.Forms.TextBox();
            this.tbidloaisanpham = new System.Windows.Forms.TextBox();
            this.tbdonvitinh = new System.Windows.Forms.TextBox();
            this.tbhangsanxuat = new System.Windows.Forms.TextBox();
            this.tbtensanpham = new System.Windows.Forms.TextBox();
            this.tbgia = new System.Windows.Forms.TextBox();
            this.tbtenloai = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.dgv_nhaphang = new System.Windows.Forms.DataGridView();
            this.lbQuanly = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbb_nhacungcap = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaphang)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(625, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 85);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(295, 431);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(85, 85);
            this.btnadd.TabIndex = 49;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1091, 315);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Khuyến mãi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 315);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Đơn vị tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1091, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Hãng sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tên loại sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1091, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Id loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Id";
            // 
            // tbkhuyenmai
            // 
            this.tbkhuyenmai.Enabled = false;
            this.tbkhuyenmai.Location = new System.Drawing.Point(1094, 335);
            this.tbkhuyenmai.Margin = new System.Windows.Forms.Padding(4);
            this.tbkhuyenmai.Name = "tbkhuyenmai";
            this.tbkhuyenmai.Size = new System.Drawing.Size(220, 22);
            this.tbkhuyenmai.TabIndex = 39;
            // 
            // tbsoluong
            // 
            this.tbsoluong.Location = new System.Drawing.Point(1094, 229);
            this.tbsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.tbsoluong.Name = "tbsoluong";
            this.tbsoluong.Size = new System.Drawing.Size(220, 22);
            this.tbsoluong.TabIndex = 38;
            // 
            // tbidloaisanpham
            // 
            this.tbidloaisanpham.Enabled = false;
            this.tbidloaisanpham.Location = new System.Drawing.Point(1094, 124);
            this.tbidloaisanpham.Margin = new System.Windows.Forms.Padding(4);
            this.tbidloaisanpham.Name = "tbidloaisanpham";
            this.tbidloaisanpham.Size = new System.Drawing.Size(220, 22);
            this.tbidloaisanpham.TabIndex = 37;
            // 
            // tbdonvitinh
            // 
            this.tbdonvitinh.Enabled = false;
            this.tbdonvitinh.Location = new System.Drawing.Point(624, 335);
            this.tbdonvitinh.Margin = new System.Windows.Forms.Padding(4);
            this.tbdonvitinh.Name = "tbdonvitinh";
            this.tbdonvitinh.Size = new System.Drawing.Size(220, 22);
            this.tbdonvitinh.TabIndex = 36;
            // 
            // tbhangsanxuat
            // 
            this.tbhangsanxuat.Enabled = false;
            this.tbhangsanxuat.Location = new System.Drawing.Point(624, 229);
            this.tbhangsanxuat.Margin = new System.Windows.Forms.Padding(4);
            this.tbhangsanxuat.Name = "tbhangsanxuat";
            this.tbhangsanxuat.Size = new System.Drawing.Size(220, 22);
            this.tbhangsanxuat.TabIndex = 35;
            // 
            // tbtensanpham
            // 
            this.tbtensanpham.Enabled = false;
            this.tbtensanpham.Location = new System.Drawing.Point(625, 124);
            this.tbtensanpham.Margin = new System.Windows.Forms.Padding(4);
            this.tbtensanpham.Name = "tbtensanpham";
            this.tbtensanpham.Size = new System.Drawing.Size(220, 22);
            this.tbtensanpham.TabIndex = 34;
            // 
            // tbgia
            // 
            this.tbgia.Enabled = false;
            this.tbgia.Location = new System.Drawing.Point(150, 335);
            this.tbgia.Margin = new System.Windows.Forms.Padding(4);
            this.tbgia.Name = "tbgia";
            this.tbgia.Size = new System.Drawing.Size(220, 22);
            this.tbgia.TabIndex = 33;
            // 
            // tbtenloai
            // 
            this.tbtenloai.Enabled = false;
            this.tbtenloai.Location = new System.Drawing.Point(150, 229);
            this.tbtenloai.Margin = new System.Windows.Forms.Padding(4);
            this.tbtenloai.Name = "tbtenloai";
            this.tbtenloai.Size = new System.Drawing.Size(220, 22);
            this.tbtenloai.TabIndex = 32;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(150, 124);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(220, 22);
            this.tbId.TabIndex = 31;
            // 
            // dgv_nhaphang
            // 
            this.dgv_nhaphang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhaphang.Location = new System.Drawing.Point(28, 549);
            this.dgv_nhaphang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_nhaphang.Name = "dgv_nhaphang";
            this.dgv_nhaphang.ReadOnly = true;
            this.dgv_nhaphang.RowHeadersWidth = 51;
            this.dgv_nhaphang.RowTemplate.Height = 24;
            this.dgv_nhaphang.Size = new System.Drawing.Size(1436, 368);
            this.dgv_nhaphang.TabIndex = 30;
            this.dgv_nhaphang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhaphang_CellContentClick);
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
            this.lbQuanly.TabIndex = 29;
            this.lbQuanly.Text = "Nhập hàng";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(958, 457);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(180, 24);
            this.txt_search.TabIndex = 51;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(849, 471);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(101, 26);
            this.lbl_search.TabIndex = 52;
            this.lbl_search.Text = "Tìm kiếm";
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(1156, 446);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(70, 70);
            this.btn_search.TabIndex = 53;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbb_nhacungcap
            // 
            this.cbb_nhacungcap.FormattingEnabled = true;
            this.cbb_nhacungcap.Location = new System.Drawing.Point(958, 482);
            this.cbb_nhacungcap.Name = "cbb_nhacungcap";
            this.cbb_nhacungcap.Size = new System.Drawing.Size(180, 24);
            this.cbb_nhacungcap.TabIndex = 54;
            this.cbb_nhacungcap.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Nhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbb_nhacungcap);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbkhuyenmai);
            this.Controls.Add(this.tbsoluong);
            this.Controls.Add(this.tbidloaisanpham);
            this.Controls.Add(this.tbdonvitinh);
            this.Controls.Add(this.tbhangsanxuat);
            this.Controls.Add(this.tbtensanpham);
            this.Controls.Add(this.tbgia);
            this.Controls.Add(this.tbtenloai);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.dgv_nhaphang);
            this.Controls.Add(this.lbQuanly);
            this.Name = "Nhaphang";
            this.Size = new System.Drawing.Size(1644, 920);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaphang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbkhuyenmai;
        private System.Windows.Forms.TextBox tbsoluong;
        private System.Windows.Forms.TextBox tbidloaisanpham;
        private System.Windows.Forms.TextBox tbdonvitinh;
        private System.Windows.Forms.TextBox tbhangsanxuat;
        private System.Windows.Forms.TextBox tbtensanpham;
        private System.Windows.Forms.TextBox tbgia;
        private System.Windows.Forms.TextBox tbtenloai;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbQuanly;
        public System.Windows.Forms.DataGridView dgv_nhaphang;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbb_nhacungcap;
    }
}
