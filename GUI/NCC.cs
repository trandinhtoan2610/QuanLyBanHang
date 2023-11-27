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
            loadData();
            addNCCBinding();
        }
        public void loadData()
        {
           
            dtaGVNCC.DataSource = ncclist;
            listNCC = qlNCCBLL.readDB();
            ncclist.DataSource = listNCC; 

        }

        public void addNCCBinding()
        {
            tbMaNCC.DataBindings.Add(new Binding("Text", dtaGVNCC.DataSource, "id"));
            tbTenNCC.DataBindings.Add(new Binding("Text", dtaGVNCC.DataSource, "tennhacungcap"));
            tbSđt.DataBindings.Add(new Binding("Text", dtaGVNCC.DataSource, "sodienthoai"));
            tbDiachi.DataBindings.Add(new Binding("Text", dtaGVNCC.DataSource, "diachi"));
            tbEmail.DataBindings.Add(new Binding("Text", dtaGVNCC.DataSource, "email"));
        }

        public void Clear()
        {
            tbMaNCC.Text = tbTenNCC.Text = tbSđt.Text = tbDiachi.Text = tbEmail.Text  = string.Empty;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            dtaGVNCC.SelectAll();
            DataObject copydata = dtaGVNCC.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;

            xlWbook = xlapp.Workbooks.Add(miseddata);
            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);

            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1,1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
