using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using BLL;
using DTO;

namespace GUI
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnOK_MouseMove(object sender, MouseEventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.ForestGreen;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.Peru;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.Peru;
        }

        private void btnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.ForestGreen;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien(txtUser.Text, txtPass.Text);
            try
            {

                if (NhanVienBLL.Instance.CheckLogin(nhanVien))
                {
                    if (checkEditNhoMatKhau.Checked == true)
                    {
                        Properties.Settings.Default.TenDangNhap = txtUser.Text;
                        Properties.Settings.Default.MatKhau = txtPass.Text;
                        Properties.Settings.Default.Save();
                    }
                    NhanVien tk = NhanVienBLL.Instance.GetAccountByUserName(nhanVien.TenDangNhap);

                    QuanLyChung form = new QuanLyChung(tk);
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                    
                }
                else
                {
                    XtraMessageBox.Show("Đăng nhập không thành công!");
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex);
            }
        }



      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TenDangNhap != string.Empty)
            {
                txtUser.Text = Properties.Settings.Default.TenDangNhap;
                txtPass.Text = Properties.Settings.Default.MatKhau;
            }
        }

        private void checkEditHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditHienMatKhau.Checked == true)

                txtPass.Properties.UseSystemPasswordChar = false;
            else
            {
                txtPass.Properties.UseSystemPasswordChar = true;

            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}