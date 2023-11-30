using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public int Id { get; set; }
        public DateTime Ngaylap { get; set; }
        public int IdKhachhang { get; set; }
        public string Tenkhachhang { get; set; }
        public int IdNhanvien { get; set; }
        public string Tennhanvien { get; set; }
        public int Status { get; set; }
        public HoaDonDTO() { }
        public HoaDonDTO(int id, DateTime ngaylap, int idKhachhang, int idNhanvien, int status)
        {
            Id = id;
            Ngaylap = ngaylap;
            IdKhachhang = idKhachhang;
            IdNhanvien = idNhanvien;
            Status = status;
        }
    }
}
