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
using DevExpress.XtraRichEdit.API.Layout;
using DTO;

namespace GUI
{ 
    public partial class GoiKhamGUI : Form
    {
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void edit()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        LichSuKhamBenh lskb = new LichSuKhamBenh();
        public LichSuKhamBenh lichSuKhamBenh
        {
            get { return lskb; }
            set { lskb = value; }
        }
        public GoiKhamGUI(LichSuKhamBenh lskb, DanhSachLaySoGUI danhSachLaySoGUI)
        {
            InitializeComponent();
            this.lskb = lskb;
        }

     
        private void GoiKhamGUI_Load(object sender, EventArgs e)
        {
            tb_mabn.Text = lskb.MaBN.ToString();
            tb_hoten.Text = lskb.HoTen;
            tb_stt.Text = lskb.SoThuTu.ToString();

        }

        private void btnGoiKham_Click(object sender, EventArgs e)
        {
            
            if (LichSuKhamBenhBLL.Instance.GoiKham(lskb.MaKhamBenh))
            {
                DialogResult result2 = MessageBox.Show("Đã gọi bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    this.Close();
                    edit();
                }
            }
        }

          
       

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
