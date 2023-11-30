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
        public bool InsertNV(int id, string tennhanvien, string ngaysinh, int IdLoainhanvien, string sodienthoai, string cmnd, string email, string gioitinh, string diachi, string matkhau)
        {
            nv = new NhanVienDTO(id, tennhanvien, ngaysinh, IdLoainhanvien, sodienthoai, cmnd, email, gioitinh, diachi, matkhau);
            return InsertNV(nv);
        }

        public bool UpdateNV(int id, string tennhanvien, string ngaysinh, int IdLoainhanvien, string sodienthoai, string cmnd, string email, string gioitinh, string diachi, string matkhau)
        {
            dsnv = readDB();

            foreach (NhanVienDTO nv in dsnv)
            {
                if (nv.Id.Equals(id))
                {
                    nv.Id = id;
                    nv.Tennhanvien = tennhanvien;
                    nv.Ngaysinh = ngaysinh;
                    nv.IdLoainhanvien = IdLoainhanvien;
                    nv.Sodienthoai = sodienthoai;
                    nv.Cmnd = cmnd;
                    nv.Email = email;
                    nv.Gioitinh = gioitinh;
                    nv.Diachi = diachi;
                    nv.Matkhau = matkhau;
                }
            }
            return qlnvDAL.UpdateNV(id, tennhanvien, ngaysinh, IdLoainhanvien, sodienthoai, cmnd, email, gioitinh, diachi,matkhau);
        }

        public bool DeleteNV(int id)
        {
            dsnv = readDB();

            foreach (NhanVienDTO nv in dsnv)
            {
                if (nv.Id.Equals(id))
                {
                    nv.Id = id;
                }
            }
            return qlnvDAL.DeleteNV(id);
        }

    }
}
