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
        public static NhanVienDTO user = new NhanVienDTO();
        TaikhoanDAL tk = new TaikhoanDAL();
        public string CheckLogin(string sodienthoai, string matkhau)
        {
            if(sodienthoai == "")
            {
                return "requeid_taikhoan";
            }

            if(matkhau == "")
            {
                return "requeid_matkhau";
            }
            NhanVienDTO info = tk.CheckLogin( sodienthoai, matkhau);
            if (info != null)
            {
                user = info;
                return "login success";
            }
            return "sai tai khoan mat khau";
        }
    }
}
