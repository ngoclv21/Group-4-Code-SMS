using EliteMart.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteMart.AppCode
{
    public class SanPhamThongKeModel : IComparable<SanPhamThongKeModel>
    {
        public HangHoa SanPham { get; set; }
        public int SoLuongBanLe { get; set; }
        public int SoLuongTheoPhieuXuat { get; set; }
        public int Tong { get; set; }

        public int CompareTo(SanPhamThongKeModel other)
        {
            if (other == null)
                return 1;
            else
                return other.Tong.CompareTo(Tong);
        }
    }
}
