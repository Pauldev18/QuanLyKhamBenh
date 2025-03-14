USE [QuanLyKhamBenh]
GO
/****** Object:  Table [dbo].[BENHNHAN]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENHNHAN](
	[MaBN] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](150) NOT NULL,
	[NamSinh] [int] NOT NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SDT] [char](10) NULL,
	[Email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LICHSUKHAMBENH]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICHSUKHAMBENH](
	[MaKhamBenh] [int] IDENTITY(1,1) NOT NULL,
	[MaBN] [int] NOT NULL,
	[ThoiGian] [datetime] NULL,
	[SoThuTu] [int] NOT NULL,
	[TrangThai] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhamBenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAINHANVIEN]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAINHANVIEN](
	[MaLoaiNV] [int] NOT NULL,
	[TenLoaiNV] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[TenDangNhap] [varchar](100) NULL,
	[MatKhau] [varchar](100) NULL,
	[MaLoaiNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUKHAMBENH]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUKHAMBENH](
	[MaKhamBenh] [int] NULL,
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaBacSi] [varchar](10) NULL,
	[ThoiGian] [datetime] NULL,
	[TienSuBenh] [nvarchar](300) NULL,
	[TrieuChung] [nvarchar](400) NULL,
	[ChuanDoan] [nvarchar](300) NULL,
	[GhiChu] [nvarchar](500) NULL,
	[KeHoachDieuTri] [nvarchar](500) NULL,
	[ThoiGianDieuTri] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHU]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHU](
	[MaKhamBenh] [int] NULL,
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[ChiPhi] [int] NULL,
	[ThoiGian] [datetime] NULL,
	[MaNhanVien] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BENHNHAN] ON 

CREATE TABLE BenhNhanCapCuu
(
	MaCapCuu int identity(1,1) primary key,
	HoTen nvarchar(255) not null,
	DiaChi nvarchar(255),
	NamSinh nvarchar(255),
	SDT nvarchar(255),
	GioiTinh nvarchar(255),
	Email nvarchar(255),
	TienSuBenh nvarchar(255),
	TrieuChung nvarchar(255),
	ChuanDoan nvarchar(255),
	KeHoachDieuTri nvarchar(255),
	ThoiGian nvarchar(255),
	GhiChu nvarchar(255)
)

INSERT [dbo].[BENHNHAN] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [Email]) VALUES (3, N'Nguyễn Nhật Nam', 2003, N'Nam', N'Thành phố Châu Đốc, An Giang', N'0385952657', N'nguyennhatnam@gmail.com')
INSERT [dbo].[BENHNHAN] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [Email]) VALUES (4, N'Lê Quang Long', 2002, N'Nam', N'Long Xuyen, An Giang', N'0923876778', N'Long@gmail.com')
INSERT [dbo].[BENHNHAN] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [Email]) VALUES (5, N'Đặng Tiến Mẫn', 2002, N'Nam', N'Tịnh Biên, An Giang', N'0937767778', N'man@gmail.com')
INSERT [dbo].[BENHNHAN] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [Email]) VALUES (6, N'Cao Văn Lư', 1992, N'Nam', N'Thoai Son An Giang', N'0976765467', N'lu1992@gmail.com')
INSERT [dbo].[BENHNHAN] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [Email]) VALUES (7, N'Đào Văn Hoa', 2000, N'Nam', N'An Giang', N'0956565467', N'hoa@gmail.com')
INSERT [dbo].[BENHNHAN] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [Email]) VALUES (8, N'Nguyen Anh Kiet', 2002, N'Nam', N'', N'0988887777', N'')
INSERT [dbo].[BENHNHAN] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [Email]) VALUES (9, N'Nguyen Anh Kiet', 2002, N'Nam', N'', N'0988887777', N'')
SET IDENTITY_INSERT [dbo].[BENHNHAN] OFF
GO
SET IDENTITY_INSERT [dbo].[LICHSUKHAMBENH] ON 

INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (2, 3, CAST(N'2024-04-01T17:34:20.393' AS DateTime), 1, N'Đã khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (3, 4, CAST(N'2024-04-01T17:37:26.093' AS DateTime), 2, N'Đã khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (4, 5, CAST(N'2024-04-01T21:16:56.557' AS DateTime), 3, N'Đã khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (16, 5, CAST(N'2024-04-01T22:44:10.667' AS DateTime), 4, N'Chưa khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (17, 3, CAST(N'2024-04-01T22:49:20.610' AS DateTime), 5, N'Chưa khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (18, 3, CAST(N'2024-04-02T00:25:23.240' AS DateTime), 2, N'Đã khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (22, 5, CAST(N'2024-04-02T00:42:38.937' AS DateTime), 3, N'Đã gọi')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (23, 3, CAST(N'2024-04-03T09:12:29.883' AS DateTime), 2, N'Đã khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (24, 3, CAST(N'2024-04-03T15:05:55.703' AS DateTime), 3, N'Đã khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (25, 4, CAST(N'2024-04-03T15:06:11.267' AS DateTime), 4, N'Chưa khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (26, 5, CAST(N'2024-04-03T15:06:25.077' AS DateTime), 5, N'Chưa khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (27, 8, CAST(N'2024-04-03T20:20:09.230' AS DateTime), 6, N'Chưa khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (29, 6, CAST(N'2024-04-04T12:25:42.730' AS DateTime), 2, N'Đã khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (30, 9, CAST(N'2024-04-04T13:26:05.710' AS DateTime), 3, N'Đã khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (31, 9, CAST(N'2024-04-04T13:32:15.890' AS DateTime), 4, N'Đã khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (32, 8, CAST(N'2024-04-04T13:34:37.220' AS DateTime), 5, N'Đã khám')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (33, 6, CAST(N'2024-04-04T13:34:59.260' AS DateTime), 6, N'Đã gọi')
INSERT [dbo].[LICHSUKHAMBENH] ([MaKhamBenh], [MaBN], [ThoiGian], [SoThuTu], [TrangThai]) VALUES (34, 4, CAST(N'2024-04-04T13:35:13.850' AS DateTime), 7, N'Đã gọi')
SET IDENTITY_INSERT [dbo].[LICHSUKHAMBENH] OFF
GO
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNV]) VALUES (1, N'Chăm sóc khách hàng')
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNV]) VALUES (2, N'Điều dưỡng')
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNV]) VALUES (3, N'Bác sỹ')
GO
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [NgaySinh], [GioiTinh], [TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (N'BS01', N'Bác Sĩ', CAST(N'1975-01-17' AS Date), N'Nam', N'bacsi', N'123', 3)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [NgaySinh], [GioiTinh], [TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (N'CSKH01', N'Lê Đào Thành Khoa', CAST(N'1980-05-05' AS Date), N'Nam', N'Thanhkhoa', N'123', 1)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTen], [NgaySinh], [GioiTinh], [TenDangNhap], [MatKhau], [MaLoaiNV]) VALUES (N'DD01', N'Trần Đình Nam', CAST(N'1990-10-03' AS Date), N'Nam', N'trandinhnam', N'123', 2)
GO
SET IDENTITY_INSERT [dbo].[PHIEUKHAMBENH] ON 

INSERT [dbo].[PHIEUKHAMBENH] ([MaKhamBenh], [MaHoaDon], [MaBacSi], [ThoiGian], [TienSuBenh], [TrieuChung], [ChuanDoan], [GhiChu], [KeHoachDieuTri], [ThoiGianDieuTri]) VALUES (16, 1, N'BS01', CAST(N'2024-04-01T23:55:00.160' AS DateTime), N'f', N'f', N'f', N'f', N'f', N'f')
INSERT [dbo].[PHIEUKHAMBENH] ([MaKhamBenh], [MaHoaDon], [MaBacSi], [ThoiGian], [TienSuBenh], [TrieuChung], [ChuanDoan], [GhiChu], [KeHoachDieuTri], [ThoiGianDieuTri]) VALUES (31, 2, N'BS01', CAST(N'2024-04-04T13:33:55.067' AS DateTime), N'', N'', N'', N'', N'', N'')
INSERT [dbo].[PHIEUKHAMBENH] ([MaKhamBenh], [MaHoaDon], [MaBacSi], [ThoiGian], [TienSuBenh], [TrieuChung], [ChuanDoan], [GhiChu], [KeHoachDieuTri], [ThoiGianDieuTri]) VALUES (32, 3, N'BS01', CAST(N'2024-04-04T13:37:11.080' AS DateTime), N'khong k', N'fgg', N'dd', N'skkd', N'dff', N'dd')
SET IDENTITY_INSERT [dbo].[PHIEUKHAMBENH] OFF
GO
SET IDENTITY_INSERT [dbo].[PHIEUTHU] ON 

INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (4, 1, 300000, CAST(N'2024-04-01T21:16:56.557' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (16, 13, 300000, CAST(N'2024-04-01T22:44:10.667' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (17, 14, 300000, CAST(N'2024-04-01T22:49:20.610' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (18, 15, 300000, CAST(N'2024-04-02T00:25:23.243' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (22, 19, 300000, CAST(N'2024-04-02T00:42:38.940' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (23, 20, 300000, CAST(N'2024-04-03T09:12:29.893' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (24, 21, 300000, CAST(N'2024-04-03T15:05:55.993' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (25, 22, 300000, CAST(N'2024-04-03T15:06:11.540' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (26, 23, 300000, CAST(N'2024-04-03T15:06:25.360' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (27, 24, 300000, CAST(N'2024-04-03T20:20:09.233' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (29, 26, 300000, CAST(N'2024-04-04T12:25:43.027' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (30, 27, 300000, CAST(N'2024-04-04T13:26:05.713' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (31, 28, 300000, CAST(N'2024-04-04T13:32:16.183' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (32, 29, 300000, CAST(N'2024-04-04T13:34:37.220' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (33, 30, 300000, CAST(N'2024-04-04T13:34:59.557' AS DateTime), N'CSKH01')
INSERT [dbo].[PHIEUTHU] ([MaKhamBenh], [MaHoaDon], [ChiPhi], [ThoiGian], [MaNhanVien]) VALUES (34, 31, 300000, CAST(N'2024-04-04T13:35:14.140' AS DateTime), N'CSKH01')
SET IDENTITY_INSERT [dbo].[PHIEUTHU] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NHANVIEN__55F68FC077CB4468]    Script Date: 4/4/2024 1:45:26 PM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LICHSUKHAMBENH] ADD  DEFAULT (getdate()) FOR [ThoiGian]
GO
ALTER TABLE [dbo].[PHIEUKHAMBENH] ADD  DEFAULT (getdate()) FOR [ThoiGian]
GO
ALTER TABLE [dbo].[PHIEUTHU] ADD  DEFAULT (getdate()) FOR [ThoiGian]
GO
ALTER TABLE [dbo].[LICHSUKHAMBENH]  WITH CHECK ADD FOREIGN KEY([MaBN])
REFERENCES [dbo].[BENHNHAN] ([MaBN])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LOAINHANVIEN] ([MaLoaiNV])
GO
ALTER TABLE [dbo].[PHIEUKHAMBENH]  WITH CHECK ADD FOREIGN KEY([MaBacSi])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUKHAMBENH]  WITH CHECK ADD FOREIGN KEY([MaKhamBenh])
REFERENCES [dbo].[LICHSUKHAMBENH] ([MaKhamBenh])
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD FOREIGN KEY([MaKhamBenh])
REFERENCES [dbo].[LICHSUKHAMBENH] ([MaKhamBenh])
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
/****** Object:  StoredProcedure [dbo].[Proc_DangNhap]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Proc_DangNhap]
@TenDangNhap VARCHAR(100), @MatKhau VARCHAR(500)
AS
	SELECT *
	FROM dbo.NhanVien
	WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau
GO
/****** Object:  StoredProcedure [dbo].[Proc_DoiMatKhau]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Proc_DoiMatKhau]
@tenDangNhap VARCHAR(100), @matKhauCu VARCHAR(100), @matKhauMoi VARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM NhanVien WHERE TenDangNhap = @tenDangNhap and MatKhau = @matKhauCu
	IF (@isRightPass = 1)
	BEGIN
		IF (@matKhauMoi != null or @matKhauMoi != '')
			UPDATE NhanVien SET MatKhau = @matKhauMoi WHERE TenDangNhap = @tenDangNhap 
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Proc_GoiKham]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     PROC [dbo].[Proc_GoiKham] @maKhamBenh int
AS
	update LichSuKhamBenh set TrangThai = N'Đã gọi'where MaKhamBenh = @maKhamBenh
GO
/****** Object:  StoredProcedure [dbo].[Proc_KiemTraDangKyKham]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Proc_KiemTraDangKyKham] @mabn int
AS
	SELECT * FROM dbo.LichSuKhamBenh where MaBN = @mabn 
	and CONVERT(DATE, ThoiGian) =  CONVERT(DATE, GETDATE()) and TrangThai = N'Chưa khám' 
GO
/****** Object:  StoredProcedure [dbo].[Proc_LayDSChoKham]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE    PROC [dbo].[Proc_LayDSChoKham]
AS

	SELECT lskb.MaKhamBenh,lskb.MaBN,lskb.ThoiGian,lskb.SoThuTu,lskb.TrangThai,
	bn.HoTen,bn.NamSinh,bn.GioiTinh,bn.DiaChi,bn.SDT,bn.Email
	FROM  LichSuKhamBenh lskb, BenhNhan bn
	where CONVERT(DATE, lskb.ThoiGian) =  CONVERT(DATE, GETDATE()) 
	and lskb.TrangThai = N'Chưa khám' and lskb.MaBN = bn.MaBN
GO
/****** Object:  StoredProcedure [dbo].[Proc_LayDSGoiKham]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE    PROC [dbo].[Proc_LayDSGoiKham]
AS

	SELECT lskb.MaKhamBenh,lskb.MaBN,lskb.ThoiGian,lskb.SoThuTu,lskb.TrangThai,
	bn.HoTen,bn.NamSinh,bn.GioiTinh,bn.DiaChi,bn.SDT,bn.Email
	FROM  LichSuKhamBenh lskb, BenhNhan bn
	where CONVERT(DATE, lskb.ThoiGian) =  CONVERT(DATE, GETDATE()) 
	and lskb.TrangThai = N'Đã gọi' and lskb.MaBN = bn.MaBN
GO
/****** Object:  StoredProcedure [dbo].[Proc_LayDSLichSuKhamBenh]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Proc_LayDSLichSuKhamBenh] @mabn int
AS
	SELECT * FROM dbo.LichSuKhamBenh where MaBN = @mabn
GO
/****** Object:  StoredProcedure [dbo].[Proc_LayNhanVienTheoTenDangNhap]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE    PROC [dbo].[Proc_LayNhanVienTheoTenDangNhap]
@TenDangNhap VARCHAR(100)
AS
	SELECT *
	FROM dbo.NhanVien
	WHERE TenDangNhap = @TenDangNhap
GO
/****** Object:  StoredProcedure [dbo].[Proc_LaySoChoLonNhatTrongNgay]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE    PROC [dbo].[Proc_LaySoChoLonNhatTrongNgay]
AS
	SELECT Max(SoThuTu)
	FROM  LichSuKhamBenh lskb
	where CONVERT(DATE, lskb.ThoiGian) =  CONVERT(DATE, GETDATE()) 
	
GO
/****** Object:  StoredProcedure [dbo].[Proc_LayTatCaDSBenhNhan]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Proc_LayTatCaDSBenhNhan]
AS
	SELECT *
	FROM  dbo.BenhNhan 
GO
/****** Object:  StoredProcedure [dbo].[Proc_LayTatCaDSLoaiNhanVien]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Proc_LayTatCaDSLoaiNhanVien]
AS
	SELECT ltk.MaLoaiNV, ltk.TenLoaiNV
	FROM  dbo.LoaiNhanVien ltk 
GO
/****** Object:  StoredProcedure [dbo].[Proc_SuaBenhNhan]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Proc_SuaBenhNhan] @mabn int, @hoTen NVARCHAR(150), @namSinh int, 
@gioiTinh nvarchar(3), @diaChi nvarchar(200), @sdt char(10),@email varchar(50)
AS
	update BenhNhan set HoTen = @hoTen,NamSinh = @namSinh,GioiTinh = @gioiTinh,
	DiaChi = @diaChi,SDT=@sdt, Email = @email where MaBn = @mabn

GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemBenhNhan]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Proc_ThemBenhNhan] @hoTen NVARCHAR(150), @namSinh int, 
@gioiTinh nvarchar(3), @diaChi nvarchar(200), @sdt char(10),@email varchar(50)
AS
	Insert BenhNhan(HoTen,NamSinh,GioiTinh,DiaChi,SDT,Email) 
	values (@hoTen,@namSinh,@gioiTinh,@diaChi,@sdt,@email)

GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemLSKB]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE    PROC [dbo].[Proc_ThemLSKB] @mabn int, @stt int, @manhanvien varchar(10)
AS
	
	Insert LichSuKhamBenh(MaBN,ThoiGian,SoThuTu,TrangThai) 
	values (@mabn,getdate(),@stt,N'Chưa khám')
	Declare @makhambenh int
	set @makhambenh = (select Max(MaKhamBenh) from LICHSUKHAMBENH)
	insert PhieuThu(MaKhamBenh, ChiPhi, ThoiGian, MaNhanVien)
	values(@makhambenh, 300000, getdate(),@manhanvien)

GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemPhieuKhamBenh]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     PROC [dbo].[Proc_ThemPhieuKhamBenh] @maKhamBenh int, @maBacSi varchar(10), 
@TienSuBenh nvarchar(300), @TrieuChung nvarchar(400), @chandoan nvarchar(300),
@ghichu nvarchar(500),@keHoachDieuTri nvarchar(500), @thoiGianDieuTri nvarchar(100)
AS
	Insert PhieuKhamBenh(MaKhamBenh,MaBacSi,ThoiGian,TienSuBenh,TrieuChung,ChuanDoan,GhiChu,KeHoachDieuTri,ThoiGianDieuTri) 
	values (@maKhamBenh,@maBacSi,getdate(),@TienSuBenh,@TrieuChung,@chandoan,@ghichu,@keHoachDieuTri,@thoiGianDieuTri)
	update LichSuKhamBenh set TrangThai = N'Đã khám'where MaKhamBenh = @maKhamBenh
GO
/****** Object:  StoredProcedure [dbo].[Proc_XoaSoCho]    Script Date: 4/4/2024 1:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE      PROC [dbo].[Proc_XoaSoCho] @stt int
AS
	
	Declare @makb int
	set @makb = (select MaKhamBenh from LICHSUKHAMBENH where SoThuTu = @stt and CONVERT(DATE, ThoiGian) =  CONVERT(DATE, GETDATE()))
	delete PhieuThu where MaKhamBenh = @makb
	delete LICHSUKHAMBENH where MaKhamBenh = @makb

GO
