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
    public partial class ThongTinCaNhanUC : UserControl
    {
        private AppDB db = new AppDB();
        public ThongTinCaNhanUC()
        {
            InitializeComponent();
        }
        private void ThongTinCaNhanUC_Load(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = db.TaiKhoans.Find(Session.LoginAccount.TenDangNhap);
            txtHoTen.Text = taiKhoan.HoTen;
            cbxGioiTinh.Text = taiKhoan.GioiTinh == true ? "Nữ" : "Nam";
            txtQueQuan.Text = taiKhoan.QueQuan;
            txtDiaChi.Text = taiKhoan.DiaChi;
            txtSoDienThoai.Text = taiKhoan.SoDienThoai;
            if (taiKhoan.NgaySinh != null)
            {
                dtpkNgaySinh.Value = taiKhoan.NgaySinh.Value;
            }

        }
        private void btnCapNhatThongTinDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNhapLaiMatKhau.Text == "" || txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập các trường mật khẩu đầy đủ");
                    return;
                }

                if (txtNhapLaiMatKhau.Text != txtMatKhauMoi.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu không khớp");
                    return;
                }

                TaiKhoan taiKhoan = db.TaiKhoans.Find(Session.LoginAccount.TenDangNhap);
                if (taiKhoan.MatKhau != txtMatKhauCu.Text)
                {
                    MessageBox.Show("Mật khẩu không đúng");
                    return;
                }
                taiKhoan.MatKhau = txtMatKhauMoi.Text;
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công");

            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng kiếm tra lại!!!");
            }


        }

        private void btnCapNhatThongTinCaNhan_Click(object sender, EventArgs e)
        {
            try
            {

                // Kiểm tra xem có thiếu thông tin không
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                   string.IsNullOrWhiteSpace(txtQueQuan.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cá nhân.");
                    return; // Không cập nhật thông tin nếu thiếu thông tin
                }
                TaiKhoan taiKhoan = db.TaiKhoans.Find(Session.LoginAccount.TenDangNhap);

                taiKhoan.HoTen = txtHoTen.Text;
                taiKhoan.GioiTinh = cbxGioiTinh.Text == "Nữ" ? true : false;
                taiKhoan.QueQuan = txtQueQuan.Text;
                taiKhoan.DiaChi = txtDiaChi.Text;
                taiKhoan.SoDienThoai = txtSoDienThoai.Text;
                taiKhoan.NgaySinh = dtpkNgaySinh.Value;

                db.SaveChanges();
                Session.LoginAccount = taiKhoan;
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng kiếm tra lại!!!");
            }
        }


    }
}
