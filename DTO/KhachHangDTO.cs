using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public int id {  get; set; }
        public string TenKhachHang {  get; set; }
        public int SoDienThoai {  get; set; }
        public string GioiTinh {  get; set; }
        public string ghichu {  get; set; }
        public KhachHangDTO() { }
        public KhachHangDTO(int id, string TenKhachHang, int SoDienThoai, string gioitinh, string ghichu)
        {
            this.id = id;
            this.TenKhachHang = TenKhachHang;
            this.SoDienThoai = SoDienThoai;
            this.GioiTinh = GioiTinh;
            this.ghichu = ghichu;
        }    
    }

}
