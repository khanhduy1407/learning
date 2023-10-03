namespace Lab04_123
{
  partial class Form1
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnThem = new System.Windows.Forms.Button();
      this.btnSua = new System.Windows.Forms.Button();
      this.btnXoa = new System.Windows.Forms.Button();
      this.txtDiem = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.cbKhoa = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtHoTen = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMSV = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.dtgvSV = new System.Windows.Forms.DataGridView();
      this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.thôngTinCácKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnThem);
      this.groupBox1.Controls.Add(this.btnSua);
      this.groupBox1.Controls.Add(this.btnXoa);
      this.groupBox1.Controls.Add(this.txtDiem);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.cbKhoa);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtHoTen);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtMSV);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
      this.groupBox1.Location = new System.Drawing.Point(12, 113);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(271, 188);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thông tin sinh viên";
      // 
      // btnThem
      // 
      this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnThem.Location = new System.Drawing.Point(28, 157);
      this.btnThem.Name = "btnThem";
      this.btnThem.Size = new System.Drawing.Size(75, 23);
      this.btnThem.TabIndex = 10;
      this.btnThem.Text = "Thêm";
      this.btnThem.UseVisualStyleBackColor = true;
      this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
      // 
      // btnSua
      // 
      this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSua.Enabled = false;
      this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnSua.Location = new System.Drawing.Point(109, 157);
      this.btnSua.Name = "btnSua";
      this.btnSua.Size = new System.Drawing.Size(75, 23);
      this.btnSua.TabIndex = 9;
      this.btnSua.Text = "Sửa";
      this.btnSua.UseVisualStyleBackColor = true;
      this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
      // 
      // btnXoa
      // 
      this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnXoa.Enabled = false;
      this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnXoa.Location = new System.Drawing.Point(190, 157);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(75, 23);
      this.btnXoa.TabIndex = 8;
      this.btnXoa.Text = "Xóa";
      this.btnXoa.UseVisualStyleBackColor = true;
      this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
      // 
      // txtDiem
      // 
      this.txtDiem.Location = new System.Drawing.Point(68, 119);
      this.txtDiem.Name = "txtDiem";
      this.txtDiem.Size = new System.Drawing.Size(197, 20);
      this.txtDiem.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label4.Location = new System.Drawing.Point(7, 122);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Điểm TB";
      // 
      // cbKhoa
      // 
      this.cbKhoa.FormattingEnabled = true;
      this.cbKhoa.Location = new System.Drawing.Point(68, 80);
      this.cbKhoa.Name = "cbKhoa";
      this.cbKhoa.Size = new System.Drawing.Size(197, 21);
      this.cbKhoa.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label3.Location = new System.Drawing.Point(7, 83);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Khoa";
      // 
      // txtHoTen
      // 
      this.txtHoTen.Location = new System.Drawing.Point(68, 47);
      this.txtHoTen.Name = "txtHoTen";
      this.txtHoTen.Size = new System.Drawing.Size(197, 20);
      this.txtHoTen.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.Location = new System.Drawing.Point(7, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Họ Tên";
      // 
      // txtMSV
      // 
      this.txtMSV.Location = new System.Drawing.Point(68, 17);
      this.txtMSV.Name = "txtMSV";
      this.txtMSV.Size = new System.Drawing.Size(197, 20);
      this.txtMSV.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(7, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Mã Số SV";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
      this.label5.Location = new System.Drawing.Point(70, 36);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(612, 55);
      this.label5.TabIndex = 1;
      this.label5.Text = "Sinh viên Quản lý Thông tin";
      // 
      // dtgvSV
      // 
      this.dtgvSV.AllowUserToAddRows = false;
      this.dtgvSV.AllowUserToDeleteRows = false;
      this.dtgvSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgvSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.dtgvSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dtgvSV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dtgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.Khoa,
            this.Diem});
      this.dtgvSV.Cursor = System.Windows.Forms.Cursors.Hand;
      this.dtgvSV.Location = new System.Drawing.Point(289, 113);
      this.dtgvSV.Name = "dtgvSV";
      this.dtgvSV.ReadOnly = true;
      this.dtgvSV.RowHeadersVisible = false;
      this.dtgvSV.Size = new System.Drawing.Size(499, 188);
      this.dtgvSV.TabIndex = 2;
      this.dtgvSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSV_CellClick);
      // 
      // MaSV
      // 
      this.MaSV.HeaderText = "Mã Số SV";
      this.MaSV.Name = "MaSV";
      this.MaSV.ReadOnly = true;
      // 
      // HoTen
      // 
      this.HoTen.HeaderText = "Họ Tên";
      this.HoTen.Name = "HoTen";
      this.HoTen.ReadOnly = true;
      // 
      // Khoa
      // 
      this.Khoa.HeaderText = "Khoa";
      this.Khoa.Name = "Khoa";
      this.Khoa.ReadOnly = true;
      // 
      // Diem
      // 
      this.Diem.HeaderText = "Điểm TB";
      this.Diem.Name = "Diem";
      this.Diem.ReadOnly = true;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // quảnLýToolStripMenuItem
      // 
      this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCácKhoaToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
      this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
      this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
      this.quảnLýToolStripMenuItem.Text = "Quản lý";
      // 
      // thôngTinCácKhoaToolStripMenuItem
      // 
      this.thôngTinCácKhoaToolStripMenuItem.Name = "thôngTinCácKhoaToolStripMenuItem";
      this.thôngTinCácKhoaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
      this.thôngTinCácKhoaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.thôngTinCácKhoaToolStripMenuItem.Text = "Thông tin các khoa";
      this.thôngTinCácKhoaToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCácKhoaToolStripMenuItem_Click);
      // 
      // tìmKiếmToolStripMenuItem
      // 
      this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
      this.tìmKiếmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
      this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
      this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 318);
      this.Controls.Add(this.dtgvSV);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtMSV;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cbKhoa;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDiem;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
    private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
    private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
    private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.DataGridView dtgvSV;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem thôngTinCácKhoaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
  }
}

