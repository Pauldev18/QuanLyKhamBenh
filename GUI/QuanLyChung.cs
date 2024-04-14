using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Diagnostics;
using System.IO;
using BLL;
using DTO;

namespace GUI

{
    public partial class QuanLyChung : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private NhanVien nhanVienDangNhap;
        public NhanVien NhanVienDangNhap
        {
            get { return nhanVienDangNhap; }
            set { nhanVienDangNhap = value; DisplayAccount(nhanVienDangNhap.MaLoaiNV); }
        }
        public QuanLyChung(NhanVien nhanVienDangNhap)
        {
            InitializeComponent();
            this.nhanVienDangNhap = nhanVienDangNhap;
        }

        private void DisplayAccount(int maloainv)
        {
            if(maloainv==1)
            {
                rpg_QuanLy.Visible = true;
            }
            else if (maloainv == 2)
            {
                rpg_ChoKham.Visible = true;
            }
            else if (maloainv == 3)
            {
                rpg_KhamBenh.Visible = true;
            }   
           
        }
        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn đăng xuất ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {  
                this.Close();
            }
        }
        private void barButtonItemDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {

            DoiMatKhauGUI doiMatKhauGUI = new DoiMatKhauGUI(nhanVienDangNhap);
            doiMatKhauGUI.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(doiMatKhauGUI);
            doiMatKhauGUI.Dock = DockStyle.Fill;
            doiMatKhauGUI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            doiMatKhauGUI.Show();
        }


        private void QuanLyChung_Load(object sender, EventArgs e)
        {
            rpg_HeThong.Text = nhanVienDangNhap.HoTen;
            DisplayAccount(nhanVienDangNhap.MaLoaiNV);
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;


        }

        public void btnDangKyLaySo_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhSachLaySoGUI dangKyLaySoGUI = new DanhSachLaySoGUI(false);
            dangKyLaySoGUI.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(dangKyLaySoGUI);
            dangKyLaySoGUI.Dock = DockStyle.Fill;
            dangKyLaySoGUI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dangKyLaySoGUI.Show();
        }

      
        private void btnPhieuKhamBenh_ItemClick(object sender, ItemClickEventArgs e)
        {
            PhieuKhamBenhGUI phieuKhamBenhGUI = new PhieuKhamBenhGUI(nhanVienDangNhap);
            phieuKhamBenhGUI.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(phieuKhamBenhGUI);
            phieuKhamBenhGUI.Dock = DockStyle.Fill;
            phieuKhamBenhGUI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            phieuKhamBenhGUI.Show();
        }

       
        private void btnThongTinTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongTinTaiKhoanGUI thongTinTaiKhoanGUI = new ThongTinTaiKhoanGUI(nhanVienDangNhap);
            thongTinTaiKhoanGUI.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(thongTinTaiKhoanGUI);
            thongTinTaiKhoanGUI.Dock = DockStyle.Fill;
            thongTinTaiKhoanGUI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            thongTinTaiKhoanGUI.Show();
        }

        

        private void btnBenhNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            BenhNhanGUI benhNhanGUI = new BenhNhanGUI(nhanVienDangNhap);
            benhNhanGUI.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(benhNhanGUI);
            benhNhanGUI.Dock = DockStyle.Fill;
            benhNhanGUI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            benhNhanGUI.Show();
        }

     
        private void btnChoKham_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhSachLaySoGUI dangKyLaySoGUI = new DanhSachLaySoGUI(true);
            dangKyLaySoGUI.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(dangKyLaySoGUI);
            dangKyLaySoGUI.Dock = DockStyle.Fill;
            dangKyLaySoGUI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dangKyLaySoGUI.Show();
        }

       
    }
}