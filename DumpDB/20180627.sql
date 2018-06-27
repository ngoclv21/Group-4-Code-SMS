USE [master]
GO
/****** Object:  Database [EliteMart]    Script Date: 6/27/2018 9:15:24 PM ******/
CREATE DATABASE [EliteMart]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EliteMart', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EliteMart.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EliteMart_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\EliteMart_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EliteMart] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EliteMart].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EliteMart] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EliteMart] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EliteMart] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EliteMart] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EliteMart] SET ARITHABORT OFF 
GO
ALTER DATABASE [EliteMart] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EliteMart] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EliteMart] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EliteMart] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EliteMart] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EliteMart] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EliteMart] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EliteMart] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EliteMart] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EliteMart] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EliteMart] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EliteMart] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EliteMart] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EliteMart] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EliteMart] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EliteMart] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EliteMart] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EliteMart] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EliteMart] SET  MULTI_USER 
GO
ALTER DATABASE [EliteMart] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EliteMart] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EliteMart] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EliteMart] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EliteMart] SET DELAYED_DURABILITY = DISABLED 
GO
USE [EliteMart]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 6/27/2018 9:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaChiTietHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaHoaDon] [int] NULL,
	[MaHangHoa] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietNhap]    Script Date: 6/27/2018 9:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhap](
	[MaChiTietNhap] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuNhap] [int] NULL,
	[MaHangHoa] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietXuat]    Script Date: 6/27/2018 9:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietXuat](
	[MaChiTietXuat] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuXuat] [int] NULL,
	[MaHangHoa] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 6/27/2018 9:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHangHoa] [int] IDENTITY(1,1) NOT NULL,
	[TenHangHoa] [nvarchar](255) NULL,
	[SoLuong] [int] NULL,
	[ThanhPhan] [nvarchar](255) NULL,
	[DonViTinh] [nvarchar](255) NULL,
	[DonGiaNhap] [float] NULL,
	[GiaBanLe] [float] NULL,
	[GiaBanBuon] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/27/2018 9:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NhanVien] [varchar](255) NULL,
	[NgayLap] [datetime] NULL,
	[HoTen] [nvarchar](255) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[QueQuan] [nvarchar](255) NULL,
	[SoDienThoai] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/27/2018 9:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[QueQuan] [nvarchar](255) NULL,
	[SoDienThoai] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 6/27/2018 9:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTaiKhoan](
	[MaLoaiTaiKhoan] [int] NOT NULL,
	[TenLoaiTaiKhoan] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 6/27/2018 9:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[QueQuan] [nvarchar](255) NULL,
	[SoDienThoai] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 6/27/2018 9:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[MaPhieuNhapHang] [int] IDENTITY(1,1) NOT NULL,
	[NguoiQuanLy] [varchar](255) NULL,
	[MaNhaCungCap] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[NgayGiaoHang] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhapHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuXuatHang]    Script Date: 6/27/2018 9:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuXuatHang](
	[MaPhieuXuatHang] [int] IDENTITY(1,1) NOT NULL,
	[NguoiQuanLy] [varchar](255) NULL,
	[MaKhachHang] [int] NULL,
	[NgayXuat] [datetime] NULL,
	[NgayGiaoHang] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/27/2018 9:15:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](255) NOT NULL,
	[MatKhau] [varchar](255) NULL,
	[HoTen] [nvarchar](255) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](255) NULL,
	[QueQuan] [nvarchar](255) NULL,
	[SoDienThoai] [varchar](20) NULL,
	[MaLoaiTaiKhoan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaHangHoa], [SoLuong], [DonGia]) VALUES (1, 1, 1, 4, 120000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaHangHoa], [SoLuong], [DonGia]) VALUES (2, 1, 2, 6, 120000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaHangHoa], [SoLuong], [DonGia]) VALUES (3, 2, 1, 10, 120000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaHangHoa], [SoLuong], [DonGia]) VALUES (4, 2, 2, 3, 120000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaHangHoa], [SoLuong], [DonGia]) VALUES (5, 3, 1, 3, 120000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaHangHoa], [SoLuong], [DonGia]) VALUES (6, 3, 3, 5, 120000)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
SET IDENTITY_INSERT [dbo].[ChiTietNhap] ON 

