using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeDTO
    {
        public SanPhamDTO SanPham { get; set; }
        public ChiTietHoaDonBanDTO cthdbh {  get; set; }
        public ThongKeDTO(SanPhamDTO sp) { 
            SanPham = sp;
        }
        public ThongKeDTO(ChiTietHoaDonBanDTO cthdbh) { 
            this.cthdbh = cthdbh;
        }
    }
}
