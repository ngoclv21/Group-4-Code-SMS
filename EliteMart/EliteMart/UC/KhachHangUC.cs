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
                KhachHang customer = new KhachHang();
                customer.HoTen = txtHoTen.Text;
                customer.NgaySinh = dtpkNgaySinh.Value;
                customer.DiaChi = txtDiaChi.Text;
                customer.QueQuan = txtQueQuan.Text;
                customer.SoDienThoai = txtSoDienThoai.Text;
                customer.GioiTinh = cbxGioiTinh.Text == "Nam" ? true : false;

                db.KhachHangs.Add(customer);
                db.SaveChanges();
                MessageBox.Show("Thêm mới thành công.");
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
                KhachHang customer = db.KhachHangs.Find(int.Parse(txtMaKhachHang.Text));
                customer.HoTen = txtHoTen.Text;
                customer.NgaySinh = dtpkNgaySinh.Value;
                customer.DiaChi = txtDiaChi.Text;
                customer.QueQuan = txtQueQuan.Text;
                customer.SoDienThoai = txtSoDienThoai.Text;
                customer.GioiTinh = cbxGioiTinh.Text == "Nam" ? true : false;
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
                KhachHang customer = db.KhachHangs.Find(int.Parse(txtMaKhachHang.Text));
                try
                {
                    db.KhachHangs.Remove(customer);
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
    }
}
