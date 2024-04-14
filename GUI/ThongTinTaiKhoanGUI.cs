using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using DTO;

namespace GUI
{
    public partial class ThongTinTaiKhoanGUI : Form
    {
        private NhanVien nhanVien;
        public NhanVien Nhanvien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }

        public ThongTinTaiKhoanGUI(NhanVien nhanVienDangNhap)
        {
            InitializeComponent();
            this.nhanVien = nhanVienDangNhap;
        }
        private void LoadDataCombobox()
        {
            cbb_ChucVu.DisplayMember = "TenLoaiNV";
            cbb_ChucVu.ValueMember = "MaLoaiNV";
            cbb_ChucVu.DataSource = LoaiNhanVienBLL.Instance.GetAllAccountType();
        }
        public void LoadData()
        {
            tb_MaNhanVien.Text = nhanVien.MaNhanVien;
            tb_HoTen.Text = nhanVien.HoTen;
            tb_NgaySinh.Text = nhanVien.NgaySinh.ToString("dd/MM/yyyy"); ;
            tb_TenDangNhap.Text = nhanVien.TenDangNhap;
            LoadDataCombobox();
            cbb_ChucVu.SelectedValue = nhanVien.MaLoaiNV.ToString();
            cbb_GioiTinh.Text = nhanVien.GioiTinh;

        }
        private void ThongTinTaiKhoanGUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

       
        private void btnDong_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tb_MaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
