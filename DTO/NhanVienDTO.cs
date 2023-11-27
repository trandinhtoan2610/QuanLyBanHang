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
        public NhanVienDTO() { }
        public NhanVienDTO(int id, string tennhanvien, string ngaysinh, int IdLoainhanvien, string sodienthoai, string cmnd, string email, string gioitinh, string diachi)
        {
            this.Id = id;
            this.Tennhanvien = tennhanvien;
            this.Ngaysinh = ngaysinh;
            this.IdLoainhanvien = IdLoainhanvien;
            this.Sodienthoai = sodienthoai;
            this.Cmnd = cmnd;
            this.Email = email;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;   
            
        }

    }
}
