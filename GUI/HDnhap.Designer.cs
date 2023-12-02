namespace GUI
{
    partial class HDnhap
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_cthd = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthd)).BeginInit();
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
            this.lbQuanly.TabIndex = 38;
            this.lbQuanly.Text = "Quản lý hóa đơn nhập";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(592, 30);
            this.label4.TabIndex = 41;
            this.label4.Text = "Danh sách hóa đơn";
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Location = new System.Drawing.Point(55, 233);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowHeadersWidth = 51;
            this.dgv_hoadon.RowTemplate.Height = 24;
            this.dgv_hoadon.Size = new System.Drawing.Size(1128, 284);
            this.dgv_hoadon.TabIndex = 42;
            this.dgv_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellContentClick);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(597, 30);
            this.label5.TabIndex = 43;
            this.label5.Text = "Danh sách chi tiết hóa đơn";
            // 
            // dgv_cthd
            // 
            this.dgv_cthd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cthd.Location = new System.Drawing.Point(55, 576);
            this.dgv_cthd.Name = "dgv_cthd";
            this.dgv_cthd.RowHeadersWidth = 51;
            this.dgv_cthd.RowTemplate.Height = 24;
            this.dgv_cthd.Size = new System.Drawing.Size(1128, 274);
            this.dgv_cthd.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1046, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 45;
            this.button1.Text = "Export Excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(375, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker2.TabIndex = 47;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // HDnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_cthd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_hoadon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbQuanly);
            this.Name = "HDnhap";
            this.Size = new System.Drawing.Size(1644, 920);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbQuanly;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dgv_cthd;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}
