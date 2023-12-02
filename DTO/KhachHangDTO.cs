using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public int Id {  get; set; }
        public string TenKhachHang {  get; set; }
        public string SoDienThoai {  get; set; }
        public string GioiTinh {  get; set; }
        public string Ghichu {  get; set; }
        public KhachHangDTO() { }
        public KhachHangDTO(int id, string tenKhachHang, string sodienthoai, string gioitinh, string ghichu)
        {
            this.Id = id;
            this.TenKhachHang = tenKhachHang;
            this.SoDienThoai = sodienthoai;
            this.GioiTinh = gioitinh;
            this.Ghichu = ghichu;
        }    
    }

}
