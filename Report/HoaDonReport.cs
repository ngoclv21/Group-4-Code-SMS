using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using EliteMart.EF;

namespace EliteMart.Report
{
    public partial class HoaDonReport : DevExpress.XtraReports.UI.XtraReport
    {
        private HoaDon hoaDon;
        public HoaDonReport(HoaDon hoaDon)
        {
            InitializeComponent();
            this.hoaDon = hoaDon;
            Load();
        }

        public void Load()
        {
            this.bindingSource1.DataSource = hoaDon.ChiTietHoaDons;

            double tongTien = 0;
            foreach (var item in hoaDon.ChiTietHoaDons)
            {
                if (item.DonGia != null && item.SoLuong != null)
                    tongTien += item.DonGia.Value * item.SoLuong.Value;
            }

            lblMa.Text = hoaDon.MaHoaDon.ToString();
            lblTongTien.Text = tongTien.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));

            lblNgayXuat.Text = hoaDon.NgayLap.Value.ToShortDateString();
            lblQuanLy.Text = hoaDon.NhanVien;
            lblHoTen.Text = hoaDon.HoTen;

            lblSoDienThoaiKhachHang.Text = hoaDon.SoDienThoai;
            lblSoDienThoaiQuanLy.Text = hoaDon.TaiKhoan.SoDienThoai;

            if(hoaDon.NgaySinh != null)
            {
                lblNgaySinhKhachHang.Text = hoaDon.NgaySinh.Value.ToShortDateString();
            }
            if(hoaDon.TaiKhoan != null && hoaDon.TaiKhoan.NgaySinh != null)
            {
                lblNgaySinhQuanLy.Text = hoaDon.TaiKhoan.NgaySinh.Value.ToShortDateString();
            }

            lblDiaChiKhachHang.Text = hoaDon.DiaChi;
            lblDiaChiQuanLy.Text = hoaDon.TaiKhoan.DiaChi;
        }

    }
}
