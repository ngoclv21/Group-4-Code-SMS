namespace EliteMart.UC
{
    partial class NhapHangUC
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
            this.phieuNhapHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.phieuNhapHangsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colMaPhieuNhapHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTietNhaps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapHangsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapHangsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // phieuNhapHangsBindingSource
            // 
            this.phieuNhapHangsBindingSource.DataSource = typeof(EliteMart.EF.PhieuNhapHang);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.phieuNhapHangsBindingSource1;
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
            this.colMaPhieuNhapHang,
            this.colNguoiQuanLy,
            this.colMaNhaCungCap,
            this.colNgayNhap,
            this.colChiTietNhaps,
            this.colNhaCungCap});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // phieuNhapHangsBindingSource1
            // 
            this.phieuNhapHangsBindingSource1.DataSource = typeof(EliteMart.EF.PhieuNhapHang);
            // 
            // colMaPhieuNhapHang
            // 
            this.colMaPhieuNhapHang.FieldName = "MaPhieuNhapHang";
            this.colMaPhieuNhapHang.Name = "colMaPhieuNhapHang";
            this.colMaPhieuNhapHang.Visible = true;
            this.colMaPhieuNhapHang.VisibleIndex = 0;
            // 
            // colNguoiQuanLy
            // 
            this.colNguoiQuanLy.FieldName = "NguoiQuanLy";
            this.colNguoiQuanLy.Name = "colNguoiQuanLy";
            this.colNguoiQuanLy.Visible = true;
            this.colNguoiQuanLy.VisibleIndex = 1;
            // 
            // colMaNhaCungCap
            // 
            this.colMaNhaCungCap.FieldName = "MaNhaCungCap";
            this.colMaNhaCungCap.Name = "colMaNhaCungCap";
            this.colMaNhaCungCap.Visible = true;
            this.colMaNhaCungCap.VisibleIndex = 2;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.FieldName = "NgayNhap";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.Visible = true;
            this.colNgayNhap.VisibleIndex = 3;
            // 
            // colChiTietNhaps
            // 
            this.colChiTietNhaps.FieldName = "ChiTietNhaps";
            this.colChiTietNhaps.Name = "colChiTietNhaps";
            this.colChiTietNhaps.Visible = true;
            this.colChiTietNhaps.VisibleIndex = 4;
            // 
            // colNhaCungCap
            // 
            this.colNhaCungCap.FieldName = "NhaCungCap";
            this.colNhaCungCap.Name = "colNhaCungCap";
            this.colNhaCungCap.Visible = true;
            this.colNhaCungCap.VisibleIndex = 5;
            // 
            // NhapHangUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "NhapHangUC";
            this.Size = new System.Drawing.Size(817, 524);
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapHangsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapHangsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource phieuNhapHangsBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource phieuNhapHangsBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuNhapHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiQuanLy;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTietNhaps;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCungCap;
    }
}
