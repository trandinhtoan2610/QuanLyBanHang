using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    
    public class thongkeBLL
    {
        ThongKeDAL tkd = new ThongKeDAL();
        public List<SanPhamDTO> listSanPhamBTT(string thang, string nam)
        {
            
            return tkd.listSanPhamBTT(thang,nam);
        }
        public List<ChiTietHoaDonBanDTO> listcount(string thang, string nam)
        {

            return tkd.listCount(thang,nam);
        }
        public double ThongKeTienNhapHang(string thang, string nam)
        {
            return tkd.ThongKeTienNhapHang(thang,nam);
        }
        public double ThongKeDoangThuTrongThang(string thang, string nam)
        {
            return tkd.ThongKeDoanhThuTrongThang(thang, nam);
        }
        public List<NhanVienDTO> listNVBHTT(string thang, string nam)
        {
            return tkd.listNVBHTT(thang,nam);
        }
        public double[] listTienNVBHTT(string thang, string nam)
        {
            return tkd.listTienNV(thang,nam);
        }
        public List<SanPhamDTO> listSanPhamNhapHangTT(string thang, string nam)
        {
            return tkd.listSanPhamNhapHangTT(thang,nam);

        }
        public List<CTHDNhapDTO> soluongvathanhtien(string thang, string nam)
        {
            return tkd.soluongvathanhtien(thang,nam);
        }
        public List<SanPhamDTO> listHangTonKho()
        {
            return tkd.listHangTonKho();
        }

    }
}
