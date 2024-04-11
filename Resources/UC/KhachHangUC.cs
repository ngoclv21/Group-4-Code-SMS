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
    public partial class KhachHangUC : UserControl
    {
        public KhachHangUC()
        {
            InitializeComponent();
        }

        private BindingSource bds = new BindingSource();
        private AppDB db = new AppDB();

        private void KhachHangUC_Load(object sender, EventArgs e)
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
            bds.DataSource = db.KhachHangs.Select(x => new { x.MaKhachHang, x.HoTen, GioiTinh = x.GioiTinh == true ? "Nữ" : "Nam", x.NgaySinh, x.DiaChi, x.QueQuan, x.SoDienThoai, x }).ToList();
        }
        public void ChangHeader()
        {
            dtgv.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
            dtgv.Columns["HoTen"].HeaderText = "Họ tên";
            dtgv.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtgv.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgv.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgv.Columns["QueQuan"].HeaderText = "Quê quán";
            dtgv.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
        }
        public void HideColumn()
        {
            dtgv.Columns["x"].Visible = false;
        }
        public void LoadDataBinding()
        {
            txtMaKhachHang.DataBindings.Add("Text", dtgv.DataSource, "MaKhachHang", true, DataSourceUpdateMode.Never);
            txtHoTen.DataBindings.Add("Text", dtgv.DataSource, "HoTen", true, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", dtgv.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
            txtQueQuan.DataBindings.Add("Text", dtgv.DataSource, "QueQuan", true, DataSourceUpdateMode.Never);
            txtSoDienThoai.DataBindings.Add("Text", dtgv.DataSource, "SoDienThoai", true, DataSourceUpdateMode.Never);
            dtpkNgaySinh.DataBindings.Add("Value", dtgv.DataSource, "x.NgaySinh", true, DataSourceUpdateMode.Never);
        }

        public void LoadMore()
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                     string.IsNullOrWhiteSpace(txtQueQuan.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin khách hàng.");
                    return; // Không thêm khách hàng nếu thiếu thông tin
                }

                // Kiểm tra xem số điện thoại đã tồn tại trong cơ sở dữ liệu hay chưa
                string soDienThoai = txtSoDienThoai.Text;
                var existingCustomer = db.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == soDienThoai);

                if (existingCustomer != null)
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại trong cơ sở dữ liệu. Vui lòng kiểm tra lại.");
                    return;
                }

                // Thêm mới khách hàng vào cơ sở dữ liệu
                KhachHang customer = new KhachHang();
                customer.HoTen = txtHoTen.Text;
                customer.NgaySinh = dtpkNgaySinh.Value;
                customer.DiaChi = txtDiaChi.Text;
                customer.QueQuan = txtQueQuan.Text;
                customer.SoDienThoai = txtSoDienThoai.Text;
                customer.GioiTinh = cbxGioiTinh.Text == "Nam" ? false : true;

                db.KhachHangs.Add(customer);
                db.SaveChanges();
                MessageBox.Show("Thêm mới thành công.");
                LoadDtgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm mới không thành công. Vui lòng kiểm tra lại. Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtQueQuan.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ||
                    string.IsNullOrWhiteSpace(txtMaKhachHang.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin khách hàng.");
                    return; // Không thêm khách hàng nếu thiếu thông tin
                }

                int maKhachHang = int.Parse(txtMaKhachHang.Text);

                // Kiểm tra xem mã khách hàng đã tồn tại trong cơ sở dữ liệu hay chưa
                var existingCustomer = db.KhachHangs.FirstOrDefault(kh => kh.MaKhachHang == maKhachHang);

                if (existingCustomer == null)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại trong cơ sở dữ liệu. Vui lòng chọn mã khác.");
                    return;
                }

                // Cập nhật thông tin cho khách hàng
                existingCustomer.HoTen = txtHoTen.Text;
                existingCustomer.NgaySinh = dtpkNgaySinh.Value;
                existingCustomer.DiaChi = txtDiaChi.Text;
                existingCustomer.QueQuan = txtQueQuan.Text;
                existingCustomer.SoDienThoai = txtSoDienThoai.Text;
                existingCustomer.GioiTinh = cbxGioiTinh.Text == "Nam" ? false : true;

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
            try
            {
                // Kiểm tra xem người dùng đã chọn một khách hàng để xóa chưa
                if (string.IsNullOrWhiteSpace(txtMaKhachHang.Text))
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
                    return;
                }

                // Lấy mã khách hàng từ TextBox
                int maKhachHang = int.Parse(txtMaKhachHang.Text);

                // Tìm kiếm khách hàng trong cơ sở dữ liệu
                KhachHang customer = db.KhachHangs.Find(maKhachHang);

                // Kiểm tra xem khách hàng có tồn tại không
                if (customer == null)
                {
                    MessageBox.Show("Khách hàng không tồn tại trong cơ sở dữ liệu.");
                    return;
                }

                // Xóa khách hàng từ cơ sở dữ liệu
                db.KhachHangs.Remove(customer);
                db.SaveChanges();

                // Hiển thị thông báo thành công và cập nhật DataGridView
                MessageBox.Show("Xóa khách hàng thành công.");
                LoadDtgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa khách hàng: " + ex.Message);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadDtgv();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bds.DataSource = db.KhachHangs.Where(x => x.MaKhachHang.ToString().Contains(txtTimKiem.Text)
            || x.HoTen.Contains(txtTimKiem.Text) || x.DiaChi.Contains(txtTimKiem.Text)).ToList();
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (dtgv.SelectedRows[0].Cells["GioiTinh"].Value.ToString() == "Nam")
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
