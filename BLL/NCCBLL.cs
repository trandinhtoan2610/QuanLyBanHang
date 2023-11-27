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
    public class NCCBLL
    {
        private NCCDTO ncc;
        private List<NCCDTO> dsNCC;
        NCCDAL qlNCCDAL = new NCCDAL();


        public List<NCCDTO> readDB()
        {
            return qlNCCDAL.readDB();
        }

        public DataTable Display()
        {
            dsNCC = readDB();
            return qlNCCDAL.Display(dsNCC);
        }
        public bool InsertNCC(NCCDTO ncc)
        {
            dsNCC = readDB();
            dsNCC.Add(ncc);
            return qlNCCDAL.InsertNCC(ncc);
        }

        public bool InsertNCC(int id, string tenNCC, string sodienthoai, string diachi, string email)
        {
            ncc = new NCCDTO(id, tenNCC, sodienthoai, diachi, email);
            return InsertNCC(ncc);
        }

    }
}
