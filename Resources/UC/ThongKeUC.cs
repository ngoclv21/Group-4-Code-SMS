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
using EliteMart.AppCode;
using EliteMart.SpreetSeed;

namespace EliteMart.UC
{
    public partial class ThongKeUC : UserControl
    {
        private ReportByTimeModel model = new ReportByTimeModel();
        private AppDB db = new AppDB();


        private void Enable(Button btn)
        {
            btnTKTheoNam.Enabled = true;
            btnTKTheoNam.FlatAppearance.BorderSize = 0;
            btnTKTheoNam.BackColor = Color.FromArgb(178, 8, 55);

            btnTkTheoThang.Enabled = true;
            btnTkTheoThang.FlatAppearance.BorderSize = 0;
            btnTkTheoThang.BackColor = Color.FromArgb(178, 8, 55);

            btnTKTheoQuy.Enabled = true;
            btnTKTheoQuy.FlatAppearance.BorderSize = 0;
            btnTKTheoQuy.BackColor = Color.FromArgb(178, 8, 55);

            btn.Enabled = false;

            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            btn.BackColor = Color.Transparent;
        }

        private void btnTkTheoThang_Click(object sender, EventArgs e)
        {
            Enable(sender as Button);
            DateTime date = DateTime.Now;
            var startDate = new DateTime(date.Year, date.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            ThongKe(startDate, endDate);
            model.TheoLoai = "theo tháng";
        }

        private void btnTKTheoQuy_Click(object sender, EventArgs e)
        {
            Enable(sender as Button);
            DateTime date = DateTime.Now;
            var startDate = new DateTime(date.Year, date.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            startDate = startDate.AddMonths(-3);
            ThongKe(startDate, endDate);
            model.TheoLoai = "theo quý";
        }

        private void btnTKTheoNam_Click(object sender, EventArgs e)
        {
            Enable(sender as Button);
            DateTime date = DateTime.Now;
            var startDate = new DateTime(date.Year, date.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            startDate = startDate.AddYears(-1);
            ThongKe(startDate, endDate);
            model.TheoLoai = "theo năm";
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
            foreach (var item in db.PhieuXuatHangs.Where(x => x.NgayGiaoHang == null))
            {
                foreach (var item2 in item.ChiTietXuats)
                {
                    if (item2.SoLuong != null && item2.DonGia != null)
                    {
                        tonKho += item2.SoLuong.Value * item2.HangHoa.DonGiaNhap.Value;
                    }

                }
            }
            foreach (var item in db.HoaDons.Where(x => x.NgayLap != null && x.NgayLap.Value >= startDate && x.NgayLap < endDate).ToList())
            {
                foreach (var item2 in item.ChiTietHoaDons)
                {
                    if (item2.SoLuong != null && item2.DonGia != null)
                    {
                        tonKho += item2.SoLuong.Value * item2.HangHoa.DonGiaNhap.Value;
                    }

                }
            }

            lblNhapHang.Text = nhapHang.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            lblXuatHang.Text = xuatHang.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            lblHoaDon.Text = hoaDon.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            lblDoanhThu.Text = doanhThu.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            lblTonKho.Text = tonKho.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));

            string sanPhamBanChay = "";
            int soLuongBanLe = 0;
            int soLuongTheoDonXuat = 0;

            List<SanPhamThongKeModel> list = new List<SanPhamThongKeModel>();
            foreach (var hangHoa in db.HangHoas.ToList())
            {
                SanPhamThongKeModel model = new SanPhamThongKeModel();
                model.SanPham = hangHoa;
                model.SoLuongBanLe = hangHoa.ChiTietHoaDons.Where(x=> x.HoaDon.NgayLap != null && x.HoaDon.NgayLap.Value >= startDate && x.HoaDon.NgayLap < endDate).Sum(x => x.SoLuong.Value);
                model.SoLuongTheoPhieuXuat = hangHoa.ChiTietXuats.Where(x => x.PhieuXuatHang != null && x.PhieuXuatHang.NgayGiaoHang != null && x.PhieuXuatHang.NgayGiaoHang.Value >= startDate && x.PhieuXuatHang.NgayGiaoHang < endDate).Sum(x => x.SoLuong.Value);
                model.Tong = model.SoLuongTheoPhieuXuat + model.SoLuongBanLe;
                list.Add(model);

            }


            list.Sort();
            SanPhamThongKeModel best = list.First();
            SanPhamThongKeModel worst = list.Last();
            lblBestName.Text = best.SanPham.TenHangHoa;
            lblBestBanLe.Text = best.SoLuongBanLe.ToString();
            lblBestDonXuat.Text = best.SoLuongTheoPhieuXuat.ToString();

            lblWostName.Text = worst.SanPham.TenHangHoa;
            lblWorstBanLe.Text = worst.SoLuongBanLe.ToString();
            lblWorstDonXuat.Text = worst.SoLuongTheoPhieuXuat.ToString();

            model.SanPhamBanChayNhat = best.SanPham.TenHangHoa;
            model.SanPhamBanKemNhat = worst.SanPham.TenHangHoa;
            model.SoTienNhapHang = nhapHang;
            model.DoanhThu = doanhThu;
            model.SoTienXuatHang = xuatHang;
            model.TienBanLe = hoaDon;
            model.TonKho = tonKho;
            model.ChayNhatBanLe = best.SoLuongBanLe.ToString();
            model.ChayNhatTheoDonXuat = best.SoLuongTheoPhieuXuat.ToString();
            model.KemNhatBanLe = worst.SoLuongBanLe.ToString();
            model.KemNhatTheoDonXuat = worst.SoLuongTheoPhieuXuat.ToString();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalculateQtyFromSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap nhaCungCap = db.NhaCungCaps.Find(int.Parse(cbxNhaCungCap.SelectedValue.ToString()));
                int quantity = 0;
                foreach (var item in nhaCungCap.PhieuNhapHangs)
                {
                    quantity += item.ChiTietNhaps.Sum(x => x.SoLuong).Value;
                }

                lblQtyFromSupplier.Text = quantity.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!!!");
            }
        }

