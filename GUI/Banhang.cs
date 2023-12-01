using BLL;
using DTO;
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
    public partial class Banhang : UserControl
    {
        public event EventHandler DiDenGioHang;

        BindingSource splist = new BindingSource();
        SanPhamBLL lspbll = new SanPhamBLL();
        List<SanPhamDTO> lsp = new List<SanPhamDTO>();
        int rowram = -1;
        public static List<SanPhamDTO> listCart = new List<SanPhamDTO>();

        
        public Banhang()
        {
            InitializeComponent();
            load();
        }

        void load()
        {

            dataGridView1.DataSource = splist;
            loadData();
            addSanPhamBinding();
        }

        void loadData()
        {
            lsp = lspbll.GetSanphamkho();
            dataGridView1.DataSource = lsp;
        }
       

        public void addSanPhamBinding()
        {
            tbId.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbtensanpham.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "tensanpham", true, DataSourceUpdateMode.Never));
            tbidloaisanpham.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "idloaisanpham", true, DataSourceUpdateMode.Never));
            tbtenloai.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tenloai", true, DataSourceUpdateMode.Never));
            tbhangsanxuat.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "hangsanxuat", true, DataSourceUpdateMode.Never));
            tbsoluong.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Soluong", true, DataSourceUpdateMode.Never));
            tbgia.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "gia", true, DataSourceUpdateMode.Never));
            tbdonvitinh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "donvitinh", true, DataSourceUpdateMode.Never));
            tbkhuyenmai.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Khuyenmai", true, DataSourceUpdateMode.Never));
        }
        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            // Kiểm tra xem sự kiện xảy ra trong cột ComboBox
            if (e.ColumnIndex == dataGridView1.Columns["cbTensanpham"].Index)
            {
                DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells["cbTensanpham"];
                string id = comboBoxCell.Value.ToString();
                foreach (SanPhamDTO sp in lsp)
                {
                    if (sp.Id.ToString() == id)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = sp.Gia;
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = sp.Khuyenmai;
                    }
                }  
            }
            if(e.ColumnIndex == dataGridView1.Columns["tbSoluong"].Index)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells["tbSoluong"];
                    string soluong = cell.Value.ToString();
                    string gia  = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() ;
                    string khuyenmai = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() ;
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value = soluong;
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value = (Convert.ToDouble(soluong) * Convert.ToDouble(gia)) - ((Convert.ToDouble(soluong) * Convert.ToDouble(gia))* (Convert.ToDouble(khuyenmai)/100));
                }
            }

            //List<SanPhamDTO> list = new List<SanPhamDTO>();
            //SanPhamDTO spDTO = new SanPhamDTO();
            rowram = SelectRowInDataGridView(dataGridView1, e.RowIndex);

            

        }

        private int SelectRowInDataGridView(DataGridView dataGridView, int rowIndex)
        {
            // Kiểm tra xem chỉ số hàng hợp lệ
            if (rowIndex >= 0 && rowIndex < dataGridView.Rows.Count)
            {
                // Lấy đối tượng DataGridViewRow của hàng cần chọn
                DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];

                // Đặt thuộc tính Selected của đối tượng DataGridViewRow thành true
                selectedRow.Selected = true;
                return rowIndex;
            }
            return -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rowram != -1)
            {
                dataGridView1.Rows.RemoveAt(rowram);
                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiDenGioHang?.Invoke(this, EventArgs.Empty);
            GioHang.dataGridView2.DataSource = null;
            GioHang.dataGridView2.DataSource = listCart;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtenloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbtensanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbhangsanxuat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbdonvitinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbidloaisanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbkhuyenmai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            //click thêm vào giỏ hàng
            SanPhamDTO spDTO = new SanPhamDTO();
            spDTO.Id = Convert.ToInt32(tbId.Text);
            spDTO.Tensanpham= tbtensanpham.Text;
            spDTO.Donvitinh= tbdonvitinh.Text;
            spDTO.Gia = Convert.ToInt32(tbgia.Text);
            spDTO.Soluong = Convert.ToInt32(tbsoluong.Text);
            spDTO.Hangsanxuat= tbhangsanxuat.Text;
            spDTO.Khuyenmai = Convert.ToInt32(tbkhuyenmai.Text);
            spDTO.IdLoaiSanPham = Convert.ToInt32(tbidloaisanpham.Text);
            spDTO.Tenloai = tbtenloai.Text;
            listCart.Add(spDTO);
            tbId.Text = "";
            tbtensanpham.Text = "";
            tbdonvitinh.Text = "";
            tbgia.Text = "";
            tbsoluong.Text = "";
            tbhangsanxuat.Text = "";
            tbkhuyenmai.Text = "";
            tbidloaisanpham.Text = "";
            tbtenloai.Text = "";
        }

        private void lbQuanly_Click(object sender, EventArgs e)
        {

        }

        private void Banhang_Load(object sender, EventArgs e)
        {

        }
    }
}
