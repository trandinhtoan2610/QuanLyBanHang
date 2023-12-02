using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            loadData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
