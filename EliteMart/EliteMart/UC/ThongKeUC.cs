using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EliteMart.EF;

namespace EliteMart.UC
{
    public partial class ThongKeUC : UserControl
    {
        private double nhapHang, xuatHang, hoaDon;
        private AppDB db = new AppDB();

        private void btnTkTheoThang_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            var startDate = new DateTime(date.Year, date.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            ThongKe(startDate, endDate);
        }

        private void btnTKTheoQuy_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            var startDate = new DateTime(date.Year, date.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            startDate.AddMonths(-3);
            ThongKe(startDate, endDate);
        }

        private void btnTKTheoNam_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            var startDate = new DateTime(date.Year, date.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            startDate.AddYears(-1);
            ThongKe(startDate, endDate);
        }

        private void ThongKe(DateTime startDate, DateTime endDate)
        {
            double nhapHang = 0;
            double doanhThu = 0;

            foreach (var item in db.PhieuNhapHangs.Where(x=>x.NgayGiaoHang != null && x.NgayGiaoHang.Value >= startDate && x.NgayGiaoHang<endDate).ToList())
            {
                foreach (var item2 in item.ChiTietNhaps)
                {
                    if (item2.SoLuong != null && item2.DonGia != null)
                    {
                        nhapHang += item2.SoLuong.Value * item2.DonGia.Value;
                    }

                }
            }

            double xuatHang = 0;
            foreach (var item in db.PhieuXuatHangs.Where(x => x.NgayGiaoHang != null && x.NgayGiaoHang.Value >= startDate && x.NgayGiaoHang < endDate).ToList())
            {
                foreach (var item2 in item.ChiTietXuats)
                {
                    if (item2.SoLuong != null && item2.DonGia != null)
                    {
                        xuatHang += item2.SoLuong.Value * item2.DonGia.Value;
                        doanhThu += item2.SoLuong.Value * (item2.DonGia.Value - item2.HangHoa.DonGiaNhap.Value);
                    }
                        
                }
            }


            double hoaDon = 0;
            foreach (var item in db.HoaDons.Where(x => x.NgayLap != null && x.NgayLap.Value >= startDate && x.NgayLap < endDate).ToList())
            {
                foreach (var item2 in item.ChiTietHoaDons)
                {
                    if (item2.SoLuong != null && item2.DonGia != null)
                    {
                        hoaDon += item2.SoLuong.Value * item2.DonGia.Value;
                        doanhThu += item2.SoLuong.Value * (item2.DonGia.Value - item2.HangHoa.DonGiaNhap.Value);
                    }
                        
                }
            }
            double tonKho = 0;
            foreach (var item in db.HangHoas.ToList())
            {
                if(item.DonGiaNhap != null && item.SoLuong != null)
                {
                    tonKho = item.DonGiaNhap.Value * item.SoLuong.Value;
                }
            }

            lblNhapHang.Text = nhapHang.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            lblXuatHang.Text = xuatHang.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            lblHoaDon.Text = hoaDon.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            lblDoanhThu.Text = doanhThu.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            lblTonKho.Text = tonKho.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
        }

        public ThongKeUC()
        {
            InitializeComponent();
        }

        public void View()
        {
            lblNhapHang.Text = nhapHang.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            lblXuatHang.Text = xuatHang.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            lblHoaDon.Text = hoaDon.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
        }




    }
}
