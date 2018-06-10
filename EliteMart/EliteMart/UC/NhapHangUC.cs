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
    public partial class NhapHangUC : UserControl
    {
        public NhapHangUC()
        {
            InitializeComponent();
        }

        private BindingSource bds = new BindingSource();
        private AppDB db = new AppDB();
        private void NhapHangUC_Load(object sender, EventArgs e)
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
            bds.DataSource = db.PhieuNhapHangs.Select(x => new { x.MaPhieuNhapHang, x.NguoiQuanLy, NhaCungCap = x.NhaCungCap.HoTen, x.NgayNhap, x.NgayGiaoHang, x }).ToList();
        }
        public void ChangHeader()
        {
            dtgv.Columns["MaPhieuNhapHang"].HeaderText = "Phiếu nhập";
            dtgv.Columns["NguoiQuanLy"].HeaderText = "Người quản lý";
            dtgv.Columns["NhaCungCap"].HeaderText = "Nhà cung cấp";
            dtgv.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            dtgv.Columns["NgayGiaoHang"].HeaderText = "Ngày giao hàng";
        }
        public void HideColumn()
        {
            dtgv.Columns["x"].Visible = false;
        }
        public void LoadDataBinding()
        {
            lblMaPhieuNhap.DataBindings.Add("Text", dtgv.DataSource, "MaPhieuNhapHang", true, DataSourceUpdateMode.Never);
        }

        public void LoadMore()
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AppState.ManagerForm.Trigger(ScreenName.CREATE_NHAP_HANG);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa",
                                     "Xác nhận!!",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                PhieuNhapHang phieuNhapHang = db.PhieuNhapHangs.Find(int.Parse(lblMaPhieuNhap.Text));
                try
                {
                    db.PhieuNhapHangs.Remove(phieuNhapHang);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                    LoadDtgv();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa! Có lỗi xảy ra");
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDtgv();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bds.DataSource = bds.DataSource = db.PhieuNhapHangs.Select(x => new { x.MaPhieuNhapHang, x.NguoiQuanLy, NhaCungCap = x.NhaCungCap.HoTen, x.NgayNhap, x.NgayGiaoHang, x }).Where(x => x.MaPhieuNhapHang.ToString().Contains(txtTimKiem.Text)
            || x.NguoiQuanLy.Contains(txtTimKiem.Text) || x.NhaCungCap.Contains(txtTimKiem.Text)).ToList();
        }

        private void btnGiaoHang_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có muốn giao hàng",
                                     "Xác nhận!!",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                PhieuNhapHang phieuNhapHang = db.PhieuNhapHangs.Find(int.Parse(lblMaPhieuNhap.Text));
                try
                {
                    phieuNhapHang.NgayGiaoHang = DateTime.Now;
                    foreach (var item in phieuNhapHang.ChiTietNhaps)
                    {
                        HangHoa hangHoa = db.HangHoas.Find(item.MaHangHoa);
                        hangHoa.SoLuong += item.SoLuong;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Giao hàng thành công");
                    LoadDtgv();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa! Có lỗi xảy ra");
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            NhapHangReport report = new NhapHangReport();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }
    }
}
