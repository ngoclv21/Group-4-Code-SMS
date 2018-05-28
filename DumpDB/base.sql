CREATE DATABASE EliteMart

GO

CREATE TABLE LoaiTaiKhoan(
	MaLoaiTaiKhoan INT PRIMARY KEY,
	TenLoaiTaiKhoan NVARCHAR(255)
)
GO
CREATE TABLE TaiKhoan(
	TenDangNhap VARCHAR(255) PRIMARY KEY,
	MatKhau VARCHAR(255),
	HoTen NVARCHAR(255),
	GioiTinh BIT, -- 0: nam, 1: nu
	NgaySinh DATETIME,
	DiaChi NVARCHAR(255),
	QueQuan NVARCHAR(255),
	SoDienThoai VARCHAR(20),
	MaLoaiTaiKhoan INT
)
GO

CREATE TABLE KhachHang(
	MaKhachHang INT IDENTITY PRIMARY KEY,
	HoTen NVARCHAR(255),
	GioiTinh BIT, -- 0: nam, 1: nu
	NgaySinh DATETIME,
	DiaChi NVARCHAR(255),
	QueQuan NVARCHAR(255),
	SoDienThoai VARCHAR(20)
)
GO
CREATE TABLE NhaCungCap(
	MaNhaCungCap INT IDENTITY PRIMARY KEY,
	HoTen NVARCHAR(255),
	GioiTinh BIT, -- 0: nam, 1: nu
	NgaySinh DATETIME,
	DiaChi NVARCHAR(255),
	QueQuan NVARCHAR(255),
	SoDienThoai VARCHAR(20)
)

GO
