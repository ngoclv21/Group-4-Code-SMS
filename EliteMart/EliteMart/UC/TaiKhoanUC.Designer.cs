namespace EliteMart.UC
{
    partial class TaiKhoanUC
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
            this.taiKhoansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQueQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoaiTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoaDons = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhieuXuatHangs = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.taiKhoansBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(817, 472);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDangNhap,
            this.colMatKhau,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colDiaChi,
            this.colQueQuan,
            this.colSoDienThoai,
            this.colMaLoaiTaiKhoan,
            this.colHoaDons,
            this.colLoaiTaiKhoan,
            this.colPhieuXuatHangs});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // taiKhoansBindingSource
            // 
            this.taiKhoansBindingSource.DataSource = typeof(EliteMart.EF.TaiKhoan);
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.FieldName = "TenDangNhap";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 0;
            // 
            // colMatKhau
            // 
            this.colMatKhau.FieldName = "MatKhau";
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.Visible = true;
            this.colMatKhau.VisibleIndex = 1;
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 2;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 3;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 4;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 5;
            // 
            // colQueQuan
            // 
            this.colQueQuan.FieldName = "QueQuan";
            this.colQueQuan.Name = "colQueQuan";
            this.colQueQuan.Visible = true;
            this.colQueQuan.VisibleIndex = 6;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.FieldName = "SoDienThoai";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 7;
            // 
            // colMaLoaiTaiKhoan
            // 
            this.colMaLoaiTaiKhoan.FieldName = "MaLoaiTaiKhoan";
            this.colMaLoaiTaiKhoan.Name = "colMaLoaiTaiKhoan";
            this.colMaLoaiTaiKhoan.Visible = true;
            this.colMaLoaiTaiKhoan.VisibleIndex = 8;
            // 
            // colHoaDons
            // 
            this.colHoaDons.FieldName = "HoaDons";
            this.colHoaDons.Name = "colHoaDons";
            this.colHoaDons.Visible = true;
            this.colHoaDons.VisibleIndex = 9;
            // 
            // colLoaiTaiKhoan
            // 
            this.colLoaiTaiKhoan.FieldName = "LoaiTaiKhoan.TenLoaiTaiKhoan";
            this.colLoaiTaiKhoan.Name = "colLoaiTaiKhoan";
            this.colLoaiTaiKhoan.Visible = true;
            this.colLoaiTaiKhoan.VisibleIndex = 10;
            // 
            // colPhieuXuatHangs
            // 
            this.colPhieuXuatHangs.FieldName = "PhieuXuatHangs";
            this.colPhieuXuatHangs.Name = "colPhieuXuatHangs";
            this.colPhieuXuatHangs.Visible = true;
            this.colPhieuXuatHangs.VisibleIndex = 11;
            // 
            // TaiKhoanUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "TaiKhoanUC";
            this.Size = new System.Drawing.Size(817, 524);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoansBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource taiKhoansBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colQueQuan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colHoaDons;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieuXuatHangs;
    }
}
