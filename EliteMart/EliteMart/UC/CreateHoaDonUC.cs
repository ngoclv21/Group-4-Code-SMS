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

namespace EliteMart.UC
{
    public partial class CreateHoaDonUC : UserControl
    {
        HoaDon hoaDon = null;

        public CreateHoaDonUC()
        {
            InitializeComponent();
        }

        public CreateHoaDonUC(HoaDon hoaDon)
        {
            InitializeComponent();
            this.hoaDon = hoaDon;
            chiTietHoaDons = hoaDon.ChiTietHoaDons.ToList();
        }

        private AppDB db = new AppDB();
        private BindingSource bds = new BindingSource();
        private List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();

        private void CreateHoaDonUC_Load(object sender, EventArgs e)
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
            bds.DataSource = chiTietHoaDons.Select(x => new { x.MaHangHoa, x.HangHoa.TenHangHoa, x.SoLuong, x.DonGia }).ToList();
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
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.SoLuong = int.Parse(txtSoLuong.Text);
                HangHoa hangHoa = db.HangHoas.Find(int.Parse(txtHangHoa.Text.Split('-')[0]));
                chiTietHoaDon.HangHoa = hangHoa;
                chiTietHoaDon.MaHangHoa = hangHoa.MaHangHoa;
                chiTietHoaDon.DonGia = hangHoa.DonGiaXuat;
                chiTietHoaDons.Add(chiTietHoaDon);
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
                chiTietHoaDons.RemoveAt(index);
                LoadDtgv();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.HoTen = txtHoTen.Text;
                hoaDon.DiaChi = txtDiaChi.Text;
                hoaDon.GioiTinh = cbxGioiTinh.Text == "Nam" ? false : true;
                hoaDon.NgayLap = DateTime.Now;
                hoaDon.QueQuan = txtQueQuan.Text;
                hoaDon.NhanVien = Session.LoginAccount.TenDangNhap;
                hoaDon.SoDienThoai = txtSoDienThoai.Text;
                hoaDon.ChiTietHoaDons = chiTietHoaDons;

                foreach (var item in chiTietHoaDons)
                {
                    HangHoa hangHoa = db.HangHoas.Find(item.MaHangHoa);
                    if (hangHoa.SoLuong < item.SoLuong)
                    {
                        MessageBox.Show("Không đủ hàng : " + hangHoa.MaHangHoa + " - " + hangHoa.TenHangHoa);
                        return;
                    }
                    hangHoa.SoLuong -= item.SoLuong;
                }

                db.HoaDons.Add(hoaDon);
                db.SaveChanges();
                MessageBox.Show("Tạo thành công hóa đơn");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = dtgv.SelectedRows[0].Index;
            chiTietHoaDons[index].SoLuong = int.Parse(txtSoLuong.Text);
            LoadDtgv();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
