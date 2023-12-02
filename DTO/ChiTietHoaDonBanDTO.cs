using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonBanDTO
    {
        public int Id { get; set; }
        public int IdHoadonban { get; set; }
        public int IdSanpham {  get; set; }
        public int Thanhtien { get; set; }
        public int Count { get; set; }

        public ChiTietHoaDonBanDTO() { }

        public ChiTietHoaDonBanDTO(int id , int idhoadonban, int idsanpham, int thanhtien, int count)
        {
            Id = id;
            IdHoadonban = idhoadonban;
            IdSanpham = idsanpham;
            Count = count;
            Thanhtien = thanhtien;
        }
    }
}
