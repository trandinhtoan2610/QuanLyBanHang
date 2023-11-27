using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Banhang : UserControl
    {
        SanPhamBLL lspbll = new SanPhamBLL();
        List<SanPhamDTO> lsp;
        public Banhang()
        {
            InitializeComponent();
            loadcbb();
        }
        void loadcbb()
        {
            
            lsp = lspbll.readDB();
            cbTensanpham.DisplayMember = "Tensanpham";
            cbTensanpham.ValueMember = "Id";
            cbTensanpham.DataSource = lsp;
        }

        void loadgia()
        {
            lsp = lspbll.readDB();
            
        }
    }
}
