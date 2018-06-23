using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using EliteMart.EF;
using EliteMart.AppCode;
using EliteMart.Report;
using DevExpress.XtraReports.UI;

namespace EliteMart.UC
{
    public partial class HoaDonUC : UserControl
    {
        public HoaDonUC()
        {
            InitializeComponent();
        }

        private BindingSource bds = new BindingSource();
        private AppDB db = new AppDB();

        private void HoaDonUC_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            dtgv.DataSource = bds;
            ChangHeader();
            LoadMore();
            LoadDataBinding();
            HideColumn();
        }

        public void LoadDtgv()
        {
            bds.DataSource = db.HoaDons.Select(x => new { x.MaHoaDon, NhanVien = x.NhanVien, x.HoTen, x.SoDienThoai, x.NgayLap, x }).ToList();
        }
        public void ChangHeader()
        {
            dtgv.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
            dtgv.Columns["NhanVien"].HeaderText = "Nhân viên";
            dtgv.Columns["HoTen"].HeaderText = "Họ tên";
            dtgv.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgv.Columns["NgayLap"].HeaderText = "Ngày lập";
        }
        public void HideColumn()
        {
            dtgv.Columns["x"].Visible = false;
        }
        public void LoadDataBinding()
        {
            lblMaHoaDon.DataBindings.Add("Text", dtgv.DataSource, "MaHoaDon", true, DataSourceUpdateMode.Never);
        }

        public void LoadMore()
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AppState.ManagerForm.Trigger(ScreenName.CREATE_HOA_DON);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDtgv();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bds.DataSource = bds.DataSource = db.HoaDons.Select(x => new { x.MaHoaDon, NhanVien = x.NhanVien, x.HoTen, x.SoDienThoai, x.NgayLap, x }).Where(x => x.MaHoaDon.ToString().Contains(txtTimKiem.Text)
            || x.NhanVien.Contains(txtTimKiem.Text) || x.HoTen.Contains(txtTimKiem.Text)).ToList();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = db.HoaDons.Find(int.Parse(lblMaHoaDon.Text));
            HoaDonReport report = new HoaDonReport(hoaDon);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hoaDon = db.HoaDons.Find(int.Parse(lblMaHoaDon.Text));
                db.HoaDons.Remove(hoaDon);
                db.SaveChanges();
                LoadDtgv();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
