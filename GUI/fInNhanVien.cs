using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fInNhanVien : Form
    {
        public fInNhanVien()
        {
            InitializeComponent();
        }

        private void fInNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanvien_ds.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this.nhanvien_ds.NhanVien);
            nhanvien_ds report_ds = new nhanvien_ds();
            string connection_string = @"Data Source=LAPTOP-IJDHL0GE\SQLEXPRESS;Initial Catalog=PhoneManage;Integrated Security=True";
            string query = @"SELECT id, tennhanvien, ngaysinh, idLoaiNhanVien, sodienthoai, cmnd, email, gioitinh, diachi, matkhau FROM NhanVien";
            SqlConnection conn = new SqlConnection(connection_string);
            SqlDataAdapter adptr = new SqlDataAdapter(query, conn);
            adptr.Fill(report_ds, report_ds.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("nhanvienReport", report_ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
