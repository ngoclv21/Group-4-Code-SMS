using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using EliteMart.EF;

namespace EliteMart.Report
{
    public partial class NhapHangReport : DevExpress.XtraReports.UI.XtraReport
    {

        private PhieuNhapHang phieuNhapHang;

        public NhapHangReport(PhieuNhapHang phieuNhapHang)
        {
            InitializeComponent();
            this.phieuNhapHang = phieuNhapHang;
            Load();
        }

        public void Load()
        {
            this.bindingSource1.DataSource = phieuNhapHang.ChiTietNhaps;

            double tongTien = 0;
            foreach (var item in phieuNhapHang.ChiTietNhaps)
            {
                if(item.DonGia != null && item.SoLuong != null)
                tongTien += item.DonGia.Value * item.SoLuong.Value;
            }

            lblMa.Text = phieuNhapHang.MaPhieuNhapHang.ToString();
            lblTongTien.Text = tongTien.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));

            lblNgayNhap.Text = phieuNhapHang.NgayNhap.Value.ToShortDateString();
            lblQuanLy.Text = phieuNhapHang.NguoiQuanLy.Trim();
            lblNhaCungCap.Text = phieuNhapHang.NhaCungCap.HoTen;

            lblSoDienThoaiNhaCungCap.Text = phieuNhapHang.NhaCungCap.SoDienThoai;
            lblSoDienThoaiQuanLy.Text = phieuNhapHang.TaiKhoan.SoDienThoai;

            lblNgaySinhNhaCungCap.Text = phieuNhapHang.NhaCungCap.NgaySinh.Value.ToShortDateString();
            lblNgaySinhQuanLy.Text = phieuNhapHang.TaiKhoan.NgaySinh.Value.ToShortDateString();

            lblDiaChiNhaCungCap.Text = phieuNhapHang.NhaCungCap.DiaChi;
            lblDiaChiQuanLy.Text = phieuNhapHang.TaiKhoan.DiaChi;
        }

    }
}
