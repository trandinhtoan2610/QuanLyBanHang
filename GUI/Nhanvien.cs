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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI

{
    public partial class Nhanvien : UserControl
    {


        BindingSource nvlist = new BindingSource();
        NhanVienBLL qlnvBLL = new NhanVienBLL();
        NhanVienDTO nv = new NhanVienDTO();
        List<NhanVienDTO> listNhanVien,found;

        public Nhanvien()
        {
            InitializeComponent();
            load();
            dtaGVNV.Font = new Font("Times New Roman", 10);
            
        }

        public void load()
        {

            dtaGVNV.DataSource = nvlist;
            loadData();
            loadcbb();
            loadHeaderText();
            addNhanVienBinding();
            

        }

        public void loadData()
        {
            listNhanVien = qlnvBLL.readDB();
            nvlist.DataSource = listNhanVien;
        }

        void loadcbb()
        {
            LoaiNhanVienBLL lnvbll = new LoaiNhanVienBLL();
            List<LoaiNhanVienDTO> llnv;
            llnv = lnvbll.readDB();
            cbLoaiNV.DisplayMember = "tenloai";
            cbLoaiNV.ValueMember = "id";
            cbLoaiNV.DataSource = llnv;

        }

        public void loadHeaderText()
        {
            dtaGVNV.Columns["id"].HeaderText = "ID";
            dtaGVNV.Columns["tennhanvien"].HeaderText = "Tên nhân viên";
            dtaGVNV.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            dtaGVNV.Columns["IdLoainhanvien"].HeaderText = "Mã loại nhân viên";
            dtaGVNV.Columns["sodienthoai"].HeaderText = "Số điện thoại";
            dtaGVNV.Columns["cmnd"].HeaderText = "CMND";
            dtaGVNV.Columns["email"].HeaderText = "Email";
            dtaGVNV.Columns["gioitinh"].HeaderText = "Giới tính";
            dtaGVNV.Columns["diachi"].HeaderText = "Địa chỉ";
        }


        public void addNhanVienBinding()
        {

            tbMaNV.DataBindings.Add(new Binding("Text", dtaGVNV.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbTenNV.DataBindings.Add(new Binding("Text", dtaGVNV.DataSource, "tennhanvien", true, DataSourceUpdateMode.Never));
            dtNgaysinh.DataBindings.Add(new Binding("Text", dtaGVNV.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never));
            cbLoaiNV.DataBindings.Add(new Binding("Text", dtaGVNV.DataSource, "idLoaiNhanVien", true, DataSourceUpdateMode.Never));
            tbSđt.DataBindings.Add(new Binding("Text", dtaGVNV.DataSource, "sodienthoai", true, DataSourceUpdateMode.Never));
            tbCMND.DataBindings.Add(new Binding("Text", dtaGVNV.DataSource, "cmnd", true, DataSourceUpdateMode.Never));
            tbEmail.DataBindings.Add(new Binding("Text", dtaGVNV.DataSource, "email", true, DataSourceUpdateMode.Never));
            tbDiachi.DataBindings.Add(new Binding("Text", dtaGVNV.DataSource, "diachi", true, DataSourceUpdateMode.Never));
        }

        public void Clear()
        {
            tbMaNV.Text = tbTenNV.Text = cbLoaiNV.Text = tbSđt.Text = tbCMND.Text = tbEmail.Text = tbDiachi.Text = tbMatkhau.Text = string.Empty;
        }
        static bool IsPhoneNumber(string input)
        {

            return Regex.IsMatch(input, @"^0\d+$");
        }
        static bool IsCMNDNumber(string input)
        {
            // Kiểm tra chuỗi có chứa chỉ số và không chứa chữ cái
            return Regex.IsMatch(input, @"^\d+$");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            LoaiNhanVienBLL lnvbll = new LoaiNhanVienBLL();
            List<LoaiNhanVienDTO> llnv;
            llnv = lnvbll.readDB();

            DateTime selectedDateTime = dtNgaysinh.Value;

            nv.Id = Convert.ToInt32(tbMaNV.Text);
            nv.Tennhanvien = tbTenNV.Text;
            nv.Ngaysinh = selectedDateTime.ToString("yyyy-MM-dd");
            nv.IdLoainhanvien = Convert.ToInt32(cbLoaiNV.SelectedValue);
            nv.Sodienthoai = tbSđt.Text.Replace(" ", ""); ;
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
            nv.Matkhau = tbMatkhau.Text;
            /*if (qlnvBLL.InsertNV(nv.Id, nv.Tennhanvien, nv.Ngaysinh, nv.IdLoainhanvien, nv.Sodienthoai, nv.Cmnd, nv.Email, nv.Gioitinh, nv.Diachi, nv.Matkhau))
            {
                MessageBox.Show("thêm thành công");
            }
            loadData();
            Clear();*/
            if (nv.Tennhanvien != "")
            {
                if (nv.Sodienthoai != "")
                {
                    if (nv.Sodienthoai.Length == 10 && IsPhoneNumber(nv.Sodienthoai))
                    {
                        if (qlnvBLL.findbyPhone(nv.Sodienthoai).Sodienthoai == null)
                        {
                            if(nv.Cmnd != "" && IsCMNDNumber(nv.Cmnd))
                            {
                                if (nv.Matkhau != "")
                                {
                                    if(nv.Ngaysinh != "")
                                    {
                                        if (qlnvBLL.InsertNV(nv))
                                        {
                                            MessageBox.Show("thêm thành công!");
                                        }
                                        else
                                        {
                                            MessageBox.Show("thêm thất bại!");
                                        }
                                        loadData();
                                        Clear();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ngày sinh không được để trống!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Mật khẩu không được để trống!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Chứng minh nhân dân không được bỏ trống và được nhập bằng ký tự số!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại!");
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại được bắt đầu bằng số 0 và phải có 10 ký tự số!");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không được để trống !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            nv.Id = Convert.ToInt32(tbMaNV.Text);
            if (qlnvBLL.DeleteNV(nv.Id))
            {
                MessageBox.Show("Xóa thành công!");
            }
            loadData();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            LoaiNhanVienBLL lnvbll = new LoaiNhanVienBLL();
            List<LoaiNhanVienDTO> llnv;
            llnv = lnvbll.readDB();
            DateTime selectedDateTime = dtNgaysinh.Value;

            nv.Id = Convert.ToInt32(tbMaNV.Text);
            nv.Tennhanvien = tbTenNV.Text;
            nv.Ngaysinh = selectedDateTime.ToString("yyyy-MM-dd");
            nv.IdLoainhanvien = Convert.ToInt32(cbLoaiNV.SelectedValue);
            nv.Sodienthoai = tbSđt.Text.Replace(" ", ""); ;
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
            nv.Matkhau = tbMatkhau.Text;
            if (nv.Tennhanvien != "")
            {
                if (nv.Sodienthoai != "")
                {
                    if (nv.Sodienthoai.Length == 10 && IsPhoneNumber(nv.Sodienthoai))
                    {
                        if (qlnvBLL.findbyPhone(nv.Sodienthoai).Sodienthoai == null)
                        {
                            if (nv.Cmnd != "" && IsCMNDNumber(nv.Cmnd))
                            {
                                if (nv.Matkhau != "")
                                {
                                    if (nv.Ngaysinh != "")
                                    {
                                        if (qlnvBLL.UpdateNV(nv.Id, nv.Tennhanvien, nv.Ngaysinh, nv.IdLoainhanvien, nv.Sodienthoai, nv.Cmnd, nv.Email, nv.Gioitinh, nv.Diachi, nv.Matkhau))
                                        {
                                            MessageBox.Show("Cập nhât thành công!");
                                            loadData();
                                            Clear();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Cập nhật thất bại!");
                                        }
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ngày sinh không được để trống!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Mật khẩu không được để trống!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Chứng minh nhân dân không được bỏ trống và được nhập bằng ký tự số!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại được bắt đầu bằng số 0 và phải có 10 ký tự số!");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không được để trống !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
            }
        }
    }
}
