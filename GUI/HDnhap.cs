using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HDnhap : UserControl
    {
        HoaDonNhapBLL hdnBLL = new HoaDonNhapBLL();
        public HDnhap()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            DateTime dateStart = dateTimePicker1.Value;
            DateTime dateEnd = dateTimePicker2.Value;
            dgv_hoadon.DataSource = null;
            dgv_hoadon.DataSource = hdnBLL.getAllHoaDonNhap(dateStart, dateEnd);
            dgv_cthd.DataSource = null;
        }

        private void dgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra chỉ mục ô có hợp lệ
            {
                DataGridViewRow row = dgv_hoadon.Rows[e.RowIndex];
                int idHoadon = Convert.ToInt32(row.Cells[0].Value.ToString());
                dgv_cthd.DataSource = null;
                dgv_cthd.DataSource= hdnBLL.getAllCTHoaDonNhap(idHoadon);              
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!!!");
                return;
            }
            loadData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!!!");
                return;
            }
            loadData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Lấy tiêu đề cột
            List<string> columnHeaders = new List<string>();
            foreach (DataGridViewColumn column in dgv_hoadon.Columns)
            {
                columnHeaders.Add(column.HeaderText);
            }

            // Lấy dữ liệu từ DataGridView
            string data = string.Empty;
            for (int i = 0; i < dgv_hoadon.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_hoadon.Columns.Count; j++)
                {
                    if (dgv_hoadon.Rows[i].Cells[j].Value != null)
                    {
                        data += dgv_hoadon.Rows[i].Cells[j].Value.ToString() + "\t";
                    }
                    else
                    {
                        data += "\t";
                    }
                }
                data += "\n";
            }

            // Sao chép tiêu đề cột và dữ liệu vào Clipboard
            string clipboardData = string.Join("\t", columnHeaders) + "\n" + data;
            Clipboard.SetText(clipboardData);

            // Tạo ứng dụng Excel và dán dữ liệu
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object missingData = System.Reflection.Missing.Value;

            xlWbook = xlapp.Workbooks.Add(missingData);
            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);

            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
