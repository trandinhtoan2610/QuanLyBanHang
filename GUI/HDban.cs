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
    public partial class HDban : UserControl
    {
        HoaDonBLL qlhdBLL = new HoaDonBLL();
        HoaDonDTO hd = new HoaDonDTO();
        List<HoaDonDTO> dshd, found;

        ChiTietHoaDonBanBLL qlcthdBLL = new ChiTietHoaDonBanBLL();
        List<ChiTietHoaDonBanDTO> dscthd;
        public HDban()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            loadDataHoaDon();
        }
        public void loadDataHoaDon()
        {
            dshd = qlhdBLL.readDB();
            dtaGVdanhsachHD.DataSource = dshd;
            addHoaDon();
            dtaGVdanhsachHD.Columns["IdKhachhang"].Visible = false;
            dtaGVdanhsachHD.Columns["IdNhanvien"].Visible = false;
            dtaGVdanhsachHD.Columns["Id"].HeaderText = "ID";
            dtaGVdanhsachHD.Columns["Ngaylap"].HeaderText = "Ngày lập";
            dtaGVdanhsachHD.Columns["Tenkhachhang"].HeaderText = "Tên khách hàng";
            dtaGVdanhsachHD.Columns["Tennhanvien"].HeaderText = "Tên nhân viên";
            dtaGVdanhsachHD.Columns["status"].HeaderText = "Tổng tiền";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dscthd = qlcthdBLL.ShowBill(Convert.ToInt32(tbMaHD.Text));
            dtaGVdanhsachchitiet.DataSource = dscthd;
            loadHeaderText();
            dtaGVdanhsachchitiet.Columns["id"].Visible = false;
            dtaGVdanhsachchitiet.Columns["idhoadonban"].Visible = false;
            dtaGVdanhsachchitiet.Columns["idsanpham"].Visible = false;
        }

        public void loadHeaderText()
        {
            dtaGVdanhsachchitiet.Columns["tensanpham"].HeaderText = "Tên sản phẩm";
            dtaGVdanhsachchitiet.Columns["thanhtien"].HeaderText = "Thành tiền";
            dtaGVdanhsachchitiet.Columns["count"].HeaderText = "số lượng";

            
        }
        public void addHoaDon()
        {
            tbMaHD.DataBindings.Clear();
            tbTenNV.DataBindings.Clear();
            tbHoten.DataBindings.Clear();
            tbTongtien.DataBindings.Clear();
            tbMaHD.DataBindings.Add(new Binding("Text", dtaGVdanhsachHD.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbTenNV.DataBindings.Add(new Binding("Text", dtaGVdanhsachHD.DataSource, "tennhanvien", true, DataSourceUpdateMode.Never));
            tbHoten.DataBindings.Add(new Binding("Text", dtaGVdanhsachHD.DataSource, "tenkhachhang", true, DataSourceUpdateMode.Never));
            tbTongtien.DataBindings.Add(new Binding("Text", dtaGVdanhsachHD.DataSource, "status", true, DataSourceUpdateMode.Never));
        }
    }
}
