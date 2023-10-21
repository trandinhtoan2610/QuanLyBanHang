using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TaikhoanDAL:DatabaseAccess
    {
        public string CheckLogin(TaiKhoanDTO taikhoan)
        {
            string info = CheckLoginDTO(taikhoan);
            return info;
        }
    }
}
