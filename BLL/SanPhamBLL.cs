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



        public bool InsertSP(SanPhamDTO sanpham)
        {
            dssp = readDB();
            dssp.Add(sanpham);
            return qlspDAL.InsertSP(sanpham);
        }

        public bool InsertSP(int id, string tensanpham, int idLoaiSanPham, string hangsanxuat, int gia, int soluong, string donvitinh, int khuyenmai)
        {
            sp = new SanPhamDTO(id, tensanpham, idLoaiSanPham, hangsanxuat, gia, soluong, donvitinh, khuyenmai);
            return InsertSP(sp);
        }




        public bool UpdateSP(int id, string tensanpham, int idLoaiSanPham, string hangsanxuat, int gia, int soluong, string donvitinh, int khuyenmai)
        {
            dssp = readDB();

            foreach (SanPhamDTO sp in dssp)
            {
                if (sp.Id.Equals(id))
                {
                    sp.Id = id;
                    sp.Tensanpham = tensanpham;
                    sp.IdLoaiSanPham = idLoaiSanPham;
                    sp.Hangsanxuat = hangsanxuat;
                    sp.Gia = gia;
                    sp.Soluong = soluong;
                    sp.Donvitinh = donvitinh;
                    sp.Khuyenmai = khuyenmai;
                }
            }
            return qlspDAL.UpdateSP(id, tensanpham, idLoaiSanPham, hangsanxuat, gia, soluong, donvitinh, khuyenmai);
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