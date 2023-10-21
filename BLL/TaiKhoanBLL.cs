using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaikhoanDAL tk = new TaikhoanDAL();
        public string CheckLogin(TaiKhoanDTO taiKhoan)
        {
            if(taiKhoan.UserName == "")
            {
                return "requeid_taikhoan";
            }

            if(taiKhoan.Password == "")
            {
                return "requeid_matkhau";
            }
            string info = tk.CheckLogin(taiKhoan);
            return info;
        }
    }
}
