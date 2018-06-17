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
    public partial class XuatHangUC : UserControl
    {
        public XuatHangUC()
        {
            InitializeComponent();
        }

        private BindingSource bds = new BindingSource();
        private AppDB db = new AppDB();

        private void XuatHangUC_Load(object sender, EventArgs e)
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
            bds.DataSource = db.PhieuXuatHangs.Select(x => new { x.MaPhieuXuatHang, x.NguoiQuanLy, KhachHang = x.KhachHang.HoTen, x.NgayXuat, x.NgayGiaoHang, x }).ToList();
        }
        public void ChangHeader()
        {
            dtgv.Columns["MaPhieuXuatHang"].HeaderText = "Phiếu xuất";
            dtgv.Columns["NguoiQuanLy"].HeaderText = "Người quản lý";
            dtgv.Columns["KhachHang"].HeaderText = "Khách hàng";
            dtgv.Columns["NgayXuat"].HeaderText = "Ngày xuất";
            dtgv.Columns["NgayGiaoHang"].HeaderText = "Ngày giao hàng";
        }
        public void HideColumn()
        {
            dtgv.Columns["x"].Visible = false;
        }
        public void LoadDataBinding()
        {
            lblMaPhieuXuat.DataBindings.Add("Text", dtgv.DataSource, "MaPhieuXuatHang", true, DataSourceUpdateMode.Never);
        }

        public void LoadMore()
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AppState.ManagerForm.Trigger(ScreenName.CREATE_XUAT_HANG);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuXuatHang phieuXuatHang = db.PhieuXuatHangs.Find(int.Parse(lblMaPhieuXuat.Text));
                if (phieuXuatHang.NgayGiaoHang != null)
                {
                    MessageBox.Show("Đơn hàng này đã được giao");
                    return;
                }
                AppState.ManagerForm.Trigger(ScreenName.CREATE_XUAT_HANG, phieuXuatHang);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa",
                                     "Xác nhận!!",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                PhieuXuatHang phieuXuatHang = db.PhieuXuatHangs.Find(int.Parse(lblMaPhieuXuat.Text));
                if (phieuXuatHang.NgayGiaoHang != null)
                {
                    MessageBox.Show("Không thể xóa một đơn hàng đã được giao");
                    return;
                }
                try
                {
                    db.PhieuXuatHangs.Remove(phieuXuatHang);
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
            bds.DataSource = bds.DataSource = db.PhieuXuatHangs.Select(x => new { x.MaPhieuXuatHang, x.NguoiQuanLy, KhachHang = x.KhachHang.HoTen, x.NgayXuat, x.NgayGiaoHang, x }).Where(x => x.MaPhieuXuatHang.ToString().Contains(txtTimKiem.Text)
            || x.NguoiQuanLy.Contains(txtTimKiem.Text) || x.KhachHang.Contains(txtTimKiem.Text)).ToList();
        }

        private void btnGiaoHang_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có muốn giao hàng",
                                     "Xác nhận!!",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                PhieuXuatHang phieuXuatHang = db.PhieuXuatHangs.Find(int.Parse(lblMaPhieuXuat.Text));
                try
                {
                    phieuXuatHang.NgayGiaoHang = DateTime.Now;
                    foreach (var item in phieuXuatHang.ChiTietXuats)
                    {
                        HangHoa hangHoa = db.HangHoas.Find(item.MaHangHoa);
                        if(hangHoa.SoLuong < item.SoLuong)
                        {
                            MessageBox.Show("Không đủ hàng : " + hangHoa.MaHangHoa + " - " + hangHoa.TenHangHoa);
                            return;
                        }
                        hangHoa.SoLuong -= item.SoLuong;
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
            PhieuXuatHang phieuXuatHang = db.PhieuXuatHangs.Find(int.Parse(lblMaPhieuXuat.Text));
            XuatHangReport report = new XuatHangReport(phieuXuatHang);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }
    }
}
