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

        public DataTable Display()
        {
            dssp = readDB();
            return qlspDAL.Display(dssp);
        }

        public bool InsertSP(SanPhamDTO sanpham)
        {
            dssp = readDB();         
            dssp.Add(sanpham);
            return qlspDAL.InsertSP(sanpham);
        }

        public bool InsertSP(int id, string tensanpham, int idLoaiSanPham, string hangsanxuat, int gia, int soluong, string donvitinh)
        {
            sp = new SanPhamDTO(id ,tensanpham, idLoaiSanPham, hangsanxuat, gia, soluong, donvitinh);
            return InsertSP(sp);
        }




        public bool UpdateSP(int id, string tensanpham,int idLoaiSanPham, string hangsanxuat, int gia, int soluong, string donvitinh)
        {
            dssp = readDB();
            
            foreach (SanPhamDTO sp in dssp)
            {
                if (sp.Id.Equals(id))
                {
                    sp.Tensanpham = tensanpham;
                    sp.IdLoaiSanPham = idLoaiSanPham;
                    sp.Hangsanxuat = hangsanxuat;
                    sp.Gia = gia;
                    sp.Soluong = soluong;
                    sp.Donvitinh = donvitinh;
                }
            }
            return qlspDAL.UpdateSP(id, tensanpham, idLoaiSanPham, hangsanxuat, gia, soluong, donvitinh);
        }

        

        public bool DeleteKH(string index)
        {
            
            return qlspDAL.DeleteSP(index);
        }

        public DataTable Show(string text)
        {
            List<SanPhamDTO> dssp_tk = new List<SanPhamDTO>();
            dssp_tk = qlspDAL.Search(text);
            //Tìm kiếm theo chuỗi nhập vào
            return qlspDAL.Show(dssp_tk);
        }
    }
}
