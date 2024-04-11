using DevExpress.Spreadsheet;
using EliteMart.AppCode;
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
    public partial class ReportByTimeSpreedSheet : Form
    {
        IWorkbook workbook;
        DataView dataView;

        private AppDB db = new AppDB();

        public ReportByTimeSpreedSheet(ReportByTimeModel model)
        {
            InitializeComponent();

            workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(@"Template\Time.xlsx", DocumentFormat.Xlsx);
            Worksheet sheet1 = workbook.Worksheets[0];
            sheet1.Cells[0, 1].Value = string.Format("Thống kê {0}", model.TheoLoai);
            sheet1.Cells[1, 2].Value = model.SoTienNhapHang;
            sheet1.Cells[2, 2].Value = model.SoTienXuatHang;
            sheet1.Cells[3, 2].Value = model.TienBanLe;
            sheet1.Cells[4, 2].Value = model.DoanhThu;
            sheet1.Cells[5, 2].Value = model.TonKho;
            sheet1.Cells[6, 2].Value = model.SanPhamBanChayNhat;
            sheet1.Cells[7, 2].Value = model.ChayNhatBanLe;
            sheet1.Cells[8, 2].Value = model.ChayNhatTheoDonXuat;
            sheet1.Cells[9, 2].Value = model.SanPhamBanKemNhat;
            sheet1.Cells[10, 2].Value = model.KemNhatBanLe;
            sheet1.Cells[11, 2].Value = model.KemNhatTheoDonXuat;
        }
    }
}
