using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiNhanVienDTO
    {
        public int ID {  get; set; }
        public string Tenloai {  get; set; }
        public LoaiNhanVienDTO() { }
        public LoaiNhanVienDTO (int id, string tenloai) {
            ID = id;
            Tenloai = tenloai;
        }
    }
}
