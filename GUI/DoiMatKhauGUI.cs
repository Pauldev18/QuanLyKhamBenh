using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class DoiMatKhauGUI : Form
    {
        private NhanVien nhanVienDangNhap;
        public NhanVien NhanVienDangNhap
        {
            get { return nhanVienDangNhap; }
            set { nhanVienDangNhap = value; }
        }

        public DoiMatKhauGUI(NhanVien nhanVienDangNhap)
        {
            InitializeComponent();
            this.nhanVienDangNhap = nhanVienDangNhap;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string matKhauCu = tbMatKhauCu.Text;
            string matKhauMoi = tbMatKhauMoi.Text;
            string retypePass = tbNhapLaiMKMoi.Text;

            if (!matKhauMoi.Equals(retypePass))
                MessageBox.Show("Mật khẩu nhập lại không đúng");
            else if(!matKhauCu.Equals(nhanVienDangNhap.MatKhau))
                MessageBox.Show("Mật khẩu cũ không đúng");
            else 
            {
                
                if (NhanVienBLL.Instance.ChangePassWord(nhanVienDangNhap.TenDangNhap, matKhauCu, matKhauMoi))
                {
                  
                    XtraMessageBox.Show("Đổi mật khẩu thành công");
                    NhanVien taiKhoanMoi = new NhanVien(nhanVienDangNhap.MaNhanVien, nhanVienDangNhap.HoTen, nhanVienDangNhap.NgaySinh,
                                                    nhanVienDangNhap.GioiTinh, nhanVienDangNhap.TenDangNhap,tbMatKhauMoi.Text,nhanVienDangNhap.MaLoaiNV);
                    this.nhanVienDangNhap = taiKhoanMoi;
                    tbMatKhauCu.Clear();
                    tbMatKhauMoi.Clear();
                    tbNhapLaiMKMoi.Clear();

                }
                else
                {
                    
                    XtraMessageBox.Show("Đổi mật khẩu không thành công");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tbMatKhauCu.Clear();
            tbMatKhauMoi.Clear();
            tbNhapLaiMKMoi.Clear();
        }
    }
}
