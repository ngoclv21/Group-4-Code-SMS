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
using System.Data.Entity;

namespace EliteMart.UC
{
    public partial class KhoHangUC : UserControl
    {
        public KhoHangUC()
        {
            InitializeComponent();
        }

        private BindingSource bds = new BindingSource();
        private AppDB db = new AppDB();

        private void KhoHangUC_Load(object sender, EventArgs e)
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
            bds.DataSource = db.HangHoas.Select(x => new { x.MaHangHoa, x.TenHangHoa, x.DonGiaNhap, x.GiaBanLe, x.GiaBanBuon, x.SoLuong, x.ThanhPhan, x.DonViTinh ,x }).ToList();
        }
        public void ChangHeader()
        {
            dtgv.Columns["MaHangHoa"].HeaderText = "Mã hàng hóa";
            dtgv.Columns["TenHangHoa"].HeaderText = "Tên hàng hóa";
            dtgv.Columns["DonGiaNhap"].HeaderText = "Đơn giá nhập";
            dtgv.Columns["GiaBanLe"].HeaderText = "Giá bán lẻ";
            dtgv.Columns["GiaBanBuon"].HeaderText = "Giá bán buôn";
            dtgv.Columns["SoLuong"].HeaderText = "Số lượng";
            dtgv.Columns["ThanhPhan"].HeaderText = "Thành phần";
            dtgv.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
        }
        public void HideColumn()
        {
            dtgv.Columns["x"].Visible = false;
        }
        public void LoadDataBinding()
        {
            txtMaHangHoa.DataBindings.Add("Text", dtgv.DataSource, "MaHangHoa", true, DataSourceUpdateMode.Never);
            txtTenHangHoa.DataBindings.Add("Text", dtgv.DataSource, "TenHangHoa", true, DataSourceUpdateMode.Never);
            txtDonViTinh.DataBindings.Add("Text", dtgv.DataSource, "DonViTinh", true, DataSourceUpdateMode.Never);
            txtDonGiaNhap.DataBindings.Add("Text", dtgv.DataSource, "DonGiaNhap", true, DataSourceUpdateMode.Never);
            txtGiaBanLe.DataBindings.Add("Text", dtgv.DataSource, "GiaBanLe", true, DataSourceUpdateMode.Never);
            txtGiaBanBuon.DataBindings.Add("Text", dtgv.DataSource, "GiaBanBuon", true, DataSourceUpdateMode.Never);
            txtThanhPhan.DataBindings.Add("Text", dtgv.DataSource, "ThanhPhan", true, DataSourceUpdateMode.Never);
            txtSoLuong.DataBindings.Add("Text", dtgv.DataSource, "SoLuong", true, DataSourceUpdateMode.Never);
        }

        public void LoadMore()
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa hangHoa = new HangHoa();
                hangHoa.TenHangHoa = txtTenHangHoa.Text;
                hangHoa.DonViTinh = txtDonViTinh.Text;
                hangHoa.ThanhPhan = txtThanhPhan.Text;
                hangHoa.SoLuong = int.Parse(txtSoLuong.Text);
                hangHoa.DonGiaNhap = double.Parse(txtDonGiaNhap.Text);
                hangHoa.GiaBanLe = double.Parse(txtGiaBanLe.Text);
                hangHoa.GiaBanBuon = double.Parse(txtGiaBanBuon.Text);

                db.HangHoas.Add(hangHoa);
                db.SaveChanges();
                MessageBox.Show("Thêm mới thành công");
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
                HangHoa hangHoa = db.HangHoas.Find(int.Parse(txtMaHangHoa.Text));
                hangHoa.TenHangHoa = txtTenHangHoa.Text;
                hangHoa.DonViTinh = txtDonViTinh.Text;
                hangHoa.ThanhPhan = txtThanhPhan.Text;
                //hangHoa.SoLuong = int.Parse(txtSoLuong.Text);
                hangHoa.DonGiaNhap = double.Parse(txtDonGiaNhap.Text);
                hangHoa.GiaBanLe = double.Parse(txtGiaBanLe.Text);
                hangHoa.GiaBanBuon = double.Parse(txtGiaBanBuon.Text);
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
                HangHoa hangHoa = db.HangHoas.Find(int.Parse(txtMaHangHoa.Text));
                try
                {
                    db.HangHoas.Remove(hangHoa);
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
            bds.DataSource = db.HangHoas.Select(x => new { x.MaHangHoa, x.TenHangHoa, x.DonGiaNhap, x.GiaBanLe, x.GiaBanBuon, x.SoLuong, x.ThanhPhan, x.DonViTinh, x }).Where(x => x.MaHangHoa.ToString().Contains(txtTimKiem.Text)
            || x.TenHangHoa.Contains(txtTimKiem.Text) || x.ThanhPhan.Contains(txtTimKiem.Text)).ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
