
namespace GUI
{
    partial class DoiMatKhauGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhauGUI));
            this.label2 = new System.Windows.Forms.Label();
            this.tbMatKhauCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNhapLaiMKMoi = new System.Windows.Forms.TextBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // tbMatKhauCu
            // 
            this.tbMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhauCu.Location = new System.Drawing.Point(219, 112);
            this.tbMatKhauCu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMatKhauCu.Name = "tbMatKhauCu";
            this.tbMatKhauCu.Size = new System.Drawing.Size(160, 26);
            this.tbMatKhauCu.TabIndex = 5;
            this.tbMatKhauCu.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mật khẩu mới";
            // 
            // tbMatKhauMoi
            // 
            this.tbMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhauMoi.Location = new System.Drawing.Point(219, 158);
            this.tbMatKhauMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMatKhauMoi.Name = "tbMatKhauMoi";
            this.tbMatKhauMoi.Size = new System.Drawing.Size(160, 26);
            this.tbMatKhauMoi.TabIndex = 12;
            this.tbMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // tbNhapLaiMKMoi
            // 
            this.tbNhapLaiMKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhapLaiMKMoi.Location = new System.Drawing.Point(219, 206);
            this.tbNhapLaiMKMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNhapLaiMKMoi.Name = "tbNhapLaiMKMoi";
            this.tbNhapLaiMKMoi.Size = new System.Drawing.Size(160, 26);
            this.tbNhapLaiMKMoi.TabIndex = 14;
            this.tbNhapLaiMKMoi.UseSystemPasswordChar = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(254, 267);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 28);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(110, 267);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 28);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tbMatKhauMoi);
            this.sidePanel1.Controls.Add(this.label3);
            this.sidePanel1.Controls.Add(this.tbMatKhauCu);
            this.sidePanel1.Controls.Add(this.tbNhapLaiMKMoi);
            this.sidePanel1.Controls.Add(this.label2);
            this.sidePanel1.Controls.Add(this.label1);
            this.sidePanel1.Controls.Add(this.btnLuu);
            this.sidePanel1.Controls.Add(this.btnHuy);
            this.sidePanel1.Location = new System.Drawing.Point(270, 2);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(448, 566);
            this.sidePanel1.TabIndex = 16;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // DoiMatKhauGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 613);
            this.Controls.Add(this.sidePanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DoiMatKhauGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMatKhauCu;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNhapLaiMKMoi;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
    }
}