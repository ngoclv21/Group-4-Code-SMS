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
    public partial class CreateNhapHangUC : UserControl
    {
        public CreateNhapHangUC()
        {
            InitializeComponent();
        }

        private AppDB db = new AppDB();
        private BindingSource bds = new BindingSource();
        private List<ChiTietNhap> chiTietNhaps = new List<ChiTietNhap>();

        private void CreateNhapHangUC_Load(object sender, EventArgs e)
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
            bds.DataSource = chiTietNhaps.Select(x => new {x.MaHangHoa, x.HangHoa.TenHangHoa, x.SoLuong, x.DonGia }).ToList();
        }
        public void LoadMore()
        {
            //list hàng hóa
            var sourceHangHoas = new AutoCompleteStringCollection();
            List<HangHoa> hangHoas = db.HangHoas.ToList();
            foreach (var item in hangHoas)
            {
                sourceHangHoas.Add(item.MaHangHoa + " - " + item.TenHangHoa);
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
                HangHoa hangHoa = db.HangHoas.Find(int.Parse(txtHangHoa.Text.Split('-')[0]));
                chiTietNhap.HangHoa = hangHoa;
                chiTietNhap.MaHangHoa = hangHoa.MaHangHoa;
                chiTietNhap.DonGia = hangHoa.DonGia;
                chiTietNhaps.Add(chiTietNhap);
                LoadDtgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!!!");
            }
            
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuNhapHang nhapHang = new PhieuNhapHang();
                nhapHang.MaNhaCungCap = (int)cbxNhaCungCap.SelectedValue;
                nhapHang.NguoiQuanLy = txtNguoiNhap.Text.Split('-')[0];
                nhapHang.NgayNhap = dtpkNhayNhap.Value;
                nhapHang.ChiTietNhaps = chiTietNhaps;
                db.PhieuNhapHangs.Add(nhapHang);
                db.SaveChanges();
                MessageBox.Show("Tạo thành công phiếu nhập hàng");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!!!");
            }
        }

        
    }
}
