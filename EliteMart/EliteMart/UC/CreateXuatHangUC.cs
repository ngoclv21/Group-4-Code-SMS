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
    public partial class CreateXuatHangUC : UserControl
    {
        PhieuXuatHang phieuXuatHang = null;
        public CreateXuatHangUC()
        {
            InitializeComponent();
        }

        public CreateXuatHangUC(PhieuXuatHang phieuXuatHang)
        {
            InitializeComponent();
            this.phieuXuatHang = phieuXuatHang;
            chiTietXuats = phieuXuatHang.ChiTietXuats.ToList();
        }


        private AppDB db = new AppDB();
        private BindingSource bds = new BindingSource();
        private List<ChiTietXuat> chiTietXuats = new List<ChiTietXuat>();

        private void CreateXuatHangUC_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            LoadMore();
            dtgv.DataSource = bds;
            ChangHeader();
        }
        public void ChangHeader()
        {
            dtgv.Columns["MaHangHoa"].HeaderText = "Mã hàng hóa";
            dtgv.Columns["TenHangHoa"].HeaderText = "Tên hàng hóa";
            dtgv.Columns["SoLuong"].HeaderText = "Số lượng";
            dtgv.Columns["DonGia"].HeaderText = "Đơn giá";
        }

        public void LoadDtgv()
        {
            bds.DataSource = chiTietXuats.Select(x => new { x.MaHangHoa, x.HangHoa.TenHangHoa, x.SoLuong, x.DonGia }).ToList();
        }
        public void LoadMore()
        {
            //list hàng hóa
            var sourceHangHoas = new AutoCompleteStringCollection();
            List<HangHoa> hangHoas = db.HangHoas.ToList();
            foreach (var item in hangHoas)
            {
                sourceHangHoas.Add( item.TenHangHoa + " - " + item.MaHangHoa);
            }
            txtHangHoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtHangHoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtHangHoa.AutoCompleteCustomSource = sourceHangHoas;

            //list tài khoản
            var sourceTaiKhoans = new AutoCompleteStringCollection();
            List<TaiKhoan> taiKhoans = db.TaiKhoans.ToList();
            foreach (var item in taiKhoans)
            {
                sourceTaiKhoans.Add(item.TenDangNhap + " - " + item.HoTen);
            }
            txtNguoiXuat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNguoiXuat.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNguoiXuat.AutoCompleteCustomSource = sourceTaiKhoans;

            //Nhà cung cấp
            cbxKhachHang.DataSource = db.KhachHangs.ToList();
            cbxKhachHang.DisplayMember = "HoTen";
            cbxKhachHang.ValueMember = "MaKhachHang";
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietXuat chiTietXuat = new ChiTietXuat();
                chiTietXuat.SoLuong = int.Parse(txtSoLuong.Text);
                HangHoa hangHoa = db.HangHoas.Find(int.Parse(txtHangHoa.Text.Split('-')[1].Trim()));
                chiTietXuat.HangHoa = hangHoa;
                chiTietXuat.MaHangHoa = hangHoa.MaHangHoa;
                chiTietXuat.DonGia = hangHoa.GiaBanBuon;
                chiTietXuats.Add(chiTietXuat);

                if (this.phieuXuatHang != null)
                {
                    phieuXuatHang = db.PhieuXuatHangs.Find(phieuXuatHang.MaPhieuXuatHang);
                    phieuXuatHang.ChiTietXuats.Add(chiTietXuat);
                }

                LoadDtgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!!!");
            }

        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgv.SelectedRows[0].Index;
                
                if (this.phieuXuatHang == null)
                {
                    chiTietXuats.RemoveAt(index);
                }
                else
                {

                    foreach (var item in phieuXuatHang.ChiTietXuats.ToList())
                    {
                        if (item.MaChiTietXuat == chiTietXuats[index].MaChiTietXuat)
                        {
                            phieuXuatHang = db.PhieuXuatHangs.Find(phieuXuatHang.MaPhieuXuatHang);
                            phieuXuatHang.ChiTietXuats.Remove(item);
                            break;
                        }
                    }
                    chiTietXuats.RemoveAt(index);
                }

                LoadDtgv();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnTaoPhieuXuat_Click(object sender, EventArgs e)
        {
            PhieuXuatHang xuatHang = null;
            if (this.phieuXuatHang == null)
            {
                xuatHang = new PhieuXuatHang();
                xuatHang.MaKhachHang = (int)cbxKhachHang.SelectedValue;
                xuatHang.NguoiQuanLy = txtNguoiXuat.Text.Split('-')[0].Trim();
                TaiKhoan quanLy = db.TaiKhoans.Find(xuatHang.NguoiQuanLy);
                xuatHang.TaiKhoan = quanLy;
                xuatHang.NgayXuat = dtpkNgayXuat.Value;
                xuatHang.ChiTietXuats = chiTietXuats;
                db.PhieuXuatHangs.Add(xuatHang);
                db.SaveChanges();
                MessageBox.Show("Tạo thành công phiếu xuất hàng");
            }
            else
            {
                xuatHang = db.PhieuXuatHangs.Find(phieuXuatHang.MaPhieuXuatHang);
                xuatHang.MaKhachHang = (int)cbxKhachHang.SelectedValue;
                xuatHang.NguoiQuanLy = txtNguoiXuat.Text.Split('-')[0].Trim();
                TaiKhoan quanLy = db.TaiKhoans.Find(xuatHang.NguoiQuanLy);
                xuatHang.TaiKhoan = quanLy;
                xuatHang.NgayXuat = dtpkNgayXuat.Value;
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgv.SelectedRows[0].Index;
                chiTietXuats[index].SoLuong = int.Parse(txtSoLuong.Text);

                if (phieuXuatHang != null)
                {
                    phieuXuatHang = db.PhieuXuatHangs.Find(phieuXuatHang.MaPhieuXuatHang);
                    foreach (var item in phieuXuatHang.ChiTietXuats.ToList())
                    {
                        if (item.MaChiTietXuat == chiTietXuats[index].MaChiTietXuat)
                        {
                            item.SoLuong = int.Parse(txtSoLuong.Text);
                            break;
                        }
                    }
                }
                LoadDtgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!!");
            }
        }
    }
}
