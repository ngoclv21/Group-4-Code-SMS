USE [master]
GO
/****** Object:  Database [EliteMart]    Script Date: 6/3/2018 4:58:00 PM ******/
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
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 6/3/2018 4:58:00 PM ******/
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
/****** Object:  Table [dbo].[ChiTietNhap]    Script Date: 6/3/2018 4:58:00 PM ******/
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
/****** Object:  Table [dbo].[ChiTietXuat]    Script Date: 6/3/2018 4:58:00 PM ******/
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
/****** Object:  Table [dbo].[HangHoa]    Script Date: 6/3/2018 4:58:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHangHoa] [int] IDENTITY(1,1) NOT NULL,
	[TenHangHoa] [nvarchar](255) NULL,
	[DonGia] [float] NULL,
	[SoLuong] [int] NULL,
	[ThanhPhan] [nvarchar](255) NULL,
	[DonViTinh] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/3/2018 4:58:00 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/3/2018 4:58:00 PM ******/
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
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 6/3/2018 4:58:00 PM ******/
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
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 6/3/2018 4:58:00 PM ******/
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
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 6/3/2018 4:58:00 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhapHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuXuatHang]    Script Date: 6/3/2018 4:58:00 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/3/2018 4:58:00 PM ******/
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
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([MaHangHoa], [TenHangHoa], [DonGia], [SoLuong], [ThanhPhan], [DonViTinh]) VALUES (1, N'Sản phẩm 1', 100000, 5, N'Thành phần', N'Chiếc')
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
INSERT [dbo].[LoaiTaiKhoan] ([MaLoaiTaiKhoan], [TenLoaiTaiKhoan]) VALUES (1, N'Nhà quản lý')
INSERT [dbo].[LoaiTaiKhoan] ([MaLoaiTaiKhoan], [TenLoaiTaiKhoan]) VALUES (2, N'Nhân viên')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [QueQuan], [SoDienThoai], [MaLoaiTaiKhoan]) VALUES (N'admin', N'12345', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HangHoa] ([MaHangHoa])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HangHoa] ([MaHangHoa])
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhapHang] ([MaPhieuNhapHang])
GO
ALTER TABLE [dbo].[ChiTietXuat]  WITH CHECK ADD FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HangHoa] ([MaHangHoa])
GO
ALTER TABLE [dbo].[ChiTietXuat]  WITH CHECK ADD FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PhieuXuatHang] ([MaPhieuXuatHang])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([NhanVien])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PhieuXuatHang]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PhieuXuatHang]  WITH CHECK ADD FOREIGN KEY([NguoiQuanLy])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaLoaiTaiKhoan])
REFERENCES [dbo].[LoaiTaiKhoan] ([MaLoaiTaiKhoan])
GO
USE [master]
GO
ALTER DATABASE [EliteMart] SET  READ_WRITE 
GO
