using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NCCDTO
    {
        public int Id { get; set; }
        public string Tennhacungcap { get; set; }
        public string Sodienthoai { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }


        public NCCDTO() { }

        public NCCDTO(int id, string tenNCC, string sodienthoai, string diachi, string email)
        {
            Id = id;
            Tennhacungcap = tenNCC;
            Sodienthoai = sodienthoai;
            Diachi = diachi;
            Email = email;

        }
    }
}