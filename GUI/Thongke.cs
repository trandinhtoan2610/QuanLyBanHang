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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class Thongke : UserControl
    {
        DataTable combinedDataTable;
        BindingSource list = new BindingSource();
        thongkeBLL thongkeBLL = new thongkeBLL();
        List<ThongKeDTO> listSPBTT;
        public Thongke()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            dataGridView1.DataSource = list;
            
            loadData();
        }
        public void loadData()
        {
             
            list.DataSource = combinedDataTable;

        }
        public DataTable tableSanPhamBanRaTrongThang(string thang, string nam)
        {
            combinedDataTable = new DataTable();
            combinedDataTable.Columns.Add("ID", typeof(int));
            combinedDataTable.Columns.Add("Tên", typeof(string));
            combinedDataTable.Columns.Add("ID loai sản phẩm", typeof(string));
            combinedDataTable.Columns.Add("Hãng sản xuất", typeof(string));
            combinedDataTable.Columns.Add("Giá", typeof(int));
            combinedDataTable.Columns.Add("Đơn vị tính", typeof(string));
            combinedDataTable.Columns.Add("Số lượng", typeof(int));
            List<SanPhamDTO> listSanPham = thongkeBLL.listSanPhamBTT(thang, nam);
            List<ChiTietHoaDonBanDTO> listChiTietHD = thongkeBLL.listcount(thang, nam);
            foreach (SanPhamDTO sp in listSanPham)
            {
                combinedDataTable.Rows.Add(sp.Id, sp.Tensanpham,sp.IdLoaiSanPham, sp.Hangsanxuat, sp.Gia, sp.Donvitinh, 0);
            }
            int index = 0;
            foreach (ChiTietHoaDonBanDTO cthd in listChiTietHD)
            {
                if (index < combinedDataTable.Rows.Count)
                {
                    combinedDataTable.Rows[index]["Số lượng"] = cthd.Count;
                    index++;
                }
            }

            return combinedDataTable;
        }
        public DataTable tableHangTonKho()
        {
            combinedDataTable = new DataTable();
            combinedDataTable.Columns.Add("ID", typeof(int));
            combinedDataTable.Columns.Add("Tên", typeof(string));
            combinedDataTable.Columns.Add("ID loai sản phẩm", typeof(string));
            combinedDataTable.Columns.Add("Hãng sản xuất", typeof(string));
            combinedDataTable.Columns.Add("Giá", typeof(int));
            combinedDataTable.Columns.Add("Đơn vị tính", typeof(string));
            combinedDataTable.Columns.Add("Số lượng", typeof(int));
            List<SanPhamDTO> listSanPham = thongkeBLL.listHangTonKho();
            
            foreach (SanPhamDTO sp in listSanPham)
            {
                combinedDataTable.Rows.Add(sp.Id, sp.Tensanpham, sp.IdLoaiSanPham, sp.Hangsanxuat, sp.Gia, sp.Donvitinh , sp.Soluong);
            }
            

            return combinedDataTable;
        }
        public DataTable tableNVBHTT(string thang, string nam)
        {

            combinedDataTable = new DataTable();
            combinedDataTable.Columns.Add("ID", typeof(int));
            combinedDataTable.Columns.Add("Tên", typeof(string));
            combinedDataTable.Columns.Add("Ngày sinh", typeof(string));
            combinedDataTable.Columns.Add("id loại nhân viên", typeof(int));
            combinedDataTable.Columns.Add("Số điện thoại", typeof(string));
            combinedDataTable.Columns.Add("email", typeof(string));
            combinedDataTable.Columns.Add("Tổng tiền bán được", typeof(double));
            List<NhanVienDTO> listNV = thongkeBLL.listNVBHTT(thang, nam);
            
            foreach (NhanVienDTO nv in listNV)
            {
                combinedDataTable.Rows.Add(nv.Id, nv.Tennhanvien, nv.Ngaysinh, nv.IdLoainhanvien, nv.Sodienthoai, nv.Email, 0);
            }
            int index = 0;

            for (int i = 0; i <= thongkeBLL.listTienNVBHTT(thang, nam).Length; i++)
            {
                if (index < combinedDataTable.Rows.Count)
                {
                    combinedDataTable.Rows[index]["Tổng tiền bán được"] = thongkeBLL.listTienNVBHTT(thang, nam)[i];
                    index++;
                }
            }

            return combinedDataTable;
        }
        public DataTable tableSanPhamNhap(string thang, string nam)
        {

            combinedDataTable = new DataTable();
            combinedDataTable.Columns.Add("ID", typeof(int));
            combinedDataTable.Columns.Add("Tên", typeof(string));
            combinedDataTable.Columns.Add("id loại sản phẩm", typeof(int));
            combinedDataTable.Columns.Add("Giá", typeof(int));
            combinedDataTable.Columns.Add("Đơn vị tính", typeof(string));
            combinedDataTable.Columns.Add("Số lượng", typeof(int));
            combinedDataTable.Columns.Add("Thành Tiền", typeof(double));
            List<SanPhamDTO> listNhap = thongkeBLL.listSanPhamNhapHangTT(thang, nam);
            List<CTHDNhapDTO> soluongvathanhtien = thongkeBLL.soluongvathanhtien(thang, nam);
            foreach (SanPhamDTO sp in listNhap)
            {
                combinedDataTable.Rows.Add(sp.Id, sp.Tensanpham, sp.IdLoaiSanPham, sp.Gia , sp.Donvitinh, 0, 0);
            }
            int index = 0;

            foreach (CTHDNhapDTO cthd in soluongvathanhtien)
            {
                if (index < combinedDataTable.Rows.Count)
                {
                    combinedDataTable.Rows[index]["Số lượng"] = cthd.count;
                    combinedDataTable.Rows[index]["Thành tiền"] = cthd.thanhtien;
                    index++;
                }
            }

            return combinedDataTable;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            string thang = cbbThang.Text;
            int viTri = thang.IndexOf(' ');

            string nam = cbbNam.Text;
            string[] chuoicon = thang.Split(' ');
            string thangSo = chuoicon[1];
            if (rdbt4.Checked)
            {
                
                combinedDataTable = tableSanPhamBanRaTrongThang(thangSo, nam);
                if(combinedDataTable.Rows.Count > 0)
                {
                    list.DataSource = combinedDataTable;
                    dataGridView1.DataSource = list;
                    loadData();
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm nào được bán trong khoảng thời gian này");
                }
                
            }
            else if(rdbt1.Checked)
            {
                textBox1.Text = thongkeBLL.ThongKeTienNhapHang(thangSo, nam).ToString();
            }
            else if (rdbt2.Checked)
            {
                textBox1.Text = thongkeBLL.ThongKeDoangThuTrongThang(thangSo, nam).ToString();
            }
            else if (rdbt3.Checked)
            {
                combinedDataTable = tableNVBHTT(thangSo, nam);
                if (combinedDataTable.Rows.Count > 0)
                {
                    list.DataSource = combinedDataTable;
                    dataGridView1.DataSource = list;
                    loadData();
                }
                else
                {
                    MessageBox.Show("Không có nhân viên nào bán được hàng trong tháng");
                }
            }
            else if (rdbt5.Checked)
            {
                combinedDataTable = tableSanPhamNhap(thangSo, nam);
                if (combinedDataTable.Rows.Count > 0)
                {
                    list.DataSource = combinedDataTable;
                    dataGridView1.DataSource = list;
                    loadData();
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm được nhập trong tháng");
                }
            }
            else if (rdbt6.Checked)
            {
                combinedDataTable = tableHangTonKho();
                if (combinedDataTable.Rows.Count > 0)
                {
                    list.DataSource = combinedDataTable;
                    dataGridView1.DataSource = list;
                    loadData();
                }
                else
                {
                    MessageBox.Show("Không có hàng tồn kho");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục cần xem");
            }
            
        }

        
    }
}
