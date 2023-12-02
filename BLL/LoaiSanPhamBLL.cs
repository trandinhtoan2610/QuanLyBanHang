using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiSanPhamBLL
    {
        private LoaiSanPhamDTO lsp;
        private List<LoaiSanPhamDTO> dslsp;
        LoaiSanPhamDAL qllspDAL = new LoaiSanPhamDAL();

        public List<LoaiSanPhamDTO> readDB()
        {
            return qllspDAL.readDB();
        }



        public bool InsertSP(LoaiSanPhamDTO loaisanpham)
        {
            dslsp = readDB();
            dslsp.Add(loaisanpham);
            return qllspDAL.InsertLSP(loaisanpham);
        }

        public bool InsertLSP(string tenloai)
        {
            lsp = new LoaiSanPhamDTO(tenloai);
            return InsertSP(lsp);
        }




        public bool UpdateLSP(int id, string tenloai)
        {
            dslsp = readDB();

            foreach (LoaiSanPhamDTO lsp in dslsp)
            {
                if (lsp.Id.Equals(id))
                {
                    lsp.TenLoai = tenloai;

                }
            }
            return qllspDAL.UpdateLSP(id, tenloai);
        }



        public bool DeleteLSP(int id)
        {
            return qllspDAL.DeleteLSP(id);
        }

        public List<LoaiSanPhamDTO> Search(string text)
        {
            return qllspDAL.Search(text);
        }

    }
}