using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class SanPhamBLL
    {
        private SanPhamDTO sp;
        private List<SanPhamDTO> dssp;
        SanPhamDAL qlspDAL = new SanPhamDAL();
       
        public List<SanPhamDTO> readDB()
        {
            return qlspDAL.readDB();
        }

        public List<SanPhamDTO> GetSanphamkho()
        {
            return qlspDAL.GetSanphamkho();
        }


        public bool InsertSP(SanPhamDTO sanpham)
        {
            dssp = readDB();
            dssp.Add(sanpham);
            return qlspDAL.InsertSP(sanpham);
        }

        public bool InsertSP( string tensanpham, int idLoaiSanPham, string hangsanxuat, int gia, int soluong, string donvitinh, int khuyenmai)
        {
            sp = new SanPhamDTO(tensanpham, idLoaiSanPham, hangsanxuat, gia, soluong, donvitinh, khuyenmai);
            return InsertSP(sp);
        }




        public bool UpdateSP(SanPhamDTO sp)
        {
            return qlspDAL.UpdateSP(sp);
        }



        public bool DeleteSP(int id)
        {
            return qlspDAL.DeleteSP(id);
        }

        public List<SanPhamDTO> Search(string text)
        {
           
            return qlspDAL.Search(text);
        }
    }
}