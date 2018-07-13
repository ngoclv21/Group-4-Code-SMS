using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text; 
using System.Windows.Forms;
using EliteMart.EF;

namespace EliteMart.UC
{
    public partial class CreateNhapHangUC : UserControl
    {
        PhieuNhapHang phieuNhapHang = null;
        public CreateNhapHangUC()
        {
            InitializeComponent();
        }

        public CreateNhapHangUC(PhieuNhapHang phieuNhapHang)
        {
            InitializeComponent();
            this.phieuNhapHang = phieuNhapHang;

            lblTitle.Text = lblTitle.Text + "  " + phieuNhapHang.MaPhieuNhapHang;
            btnTaoPhieuNhap.Text = "Cập nhật";

        }

        private AppDB db = new AppDB(); //ket noi
        private BindingSource bds = new BindingSource(); //gtri hien thi thuc te
        private List<ChiTietNhap> chiTietNhaps = new List<ChiTietNhap>(); //luu tru datagrid,nguon

        private void CreateNhapHangUC_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            LoadMore();
            dtgv.DataSource = bds;
            LoadDataBinding();
            ChangHeader();

            if (phieuNhapHang != null)
            {
                txtNguoiNhap.Text = phieuNhapHang.NguoiQuanLy + "-" + phieuNhapHang.TaiKhoan.HoTen;
                for (int i = 0; i < cbxNhaCungCap.Items.Count; i++)
                {
                    if ((cbxNhaCungCap.Items[i] as NhaCungCap).MaNhaCungCap == phieuNhapHang.MaNhaCungCap)
                    {
                        cbxNhaCungCap.SelectedIndex = i;
                        break;
                    }
                }
                dtpkNhayNhap.Value = phieuNhapHang.NgayNhap.Value;
            }
        }

        public void LoadDataBinding()
        {
            txtHangHoa.DataBindings.Add("Text", dtgv.DataSource, "MaHangHoa", true, DataSourceUpdateMode.Never);
            txtSoLuong.DataBindings.Add("Text", dtgv.DataSource, "SoLuong", true, DataSourceUpdateMode.Never);
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
            if (phieuNhapHang != null)
            {
                chiTietNhaps = phieuNhapHang.ChiTietNhaps.ToList();
            }
            bds.DataSource = chiTietNhaps.Select(x => new { x.MaHangHoa, x.HangHoa.TenHangHoa, x.SoLuong, x.DonGia }).ToList();
        }
        public void LoadMore()
        {
            //list hàng hóa
            var sourceHangHoas = new AutoCompleteStringCollection();
            List<HangHoa> hangHoas = db.HangHoas.ToList();
            foreach (var item in hangHoas)
            {
                sourceHangHoas.Add(item.TenHangHoa + " - " + item.MaHangHoa);
            }
            txtHangHoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtHangHoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtHangHoa.AutoCompleteCustomSource = sourceHangHoas;

            //list tài khoản
            var sourceTaiKhoans = new AutoCompleteStringCollection();
            List<TaiKhoan> taiKhoans = db.TaiKhoans.Where(x=>x.MaLoaiTaiKhoan == 1).ToList(); // hard code 1 == quản lý
            foreach (var item in taiKhoans)
            {
                sourceTaiKhoans.Add(item.TenDangNhap + " - " + item.HoTen);
            }
            txtNguoiNhap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNguoiNhap.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNguoiNhap.AutoCompleteCustomSource = sourceTaiKhoans;

            //Nhà cung cấp
            cbxNhaCungCap.DataSource = db.NhaCungCaps.ToList();
            cbxNhaCungCap.DisplayMember = "HoTen";
            cbxNhaCungCap.ValueMember = "MaNhaCungCap";
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietNhap chiTietNhap = new ChiTietNhap();
                chiTietNhap.SoLuong = int.Parse(txtSoLuong.Text);
                HangHoa hangHoa = db.HangHoas.Find(int.Parse(txtHangHoa.Text.Split('-')[1].Trim()));
                chiTietNhap.HangHoa = hangHoa;
                chiTietNhap.MaHangHoa = hangHoa.MaHangHoa;
                chiTietNhap.DonGia = hangHoa.DonGiaNhap;
                chiTietNhaps.Add(chiTietNhap);

                if (this.phieuNhapHang != null)
                {
                    phieuNhapHang = db.PhieuNhapHangs.Find(phieuNhapHang.MaPhieuNhapHang);
                    phieuNhapHang.ChiTietNhaps.Add(chiTietNhap);
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
                if (this.phieuNhapHang == null)
                {
                    chiTietNhaps.RemoveAt(index);
                }
                else
                {

                    foreach (var item in phieuNhapHang.ChiTietNhaps.ToList())
                    {
                        if (item.MaChiTietNhap == chiTietNhaps[index].MaChiTietNhap)
                        {
                            phieuNhapHang = db.PhieuNhapHangs.Find(phieuNhapHang.MaPhieuNhapHang);
                            phieuNhapHang.ChiTietNhaps.Remove(item);
                            break;
                        }
                    }
                    chiTietNhaps.RemoveAt(index);
                }
                    
                LoadDtgv();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuNhapHang nhapHang = null;
                if (this.phieuNhapHang == null)
                {
                    nhapHang = new PhieuNhapHang();
                    nhapHang.MaNhaCungCap = (int)cbxNhaCungCap.SelectedValue;
                    nhapHang.NguoiQuanLy = txtNguoiNhap.Text.Split('-')[0].Trim();
                    TaiKhoan quanLy = db.TaiKhoans.Find(nhapHang.NguoiQuanLy);
                    nhapHang.TaiKhoan = quanLy;
                    nhapHang.NgayNhap = dtpkNhayNhap.Value;
                    nhapHang.ChiTietNhaps = chiTietNhaps;
                    db.PhieuNhapHangs.Add(nhapHang);
                    db.SaveChanges();
                    MessageBox.Show("Tạo thành công phiếu nhập hàng");
                }
                else
                {
                    nhapHang = db.PhieuNhapHangs.Find(phieuNhapHang.MaPhieuNhapHang);
                    nhapHang.MaNhaCungCap = (int)cbxNhaCungCap.SelectedValue;
                    nhapHang.NguoiQuanLy = txtNguoiNhap.Text.Split('-')[0].Trim();
                    TaiKhoan quanLy = db.TaiKhoans.Find(nhapHang.NguoiQuanLy);
                    nhapHang.TaiKhoan = quanLy;
                    nhapHang.NgayNhap = dtpkNhayNhap.Value;
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgv.SelectedRows[0].Index;
                chiTietNhaps[index].SoLuong = int.Parse(txtSoLuong.Text);

                if(phieuNhapHang != null)
                {
                    phieuNhapHang = db.PhieuNhapHangs.Find(phieuNhapHang.MaPhieuNhapHang);
                    foreach (var item in phieuNhapHang.ChiTietNhaps.ToList())
                    {
                        if(item.MaChiTietNhap == chiTietNhaps[index].MaChiTietNhap)
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
