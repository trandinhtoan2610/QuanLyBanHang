using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraCharts.Native;
using System.Text;
using Microsoft.Office.Interop.Excel;
    

namespace GUI
{
    public partial class NCC : UserControl
    {
        BindingSource ncclist = new BindingSource();
        NCCBLL qlNCCBLL = new NCCBLL();
        NCCDTO ncc = new NCCDTO();
        List<NCCDTO> listNCC;

        public NCC()
        {
            InitializeComponent();
            load();
            loadHeaderText();


        }
        public void load()
        {

            dtaGVNCC.DataSource = ncclist;
            listNCC = qlNCCBLL.readDB();
            ncclist.DataSource = listNCC;
            addNCCBinding();

        }

        public void loadHeaderText()
        {
            dtaGVNCC.Columns["id"].HeaderText = "ID";
            dtaGVNCC.Columns["tennhacungcap"].HeaderText = "Tên nhà cung cấp";
            dtaGVNCC.Columns["sodienthoai"].HeaderText = "Số điện thoại";
            dtaGVNCC.Columns["diachi"].HeaderText = "Địa chỉ";
            dtaGVNCC.Columns["email"].HeaderText = "Email";

        }
        public void loadData()
        {
            listNCC = qlNCCBLL.readDB();
            ncclist.DataSource = listNCC;
        }

        public void addNCCBinding()
        {
            tbMaNCC.DataBindings.Add(new Binding("Text", dtaGVNCC.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbTenNCC.DataBindings.Add(new Binding("Text", dtaGVNCC.DataSource, "tennhacungcap", true, DataSourceUpdateMode.Never));
            tbSđt.DataBindings.Add(new Binding("Text", dtaGVNCC.DataSource, "sodienthoai", true, DataSourceUpdateMode.Never));
            tbDiachi.DataBindings.Add(new Binding("Text", dtaGVNCC.DataSource, "diachi", true, DataSourceUpdateMode.Never));
            tbEmail.DataBindings.Add(new Binding("Text", dtaGVNCC.DataSource, "email", true, DataSourceUpdateMode.Never));
        }

        public void Clear()
        {
            tbMaNCC.Text = tbTenNCC.Text = tbSđt.Text = tbDiachi.Text = tbEmail.Text = string.Empty;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            ncc.Tennhacungcap = tbTenNCC.Text;
            ncc.Sodienthoai = tbSđt.Text;
            ncc.Diachi = tbDiachi.Text;
            ncc.Email = tbEmail.Text;


            if (qlNCCBLL.InsertNCC(ncc.Id, ncc.Tennhacungcap, ncc.Sodienthoai, ncc.Diachi, ncc.Email))
            {
                MessageBox.Show("thêm thành công!");
            }
            loadData();
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ncc.Id = Convert.ToInt32(tbMaNCC.Text);
            ncc.Tennhacungcap = tbTenNCC.Text;
            ncc.Sodienthoai = tbSđt.Text;
            ncc.Diachi = tbDiachi.Text;
            ncc.Email = tbEmail.Text;

            if (qlNCCBLL.UpdateNCC(ncc.Id, ncc.Tennhacungcap, ncc.Sodienthoai, ncc.Diachi, ncc.Email))
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            loadData();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ncc.Id = Convert.ToInt32(tbMaNCC.Text);
            if (qlNCCBLL.DeleteNCC(ncc.Id))
            {
                MessageBox.Show("Xóa thành công!");
            }
            loadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // Lấy tiêu đề của các cột và gán chúng vào chuỗi
            for (int i = 0; i < dtaGVNCC.Columns.Count; i++)
            {
                sb.Append(dtaGVNCC.Columns[i].HeaderText);
                sb.Append("\t"); // Sử dụng tab để phân tách giữa các cột
            }
            sb.AppendLine(); // Xuống dòng sau khi ghi tiêu đề

            // Lấy dữ liệu từ các hàng và cột và ghi vào chuỗi
            for (int i = 0; i < dtaGVNCC.Rows.Count; i++)
            {
                for (int j = 0; j < dtaGVNCC.Columns.Count; j++)
                {
                    sb.Append(dtaGVNCC.Rows[i].Cells[j].Value);
                    sb.Append("\t"); // Sử dụng tab để phân tách giữa các cột
                }
                sb.AppendLine(); // Xuống dòng sau khi ghi mỗi hàng
            }

            // Sao chép chuỗi dữ liệu vào Clipboard
            Clipboard.SetText(sb.ToString());

            // Khởi tạo ứng dụng Excel
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;

            // Tạo một Workbook mới
            Microsoft.Office.Interop.Excel.Workbook xlWbook = xlapp.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets[1];

            // Dán dữ liệu từ clipboard vào Excel
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            // Lấy tiêu đề của các cột và gán chúng vào Excel
            for (int i = 1; i <= dtaGVNCC.Columns.Count; i++)
            {
                xlsheet.Cells[1, i] = dtaGVNCC.Columns[i - 1].HeaderText;
            }

            // Thiết lập lại vùng lựa chọn đầu tiên để hiển thị trọn vẹn bảng Excel
            xlsheet.Range[xlsheet.Cells[1, 1], xlsheet.Cells[dtaGVNCC.Rows.Count + 1, dtaGVNCC.Columns.Count]].AutoFormat(Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);

            // Xóa dữ liệu trong Clipboard để tránh rò rỉ bộ nhớ
            Clipboard.Clear();
        }
    }

}