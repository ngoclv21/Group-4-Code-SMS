﻿using EliteMart.AppCode;
using EliteMart.EF;
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
    public partial class Manager : Form, Triggerable
    {

        #region menu
        private bool isMouseDown = false;
        private int x, y;

        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            x = e.X;
            y = e.Y;
        }

        private void pn_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(this.Location.X + e.X - x, this.Location.Y + e.Y - y);
            }
        }

        private void pn_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            x = e.X;
            y = e.Y;
        }

        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(this.Location.X + e.X - x, this.Location.Y + e.Y - y);
            }
        }

        private void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        public Manager()
        {
            InitializeComponent();
            panel3.BringToFront();
            
        }
        private void Manager_Load(object sender, EventArgs e)
        {
            HomeUC uc = new HomeUC();
            uc.Width = pnContent.Width;
            uc.Height = pnContent.Height;
            pnContent.Controls.Add(uc);
            AppState.ManagerForm = this;
            CheckRole();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckRole()
        {
            try
            {
                int maLoaiTaiKhoan = Session.LoginAccount.MaLoaiTaiKhoan.Value;
                switch (maLoaiTaiKhoan)
                {
                    case Role.NHAN_VIEN:
                        btnThongKe.ForeColor = Color.Gray;
                        btnTaiKhoan.ForeColor = Color.Gray;
                        btnNhaCungCap.ForeColor = Color.Gray;
                        btnXuatHang.ForeColor = Color.Gray;
                        btnNhapHang.ForeColor = Color.Gray;
                        break;
                    case Role.THU_KHO:
                        btnThongKe.ForeColor = Color.Gray;
                        btnTaiKhoan.ForeColor = Color.Gray;
                        btnNhaCungCap.ForeColor = Color.Gray;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                
            }
        }

        private bool checkRole(object sender)
        {
            Button s = sender as Button;
            if (s.ForeColor == Color.Gray)
            {
                return false;
            }
            return true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(!checkRole(sender))
            {
                return;
            }

            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            HomeUC uc = new HomeUC();
            uc.Width = pnContent.Width;
            uc.Height = pnContent.Height;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            if (!checkRole(sender))
            {
                return;
            }
            SidePanel.Height = btnKhoHang.Height;
            SidePanel.Top = btnKhoHang.Top;
            KhoHangUC uc = new KhoHangUC();
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Width = pnContent.Width;
            uc.Height = pnContent.Height;
            uc.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (!checkRole(sender))
            {
                return;
            }
            SidePanel.Height = btnNhapHang.Height;
            SidePanel.Top = btnNhapHang.Top;
            NhapHangUC uc = new NhapHangUC();
            uc.Width = pnContent.Width;
            uc.Height = pnContent.Height;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            if (!checkRole(sender))
            {
                return;
            }
            SidePanel.Height = btnXuatHang.Height;
            SidePanel.Top = btnXuatHang.Top;
            XuatHangUC uc = new XuatHangUC();
            uc.Width = pnContent.Width;
            uc.Height = pnContent.Height;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (!checkRole(sender))
            {
                return;
            }
            SidePanel.Height = btnKhachHang.Height;
            SidePanel.Top = btnKhachHang.Top;
            KhachHangUC uc = new KhachHangUC();
            uc.Width = pnContent.Width;
            uc.Height = pnContent.Height;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            if (!checkRole(sender))
            {
                return;
            }
            SidePanel.Height = btnNhaCungCap.Height;
            SidePanel.Top = btnNhaCungCap.Top;
            NhaCungCapUC uc = new NhaCungCapUC();
            uc.Width = pnContent.Width;
            uc.Height = pnContent.Height;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (!checkRole(sender))
            {
                return;
            }
            SidePanel.Height = btnHoaDon.Height;
            SidePanel.Top = btnHoaDon.Top;
            HoaDonUC uc = new HoaDonUC();
            uc.Width = pnContent.Width;
            uc.Height = pnContent.Height;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!checkRole(sender))
            {
                return;
            }
            SidePanel.Height = btnTaiKhoan.Height;
            SidePanel.Top = btnTaiKhoan.Top;
            TaiKhoanUC uc = new TaiKhoanUC();
            uc.Width = pnContent.Width;
            uc.Height = pnContent.Height;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (!checkRole(sender))
            {
                return;
            }
            SidePanel.Height = btnThongKe.Height;
            SidePanel.Top = btnThongKe.Top;
            ThongKeUC uc = new ThongKeUC();
            uc.Width = pnContent.Width;
            uc.Height = pnContent.Height;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }
        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            if (!checkRole(sender))
            {
                return;
            }
            SidePanel.Height = btnThongTinCaNhan.Height;
            SidePanel.Top = btnThongTinCaNhan.Top;
            ThongTinCaNhanUC uc = new ThongTinCaNhanUC();
            uc.Width = pnContent.Width;
            uc.Height = pnContent.Height;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
            uc.Show();
        }
        public void Trigger()
        {
            
        }

        public void Trigger(string screen)
        {
            switch (screen)
            {
                case ScreenName.CREATE_NHAP_HANG:
                    CreateNhapHangUC uc = new CreateNhapHangUC();
                    uc.Width = pnContent.Width;
                    uc.Height = pnContent.Height;
                    pnContent.Controls.Clear();
                    pnContent.Controls.Add(uc);
                    uc.Show();
                    break;
                case ScreenName.CREATE_XUAT_HANG:
                    CreateXuatHangUC uc2 = new CreateXuatHangUC();
                    uc2.Width = pnContent.Width;
                    uc2.Height = pnContent.Height;
                    pnContent.Controls.Clear();
                    pnContent.Controls.Add(uc2);
                    uc2.Show();
                    break;
                case ScreenName.CREATE_HOA_DON:
                    CreateHoaDonUC uc3 = new CreateHoaDonUC();
                    uc3.Width = pnContent.Width;
                    uc3.Height = pnContent.Height;
                    pnContent.Controls.Clear();
                    pnContent.Controls.Add(uc3);
                    uc3.Show();
                    break;
                default:
                    break;
            }
        }

        public void Trigger(string screen, object o)
        {
            switch (screen)
            {
                case ScreenName.CREATE_NHAP_HANG:
                    CreateNhapHangUC uc = new CreateNhapHangUC((PhieuNhapHang)o);
                    uc.Width = pnContent.Width;
                    uc.Height = pnContent.Height;
                    pnContent.Controls.Clear();
                    pnContent.Controls.Add(uc);
                    uc.Show();
                    break;
                case ScreenName.CREATE_XUAT_HANG:
                    CreateXuatHangUC uc2 = new CreateXuatHangUC((PhieuXuatHang)o);
                    uc2.Width = pnContent.Width;
                    uc2.Height = pnContent.Height;
                    pnContent.Controls.Clear();
                    pnContent.Controls.Add(uc2);
                    uc2.Show();
                    break;
                case ScreenName.CREATE_HOA_DON:
                    CreateHoaDonUC uc3 = new CreateHoaDonUC((HoaDon)o);
                    uc3.Width = pnContent.Width;
                    uc3.Height = pnContent.Height;
                    pnContent.Controls.Clear();
                    pnContent.Controls.Add(uc3);
                    uc3.Show();
                    break;
                default:
                    break;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đồ án cửa hàng Elite Mart");
        }

        private void btnFb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/mai.anhh.54");
        }
    }
}
