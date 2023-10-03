namespace Lab04_123
{
  partial class frmSearch
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
      this.dtgvSV = new System.Windows.Forms.DataGridView();
      this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnSua = new System.Windows.Forms.Button();
      this.btnXoa = new System.Windows.Forms.Button();
      this.cbKhoa = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtHoTen = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMSV = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtCount = new System.Windows.Forms.TextBox();
      this.btnReturn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
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
      this.dtgvSV.Location = new System.Drawing.Point(12, 206);
      this.dtgvSV.Name = "dtgvSV";
      this.dtgvSV.ReadOnly = true;
      this.dtgvSV.RowHeadersVisible = false;
      this.dtgvSV.Size = new System.Drawing.Size(499, 188);
      this.dtgvSV.TabIndex = 4;
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
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnSua);
      this.groupBox1.Controls.Add(this.btnXoa);
      this.groupBox1.Controls.Add(this.cbKhoa);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtHoTen);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtMSV);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(271, 188);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thông tin tìm kiếm";
      // 
      // btnSua
      // 
      this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnSua.Location = new System.Drawing.Point(109, 157);
      this.btnSua.Name = "btnSua";
      this.btnSua.Size = new System.Drawing.Size(75, 23);
      this.btnSua.TabIndex = 9;
      this.btnSua.Text = "Tìm kiếm";
      this.btnSua.UseVisualStyleBackColor = true;
      this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
      // 
      // btnXoa
      // 
      this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnXoa.Location = new System.Drawing.Point(190, 157);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(75, 23);
      this.btnXoa.TabIndex = 8;
      this.btnXoa.Text = "Xóa";
      this.btnXoa.UseVisualStyleBackColor = true;
      this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
      // 
      // cbKhoa
      // 
      this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.cbKhoa.FormattingEnabled = true;
      this.cbKhoa.Location = new System.Drawing.Point(68, 111);
      this.cbKhoa.Name = "cbKhoa";
      this.cbKhoa.Size = new System.Drawing.Size(197, 21);
      this.cbKhoa.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label3.Location = new System.Drawing.Point(7, 114);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Khoa";
      // 
      // txtHoTen
      // 
      this.txtHoTen.Location = new System.Drawing.Point(68, 70);
      this.txtHoTen.Name = "txtHoTen";
      this.txtHoTen.Size = new System.Drawing.Size(197, 20);
      this.txtHoTen.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.Location = new System.Drawing.Point(7, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Họ Tên";
      // 
      // txtMSV
      // 
      this.txtMSV.Location = new System.Drawing.Point(68, 32);
      this.txtMSV.Name = "txtMSV";
      this.txtMSV.Size = new System.Drawing.Size(197, 20);
      this.txtMSV.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(7, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Mã Số SV";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(320, 179);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(85, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "Kết quả tìm kiếm";
      // 
      // txtCount
      // 
      this.txtCount.Location = new System.Drawing.Point(411, 176);
      this.txtCount.Name = "txtCount";
      this.txtCount.ReadOnly = true;
      this.txtCount.Size = new System.Drawing.Size(100, 20);
      this.txtCount.TabIndex = 6;
      this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnReturn
      // 
      this.btnReturn.Location = new System.Drawing.Point(436, 12);
      this.btnReturn.Name = "btnReturn";
      this.btnReturn.Size = new System.Drawing.Size(75, 23);
      this.btnReturn.TabIndex = 7;
      this.btnReturn.Text = "Trở về";
      this.btnReturn.UseVisualStyleBackColor = true;
      this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
      // 
      // frmSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(523, 404);
      this.Controls.Add(this.btnReturn);
      this.Controls.Add(this.txtCount);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.dtgvSV);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmSearch";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmSearch";
      this.Load += new System.EventHandler(this.frmSearch_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgvSV)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dtgvSV;
    private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
    private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
    private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
    private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.ComboBox cbKhoa;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtMSV;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtCount;
    private System.Windows.Forms.Button btnReturn;
  }
}