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
    public partial class DanhSachLaySoGUI : Form
    {
        private bool choKham;

        LichSuKhamBenh lskb = new LichSuKhamBenh();
        public bool ChoKham
        {
            get { return choKham; }
            set { choKham = value; }
        }
        public DanhSachLaySoGUI(bool choKham)
        {
            InitializeComponent();
            this.choKham = choKham;

        }

        private void LoadDataGridView()
        {
            dtgvDSLaySo.AutoGenerateColumns = false;
            dtgvDSLaySo.DataSource = LichSuKhamBenhBLL.Instance.LayDSChoKham();
        }

        private void DanhSachLaySoGUI_Load(object sender, EventArgs e)
        {
            if(choKham)
            {
                btn_GoiKham.Enabled = true;
                btnXoa.Enabled = false;
            }
            else
            {
                btn_GoiKham.Enabled = false;
                btnXoa.Enabled = true;
            }    
               
            LoadDataGridView();
        }

        private void dtgvDSLaySo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy các trường thông tin vào các textbox
            string maKhamBenh = dtgvDSLaySo.CurrentRow.Cells["MaKhamBenh"].Value.ToString();
            tb_MaBn.Text = dtgvDSLaySo.CurrentRow.Cells["MaBN"].Value.ToString();
            tb_HoTen.Text = dtgvDSLaySo.CurrentRow.Cells["HoTen"].Value.ToString();
            tb_NamSinh.Text = dtgvDSLaySo.CurrentRow.Cells["NamSinh"].Value.ToString();
            tb_Stt.Text = dtgvDSLaySo.CurrentRow.Cells["SoThuTu"].Value.ToString();
            tb_ThoiGian.Text = dtgvDSLaySo.CurrentRow.Cells["ThoiGian"].Value.ToString();
            tb_TrangThai.Text = dtgvDSLaySo.CurrentRow.Cells["TrangThai"].Value.ToString();
            lskb = new LichSuKhamBenh(int.Parse(maKhamBenh), int.Parse(tb_MaBn.Text), DateTime.Parse(tb_ThoiGian.Text),
                int.Parse(tb_Stt.Text), tb_TrangThai.Text,tb_HoTen.Text);
           
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa số chờ này", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (LichSuKhamBenhBLL.Instance.XoaSoCho(lskb.SoThuTu))
                {
                    XtraMessageBox.Show("Xóa số chờ thành công");
                    LoadDataGridView();
                }
                else
                    XtraMessageBox.Show("Xóa số chờ thất bại", "Lỗi");
            }
        }
        private void goiKhamGUI_UpdateEventHandler1(object sender, GoiKhamGUI.UpdateEventArgs args)
        {

            LoadDataGridView();

        }
        private void btn_GoiKham_Click(object sender, EventArgs e)
        {
            GoiKhamGUI goiKhamGUI = new GoiKhamGUI(lskb,this);
            goiKhamGUI.UpdateEventHandler += goiKhamGUI_UpdateEventHandler1;
            goiKhamGUI.ShowDialog();
        }

     
    }

}
