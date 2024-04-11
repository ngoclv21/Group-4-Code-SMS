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

namespace EliteMart.UC
{
    public partial class TaiKhoanUC : UserControl
    {
        public TaiKhoanUC()
        {
            InitializeComponent();
        }

        private BindingSource bds = new BindingSource();
        private AppDB db = new AppDB();

        private void TaiKhoanUC_Load(object sender, EventArgs e)
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
            bds.DataSource = db.TaiKhoans.Select(x => new { x.TenDangNhap, x.HoTen, GioiTinh = x.GioiTinh == true ? "Nữ" : "Nam", x.NgaySinh, x.DiaChi, x.QueQuan, x.SoDienThoai, x.LoaiTaiKhoan.TenLoaiTaiKhoan, x  }).ToList();
        }
        public void ChangHeader()
        {
            dtgv.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dtgv.Columns["HoTen"].HeaderText = "Họ tên";
            dtgv.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtgv.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgv.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgv.Columns["QueQuan"].HeaderText = "Quê quán";
            dtgv.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgv.Columns["TenLoaiTaiKhoan"].HeaderText = "Loại tài khoản";
        }
        public void HideColumn()
        {
            dtgv.Columns["x"].Visible = false;
        }
        public void LoadDataBinding()
        {
            txtTenDangNhap.DataBindings.Add("Text", dtgv.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never);
            txtHoTen.DataBindings.Add("Text", dtgv.DataSource, "HoTen", true, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", dtgv.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
            txtQueQuan.DataBindings.Add("Text", dtgv.DataSource, "QueQuan", true, DataSourceUpdateMode.Never);
            txtSoDienThoai.DataBindings.Add("Text", dtgv.DataSource, "SoDienThoai", true, DataSourceUpdateMode.Never);
            dtpkNgaySinh.DataBindings.Add("Value", dtgv.DataSource, "x.NgaySinh", true, DataSourceUpdateMode.Never);
            cbxLoaiTaiKhoan.DataBindings.Add("SelectedValue", dtgv.DataSource, "x.MaLoaiTaiKhoan", true, DataSourceUpdateMode.Never);
        }

        public void LoadMore()
        {
            cbxLoaiTaiKhoan.DataSource = db.LoaiTaiKhoans.ToList();
            cbxLoaiTaiKhoan.DisplayMember = "TenLoaiTaiKhoan";
            cbxLoaiTaiKhoan.ValueMember = "MaLoaiTaiKhoan";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan account = new TaiKhoan();
                account.TenDangNhap = txtTenDangNhap.Text;
                account.HoTen = txtHoTen.Text;
                account.NgaySinh = dtpkNgaySinh.Value;
                account.MatKhau = "12345";
                account.MaLoaiTaiKhoan = (int)cbxLoaiTaiKhoan.SelectedValue;
                account.DiaChi = txtDiaChi.Text;
                account.QueQuan = txtQueQuan.Text;
                account.SoDienThoai = txtSoDienThoai.Text;
                account.GioiTinh = cbxGioiTinh.Text == "Nam" ? false : true;

                db.TaiKhoans.Add(account);
                db.SaveChanges();
                MessageBox.Show("Thêm mới thành công. Mật khẩu mặc định là '12345'");
                LoadDtgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm mới không thành công. Vui lòng kiểm tra lại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan account = db.TaiKhoans.Find(txtTenDangNhap.Text);
                if (account == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản để cập nhật.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtQueQuan.Text) ||
                    string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin tài khoản.");
                    return;
                }
                account.HoTen = txtHoTen.Text;
                account.NgaySinh = dtpkNgaySinh.Value;
                account.MatKhau = "12345";
                account.MaLoaiTaiKhoan = (int)cbxLoaiTaiKhoan.SelectedValue;
                account.DiaChi = txtDiaChi.Text;
                account.QueQuan = txtQueQuan.Text;
                account.SoDienThoai = txtSoDienThoai.Text;
                account.GioiTinh = cbxGioiTinh.Text == "Nam" ? false : true;
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
                LoadDtgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công. Vui lòng kiểm tra lại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa",
                                     "Xác nhận!!",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                TaiKhoan account = db.TaiKhoans.Find(txtTenDangNhap.Text);
                try
                {
                    db.TaiKhoans.Remove(account);
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
            bds.DataSource = db.TaiKhoans.Select(x => new { x.TenDangNhap, x.HoTen, GioiTinh = x.GioiTinh == true ? "Nữ" : "Nam", x.NgaySinh, x.DiaChi, x.QueQuan, x.SoDienThoai, x.LoaiTaiKhoan.TenLoaiTaiKhoan, x }).Where(x => x.TenDangNhap.ToString().Contains(txtTimKiem.Text)
            || x.HoTen.Contains(txtTimKiem.Text) || x.TenLoaiTaiKhoan.Contains(txtTimKiem.Text)).ToList();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if(dtgv.SelectedRows[0].Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                cbxGioiTinh.SelectedIndex = 0;
            }
            else
            {
                cbxGioiTinh.SelectedIndex = 1;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
