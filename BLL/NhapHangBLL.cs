using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhapHangBLL
    {
        NhapHangDAL nhDAL= new NhapHangDAL();
        public List<SanPhamDTO> getAllProduct(int nhaCungCapId, string txt_search)
        {
            return nhDAL.getAllProduct(nhaCungCapId, txt_search);
        }
        public List<NCCDTO> getAllNhaCungCap()
        {
            return nhDAL.getAllNhaCungCap();
        }
        public Boolean InsertSP(List<SanPhamDTO> listsp, NhanVienDTO nv, int nhaCungCapId)
        {
            Boolean result= nhDAL.InsertSP(listsp, nv, nhaCungCapId);           
            return result;
        }
    }
}
