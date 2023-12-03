namespace GUI
{
    partial class Thongke
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
            this.lbQuanly = new System.Windows.Forms.Label();
            this.pnThongke = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.rdbt6 = new System.Windows.Forms.RadioButton();
            this.rdbt5 = new System.Windows.Forms.RadioButton();
            this.rdbt4 = new System.Windows.Forms.RadioButton();
            this.rdbt3 = new System.Windows.Forms.RadioButton();
            this.rdbt2 = new System.Windows.Forms.RadioButton();
            this.rdbt1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnThongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lbQuanly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbQuanly.Size = new System.Drawing.Size(1644, 47);
            this.lbQuanly.TabIndex = 39;
            this.lbQuanly.Text = "Quản lý thống kê";
            // 
            // pnThongke
            // 
            this.pnThongke.Controls.Add(this.btnXem);
            this.pnThongke.Controls.Add(this.cbbNam);
            this.pnThongke.Controls.Add(this.cbbThang);
            this.pnThongke.Controls.Add(this.rdbt6);
            this.pnThongke.Controls.Add(this.rdbt5);
            this.pnThongke.Controls.Add(this.rdbt4);
            this.pnThongke.Controls.Add(this.rdbt3);
            this.pnThongke.Controls.Add(this.rdbt2);
            this.pnThongke.Controls.Add(this.rdbt1);
            this.pnThongke.Location = new System.Drawing.Point(22, 88);
            this.pnThongke.Name = "pnThongke";
            this.pnThongke.Size = new System.Drawing.Size(813, 344);
            this.pnThongke.TabIndex = 40;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(647, 226);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(111, 57);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbbNam.Location = new System.Drawing.Point(408, 243);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(121, 24);
            this.cbbNam.TabIndex = 8;
            this.cbbNam.Text = "2022";
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "Tháng 1 ",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbbThang.Location = new System.Drawing.Point(120, 243);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 24);
            this.cbbThang.TabIndex = 7;
            this.cbbThang.Text = "Tháng 1";
            // 
            // rdbt6
            // 
            this.rdbt6.AutoSize = true;
            this.rdbt6.Location = new System.Drawing.Point(408, 174);
            this.rdbt6.Name = "rdbt6";
            this.rdbt6.Size = new System.Drawing.Size(135, 20);
            this.rdbt6.TabIndex = 5;
            this.rdbt6.TabStop = true;
            this.rdbt6.Text = "Sản phẩm tồn kho";
            this.rdbt6.UseVisualStyleBackColor = true;
            // 
            // rdbt5
            // 
            this.rdbt5.AutoSize = true;
            this.rdbt5.Location = new System.Drawing.Point(408, 114);
            this.rdbt5.Name = "rdbt5";
            this.rdbt5.Size = new System.Drawing.Size(256, 20);
            this.rdbt5.TabIndex = 4;
            this.rdbt5.TabStop = true;
            this.rdbt5.Text = "Danh sách sản phẩm nhập trong tháng";
            this.rdbt5.UseVisualStyleBackColor = true;
            // 
            // rdbt4
            // 
            this.rdbt4.AutoSize = true;
            this.rdbt4.Location = new System.Drawing.Point(408, 51);
            this.rdbt4.Name = "rdbt4";
            this.rdbt4.Size = new System.Drawing.Size(249, 20);
            this.rdbt4.TabIndex = 3;
            this.rdbt4.TabStop = true;
            this.rdbt4.Text = "Danh sách sản phẩm bán trong tháng";
            this.rdbt4.UseVisualStyleBackColor = true;
            // 
            // rdbt3
            // 
            this.rdbt3.AutoSize = true;
            this.rdbt3.Location = new System.Drawing.Point(120, 174);
            this.rdbt3.Name = "rdbt3";
            this.rdbt3.Size = new System.Drawing.Size(247, 20);
            this.rdbt3.TabIndex = 2;
            this.rdbt3.TabStop = true;
            this.rdbt3.Text = "Danh sách nhân viên bán trong tháng";
            this.rdbt3.UseVisualStyleBackColor = true;
            // 
            // rdbt2
            // 
            this.rdbt2.AutoSize = true;
            this.rdbt2.Location = new System.Drawing.Point(120, 114);
            this.rdbt2.Name = "rdbt2";
            this.rdbt2.Size = new System.Drawing.Size(157, 20);
            this.rdbt2.TabIndex = 1;
            this.rdbt2.TabStop = true;
            this.rdbt2.Text = "Doanh thu trong tháng";
            this.rdbt2.UseVisualStyleBackColor = true;
            // 
            // rdbt1
            // 
            this.rdbt1.AutoSize = true;
            this.rdbt1.Location = new System.Drawing.Point(120, 51);
            this.rdbt1.Name = "rdbt1";
            this.rdbt1.Size = new System.Drawing.Size(168, 20);
            this.rdbt1.TabIndex = 0;
            this.rdbt1.TabStop = true;
            this.rdbt1.Text = "Tiền chi tiêu trong tháng";
            this.rdbt1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1345, 344);
            this.dataGridView1.TabIndex = 41;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(887, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 30);
            this.textBox1.TabIndex = 42;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnThongke);
            this.Controls.Add(this.lbQuanly);
            this.Name = "Thongke";
            this.Size = new System.Drawing.Size(1644, 920);
            this.pnThongke.ResumeLayout(false);
            this.pnThongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuanly;
        private System.Windows.Forms.Panel pnThongke;
        private System.Windows.Forms.RadioButton rdbt6;
        private System.Windows.Forms.RadioButton rdbt5;
        private System.Windows.Forms.RadioButton rdbt4;
        private System.Windows.Forms.RadioButton rdbt3;
        private System.Windows.Forms.RadioButton rdbt2;
        private System.Windows.Forms.RadioButton rdbt1;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
