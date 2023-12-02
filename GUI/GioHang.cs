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
            qlhdbll.InsertHDB(1, ngayHomNay, KhachHangBLL.khachdto.Id , TaiKhoanBLL.user.Id, 0);
            
            
            qlcthdb.InsertCTHDB(1, qlhdbll.GetIdHDB(KhachHangBLL.khachdto.Id), 1, 10000, 1);
        }



        /*public ChiTietHoaDonBanDTO GetData()
        {
            //return 
        }*/
    }
}
