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
        public List<SanPhamDTO> getAllProduct()
        {
            return nhDAL.getAllProduct();
        }
        public Boolean InsertSP(List<SanPhamDTO> listsp)
        {
            Boolean result= nhDAL.InsertSP(listsp);           
            return result;
        }
    }
}
