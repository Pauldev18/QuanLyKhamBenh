using BLL;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class PhieuKhamBenhGUI : DevExpress.XtraEditors.XtraForm
    {
        NhanVien taikhoan = new NhanVien();
        public NhanVien taiKhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        public PhieuKhamBenhGUI(NhanVien taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
        }

    
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (tb_tsbbanthan.Text == "" || tb_trieuchung.Text == ""||tb_chandoan.Text =="" || tb_KeHoachDieuTri.Text=="")
            {
                XtraMessageBox.Show("Điền đầy đủ thông tin","Cảnh báo");
            }
            PhieuKhamBenh hoaDonKhamBenh = new PhieuKhamBenh(int.Parse(txt_makhambenh.Text.ToString()), taiKhoan.MaNhanVien, tb_tsbbanthan.Text, tb_trieuchung.Text,
                tb_chandoan.Text, tb_GhiChu.Text, tb_KeHoachDieuTri.Text,tb_ThoiGian.Text);

            if (PhieuKhamBenhBLL.Instance.Insert(hoaDonKhamBenh))
            {
                XtraMessageBox.Show("Tạo phiếu khám bệnh thành công, Phiếu khám sẽ được in ra", "Thông báo");
                PhieuKhamBenhReport report = new PhieuKhamBenhReport();
                report.Parameters["HoTen"].Value = tb_hoten.Text;
                report.Parameters["NamSinh"].Value = int.Parse(tb_namsinh.Text);
                report.Parameters["GioiTinh"].Value = cbbGioiTinh.Text;
                report.Parameters["DiaChi"].Value = tb_diachi.Text ;
                report.Parameters["SDT"].Value = tb_sodt.Text;
                report.Parameters["Email"].Value = tb_email.Text;
                report.Parameters["TienSuBenh"].Value = hoaDonKhamBenh.TienSuBenh;
                report.Parameters["TrieuChung"].Value = hoaDonKhamBenh.TrieuChung;
                report.Parameters["ChuanDoan"].Value = hoaDonKhamBenh.ChanDoan; ;
                report.Parameters["GhiChu"].Value = hoaDonKhamBenh.GhiChu;
                report.Parameters["KeHoachDieuTri"].Value = hoaDonKhamBenh.KeHoachDieuTri; ;
                report.Parameters["ThoiGianDieuTri"].Value = hoaDonKhamBenh.ThoiGianDieuTri;
                ReportPrintTool tool = new ReportPrintTool(report);
                tool.ShowPreview();


            }
            else
                XtraMessageBox.Show("Thêm phiếu khám thất bại", "Lỗi");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            tb_hoten.Clear();
            tb_email.Clear();
            tb_diachi.Clear();  
            tb_sodt.Clear();
            tb_namsinh.Clear();
            tb_KeHoachDieuTri.Clear(); 
            tb_chandoan.Clear();    
            tb_tsbbanthan.Clear();
            tb_trieuchung.Clear();
            tb_ThoiGian.Clear();  
            tb_GhiChu.Clear();
            tb_mabn.Clear();
        }

        private void PhieuKhamBenhGUI_Load(object sender, EventArgs e)
        {
            data_khambenh.DataSource = LichSuKhamBenhBLL.Instance.LayDSGoiKham();
        }


        private void glue_dsbenhnhan_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as GridLookUpEdit;

            DataRow dr = (edit.Properties.GetRowByKeyValue(edit.EditValue) as DataRowView).Row;
            tb_mabn.Text = dr["MaBN"].ToString();
            tb_hoten.Text = dr["HoTen"].ToString();
            tb_email.Text = dr["Email"].ToString();
            tb_diachi.Text = dr["DiaChi"].ToString();
            tb_namsinh.Text = dr["NamSinh"].ToString();
            cbbGioiTinh.Text = dr["GioiTinh"].ToString();
            tb_sodt.Text = dr["SDT"].ToString();
         
        }

        private void data_khambenh_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_makhambenh.Text = data_khambenh.CurrentRow.Cells["MaKhamBenh"].Value.ToString();
            tb_mabn.Text = data_khambenh.CurrentRow.Cells["MaBN"].Value.ToString();
            tb_hoten.Text = data_khambenh.CurrentRow.Cells["HoTen"].Value.ToString();
            tb_email.Text = data_khambenh.CurrentRow.Cells["Email"].Value.ToString();
            tb_diachi.Text = data_khambenh.CurrentRow.Cells["DiaChi"].Value.ToString();
            tb_namsinh.Text = data_khambenh.CurrentRow.Cells["NamSinh"].Value.ToString();
            cbbGioiTinh.Text = data_khambenh.CurrentRow.Cells["GioiTinh"].Value.ToString();
            tb_sodt.Text = data_khambenh.CurrentRow.Cells["SDT"].Value.ToString();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}