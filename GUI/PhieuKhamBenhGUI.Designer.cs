namespace GUI
{
    partial class PhieuKhamBenhGUI
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
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_mabn = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_sodt = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_namsinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_trieuchung = new System.Windows.Forms.TextBox();
            this.tb_chandoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_tsbbanthan = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_GhiChu = new System.Windows.Forms.TextBox();
            this.tb_KeHoachDieuTri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ThoiGian = new System.Windows.Forms.TextBox();
            this.data_khambenh = new System.Windows.Forms.DataGridView();
            this.txt_makhambenh = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelChucNang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_khambenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChucNang
            // 
            this.panelChucNang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelChucNang.Controls.Add(this.buttonLuu);
            this.panelChucNang.Controls.Add(this.buttonReset);
            this.panelChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChucNang.Location = new System.Drawing.Point(42, 11);
            this.panelChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(806, 56);
            this.panelChucNang.TabIndex = 6;
            // 
            // buttonLuu
            // 
            this.buttonLuu.AutoSize = true;
            this.buttonLuu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.buttonLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLuu.Location = new System.Drawing.Point(553, 10);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(117, 39);
            this.buttonLuu.TabIndex = 2;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonReset.FlatAppearance.BorderSize = 3;
            this.buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.buttonReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonReset.Location = new System.Drawing.Point(159, 10);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(102, 39);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txt_makhambenh);
            this.groupBox1.Controls.Add(this.tb_mabn);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tb_sodt);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_namsinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_hoten);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbbGioiTinh);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(40, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(808, 174);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "I. Hành Chính";
            // 
            // tb_mabn
            // 
            this.tb_mabn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_mabn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mabn.Location = new System.Drawing.Point(562, 39);
            this.tb_mabn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_mabn.Name = "tb_mabn";
            this.tb_mabn.ReadOnly = true;
            this.tb_mabn.Size = new System.Drawing.Size(243, 27);
            this.tb_mabn.TabIndex = 114;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(440, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 18);
            this.label15.TabIndex = 113;
            this.label15.Text = "Mã bệnh nhân";
            // 
            // tb_sodt
            // 
            this.tb_sodt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_sodt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sodt.Location = new System.Drawing.Point(562, 102);
            this.tb_sodt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sodt.Name = "tb_sodt";
            this.tb_sodt.ReadOnly = true;
            this.tb_sodt.Size = new System.Drawing.Size(243, 27);
            this.tb_sodt.TabIndex = 72;
            // 
            // tb_email
            // 
            this.tb_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(562, 136);
            this.tb_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(243, 27);
            this.tb_email.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã khám bệnh";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diachi.Location = new System.Drawing.Point(562, 70);
            this.tb_diachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.ReadOnly = true;
            this.tb_diachi.Size = new System.Drawing.Size(243, 27);
            this.tb_diachi.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(443, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Email";
            // 
            // tb_namsinh
            // 
            this.tb_namsinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_namsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_namsinh.Location = new System.Drawing.Point(159, 103);
            this.tb_namsinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_namsinh.Name = "tb_namsinh";
            this.tb_namsinh.ReadOnly = true;
            this.tb_namsinh.Size = new System.Drawing.Size(193, 27);
            this.tb_namsinh.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(439, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Số điện thoại";
            // 
            // tb_hoten
            // 
            this.tb_hoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hoten.Location = new System.Drawing.Point(159, 70);
            this.tb_hoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.ReadOnly = true;
            this.tb_hoten.Size = new System.Drawing.Size(193, 27);
            this.tb_hoten.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(439, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 64;
            this.label10.Text = "Địa chỉ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(37, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 18);
            this.label13.TabIndex = 61;
            this.label13.Text = "Họ tên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(37, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 62;
            this.label12.Text = "Năm sinh";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.Enabled = false;
            this.cbbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(159, 134);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(193, 30);
            this.cbbGioiTinh.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(37, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 63;
            this.label11.Text = "Giới tính";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_trieuchung);
            this.groupBox2.Controls.Add(this.tb_chandoan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_tsbbanthan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(40, 242);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(808, 158);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "II. Hỏi Bệnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "2. Triệu chứng";
            // 
            // tb_trieuchung
            // 
            this.tb_trieuchung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_trieuchung.Location = new System.Drawing.Point(193, 84);
            this.tb_trieuchung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_trieuchung.Name = "tb_trieuchung";
            this.tb_trieuchung.Size = new System.Drawing.Size(613, 26);
            this.tb_trieuchung.TabIndex = 5;
            // 
            // tb_chandoan
            // 
            this.tb_chandoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_chandoan.Location = new System.Drawing.Point(193, 124);
            this.tb_chandoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_chandoan.Name = "tb_chandoan";
            this.tb_chandoan.Size = new System.Drawing.Size(613, 26);
            this.tb_chandoan.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(35, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "3. Chẩn đoán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(35, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "1. Tiền sử bệnh";
            // 
            // tb_tsbbanthan
            // 
            this.tb_tsbbanthan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_tsbbanthan.Location = new System.Drawing.Point(193, 42);
            this.tb_tsbbanthan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tsbbanthan.Name = "tb_tsbbanthan";
            this.tb_tsbbanthan.Size = new System.Drawing.Size(613, 26);
            this.tb_tsbbanthan.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tb_GhiChu);
            this.groupBox4.Controls.Add(this.tb_KeHoachDieuTri);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tb_ThoiGian);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(42, 404);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(808, 170);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "III. Kế Hoạch Điều Trị";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(30, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "3. Ghi chú";
            // 
            // tb_GhiChu
            // 
            this.tb_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_GhiChu.Location = new System.Drawing.Point(188, 125);
            this.tb_GhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_GhiChu.Name = "tb_GhiChu";
            this.tb_GhiChu.Size = new System.Drawing.Size(619, 26);
            this.tb_GhiChu.TabIndex = 7;
            // 
            // tb_KeHoachDieuTri
            // 
            this.tb_KeHoachDieuTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_KeHoachDieuTri.Location = new System.Drawing.Point(188, 42);
            this.tb_KeHoachDieuTri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_KeHoachDieuTri.Name = "tb_KeHoachDieuTri";
            this.tb_KeHoachDieuTri.Size = new System.Drawing.Size(619, 26);
            this.tb_KeHoachDieuTri.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "1. Kế hoạch điều trị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(30, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "2. Thời gian";
            // 
            // tb_ThoiGian
            // 
            this.tb_ThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_ThoiGian.Location = new System.Drawing.Point(188, 83);
            this.tb_ThoiGian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ThoiGian.Name = "tb_ThoiGian";
            this.tb_ThoiGian.Size = new System.Drawing.Size(619, 26);
            this.tb_ThoiGian.TabIndex = 5;
            // 
            // data_khambenh
            // 
            this.data_khambenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_khambenh.Location = new System.Drawing.Point(1040, 103);
            this.data_khambenh.Name = "data_khambenh";
            this.data_khambenh.Size = new System.Drawing.Size(650, 509);
            this.data_khambenh.TabIndex = 24;
            this.data_khambenh.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_khambenh_CellEnter);
            // 
            // txt_makhambenh
            // 
            this.txt_makhambenh.Enabled = false;
            this.txt_makhambenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makhambenh.Location = new System.Drawing.Point(159, 37);
            this.txt_makhambenh.Name = "txt_makhambenh";
            this.txt_makhambenh.Size = new System.Drawing.Size(193, 26);
            this.txt_makhambenh.TabIndex = 115;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // PhieuKhamBenhGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 624);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.data_khambenh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelChucNang);
            this.IconOptions.Image = global::GUI.Properties.Resources.hospital;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PhieuKhamBenhGUI";
            this.Text = "Phiếu Khám Bệnh";
            this.Load += new System.EventHandler(this.PhieuKhamBenhGUI_Load);
            this.panelChucNang.ResumeLayout(false);
            this.panelChucNang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_khambenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_chandoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_tsbbanthan;
        private System.Windows.Forms.TextBox tb_sodt;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_namsinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_trieuchung;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_KeHoachDieuTri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_ThoiGian;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_GhiChu;
        private System.Windows.Forms.TextBox tb_mabn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView data_khambenh;
        private System.Windows.Forms.TextBox txt_makhambenh;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}