INSERT [dbo].[ChiTietNhap] ([MaChiTietNhap], [MaPhieuNhap], [MaHangHoa], [SoLuong], [DonGia]) VALUES (3, 2, 1, 10, 120000)
INSERT [dbo].[ChiTietNhap] ([MaChiTietNhap], [MaPhieuNhap], [MaHangHoa], [SoLuong], [DonGia]) VALUES (4, 2, 2, 11, 120000)
INSERT [dbo].[ChiTietNhap] ([MaChiTietNhap], [MaPhieuNhap], [MaHangHoa], [SoLuong], [DonGia]) VALUES (5, 2, 1, 2, 120000)
INSERT [dbo].[ChiTietNhap] ([MaChiTietNhap], [MaPhieuNhap], [MaHangHoa], [SoLuong], [DonGia]) VALUES (7, 4, 1, 15, 100000)
INSERT [dbo].[ChiTietNhap] ([MaChiTietNhap], [MaPhieuNhap], [MaHangHoa], [SoLuong], [DonGia]) VALUES (23, 5, 1, 5, 100000)
INSERT [dbo].[ChiTietNhap] ([MaChiTietNhap], [MaPhieuNhap], [MaHangHoa], [SoLuong], [DonGia]) VALUES (24, NULL, 3, 4, 100000)
INSERT [dbo].[ChiTietNhap] ([MaChiTietNhap], [MaPhieuNhap], [MaHangHoa], [SoLuong], [DonGia]) VALUES (25, 5, 1, 2, 100000)
INSERT [dbo].[ChiTietNhap] ([MaChiTietNhap], [MaPhieuNhap], [MaHangHoa], [SoLuong], [DonGia]) VALUES (26, 6, 1, 1, 100000)
INSERT [dbo].[ChiTietNhap] ([MaChiTietNhap], [MaPhieuNhap], [MaHangHoa], [SoLuong], [DonGia]) VALUES (27, 6, 3, 2, 100000)
SET IDENTITY_INSERT [dbo].[ChiTietNhap] OFF
SET IDENTITY_INSERT [dbo].[ChiTietXuat] ON 

INSERT [dbo].[ChiTietXuat] ([MaChiTietXuat], [MaPhieuXuat], [MaHangHoa], [SoLuong], [DonGia]) VALUES (1, 1, 2, 4, 120000)
INSERT [dbo].[ChiTietXuat] ([MaChiTietXuat], [MaPhieuXuat], [MaHangHoa], [SoLuong], [DonGia]) VALUES (2, 1, 1, 4, 120000)
INSERT [dbo].[ChiTietXuat] ([MaChiTietXuat], [MaPhieuXuat], [MaHangHoa], [SoLuong], [DonGia]) VALUES (4, NULL, 2, 1, 120000)
INSERT [dbo].[ChiTietXuat] ([MaChiTietXuat], [MaPhieuXuat], [MaHangHoa], [SoLuong], [DonGia]) VALUES (5, 3, 1, 1, 120000)
INSERT [dbo].[ChiTietXuat] ([MaChiTietXuat], [MaPhieuXuat], [MaHangHoa], [SoLuong], [DonGia]) VALUES (6, 3, 3, 5, 120000)
SET IDENTITY_INSERT [dbo].[ChiTietXuat] OFF
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([MaHangHoa], [TenHangHoa], [SoLuong], [ThanhPhan], [DonViTinh], [DonGiaNhap], [GiaBanLe], [GiaBanBuon]) VALUES (1, N'Sản phẩm 1', 14, N'Thành phần', N'Chiếc', 100000, 120000, 110000)
INSERT [dbo].[HangHoa] ([MaHangHoa], [TenHangHoa], [SoLuong], [ThanhPhan], [DonViTinh], [DonGiaNhap], [GiaBanLe], [GiaBanBuon]) VALUES (2, N'Sản phẩm 2', 17, N'Thành phần', N'Chiếc', 100000, 120000, 110000)
INSERT [dbo].[HangHoa] ([MaHangHoa], [TenHangHoa], [SoLuong], [ThanhPhan], [DonViTinh], [DonGiaNhap], [GiaBanLe], [GiaBanBuon]) VALUES (3, N'Sản phẩm 3', 4, N'Thành phần', N'Chiếc', 100000, 120000, 110000)
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHoaDon], [NhanVien], [NgayLap], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [QueQuan], [SoDienThoai]) VALUES (1, N'admin', CAST(N'2018-06-11 23:08:11.353' AS DateTime), N'khach hang', 0, NULL, N'dia chi', N'que quan', N'0966810905')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NhanVien], [NgayLap], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [QueQuan], [SoDienThoai]) VALUES (2, N'admin', CAST(N'2018-06-11 23:27:31.697' AS DateTime), N'khach hang 2', 0, NULL, N'dia chi 2', N'que quan 2', N'0966810905')
INSERT [dbo].[HoaDon] ([MaHoaDon], [NhanVien], [NgayLap], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [QueQuan], [SoDienThoai]) VALUES (3, N'admin', CAST(N'2018-06-17 10:24:34.090' AS DateTime), N'as', 0, NULL, N'dfdfd', N'dfdfdfdf', N'123123123')
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [QueQuan], [SoDienThoai]) VALUES (1, N'Khách hàng 1', 0, CAST(N'2018-06-10 21:15:46.703' AS DateTime), N'Địa chỉ', N'Quê quán', N'0966810905')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [QueQuan], [SoDienThoai]) VALUES (2, N'Khách hàng 1', 0, CAST(N'2018-06-10 21:15:46.703' AS DateTime), N'Địa chỉ', N'Quê quán', N'0966810905')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[LoaiTaiKhoan] ([MaLoaiTaiKhoan], [TenLoaiTaiKhoan]) VALUES (1, N'Nhà quản lý')
INSERT [dbo].[LoaiTaiKhoan] ([MaLoaiTaiKhoan], [TenLoaiTaiKhoan]) VALUES (2, N'Nhân viên')
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [QueQuan], [SoDienThoai]) VALUES (1, N'Nhà cung cấp 1', 0, CAST(N'2018-06-10 22:37:46.960' AS DateTime), N'ĐỊa chỉ 2', N'Quê quán', N'0966810905')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
SET IDENTITY_INSERT [dbo].[PhieuNhapHang] ON 

INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhapHang], [NguoiQuanLy], [MaNhaCungCap], [NgayNhap], [NgayGiaoHang]) VALUES (2, N'admin', 1, CAST(N'2018-06-11 21:28:54.147' AS DateTime), CAST(N'2018-06-12 22:57:41.163' AS DateTime))
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhapHang], [NguoiQuanLy], [MaNhaCungCap], [NgayNhap], [NgayGiaoHang]) VALUES (4, N'admin', 1, CAST(N'2018-06-16 23:07:51.913' AS DateTime), NULL)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhapHang], [NguoiQuanLy], [MaNhaCungCap], [NgayNhap], [NgayGiaoHang]) VALUES (5, N'admin', 1, CAST(N'2018-06-16 23:46:59.243' AS DateTime), NULL)
INSERT [dbo].[PhieuNhapHang] ([MaPhieuNhapHang], [NguoiQuanLy], [MaNhaCungCap], [NgayNhap], [NgayGiaoHang]) VALUES (6, N'admin', 1, CAST(N'2018-06-17 10:09:55.990' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[PhieuNhapHang] OFF
SET IDENTITY_INSERT [dbo].[PhieuXuatHang] ON 

INSERT [dbo].[PhieuXuatHang] ([MaPhieuXuatHang], [NguoiQuanLy], [MaKhachHang], [NgayXuat], [NgayGiaoHang]) VALUES (1, N'admin', 1, CAST(N'2018-06-14 21:17:40.583' AS DateTime), CAST(N'2018-06-14 22:53:37.477' AS DateTime))
INSERT [dbo].[PhieuXuatHang] ([MaPhieuXuatHang], [NguoiQuanLy], [MaKhachHang], [NgayXuat], [NgayGiaoHang]) VALUES (3, N'admin', 1, CAST(N'2018-06-17 10:21:03.387' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[PhieuXuatHang] OFF
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [QueQuan], [SoDienThoai], [MaLoaiTaiKhoan]) VALUES (N'admin', N'12345', N'Admin', 1, CAST(N'2018-06-10 20:49:47.683' AS DateTime), N'Địa chỉ', N'Quê quán', N'0966810905', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [QueQuan], [SoDienThoai], [MaLoaiTaiKhoan]) VALUES (N'member', N'12345', N'Ho ten', 1, CAST(N'2018-06-10 20:49:47.683' AS DateTime), N'Hà nội', N'Thái Bình', N'0966810905', 2)
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietHo__MaHan__33D4B598] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HangHoa] ([MaHangHoa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK__ChiTietHo__MaHan__33D4B598]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietHo__MaHoa__32E0915F] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK__ChiTietHo__MaHoa__32E0915F]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietNh__MaHan__2D27B809] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HangHoa] ([MaHangHoa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK__ChiTietNh__MaHan__2D27B809]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietNh__MaPhi__2C3393D0] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhapHang] ([MaPhieuNhapHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK__ChiTietNh__MaPhi__2C3393D0]
GO
ALTER TABLE [dbo].[ChiTietXuat]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietXu__MaHan__2F10007B] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HangHoa] ([MaHangHoa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietXuat] CHECK CONSTRAINT [FK__ChiTietXu__MaHan__2F10007B]
GO
ALTER TABLE [dbo].[ChiTietXuat]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietXu__MaPhi__2E1BDC42] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PhieuXuatHang] ([MaPhieuXuatHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietXuat] CHECK CONSTRAINT [FK__ChiTietXu__MaPhi__2E1BDC42]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK__HoaDon__NhanVien__31EC6D26] FOREIGN KEY([NhanVien])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK__HoaDon__NhanVien__31EC6D26]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK__PhieuNhap__MaNha__276EDEB3] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [FK__PhieuNhap__MaNha__276EDEB3]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([NguoiQuanLy])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuXuatHang]  WITH CHECK ADD  CONSTRAINT [FK__PhieuXuat__MaKha__2B3F6F97] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuXuatHang] CHECK CONSTRAINT [FK__PhieuXuat__MaKha__2B3F6F97]
GO
ALTER TABLE [dbo].[PhieuXuatHang]  WITH CHECK ADD  CONSTRAINT [FK__PhieuXuat__Nguoi__2A4B4B5E] FOREIGN KEY([NguoiQuanLy])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuXuatHang] CHECK CONSTRAINT [FK__PhieuXuat__Nguoi__2A4B4B5E]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK__TaiKhoan__MaLoai__239E4DCF] FOREIGN KEY([MaLoaiTaiKhoan])
REFERENCES [dbo].[LoaiTaiKhoan] ([MaLoaiTaiKhoan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK__TaiKhoan__MaLoai__239E4DCF]
GO
USE [master]
GO
ALTER DATABASE [EliteMart] SET  READ_WRITE 
GO
