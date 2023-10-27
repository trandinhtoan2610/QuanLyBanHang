using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI

{
    public partial class Khachhang : UserControl
    {
        public Khachhang()
        {
            InitializeComponent();
        }

        private void tbTimkiem_Enter(object sender, EventArgs e)
        {
            if (tbTimkiem.Text == "Tìm kiếm")
            {
                tbTimkiem.Text = "";
                tbTimkiem.ForeColor = Color.Black;
            }
        }

        private void tbTimkiem_Leave(object sender, EventArgs e)
        {
            if (tbTimkiem.Text == "")
            {
                tbTimkiem.Text = "Tìm Kiếm";
                tbTimkiem.ForeColor = Color.LightGray;
            }
        }
    }
}
