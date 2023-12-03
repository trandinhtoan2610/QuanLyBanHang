namespace GUI
{
    partial class fTimkiem
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
            this.gbThongtinKH = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSđt = new System.Windows.Forms.TextBox();
            this.lbSđt = new System.Windows.Forms.Label();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbThongtinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongtinKH
            // 
            this.gbThongtinKH.Controls.Add(this.button1);
            this.gbThongtinKH.Controls.Add(this.tbSđt);
            this.gbThongtinKH.Controls.Add(this.lbSđt);
            this.gbThongtinKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongtinKH.Location = new System.Drawing.Point(460, 356);
            this.gbThongtinKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongtinKH.Name = "gbThongtinKH";
            this.gbThongtinKH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongtinKH.Size = new System.Drawing.Size(729, 238);
            this.gbThongtinKH.TabIndex = 1;
            this.gbThongtinKH.TabStop = false;
            this.gbThongtinKH.Text = "Thông tin khách hàng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSđt
            // 
            this.tbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSđt.Location = new System.Drawing.Point(262, 97);
            this.tbSđt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSđt.Name = "tbSđt";
            this.tbSđt.Size = new System.Drawing.Size(212, 24);
            this.tbSđt.TabIndex = 16;
            // 
            // lbSđt
            // 
            this.lbSđt.AutoSize = true;
            this.lbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSđt.Location = new System.Drawing.Point(116, 100);
            this.lbSđt.Name = "lbSđt";
            this.lbSđt.Size = new System.Drawing.Size(134, 24);
            this.lbSđt.TabIndex = 13;
            this.lbSđt.Text = "Số điện thoại";
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.BackColor = System.Drawing.Color.Cyan;
            this.lbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(455, 267);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(735, 39);
            this.lbTimkiem.TabIndex = 2;
            this.lbTimkiem.Text = "Tìm kiếm khách hàng";
            this.lbTimkiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fTimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTimkiem);
            this.Controls.Add(this.gbThongtinKH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTimkiem";
            this.Size = new System.Drawing.Size(1644, 921);
            this.gbThongtinKH.ResumeLayout(false);
            this.gbThongtinKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongtinKH;
        private System.Windows.Forms.TextBox tbSđt;
        private System.Windows.Forms.Label lbSđt;
        private System.Windows.Forms.Label lbTimkiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}
