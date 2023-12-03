using BLL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class GioHang : UserControl
    {
        HoaDonBLL qlhdbll = new HoaDonBLL();
        HoaDonDTO hd = new HoaDonDTO();

        List<ChiTietHoaDonBanDTO> cthdb;
        ChiTietHoaDonBanBLL qlcthdb = new ChiTietHoaDonBanBLL();
        public GioHang()
        {
            InitializeComponent();
            
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            DateTime ngayHomNay = DateTime.Now;
            int idhoadon = qlhdbll.InsertHDB(1, ngayHomNay, KhachHangBLL.khachdto.Id , TaiKhoanBLL.user.Id, 0);
            if(idhoadon == -1 ) 
            {
                MessageBox.Show("Lỗi");
                return;
            }
            foreach (var item in Banhang.listCart)
            {
                qlcthdb.InsertCTHDB(1, idhoadon, item.Id, item.Gia, item.Soluong);
                MessageBox.Show(item.Id + " ");
            }
            Banhang.listCart.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Banhang.listCart;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbId.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //click thêm thay đổi số lượng giỏ hàng
                SanPhamDTO spDTO = new SanPhamDTO();
                spDTO.Id = Convert.ToInt32(tbId.Text);
                spDTO.Tensanpham = tbtensanpham.Text;
                spDTO.Donvitinh = tbdonvitinh.Text;
                spDTO.Gia = Convert.ToInt32(tbgia.Text);
                spDTO.Soluong = Convert.ToInt32(tbsoluong.Text);
                spDTO.Hangsanxuat = tbhangsanxuat.Text;
                spDTO.Khuyenmai = Convert.ToInt32(tbkhuyenmai.Text);
                spDTO.IdLoaiSanPham = Convert.ToInt32(tbidloaisanpham.Text);
                spDTO.Tenloai = tbtenloai.Text;

                int quantityCart = 0;
                int quantityNew = spDTO.Soluong;
                foreach (var item in Banhang.listCart)
                {
                    if (item.Id == spDTO.Id)
                    {
                        int quantityOld = item.Soluong;
                        quantityCart = quantityOld;
                        break;
                    }
                }
                Banhang.listCart.RemoveAll(item => item.Id == spDTO.Id);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Nhaphang.listCart;
                int sumMoney = 0;
                foreach (var item in Banhang.listCart)
                {
                    sumMoney += item.Gia * item.Soluong;
                }
                label12.Text = sumMoney + "đ";
                foreach (var item in Banhang.listProduct)
                {
                    if (item.Id == spDTO.Id)
                    {
                        item.Soluong = item.Soluong + quantityCart;
                        break;
                    }
                }
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
            catch (Exception ex)
            {
                MessageBox.Show("Sai định dạng số lượng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra chỉ mục ô có hợp lệ
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                // Sử dụng row để truy cập các giá trị của hàng theo nhu cầu của bạn
                // Ví dụ: string cellValue = row.Cells["TênCột"].Value.ToString();

                tbId.Text = row.Cells[0].Value.ToString();
                tbtensanpham.Text = row.Cells[1].Value.ToString();
                tbidloaisanpham.Text = row.Cells[2].Value.ToString();
                tbtenloai.Text = row.Cells[3].Value.ToString();
                tbhangsanxuat.Text = row.Cells[4].Value.ToString();
                tbgia.Text = row.Cells[5].Value.ToString();
                tbsoluong.Text = row.Cells[6].Value.ToString();
                tbdonvitinh.Text = row.Cells[7].Value.ToString();
                tbkhuyenmai.Text = row.Cells[8].Value.ToString();

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }
    }
}
