using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {

        public int Id { get; set; }
        public string Tennhanvien { get; set; }

        public string Ngaysinh { get; set; }
        public int IdLoainhanvien { get; set; }
        public string Sodienthoai { get; set; }
        public string Cmnd { get; set; }
        public string Email { get; set; }
        public string Gioitinh { get; set; }
        public string Diachi { get; set; }

        public string Matkhau { get; set; }
        public NhanVienDTO() { }
        public NhanVienDTO(int id, string tennhanvien, string ngaysinh, int IdLoainhanvien, string sodienthoai, string cmnd, string email, string gioitinh, string diachi, string matkhau)
        {
            Id = id;
            Tennhanvien = tennhanvien;
            Ngaysinh = ngaysinh;
            this.IdLoainhanvien = IdLoainhanvien;
            Sodienthoai = sodienthoai;
            Cmnd = cmnd;
            Email = email;
            Gioitinh = gioitinh;
            Diachi = diachi;
            Matkhau = matkhau;
        }

    }
}
