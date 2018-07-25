using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteMart.AppCode
{
    public class ReportByTimeModel
    {
        public string TheoLoai { get; set; }
        public double SoTienNhapHang { get; set; }
        public double SoTienXuatHang { get; set; }
        public double TienBanLe { get; set; }
        public double DoanhThu { get; set; }
        public double TonKho { get; set; }
        public string SanPhamBanChayNhat { get; set; }
        public string SanPhamBanKemNhat { get; set; }
        public string ChayNhatBanLe { get; set; }
        public string ChayNhatTheoDonXuat { get; set; }
        public string KemNhatBanLe { get; set; }
        public string KemNhatTheoDonXuat { get; set; }
    }
}
