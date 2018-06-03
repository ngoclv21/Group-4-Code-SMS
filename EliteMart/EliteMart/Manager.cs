using EliteMart.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteMart
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            panel3.BringToFront();

            pnContent.Controls.Add(new HomeUC());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            HomeUC uc = new HomeUC();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnKhoHang.Height;
            SidePanel.Top = btnKhoHang.Top;
            KhoHangUC uc = new KhoHangUC();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnNhapHang.Height;
            SidePanel.Top = btnNhapHang.Top;
            NhapHangUC uc = new NhapHangUC();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnXuatHang.Height;
            SidePanel.Top = btnXuatHang.Top;
            XuatHangUC uc = new XuatHangUC();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnKhachHang.Height;
            SidePanel.Top = btnKhachHang.Top;
            KhachHangUC uc = new KhachHangUC();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnNhaCungCap.Height;
            SidePanel.Top = btnNhaCungCap.Top;
            NhaCungCapUC uc = new NhaCungCapUC();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHoaDon.Height;
            SidePanel.Top = btnHoaDon.Top;
            HoaDonUC uc = new HoaDonUC();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTaiKhoan.Height;
            SidePanel.Top = btnTaiKhoan.Top;
            TaiKhoanUC uc = new TaiKhoanUC();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnThongKe.Height;
            SidePanel.Top = btnThongKe.Top;
            ThongKeUC uc = new ThongKeUC();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }
    }
}
