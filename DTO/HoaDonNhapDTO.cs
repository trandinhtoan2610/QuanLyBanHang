using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonNhapDTO
    {
        public int id { get; set; }
        public DateTime ngaylap { get; set; }
        public int idNhanvien { get; set; }
        public int idNhacungcap { get; set; }
        public int status { get; set; }
    }
}
