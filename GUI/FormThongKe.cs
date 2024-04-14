using BLL;
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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               

                // Kiểm tra năm nhập vào
                if (!int.TryParse(txt_nam.Text, out int year))
                {
                    MessageBox.Show("Vui lòng nhập năm là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nam.Focus();
                  
                    return;
                }

              

                DataTable dt = ThongKeBLL.Instance.thongke(txt_nam.Text);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Đặt dữ liệu vào biểu đồ
                    c_R_A.DataSource = dt;
                    c_R_A.Series["Doanh Thu"].XValueMember = "Thang";
                    c_R_A.Series["Doanh Thu"].YValueMembers = "DoanhThu";

                    // Đặt tiêu đề cho trục X và trục Y
                    c_R_A.ChartAreas[0].AxisX.Title = "Tháng";
                    c_R_A.ChartAreas[0].AxisY.Title = "Doanh thu";

                    // Hiển thị biểu đồ
                    c_R_A.DataBind();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu doanh thu cho năm " + year, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Thang", typeof(int));
            dt.Columns.Add("DoanhThu", typeof(int));
            for (int i = 1; i <= 7; i++)
            {
                dt.Rows.Add(i, 0);
            }
            c_R_A.DataSource = dt;
            c_R_A.Series["Doanh Thu"].XValueMember = "Thang";
            c_R_A.Series["Doanh Thu"].YValueMembers = "DoanhThu";

           
            c_R_A.ChartAreas[0].AxisX.Title = "Tháng";
            c_R_A.ChartAreas[0].AxisY.Title = "Doanh thu";

          
            c_R_A.DataBind();
        }
    }
}
