using BLL;
using DAO;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class CapCuu : Form
    {
        public CapCuu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_tsbbanthan.Text == "" || tb_trieuchung.Text == "" || tb_chandoan.Text == "" || tb_KeHoachDieuTri.Text == "")
            {
                XtraMessageBox.Show("Điền đầy đủ thông tin", "Cảnh báo");
            }
            BenhNhanCapCuu benhNhanCapCuu = new BenhNhanCapCuu();
            benhNhanCapCuu.HoTen = tb_hoten.Text;
            benhNhanCapCuu.SDT = tb_sodt.Text;
            benhNhanCapCuu.DiaChi = tb_diachi.Text;
            benhNhanCapCuu.NamSinh = tb_namsinh.Text;
            benhNhanCapCuu.GioiTinh = cbbGioiTinh.Text;
            benhNhanCapCuu.Email = tb_email.Text;
            benhNhanCapCuu.TienSuBenh = tb_tsbbanthan.Text;
            benhNhanCapCuu.TrieuChung = tb_trieuchung.Text;
            benhNhanCapCuu.ChuanDoan = tb_chandoan.Text;
            benhNhanCapCuu.KeHoachDieuTri = tb_KeHoachDieuTri.Text;
            benhNhanCapCuu.ThoiGian = tb_ThoiGian.Text;
            benhNhanCapCuu.GhiChu = tb_GhiChu.Text;
            if (CapCuuBLL.Instance.Insert(benhNhanCapCuu))
            {
                XtraMessageBox.Show("Tạo phiếu khám bệnh thành công, Phiếu khám sẽ được in ra", "Thông báo");
                PhieuKhamBenhReport report = new PhieuKhamBenhReport();
                report.Parameters["HoTen"].Value = tb_hoten.Text;
                report.Parameters["NamSinh"].Value = int.Parse(tb_namsinh.Text);
                report.Parameters["GioiTinh"].Value = cbbGioiTinh.Text;
                report.Parameters["DiaChi"].Value = tb_diachi.Text;
                report.Parameters["SDT"].Value = tb_sodt.Text;
                report.Parameters["Email"].Value = tb_email.Text;
                report.Parameters["TienSuBenh"].Value = benhNhanCapCuu.TienSuBenh;
                report.Parameters["TrieuChung"].Value = benhNhanCapCuu.TrieuChung;
                report.Parameters["ChuanDoan"].Value = benhNhanCapCuu.ChuanDoan; 
                report.Parameters["GhiChu"].Value = benhNhanCapCuu.GhiChu;
                report.Parameters["KeHoachDieuTri"].Value = benhNhanCapCuu.KeHoachDieuTri; ;
                report.Parameters["ThoiGianDieuTri"].Value = benhNhanCapCuu.ThoiGian;
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();
            }
            else
            {
                XtraMessageBox.Show("Thêm phiếu khám thất bại", "Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                XtraMessageBox.Show("Process...");
                PhieuKhamBenhReport report = new PhieuKhamBenhReport();
                report.Parameters["HoTen"].Value = tb_hoten.Text;
                report.Parameters["NamSinh"].Value = int.Parse(tb_namsinh.Text);
                report.Parameters["GioiTinh"].Value = cbbGioiTinh.Text;
                report.Parameters["DiaChi"].Value = tb_diachi.Text;
                report.Parameters["SDT"].Value = tb_sodt.Text;
                report.Parameters["Email"].Value = tb_email.Text;
                report.Parameters["TienSuBenh"].Value = tb_tsbbanthan.Text;
                report.Parameters["TrieuChung"].Value = tb_trieuchung.Text;
                report.Parameters["ChuanDoan"].Value = tb_chandoan;
                report.Parameters["GhiChu"].Value = "Chuyển tuyến!!!";
                report.Parameters["KeHoachDieuTri"].Value = tb_KeHoachDieuTri.Text;
                report.Parameters["ThoiGianDieuTri"].Value = tb_ThoiGian.Text;
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();
            }catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi!!!");
            }
        }
    }
}
