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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using DTO;

namespace GUI
{ 
    public partial class DangKyKhamGUI : Form
    {
        BenhNhan benhNhan = new BenhNhan();
        NhanVien taikhoan = new NhanVien();
        public BenhNhan Benhnhan
        {
            get { return benhNhan; }
            set { benhNhan = value; }
        }
        public NhanVien taiKhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        public DangKyKhamGUI(BenhNhan bn, NhanVien taikhoan)
        {
            InitializeComponent();
            this.benhNhan = bn;
            this.taikhoan = taikhoan;
        }

     
        private void DangKyKhamGUI_Load(object sender, EventArgs e)
        {
            tb_mabn.Text = benhNhan.MaBN.ToString();
            tb_hoten.Text = benhNhan.HoTen;
            tb_stt.Text = (LichSuKhamBenhBLL.Instance.LaySoChoLonNhatTrongNgay() + 1).ToString();

        }

        private void btnDangkylayso_Click(object sender, EventArgs e)
        {
            LichSuKhamBenh lskb = new LichSuKhamBenh(int.Parse(tb_mabn.Text), int.Parse(tb_stt.Text));

            if (!BenhNhanBLL.Instance.KiemTraDangKyKham(int.Parse(tb_mabn.Text)))
            {

                if (LichSuKhamBenhBLL.Instance.Insert(lskb, taikhoan))
                {
                    XtraMessageBox.Show("Đăng ký khám thành công, Phiếu thu sẽ được in ra", "Thông báo");
                    PhieuThu report = new PhieuThu();
                    report.Parameters["HoTen"].Value = benhNhan.HoTen.ToString();
                    report.Parameters["NamSinh"].Value = benhNhan.NamSinh.ToString();
                    report.Parameters["Stt"].Value = int.Parse(tb_stt.Text).ToString();
                    report.Parameters["ThoiGian"].Value = DateTime.Now.ToString(); ;
                    report.Parameters["ChiPhi"].Value = "300000";
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreview();

                }
                else
                    XtraMessageBox.Show("Đăng ký khám thất bại", "Lỗi");
            }
            else
                XtraMessageBox.Show("Bệnh nhân đã đăng ký khám hôm nay", "Thông báo");



          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
