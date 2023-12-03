namespace GUI
{
    partial class Banhang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banhang));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbQuanly = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbtenloai = new System.Windows.Forms.TextBox();
            this.tbgia = new System.Windows.Forms.TextBox();
            this.tbtensanpham = new System.Windows.Forms.TextBox();
            this.tbhangsanxuat = new System.Windows.Forms.TextBox();
            this.tbdonvitinh = new System.Windows.Forms.TextBox();
            this.tbidloaisanpham = new System.Windows.Forms.TextBox();
            this.tbsoluong = new System.Windows.Forms.TextBox();
            this.tbkhuyenmai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
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
            this.lbQuanly.TabIndex = 5;
            this.lbQuanly.Text = "Quản lý bán hàng";
            this.lbQuanly.Click += new System.EventHandler(this.lbQuanly_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 549);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1436, 368);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(151, 124);
            this.tbId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(220, 22);
            this.tbId.TabIndex = 9;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // tbtenloai
            // 
            this.tbtenloai.Enabled = false;
            this.tbtenloai.Location = new System.Drawing.Point(151, 229);
            this.tbtenloai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbtenloai.Name = "tbtenloai";
            this.tbtenloai.Size = new System.Drawing.Size(220, 22);
            this.tbtenloai.TabIndex = 10;
            this.tbtenloai.TextChanged += new System.EventHandler(this.tbtenloai_TextChanged);
            // 
            // tbgia
            // 
            this.tbgia.Enabled = false;
            this.tbgia.Location = new System.Drawing.Point(151, 335);
            this.tbgia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbgia.Name = "tbgia";
            this.tbgia.Size = new System.Drawing.Size(220, 22);
            this.tbgia.TabIndex = 11;
            this.tbgia.TextChanged += new System.EventHandler(this.tbgia_TextChanged);
            // 
            // tbtensanpham
            // 
            this.tbtensanpham.Enabled = false;
            this.tbtensanpham.Location = new System.Drawing.Point(625, 124);
            this.tbtensanpham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbtensanpham.Name = "tbtensanpham";
            this.tbtensanpham.Size = new System.Drawing.Size(220, 22);
            this.tbtensanpham.TabIndex = 12;
            this.tbtensanpham.TextChanged += new System.EventHandler(this.tbtensanpham_TextChanged);
            // 
            // tbhangsanxuat
            // 
            this.tbhangsanxuat.Enabled = false;
            this.tbhangsanxuat.Location = new System.Drawing.Point(625, 229);
            this.tbhangsanxuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbhangsanxuat.Name = "tbhangsanxuat";
            this.tbhangsanxuat.Size = new System.Drawing.Size(220, 22);
            this.tbhangsanxuat.TabIndex = 13;
            this.tbhangsanxuat.TextChanged += new System.EventHandler(this.tbhangsanxuat_TextChanged);
            // 
            // tbdonvitinh
            // 
            this.tbdonvitinh.Enabled = false;
            this.tbdonvitinh.Location = new System.Drawing.Point(625, 335);
            this.tbdonvitinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbdonvitinh.Name = "tbdonvitinh";
            this.tbdonvitinh.Size = new System.Drawing.Size(220, 22);
            this.tbdonvitinh.TabIndex = 14;
            this.tbdonvitinh.TextChanged += new System.EventHandler(this.tbdonvitinh_TextChanged);
            // 
            // tbidloaisanpham
            // 
            this.tbidloaisanpham.Enabled = false;
            this.tbidloaisanpham.Location = new System.Drawing.Point(1095, 124);
            this.tbidloaisanpham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbidloaisanpham.Name = "tbidloaisanpham";
            this.tbidloaisanpham.Size = new System.Drawing.Size(220, 22);
            this.tbidloaisanpham.TabIndex = 15;
            this.tbidloaisanpham.TextChanged += new System.EventHandler(this.tbidloaisanpham_TextChanged);
            // 
            // tbsoluong
            // 
            this.tbsoluong.Location = new System.Drawing.Point(1095, 229);
            this.tbsoluong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbsoluong.Name = "tbsoluong";
            this.tbsoluong.Size = new System.Drawing.Size(220, 22);
            this.tbsoluong.TabIndex = 16;
            this.tbsoluong.TextChanged += new System.EventHandler(this.tbsoluong_TextChanged);
            // 
            // tbkhuyenmai
            // 
            this.tbkhuyenmai.Enabled = false;
            this.tbkhuyenmai.Location = new System.Drawing.Point(1095, 335);
            this.tbkhuyenmai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbkhuyenmai.Name = "tbkhuyenmai";
            this.tbkhuyenmai.Size = new System.Drawing.Size(220, 22);
            this.tbkhuyenmai.TabIndex = 17;
            this.tbkhuyenmai.TextChanged += new System.EventHandler(this.tbkhuyenmai_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "id ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1091, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "id loại sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên loại sản phẩm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hãng sản xuất";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1091, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Số lượng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giá";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 315);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Đơn vị tính";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1091, 315);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Khuyến mãi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(309, 431);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(85, 85);
            this.btnadd.TabIndex = 27;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(652, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 85);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbQuanly);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Banhang";
            this.Size = new System.Drawing.Size(1644, 921);
            this.Load += new System.EventHandler(this.Banhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbQuanly;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbtenloai;
        private System.Windows.Forms.TextBox tbgia;
        private System.Windows.Forms.TextBox tbtensanpham;
        private System.Windows.Forms.TextBox tbhangsanxuat;
        private System.Windows.Forms.TextBox tbdonvitinh;
        private System.Windows.Forms.TextBox tbidloaisanpham;
        private System.Windows.Forms.TextBox tbsoluong;
        private System.Windows.Forms.TextBox tbkhuyenmai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button1;
    }
}
