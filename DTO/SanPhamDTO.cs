using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        
        public int Id { get; set; }
        public string Tensanpham { get; set; }
        public int IdLoaiSanPham { get; set; }
        public string Tenloai { get; set; }
        public string Hangsanxuat { get; set; }
        public int Gia { get; set; }
        public int Soluong { get; set; }
        public string Donvitinh { get; set; }
        public SanPhamDTO() { }
        public SanPhamDTO(int id,string tensanpham, int idLoaiSanPham, string hangsanxuat, int gia, int soluong, string donvitinh) 
        {   
            Id = id;
            Tensanpham = tensanpham;
            IdLoaiSanPham = idLoaiSanPham;    
            Hangsanxuat = hangsanxuat;
            Gia = gia;
            Soluong = soluong;
            Donvitinh = donvitinh;
        }
        
    }
}
