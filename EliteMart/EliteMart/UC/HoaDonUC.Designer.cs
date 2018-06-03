namespace EliteMart.UC
{
    partial class HoaDonUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hoaDonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colMaHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQueQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTietHoaDons = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hoaDonsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(817, 472);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHoaDon,
            this.colNhanVien,
            this.colNgayLap,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colDiaChi,
            this.colQueQuan,
            this.colSoDienThoai,
            this.colChiTietHoaDons,
            this.colTaiKhoan});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // hoaDonsBindingSource
            // 
            this.hoaDonsBindingSource.DataSource = typeof(EliteMart.EF.HoaDon);
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.FieldName = "MaHoaDon";
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.Visible = true;
            this.colMaHoaDon.VisibleIndex = 0;
            // 
            // colNhanVien
            // 
            this.colNhanVien.FieldName = "NhanVien";
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.Visible = true;
            this.colNhanVien.VisibleIndex = 1;
            // 
            // colNgayLap
            // 
            this.colNgayLap.FieldName = "NgayLap";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 2;
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 3;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 4;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 5;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 6;
            // 
            // colQueQuan
            // 
            this.colQueQuan.FieldName = "QueQuan";
            this.colQueQuan.Name = "colQueQuan";
            this.colQueQuan.Visible = true;
            this.colQueQuan.VisibleIndex = 7;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 8;
            // 
            // colChiTietHoaDons
            // 
            this.colChiTietHoaDons.FieldName = "ChiTietHoaDons";
            this.colChiTietHoaDons.Name = "colChiTietHoaDons";
            this.colChiTietHoaDons.Visible = true;
            this.colChiTietHoaDons.VisibleIndex = 9;
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.FieldName = "TaiKhoan";
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.Visible = true;
            this.colTaiKhoan.VisibleIndex = 10;
            // 
            // HoaDonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "HoaDonUC";
            this.Size = new System.Drawing.Size(817, 524);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource hoaDonsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colQueQuan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTietHoaDons;
        private DevExpress.XtraGrid.Columns.GridColumn colTaiKhoan;
    }
}
