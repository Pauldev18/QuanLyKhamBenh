namespace GUI
{
    partial class QuanLyChung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyChung));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangKyLaySo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuKhamBenh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTinTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnBenhNhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnChoKham = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage_hethong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpg_HeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage_nghiepvu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpg_QuanLy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg_ChoKham = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg_KhamBenh = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(57);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnDangKyLaySo,
            this.btn_DoiMatKhau,
            this.btn_DangXuat,
            this.btnPhieuKhamBenh,
            this.btnThongTinTaiKhoan,
            this.btnBenhNhan,
            this.btnChoKham});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.ribbon.MaxItemId = 39;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 644;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_hethong,
            this.ribbonPage_nghiepvu});
            this.ribbon.Size = new System.Drawing.Size(1717, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDangKyLaySo
            // 
            this.btnDangKyLaySo.Caption = "Đăng ký lấy số";
            this.btnDangKyLaySo.Id = 1;
            this.btnDangKyLaySo.ImageOptions.Image = global::GUI.Properties.Resources.Ecommerce_Bill_icon;
            this.btnDangKyLaySo.Name = "btnDangKyLaySo";
            this.btnDangKyLaySo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangKyLaySo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKyLaySo_ItemClick);
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.Caption = "Đổi mật khẩu";
            this.btn_DoiMatKhau.Id = 5;
            this.btn_DoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DoiMatKhau.ImageOptions.Image")));
            this.btn_DoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DoiMatKhau.ImageOptions.LargeImage")));
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDoiMatKhau_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng xuất";
            this.btn_DangXuat.Id = 6;
            this.btn_DangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.Image")));
            this.btn_DangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.LargeImage")));
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // btnPhieuKhamBenh
            // 
            this.btnPhieuKhamBenh.Caption = "Phiếu Khám Bệnh";
            this.btnPhieuKhamBenh.Id = 15;
            this.btnPhieuKhamBenh.ImageOptions.Image = global::GUI.Properties.Resources.textbox_16x16;
            this.btnPhieuKhamBenh.ImageOptions.LargeImage = global::GUI.Properties.Resources.textbox_32x32;
            this.btnPhieuKhamBenh.ItemAppearance.Disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuKhamBenh.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnPhieuKhamBenh.Name = "btnPhieuKhamBenh";
            this.btnPhieuKhamBenh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhieuKhamBenh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuKhamBenh_ItemClick);
            // 
            // btnThongTinTaiKhoan
            // 
            this.btnThongTinTaiKhoan.Caption = "Thông tin tài khoản";
            this.btnThongTinTaiKhoan.Id = 31;
            this.btnThongTinTaiKhoan.ImageOptions.Image = global::GUI.Properties.Resources.user_info_icon;
            this.btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            this.btnThongTinTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThongTinTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongTinTaiKhoan_ItemClick);
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.Caption = "Bệnh Nhân";
            this.btnBenhNhan.Id = 34;
            this.btnBenhNhan.ImageOptions.Image = global::GUI.Properties.Resources.User_Group_icon;
            this.btnBenhNhan.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenhNhan.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBenhNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBenhNhan_ItemClick);
            // 
            // btnChoKham
            // 
            this.btnChoKham.Caption = "DS Chờ Khám";
            this.btnChoKham.Id = 37;
            this.btnChoKham.ImageOptions.Image = global::GUI.Properties.Resources.listbullets_16x161;
            this.btnChoKham.ImageOptions.LargeImage = global::GUI.Properties.Resources.listbullets_32x321;
            this.btnChoKham.Name = "btnChoKham";
            this.btnChoKham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChoKham_ItemClick);
            // 
            // ribbonPage_hethong
            // 
            this.ribbonPage_hethong.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage_hethong.Appearance.Options.UseFont = true;
            this.ribbonPage_hethong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpg_HeThong});
            this.ribbonPage_hethong.Name = "ribbonPage_hethong";
            this.ribbonPage_hethong.Text = "Quản trị hệ thống";
            // 
            // rpg_HeThong
            // 
            this.rpg_HeThong.ItemLinks.Add(this.btn_DoiMatKhau);
            this.rpg_HeThong.ItemLinks.Add(this.btn_DangXuat);
            this.rpg_HeThong.ItemLinks.Add(this.btnThongTinTaiKhoan);
            this.rpg_HeThong.Name = "rpg_HeThong";
            this.rpg_HeThong.Text = "Hệ Thống";
            // 
            // ribbonPage_nghiepvu
            // 
            this.ribbonPage_nghiepvu.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage_nghiepvu.Appearance.Options.UseFont = true;
            this.ribbonPage_nghiepvu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpg_QuanLy,
            this.rpg_ChoKham,
            this.rpg_KhamBenh});
            this.ribbonPage_nghiepvu.Name = "ribbonPage_nghiepvu";
            this.ribbonPage_nghiepvu.Text = "Quản lý nghiệp vụ";
            // 
            // rpg_QuanLy
            // 
            this.rpg_QuanLy.AllowTextClipping = false;
            this.rpg_QuanLy.ItemLinks.Add(this.btnBenhNhan);
            this.rpg_QuanLy.ItemLinks.Add(this.btnDangKyLaySo);
            this.rpg_QuanLy.Name = "rpg_QuanLy";
            this.rpg_QuanLy.Text = "Quản lý";
            this.rpg_QuanLy.Visible = false;
            // 
            // rpg_ChoKham
            // 
            this.rpg_ChoKham.AllowTextClipping = false;
            this.rpg_ChoKham.ItemLinks.Add(this.btnChoKham);
            this.rpg_ChoKham.Name = "rpg_ChoKham";
            this.rpg_ChoKham.Text = "DS Chờ Khám";
            this.rpg_ChoKham.Visible = false;
            // 
            // rpg_KhamBenh
            // 
            this.rpg_KhamBenh.AllowTextClipping = false;
            this.rpg_KhamBenh.ItemLinks.Add(this.btnPhieuKhamBenh);
            this.rpg_KhamBenh.Name = "rpg_KhamBenh";
            this.rpg_KhamBenh.Text = "Khám Bệnh";
            this.rpg_KhamBenh.Visible = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 888);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1717, 24);
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.BackgroundImage = global::GUI.Properties.Resources.background_2;
            this.panelMain.Location = new System.Drawing.Point(0, 489);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(0, 0);
            this.panelMain.TabIndex = 3;
            // 
            // QuanLyChung
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::GUI.Properties.Resources.background_2;
            this.ClientSize = new System.Drawing.Size(1717, 912);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("QuanLyChung.IconOptions.Icon")));
            this.IconOptions.Image = global::GUI.Properties.Resources.hospital;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "QuanLyChung";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "PHẦN MỀM QUẢN LÝ PHÒNG KHÁM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyChung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_hethong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDangKyLaySo;
        private DevExpress.XtraBars.BarButtonItem btn_DoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_nghiepvu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_QuanLy;
        private DevExpress.XtraBars.BarButtonItem btnPhieuKhamBenh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_KhamBenh;
        private DevExpress.XtraBars.BarButtonItem btnThongTinTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnBenhNhan;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraBars.BarButtonItem btnChoKham;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_ChoKham;
    }
}