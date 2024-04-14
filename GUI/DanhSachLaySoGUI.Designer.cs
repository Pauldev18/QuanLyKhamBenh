
namespace GUI
{
    partial class DanhSachLaySoGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachLaySoGUI));
            this.tb_MaBn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NamSinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.dtgvDSLaySo = new System.Windows.Forms.DataGridView();
            this.SoThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhamBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.btn_GoiKham = new DevExpress.XtraEditors.SimpleButton();
            this.tb_TrangThai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ThoiGian = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Stt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSLaySo)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_MaBn
            // 
            this.tb_MaBn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaBn.Location = new System.Drawing.Point(212, 62);
            this.tb_MaBn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_MaBn.Name = "tb_MaBn";
            this.tb_MaBn.ReadOnly = true;
            this.tb_MaBn.Size = new System.Drawing.Size(153, 27);
            this.tb_MaBn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Năm sinh";
            // 
            // tb_NamSinh
            // 
            this.tb_NamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NamSinh.Location = new System.Drawing.Point(513, 31);
            this.tb_NamSinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_NamSinh.Name = "tb_NamSinh";
            this.tb_NamSinh.ReadOnly = true;
            this.tb_NamSinh.Size = new System.Drawing.Size(152, 27);
            this.tb_NamSinh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã bệnh nhân";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.dtgvDSLaySo);
            this.sidePanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidePanel2.Location = new System.Drawing.Point(24, 175);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(720, 318);
            this.sidePanel2.TabIndex = 10;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // dtgvDSLaySo
            // 
            this.dtgvDSLaySo.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSLaySo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDSLaySo.ColumnHeadersHeight = 40;
            this.dtgvDSLaySo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoThuTu,
            this.MaKhamBenh,
            this.MaBN,
            this.HoTen,
            this.NamSinh,
            this.GioiTinh,
            this.DiaChi,
            this.ThoiGian,
            this.TrangThai,
            this.SDT,
            this.Email});
            this.dtgvDSLaySo.EnableHeadersVisualStyles = false;
            this.dtgvDSLaySo.Location = new System.Drawing.Point(2, 0);
            this.dtgvDSLaySo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvDSLaySo.Name = "dtgvDSLaySo";
            this.dtgvDSLaySo.ReadOnly = true;
            this.dtgvDSLaySo.RowHeadersWidth = 51;
            this.dtgvDSLaySo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvDSLaySo.RowTemplate.Height = 40;
            this.dtgvDSLaySo.Size = new System.Drawing.Size(716, 386);
            this.dtgvDSLaySo.TabIndex = 0;
            this.dtgvDSLaySo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSLaySo_CellEnter);
            // 
            // SoThuTu
            // 
            this.SoThuTu.DataPropertyName = "SoThuTu";
            this.SoThuTu.HeaderText = "Số thứ tự";
            this.SoThuTu.MinimumWidth = 6;
            this.SoThuTu.Name = "SoThuTu";
            this.SoThuTu.ReadOnly = true;
            this.SoThuTu.Width = 125;
            // 
            // MaKhamBenh
            // 
            this.MaKhamBenh.DataPropertyName = "MaKhamBenh";
            this.MaKhamBenh.HeaderText = "Mã KB";
            this.MaKhamBenh.MinimumWidth = 6;
            this.MaKhamBenh.Name = "MaKhamBenh";
            this.MaKhamBenh.ReadOnly = true;
            this.MaKhamBenh.Visible = false;
            this.MaKhamBenh.Width = 15;
            // 
            // MaBN
            // 
            this.MaBN.DataPropertyName = "MaBN";
            this.MaBN.HeaderText = "Mã bệnh nhân";
            this.MaBN.MinimumWidth = 6;
            this.MaBN.Name = "MaBN";
            this.MaBN.ReadOnly = true;
            this.MaBN.Width = 200;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 250;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm sinh";
            this.NamSinh.MinimumWidth = 6;
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.ReadOnly = true;
            this.NamSinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Visible = false;
            this.DiaChi.Width = 125;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            this.ThoiGian.Width = 200;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 145;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Visible = false;
            this.SDT.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            this.Email.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Danh sách lấy số khám bệnh\r\n";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.btn_GoiKham);
            this.sidePanel1.Controls.Add(this.tb_TrangThai);
            this.sidePanel1.Controls.Add(this.label7);
            this.sidePanel1.Controls.Add(this.tb_ThoiGian);
            this.sidePanel1.Controls.Add(this.label6);
            this.sidePanel1.Controls.Add(this.tb_Stt);
            this.sidePanel1.Controls.Add(this.label5);
            this.sidePanel1.Controls.Add(this.label3);
            this.sidePanel1.Controls.Add(this.tb_HoTen);
            this.sidePanel1.Controls.Add(this.btnXoa);
            this.sidePanel1.Controls.Add(this.label4);
            this.sidePanel1.Controls.Add(this.sidePanel2);
            this.sidePanel1.Controls.Add(this.label2);
            this.sidePanel1.Controls.Add(this.tb_NamSinh);
            this.sidePanel1.Controls.Add(this.label1);
            this.sidePanel1.Controls.Add(this.tb_MaBn);
            this.sidePanel1.Location = new System.Drawing.Point(74, 3);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(754, 527);
            this.sidePanel1.TabIndex = 4;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // btn_GoiKham
            // 
            this.btn_GoiKham.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoiKham.Appearance.Options.UseFont = true;
            this.btn_GoiKham.Enabled = false;
            this.btn_GoiKham.ImageOptions.Image = global::GUI.Properties.Resources.doublelast_16x16;
            this.btn_GoiKham.Location = new System.Drawing.Point(520, 141);
            this.btn_GoiKham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GoiKham.Name = "btn_GoiKham";
            this.btn_GoiKham.Size = new System.Drawing.Size(112, 28);
            this.btn_GoiKham.TabIndex = 24;
            this.btn_GoiKham.Text = "Gọi Vào Khám";
            this.btn_GoiKham.Click += new System.EventHandler(this.btn_GoiKham_Click);
            // 
            // tb_TrangThai
            // 
            this.tb_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TrangThai.Location = new System.Drawing.Point(513, 93);
            this.tb_TrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_TrangThai.Name = "tb_TrangThai";
            this.tb_TrangThai.ReadOnly = true;
            this.tb_TrangThai.Size = new System.Drawing.Size(152, 27);
            this.tb_TrangThai.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Trạng thái";
            // 
            // tb_ThoiGian
            // 
            this.tb_ThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ThoiGian.Location = new System.Drawing.Point(513, 62);
            this.tb_ThoiGian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ThoiGian.Name = "tb_ThoiGian";
            this.tb_ThoiGian.ReadOnly = true;
            this.tb_ThoiGian.Size = new System.Drawing.Size(152, 27);
            this.tb_ThoiGian.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Thời gian";
            // 
            // tb_Stt
            // 
            this.tb_Stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stt.Location = new System.Drawing.Point(212, 31);
            this.tb_Stt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Stt.Name = "tb_Stt";
            this.tb_Stt.ReadOnly = true;
            this.tb_Stt.Size = new System.Drawing.Size(153, 27);
            this.tb_Stt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Số thự tự";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Họ tên";
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_HoTen.Location = new System.Drawing.Point(212, 93);
            this.tb_HoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.ReadOnly = true;
            this.tb_HoTen.Size = new System.Drawing.Size(153, 27);
            this.tb_HoTen.TabIndex = 16;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(443, 141);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 28);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // DanhSachLaySoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 540);
            this.Controls.Add(this.sidePanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DanhSachLaySoGUI";
            this.Text = "Danh Sách Lấy Số";
            this.Load += new System.EventHandler(this.DanhSachLaySoGUI_Load);
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSLaySo)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_MaBn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NamSinh;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private System.Windows.Forms.DataGridView dtgvDSLaySo;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.TextBox tb_Stt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.TextBox tb_TrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_ThoiGian;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btn_GoiKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhamBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}