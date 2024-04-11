using DevExpress.Spreadsheet;
using EliteMart.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteMart.SpreetSeed
{
    public partial class ReportBySupplierSpreadSheet : Form
    {
        IWorkbook workbook;
        DataView dataView;

        private AppDB db = new AppDB();

        public ReportBySupplierSpreadSheet(string maNhaCungCap)
        {
            InitializeComponent();

            workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(@"Template\Supplier.xlsx", DocumentFormat.Xlsx);
            try
            {
                NhaCungCap nhaCungCap = db.NhaCungCaps.Find(int.Parse(maNhaCungCap));
                Worksheet sheet1 = workbook.Worksheets[0];
                var list = db.ChiTietNhaps.Where(x => x.PhieuNhapHang.MaNhaCungCap == nhaCungCap.MaNhaCungCap).GroupBy(x => x.HangHoa).Select(x => new { HangHoa = x.Key, SoLuong = x.Sum(s => s.SoLuong) }).ToList();
                int stt = 1;
                foreach (var item in list)
                {
                    sheet1.Cells[stt + 1, 0].Value = stt;
                    sheet1.Cells[stt + 1, 1].Value = item.HangHoa.MaHangHoa;
                    sheet1.Cells[stt + 1, 2].Value = item.HangHoa.TenHangHoa;
                    sheet1.Cells[stt + 1, 3].Value = item.HangHoa.ThanhPhan;
                    sheet1.Cells[stt + 1, 4].Value = item.HangHoa.DonGiaNhap;
                    sheet1.Cells[stt + 1, 5].Value = item.SoLuong;
                    stt++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
            
        }
    }
}
