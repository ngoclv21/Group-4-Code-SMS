namespace EliteMart.UC
{
    partial class XuatHangUC
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
            this.phieuXuatHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colMaPhieuXuatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTietXuats = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatHangsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.phieuXuatHangsBindingSource;
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
            this.colMaPhieuXuatHang,
            this.colNguoiQuanLy,
            this.colMaKhachHang,
            this.colNgayXuat,
            this.colChiTietXuats,
            this.colKhachHang,
            this.colTaiKhoan});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // phieuXuatHangsBindingSource
            // 
            this.phieuXuatHangsBindingSource.DataSource = typeof(EliteMart.EF.PhieuXuatHang);
            // 
            // colMaPhieuXuatHang
            // 
            this.colMaPhieuXuatHang.FieldName = "MaPhieuXuatHang";
            this.colMaPhieuXuatHang.Name = "colMaPhieuXuatHang";
            this.colMaPhieuXuatHang.Visible = true;
            this.colMaPhieuXuatHang.VisibleIndex = 0;
            // 
            // colNguoiQuanLy
            // 
            this.colNguoiQuanLy.FieldName = "NguoiQuanLy";
            this.colNguoiQuanLy.Name = "colNguoiQuanLy";
            this.colNguoiQuanLy.Visible = true;
            this.colNguoiQuanLy.VisibleIndex = 1;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.FieldName = "MaKhachHang";
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.Visible = true;
            this.colMaKhachHang.VisibleIndex = 2;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.FieldName = "NgayXuat";
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.Visible = true;
            this.colNgayXuat.VisibleIndex = 3;
            // 
            // colChiTietXuats
            // 
            this.colChiTietXuats.FieldName = "ChiTietXuats";
            this.colChiTietXuats.Name = "colChiTietXuats";
            this.colChiTietXuats.Visible = true;
            this.colChiTietXuats.VisibleIndex = 4;
            // 
            // colKhachHang
            // 
            this.colKhachHang.FieldName = "KhachHang";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.Visible = true;
            this.colKhachHang.VisibleIndex = 5;
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.FieldName = "TaiKhoan";
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.Visible = true;
            this.colTaiKhoan.VisibleIndex = 6;
            // 
            // XuatHangUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "XuatHangUC";
            this.Size = new System.Drawing.Size(817, 524);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatHangsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource phieuXuatHangsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuXuatHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiQuanLy;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTietXuats;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTaiKhoan;
    }
}
