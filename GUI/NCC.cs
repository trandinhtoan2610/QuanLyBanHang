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
        public void loadData()
        {
            listNCC = qlNCCBLL.readDB();
            ncclist.DataSource = listNCC;
        }

        public void loadHeaderText()
        {
            dtaGVNCC.Columns["id"].HeaderText = "ID";
            dtaGVNCC.Columns["tennhacungcap"].HeaderText = "Tên nhà cung cấp";
            dtaGVNCC.Columns["sodienthoai"].HeaderText = "Số điện thoại";
            dtaGVNCC.Columns["diachi"].HeaderText = "Địa chỉ";
            dtaGVNCC.Columns["email"].HeaderText = "Email";

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
        


    }
}