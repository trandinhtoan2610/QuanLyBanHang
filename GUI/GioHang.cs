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
            load();
        }

        public void GetDuLieu()
        {
            
        }

        void load()
        {
            
        }



        public  void  dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // Lấy giá trị từ các cột mong muốn và hiển thị lên các TextBox tương ứng
                tbId.Text = selectedRow.Cells["id"].Value.ToString();
                tbtensanpham.Text = selectedRow.Cells["tensanpham"].Value.ToString();
                tbidloaisanpham.Text = selectedRow.Cells["idloaisanpham"].Value.ToString();
                tbtenloai.Text = selectedRow.Cells["Tenloai"].Value.ToString();
                tbhangsanxuat.Text = selectedRow.Cells["hangsanxuat"].Value.ToString();
                tbsoluong.Text = selectedRow.Cells["Soluong"].Value.ToString();
                tbgia.Text = selectedRow.Cells["gia"].Value.ToString();
                tbdonvitinh.Text = selectedRow.Cells["donvitinh"].Value.ToString();
                tbkhuyenmai.Text = selectedRow.Cells["Khuyenmai"].Value.ToString();

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
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
        }

        private void btnadd_Click_1(object sender, EventArgs e)
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
                        //ví dụ ban đầu có sl=5 chỉnh lại sl=3 -> quantityCart= 5-3= 2 ngược lại quantityCart= 3-5= -2
                        quantityCart = quantityOld - quantityNew;
                        item.Soluong = quantityNew;
                        break;
                    }
                }
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = Banhang.listCart;
                int sumMoney = 0;
                foreach (var item in Banhang.listCart)
                {
                    sumMoney += item.Gia * item.Soluong;
                }
                label11.Text = sumMoney + "đ";
                foreach (var item in Banhang.listCart)
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



        /*public ChiTietHoaDonBanDTO GetData()
        {
            //return 
        }*/
    }
}
