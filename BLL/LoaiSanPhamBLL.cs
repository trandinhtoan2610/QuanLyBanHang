﻿using DAL;
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

        public bool InsertLSP(int id, string tenloai)
        {
            lsp = new LoaiSanPhamDTO(id, tenloai);
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



        public bool DeleteKH(string index)
        {

            return qllspDAL.DeleteLSP(index);
        }


    }
}