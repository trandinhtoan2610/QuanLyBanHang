using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPhamDTO
    {
        public int Id { get; set; }
        public string TenLoai { get; set; }
        public LoaiSanPhamDTO() { }
        public LoaiSanPhamDTO(int id, string tenloai)
        {
            Id = id;
            TenLoai = tenloai;
        }
    }
}