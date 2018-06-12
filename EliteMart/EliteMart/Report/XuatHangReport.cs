using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using EliteMart.EF;

namespace EliteMart.Report
{
    public partial class XuatHangReport : DevExpress.XtraReports.UI.XtraReport
    {
        private PhieuXuatHang phieuXuatHang;
        public XuatHangReport(PhieuXuatHang phieuXuatHang)
        {
            InitializeComponent();
            this.phieuXuatHang = phieuXuatHang;
            Load();
        }

        public void Load()
        {
            this.bindingSource1.DataSource = phieuXuatHang.ChiTietXuats;

            double tongTien = 0;
            foreach (var item in phieuXuatHang.ChiTietXuats)
            {
                if (item.DonGia != null && item.SoLuong != null)
                    tongTien += item.DonGia.Value * item.SoLuong.Value;
            }

            lblMa.Text = phieuXuatHang.MaPhieuXuatHang.ToString();
            lblTongTien.Text = tongTien.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));

            lblNgayXuat.Text = phieuXuatHang.NgayXuat.Value.ToShortDateString();
            lblQuanLy.Text = phieuXuatHang.NguoiQuanLy;
            lblKhachHang.Text = phieuXuatHang.KhachHang.HoTen;

            lblSoDienThoaiKhachHang.Text = phieuXuatHang.KhachHang.SoDienThoai;
            lblSoDienThoaiQuanLy.Text = phieuXuatHang.TaiKhoan.SoDienThoai;

            lblNgaySinhKhachHang.Text = phieuXuatHang.KhachHang.NgaySinh.Value.ToShortDateString();
            lblNgaySinhQuanLy.Text = phieuXuatHang.TaiKhoan.NgaySinh.Value.ToShortDateString();

            lblDiaChiKhachHang.Text = phieuXuatHang.KhachHang.DiaChi;
            lblDiaChiQuanLy.Text = phieuXuatHang.TaiKhoan.DiaChi;
        }
    }
}
