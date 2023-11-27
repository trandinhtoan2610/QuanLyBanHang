using BLL;
using DTO;
using System;
using System.Collections;
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
    public partial class Nhanvien : UserControl
    {
       

        BindingSource nvlist = new BindingSource();
        NhanVienBLL qlnvBLL = new NhanVienBLL();
        NhanVienDTO nv = new NhanVienDTO();
        List<NhanVienDTO> listNhanVien;

        public Nhanvien()
        {
            InitializeComponent();
            loadData();
        }




        public void loadData()
        {
           
            dtaGVNV.DataSource = nvlist;
            listNhanVien = qlnvBLL.readDB();
            nvlist.DataSource = listNhanVien;

           // dtNgaysinh = new DateTimePicker();
            //dtNgaysinh.Format = DateTimePickerFormat.Short;
            //dtNgaysinh.CustomFormat = "yyyy-MM-dd";

            
        }

        public void Clear()
        {
            tbMaNV.Text = tbTenNV.Text = cbLoaiNV.Text  = tbSđt.Text = tbCMND.Text = tbEmail.Text = tbDiachi.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dtNgaysinh.Value;
            
            string aa= selectedDateTime.ToString("yyyy-MM-dd");

            MessageBox.Show("thêm thành công! " );


            nv.Id = Convert.ToInt32(tbMaNV.Text);
            nv.Tennhanvien = tbTenNV.Text;
            nv.Ngaysinh = dtNgaysinh.Value;
            nv.IdLoainhanvien = Convert.ToInt32(cbLoaiNV.Text);
            nv.Sodienthoai = tbSđt.Text;
            nv.Cmnd = tbCMND.Text;
            nv.Email = tbEmail.Text;
            if (rb1.Checked)
            {
                nv.Gioitinh = rb1.Text;
            }
            else
            {
                nv.Gioitinh = rb2.Text;
            }

            nv.Diachi = tbDiachi.Text;

            if (qlnvBLL.InsertNV(nv.Id, nv.Tennhanvien, nv.Ngaysinh, nv.IdLoainhanvien, nv.Sodienthoai, nv.Cmnd, nv.Email, nv.Gioitinh, nv.Diachi)) 
            {
                MessageBox.Show("thêm thành công");
            }
            loadData();
            Clear();
        }
    }
}
