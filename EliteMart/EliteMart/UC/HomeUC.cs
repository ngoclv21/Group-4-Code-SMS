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
    public partial class HomeUC : UserControl
    {
        public AppDB db = new AppDB();
        public HomeUC()
        {
            InitializeComponent();
            lblNhanVien.Text = db.TaiKhoans.Count().ToString();
            lblKhachHang.Text = db.KhachHangs.Count().ToString();
            lblNhaCungCap.Text = db.NhaCungCaps.Count().ToString();
            lblNhapHang.Text = db.PhieuNhapHangs.Count().ToString();
            lblXuatHang.Text = db.PhieuXuatHangs.Count().ToString();
            lblHoaDon.Text = db.HoaDons.Count().ToString();
        }
    }
}
