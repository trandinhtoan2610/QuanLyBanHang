using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDTO nv;
        private List<NhanVienDTO> dsnv;
        NhanVienDAL qlnvDAL = new NhanVienDAL();

        public List<NhanVienDTO> readDB()
        {
            return qlnvDAL.readDB();
        }

 
        public bool InsertNV(NhanVienDTO nhanvien)
        {
            dsnv = readDB();
            dsnv.Add(nhanvien);
            return qlnvDAL.InsertNV(nhanvien);
        }
        public bool InsertNV(int id, string tennhanvien, string ngaysinh, int IdLoainhanvien, string sodienthoai, string cmnd, string email, string gioitinh, string diachi)
        {
            nv = new NhanVienDTO(id, tennhanvien, ngaysinh, IdLoainhanvien, sodienthoai, cmnd, email, gioitinh, diachi);
            return InsertNV(nv);
        }

    }
}
