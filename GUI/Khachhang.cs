using BLL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Khachhang : UserControl
    {
        BindingSource khlist = new BindingSource();
        KhachHangBLL qlkhBLL = new KhachHangBLL();
        KhachHangDTO kh = new KhachHangDTO();
        List<KhachHangDTO> listKhachHang, found;
        public Khachhang()
        {
            InitializeComponent();
            
            load();
            Clear();
        }
        public void load()
        {
            dtaGVKhachang.DataSource = khlist;
            loadData();
            /*addNhanVienBinding();*/
            Clear();
        }

        public void loadData()
        {
            listKhachHang = qlkhBLL.readDB();
            khlist.DataSource = listKhachHang;

        }
        
        private void tbTimkiem_Enter(object sender, EventArgs e)
        {
            if (tbTimkiem.Text == "Tìm kiếm")
            {
                tbTimkiem.Text = "";
                tbTimkiem.ForeColor = Color.Black;
            }
        }
        private void tbTimkiem_Leave(object sender, EventArgs e)
        {
            if (tbTimkiem.Text == "")
            {
                tbTimkiem.Text = "Tìm Kiếm";
                tbTimkiem.ForeColor = Color.LightGray;
            }
        }
        public void Clear()
        {
            tbMaKH.Text= tbHoten.Text = tbSđt.Text=tbGhichu.Text=string.Empty;
        }
        public void addNhanVienBinding()
        {
            
            tbMaKH.DataBindings.Add(new Binding("Text", dtaGVKhachang.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbHoten.DataBindings.Add(new Binding("Text", dtaGVKhachang.DataSource, "tenkhachhang", true, DataSourceUpdateMode.Never));
            tbSđt.DataBindings.Add(new Binding("Text", dtaGVKhachang.DataSource, "sodienthoai", true, DataSourceUpdateMode.Never));
            rb1.DataBindings.Add(new Binding("Checked", dtaGVKhachang.DataSource, "gioitinh", true, DataSourceUpdateMode.Never));
            tbGhichu.DataBindings.Add(new Binding("Text", dtaGVKhachang.DataSource, "ghichu", true, DataSourceUpdateMode.Never));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
             id = int.Parse(tbMaKH.Text);
            if(id > 0)
            {
                if (qlkhBLL.DeleteKH(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    loadData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
            }
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            KhachHangDTO k = new KhachHangDTO();
            k.Id = int.Parse(tbMaKH.Text);
            k.TenKhachHang = tbMaKH.Text;
            k.SoDienThoai = tbSđt.Text;
            if (rb1.Checked)
            {
                k.GioiTinh = "Nam";
            }
            else
            {
                k.GioiTinh = "Nu";
            }
            k.Ghichu = tbGhichu.Text;
            if (qlkhBLL.UpdateKH(k))
            {
                MessageBox.Show("update thành công!");
            }
            else
            {
                MessageBox.Show("update thất bại!");
            }
            
            loadData();
            Clear();
        }
        public void search()
        {
           string text = tbTimkiem.Text;
           found = qlkhBLL.Search(text);
           khlist.DataSource = found;
        }
        
        private void tbTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(tbTimkiem.Text))
                {
                    
                    loadData();
                }
                else
                {
                    search();
                   

                }
                e.SuppressKeyPress = true;
            }
        }

        /*private void btnExport_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            // Lấy tiêu đề của các cột và gán chúng vào chuỗi
            for (int i = 0; i < dtaGVKhachang.Columns.Count; i++)
            {
                sb.Append(dtaGVKhachang.Columns[i].HeaderText);
                sb.Append("\t"); // Sử dụng tab để phân tách giữa các cột
            }
            sb.AppendLine(); // Xuống dòng sau khi ghi tiêu đề

            // Lấy dữ liệu từ các hàng và cột và ghi vào chuỗi
            for (int i = 0; i < dtaGVKhachang.Rows.Count; i++)
            {
                for (int j = 0; j < dtaGVKhachang.Columns.Count; j++)
                {
                    sb.Append(dtaGVKhachang.Rows[i].Cells[j].Value);
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
            for (int i = 1; i <= dtaGVKhachang.Columns.Count; i++)
            {
                xlsheet.Cells[1, i] = dtaGVKhachang.Columns[i - 1].HeaderText;
            }

            // Thiết lập lại vùng lựa chọn đầu tiên để hiển thị trọn vẹn bảng Excel
            xlsheet.Range[xlsheet.Cells[1, 1], xlsheet.Cells[dtaGVKhachang.Rows.Count + 1, dtaGVKhachang.Columns.Count]].AutoFormat(Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);

            // Xóa dữ liệu trong Clipboard để tránh rò rỉ bộ nhớ
            Clipboard.Clear();

        }*/

        private void dtaGVKhachang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int test = int.Parse(dtaGVKhachang[0, dtaGVKhachang.CurrentRow.Index].Value.ToString());
            if (dtaGVKhachang.RowCount > 0 && test >0)
            {
                tbMaKH.Text = dtaGVKhachang[0 , dtaGVKhachang.CurrentRow.Index].Value.ToString();
               tbHoten.Text = dtaGVKhachang[1, dtaGVKhachang.CurrentRow.Index].Value.ToString();
                tbSđt.Text = dtaGVKhachang[2, dtaGVKhachang.CurrentRow.Index].Value.ToString();
                
                string gioitinh = tbGhichu.Text = dtaGVKhachang[3, dtaGVKhachang.CurrentRow.Index].Value.ToString();
                if(gioitinh == "Nam")
                {
                    rb1.Checked = true;
                }
                else
                {
                    rb2.Checked = true;
                }
                tbGhichu.Text = dtaGVKhachang[4, dtaGVKhachang.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            kh.TenKhachHang = tbHoten.Text;
            kh.SoDienThoai = tbSđt.Text;
            if(rb1.Checked)
            {
                kh.GioiTinh = "Nam";
            }
            else 
            {
                kh.GioiTinh = "Nữ";
            }
            kh.Ghichu = tbGhichu.Text;
            if (qlkhBLL.InsertKH(kh))
            {
                MessageBox.Show("thêm thành công!");
            }
            else
            {
                MessageBox.Show("thêm thất bại!");
            }
            loadData();
            Clear();

        }
    }
}
