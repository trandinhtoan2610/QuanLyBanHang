using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanHangDTO
    {
        public int Id {  get; set; }
        public string MaHD { get; set; }
        public string Tennhanvien {  get; set; }
        public string Tenkhachhang { get; set; }
        public string Ngaylap {  get; set; }
        public decimal Tongtien { get; set; }
        public string Tensanpham {  get; set; }
        public int Soluong {  get; set; }
        public decimal Gia {  get; set; }
        public decimal Thanhtien { get; set; }
        public int Khuyenmai { get; set; }

        public BanHangDTO() { }

        public BanHangDTO(int id, string maHD, string tennhanvien, string tenkhachhang, string ngaylap, decimal tongtien, string tensanpham, int soluong, decimal gia, decimal thanhtien, int khuyenmai)
        {
            Id = id;
            MaHD = maHD;
            Tennhanvien = tennhanvien;
            Tenkhachhang = tenkhachhang;
            Ngaylap = ngaylap;
            Tongtien = tongtien;
            Tensanpham = tensanpham;
            Soluong = soluong;
            Gia = gia;
            Thanhtien = thanhtien;
            Khuyenmai = khuyenmai;
        }
    }
}
