using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Banhang : UserControl
    {
        public event EventHandler DiDenGioHang;
        
        SanPhamBLL lspbll = new SanPhamBLL();
        List<SanPhamDTO> lsp = new List<SanPhamDTO>();
        int rowram = -1;
        public static List<SanPhamDTO> listCart = new List<SanPhamDTO>();
        public static List<SanPhamDTO> listProduct = new List<SanPhamDTO>();


        public Banhang()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            loadData(); 
        }

        void loadData()
        {
            listProduct = lspbll.GetSanphamkho();
            dataGridView1.DataSource = listProduct;
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            DiDenGioHang?.Invoke(this, EventArgs.Empty);
            int sumMoney = 0;
            foreach (var item in listCart)
            {
                sumMoney += item.Gia * item.Soluong;
            }
            GioHang.label12.Text = sumMoney + "đ";
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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra chỉ mục ô có hợp lệ
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells[5].Value.ToString() == "0")
                {
                    MessageBox.Show("Sản phẩm đã hết!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Sử dụng row để truy cập các giá trị của hàng theo nhu cầu của bạn
                // Ví dụ: string cellValue = row.Cells["TênCột"].Value.ToString();

                tbId.Text = row.Cells[0].Value.ToString();
                tbtensanpham.Text = row.Cells[1].Value.ToString();
                tbidloaisanpham.Text = row.Cells[2].Value.ToString();
                tbtenloai.Text = row.Cells[3].Value.ToString();
                tbhangsanxuat.Text = row.Cells[4].Value.ToString();
                tbgia.Text = row.Cells[5].Value.ToString();
                tbsoluong.Text = "1";
                tbdonvitinh.Text = row.Cells[7].Value.ToString();
                tbkhuyenmai.Text = row.Cells[8].Value.ToString();
            }
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
            if (tbId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thêm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
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
            bool isExist = false;
            foreach (var item in listCart)
             {
                    if (item.Id == spDTO.Id)
                    {
                        isExist = true;
                        item.Soluong = item.Soluong + spDTO.Soluong;
                        break;
                    }
             }
             if (!isExist)
             {
                 listCart.Add(spDTO);
             }

                foreach (var item in listProduct)
                {
                if (item.Id == spDTO.Id)
                  {
                    item.Soluong = item.Soluong - spDTO.Soluong;
                    break;
                }
             }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listProduct;
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
