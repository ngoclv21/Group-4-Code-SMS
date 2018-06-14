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
    public partial class NhaCungCapUC : UserControl
    {
        public NhaCungCapUC()
        {
            InitializeComponent();
        }

        private BindingSource bds = new BindingSource();
        private AppDB db = new AppDB();
        private void NhaCungCapUC_Load(object sender, EventArgs e)
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
            bds.DataSource = db.NhaCungCaps.Select(x => new { x.MaNhaCungCap, x.HoTen, GioiTinh = x.GioiTinh == true ? "Nữ" : "Nam", x.NgaySinh, x.DiaChi, x.QueQuan, x.SoDienThoai, x }).ToList();
        }
        public void ChangHeader()
        {
            dtgv.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
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
            txtMaNCC.DataBindings.Add("Text", dtgv.DataSource, "MaNhaCungCap", true, DataSourceUpdateMode.Never);
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
                NhaCungCap supplier = new NhaCungCap();
                supplier.HoTen = txtHoTen.Text;
                supplier.NgaySinh = dtpkNgaySinh.Value;
                supplier.DiaChi = txtDiaChi.Text;
                supplier.QueQuan = txtQueQuan.Text;
                supplier.SoDienThoai = txtSoDienThoai.Text;
                supplier.GioiTinh = cbxGioiTinh.Text == "Nam" ? false : true;

                db.NhaCungCaps.Add(supplier);
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
                NhaCungCap supplier = db.NhaCungCaps.Find(int.Parse(txtMaNCC.Text));
                supplier.HoTen = txtHoTen.Text;
                supplier.NgaySinh = dtpkNgaySinh.Value;
                supplier.DiaChi = txtDiaChi.Text;
                supplier.QueQuan = txtQueQuan.Text;
                supplier.SoDienThoai = txtSoDienThoai.Text;
                supplier.GioiTinh = cbxGioiTinh.Text == "Nam" ? false : true;
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
                NhaCungCap supplier = db.NhaCungCaps.Find(int.Parse(txtMaNCC.Text));
                try
                {
                    db.NhaCungCaps.Remove(supplier);
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
            bds.DataSource = db.NhaCungCaps.Select(x => new { x.MaNhaCungCap, x.HoTen, GioiTinh = x.GioiTinh == true ? "Nữ" : "Nam", x.NgaySinh, x.DiaChi, x.QueQuan, x.SoDienThoai, x }).Where(x => x.MaNhaCungCap.ToString().Contains(txtTimKiem.Text)
            || x.HoTen.Contains(txtTimKiem.Text) || x.DiaChi.Contains(txtTimKiem.Text)).ToList();
        }

        

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
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
