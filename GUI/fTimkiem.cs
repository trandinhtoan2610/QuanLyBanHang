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
    public partial class fTimkiem : UserControl
    {
        public event EventHandler DiDenBanhang;
        public fTimkiem()
        {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            DiDenBanhang?.Invoke(this, EventArgs.Empty);
        }
    }
}
