using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DevExpress.XtraEditors;
using DTO;
namespace GUI
{
    public partial class BenhNhanGUI: Form
    {
        bool them = false;
        BenhNhan benhNhan = new BenhNhan();
        NhanVien taikhoan = new NhanVien();
        public NhanVien taiKhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        public BenhNhanGUI(NhanVien taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
        }

        private void LoadDataGridView()
        {
            dtgvDSBenhNhan.AutoGenerateColumns = false;
            dtgvDSBenhNhan.DataSource = BenhNhanBLL.Instance.LayTatCaDSBenhNhan();
        }

        private void BenhNhanGUI_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dtgvDSBenhNhan_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy các trường thông tin vào các textbox
            tb_mabn.Text = dtgvDSBenhNhan.CurrentRow.Cells["MaBN"].Value.ToString();
            tb_namsinh.Text = dtgvDSBenhNhan.CurrentRow.Cells["NamSinh"].Value.ToString();
            tb_hoten.Text = dtgvDSBenhNhan.CurrentRow.Cells["HoTen"].Value.ToString();
            cbbGioiTinh.Text = dtgvDSBenhNhan.CurrentRow.Cells["GioiTinh"].Value.ToString();
            tb_diachi.Text = dtgvDSBenhNhan.CurrentRow.Cells["DiaChi"].Value.ToString();
            tb_sodt.Text = dtgvDSBenhNhan.CurrentRow.Cells["SDT"].Value.ToString();
            tb_email.Text = dtgvDSBenhNhan.CurrentRow.Cells["Email"].Value.ToString();
            benhNhan = new BenhNhan(int.Parse(tb_mabn.Text), tb_hoten.Text, int.Parse(tb_namsinh.Text), 
                                    cbbGioiTinh.Text,tb_diachi.Text,tb_email.Text,tb_sodt.Text);
            dtgv_DSLichSuKB.AutoGenerateColumns = false;
            dtgv_DSLichSuKB.DataSource = BenhNhanBLL.Instance.LayDSLichSuKhamBenh(int.Parse(tb_mabn.Text));
            
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            btnSua.Enabled = false;
            btnDangkylayso.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cbbGioiTinh.Enabled = true;
            tb_hoten.ReadOnly = false;
            tb_namsinh.ReadOnly = false;
            tb_email.ReadOnly = false;
            tb_diachi.ReadOnly = false;
            tb_sodt.ReadOnly = false;
           
            //Mã bệnh nhân set giá trị tăng dần với trạng thái set giá trị mặc định nên không cần nhập giá trị mới
            tb_mabn.Clear();
            tb_hoten.Clear();
            tb_namsinh.Clear();
            tb_email.Clear();
            tb_diachi.Clear();
            tb_sodt.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            btnThem.Enabled = false;
            btnDangkylayso.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            cbbGioiTinh.Enabled = true;
            tb_hoten.ReadOnly = false;
            tb_namsinh.ReadOnly = false;
            tb_email.ReadOnly = false;
            tb_diachi.ReadOnly = false;
            tb_sodt.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tb_hoten.Text == "" || tb_namsinh.Text == "")
            {
                XtraMessageBox.Show("Họ tên và năm sinh không được để trống", "Cảnh báo");
            }
            else
            {
                if (them) //lưu thêm 
                {
                    BenhNhan benhNhanTemp = new BenhNhan(tb_hoten.Text, int.Parse(tb_namsinh.Text), 
                                                        cbbGioiTinh.Text, tb_diachi.Text, tb_email.Text, tb_sodt.Text);

                    if (BenhNhanBLL.Instance.Insert(benhNhanTemp))
                    {
                        XtraMessageBox.Show("Thêm bệnh nhân mới thành công", "Thông báo");
                        LoadDataGridView();
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnDangkylayso.Enabled = true;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;

                    }
                    else
                        XtraMessageBox.Show("Thêm bệnh nhân thất bại", "Lỗi");
                }
                else // lưu sửa bản
                {
                    if (tb_hoten.Text == benhNhan.HoTen && tb_namsinh.Text == benhNhan.NamSinh.ToString() 
                        && cbbGioiTinh.Text == benhNhan.GioiTinh && tb_diachi.Text == benhNhan.DiaChi.ToString()
                        && tb_sodt.Text == benhNhan.Sdt && tb_email.Text == benhNhan.Email.ToString())
                    { 
                        XtraMessageBox.Show("Chưa có thông tin nào cần sửa", "Thông báo");
                    }
                    else
                    {
                        BenhNhan benhNhanTemp = new BenhNhan(int.Parse(tb_mabn.Text), tb_hoten.Text, int.Parse(tb_namsinh.Text), 
                                                        cbbGioiTinh.Text, tb_diachi.Text, tb_email.Text, tb_sodt.Text);

                        if (BenhNhanBLL.Instance.Update(benhNhanTemp))
                        {
                            XtraMessageBox.Show("Sửa bệnh nhân thành công", "Thông báo");
                            LoadDataGridView();
                            btnThem.Enabled = true;
                            btnSua.Enabled = true;
                            btnDangkylayso.Enabled = true;
                            btnLuu.Enabled = false;
                            btnHuy.Enabled = false;
                        }
                        else
                            XtraMessageBox.Show("Sửa bệnh nhân thất bại", "Lỗi");
                    }

                }
            }
        }

       
        private void btnHuy_Click(object sender, EventArgs e)
        {
            tb_mabn.Text = benhNhan.MaBN.ToString();
            tb_hoten.Text = benhNhan.HoTen;
            cbbGioiTinh.Text = benhNhan.GioiTinh;
            tb_namsinh.Text = benhNhan.NamSinh.ToString();
            tb_diachi.Text = benhNhan.DiaChi;
            tb_sodt.Text = benhNhan.Sdt;
            tb_email.Text = benhNhan.Email;
            tb_mabn.ReadOnly = true;
            cbbGioiTinh.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnDangkylayso.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnDangkylayso_Click(object sender, EventArgs e)
        {
            if(!BenhNhanBLL.Instance.KiemTraDangKyKham(int.Parse(tb_mabn.Text)))
            {
                DangKyKhamGUI dangKyKhamGUI = new DangKyKhamGUI(benhNhan,taikhoan);
                dangKyKhamGUI.ShowDialog();
            }
            else
                XtraMessageBox.Show("Bệnh nhân đã đăng ký khám hôm nay", "Thông báo");
            
        }

        private void tb_mabn_TextChanged(object sender, EventArgs e)
        {
            tb_hoten.Text = benhNhan.HoTen;
        }
    }
}
