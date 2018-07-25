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

        public ReportBySupplierSpreadSheet()
        {
            InitializeComponent();

            workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(@"Template\Supplier.xlsx", DocumentFormat.Xlsx);
        }
    }
}
