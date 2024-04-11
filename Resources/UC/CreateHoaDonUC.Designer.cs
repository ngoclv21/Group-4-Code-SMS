namespace EliteMart.UC
{
    partial class CreateHoaDonUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateHoaDonUC));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHangHoa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.dtgv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 191);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 411);
            this.panel3.TabIndex = 11;
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToOrderColumns = true;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(0, 0);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dtgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dtgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dtgv.RowTemplate.Height = 25;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1200, 411);
            this.dtgv.TabIndex = 41;
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoHoaDon.BackColor = System.Drawing.Color.White;
            this.btnTaoHoaDon.BackgroundImage = global::EliteMart.Properties.Resources.beautiful_color_ui_gradients_backgrounds_frost;
            this.btnTaoHoaDon.FlatAppearance.BorderSize = 0;
            this.btnTaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHoaDon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(1002, 80);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(186, 42);
            this.btnTaoHoaDon.TabIndex = 41;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = false;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnRemoveRow);
            this.panel2.Controls.Add(this.btnAddRow);
            this.panel2.Controls.Add(this.btnTaoHoaDon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtHangHoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 602);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 198);
            this.panel2.TabIndex = 10;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(1026, 23);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 42);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnRemoveRow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveRow.BackgroundImage")));
            this.btnRemoveRow.FlatAppearance.BorderSize = 0;
            this.btnRemoveRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRow.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRow.ForeColor = System.Drawing.Color.White;
            this.btnRemoveRow.Location = new System.Drawing.Point(1110, 23);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(78, 42);
            this.btnRemoveRow.TabIndex = 49;
            this.btnRemoveRow.Text = "Xóa";
            this.btnRemoveRow.UseVisualStyleBackColor = false;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnAddRow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRow.BackgroundImage")));
            this.btnAddRow.FlatAppearance.BorderSize = 0;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRow.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRow.ForeColor = System.Drawing.Color.White;
            this.btnAddRow.Location = new System.Drawing.Point(942, 23);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(78, 42);
            this.btnAddRow.TabIndex = 48;
            this.btnAddRow.Text = "Thêm";
            this.btnAddRow.UseVisualStyleBackColor = false;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(615, 18);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(170, 36);
            this.txtSoLuong.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Hàng hóa:";
            // 
            // txtHangHoa
            // 
            this.txtHangHoa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHangHoa.Location = new System.Drawing.Point(202, 18);
            this.txtHangHoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHangHoa.Name = "txtHangHoa";
            this.txtHangHoa.Size = new System.Drawing.Size(170, 36);
            this.txtHangHoa.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label9.Location = new System.Drawing.Point(507, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 49);
            this.label9.TabIndex = 42;
            this.label9.Text = "HÓA ĐƠN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpkNgaySinh);
            this.panel1.Controls.Add(this.cbxGioiTinh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSoDienThoai);
            this.panel1.Controls.Add(this.txtQueQuan);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 191);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(713, 122);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(170, 36);
            this.dtpkNgaySinh.TabIndex = 60;
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(112, 118);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(170, 37);
            this.cbxGioiTinh.TabIndex = 59;
            this.cbxGioiTinh.Text = "Nam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 29);
            this.label7.TabIndex = 52;
            this.label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 53;
            this.label6.Text = "Quê quán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 54;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 56;
            this.label3.Text = "Giới tính:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 29);
            this.label10.TabIndex = 57;
            this.label10.Text = "Họ tên:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(713, 83);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(170, 36);
            this.txtSoDienThoai.TabIndex = 46;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(412, 122);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(170, 36);
            this.txtQueQuan.TabIndex = 47;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(412, 80);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(170, 36);
            this.txtDiaChi.TabIndex = 48;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(112, 79);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(170, 36);
            this.txtHoTen.TabIndex = 49;
            // 
            // CreateHoaDonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateHoaDonUC";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.CreateHoaDonUC_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHangHoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.Button btnAddRow;
    }
}
