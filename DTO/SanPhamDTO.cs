using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public int id;
        public string tensanpham;
        public int idLoaiSanPham;
        public string hangsanxuat;
        public int gia;
        public int soluong;
        public string donvitinh;
        public SanPhamDTO() { }
        public SanPhamDTO(string tensanpham, int idLoaiSanPham, string hangsanxuat, int gia, int soluong, string donvitinh) 
        {
            this.tensanpham = tensanpham;
            this.idLoaiSanPham  = idLoaiSanPham;  
            this.hangsanxuat = hangsanxuat;
            this.gia = gia;
            this.soluong = soluong;
            this.donvitinh  = donvitinh;
        }
        public int Id { get; set; }
        public string Tensanpham { get; set; }
        public int IdLoaiSanPham { get; set; }
        public string Hangsanxuat { get; set; }
        public int Gia { get; set; }
        public int Soluong { get; set; }
        public String Donvitinh { get; set; }
    }
}