        private void btnPrintByTime_Click(object sender, EventArgs e)
        {
            ReportByTimeSpreedSheet form = new ReportByTimeSpreedSheet(model);
            form.Show();
        }

        private void btnPrintBySupplier_Click(object sender, EventArgs e)
        {

            ReportBySupplierSpreadSheet form = new ReportBySupplierSpreadSheet(cbxNhaCungCap.SelectedValue.ToString());
            form.Show();
        }

        public ThongKeUC()
        {
            InitializeComponent();
            LoadMore();
        }

        private void LoadMore()
        {
            //Nhà cung cấp
            cbxNhaCungCap.DataSource = db.NhaCungCaps.ToList();
            cbxNhaCungCap.DisplayMember = "HoTen";
            cbxNhaCungCap.ValueMember = "MaNhaCungCap";
        }
        public void View()
        {
            //lblNhapHang.Text = nhapHang.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            //lblXuatHang.Text = xuatHang.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            //lblHoaDon.Text = hoaDon.ToString("#,###", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblQtyFromSupplier_Click(object sender, EventArgs e)
        {

        }

        private void lblTonKho_Click(object sender, EventArgs e)
        {

        }

        private void lblDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void lblHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void lblXuatHang_Click(object sender, EventArgs e)
        {

        }

        private void lblWorstDonXuat_Click(object sender, EventArgs e)
        {

        }

        private void lblBestDonXuat_Click(object sender, EventArgs e)
        {

        }

        private void lblWorstBanLe_Click(object sender, EventArgs e)
        {

        }

        private void lblBestBanLe_Click(object sender, EventArgs e)
        {

        }

        private void lblWostName_Click(object sender, EventArgs e)
        {

        }

        private void lblBestName_Click(object sender, EventArgs e)
        {

        }

        private void lblNhapHang_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
