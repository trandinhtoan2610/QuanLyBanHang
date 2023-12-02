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
            loadData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            loadData();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            dgv_hoadon.SelectAll();
            DataObject copydata = dgv_hoadon.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }*/
    }
}
