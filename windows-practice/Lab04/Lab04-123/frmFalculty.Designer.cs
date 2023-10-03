namespace Lab04_123
{
  partial class frmFalculty
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
      this.dtgvKhoa = new System.Windows.Forms.DataGridView();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnThemHoacSua = new System.Windows.Forms.Button();
      this.btnXoa = new System.Windows.Forms.Button();
      this.txtTongGS = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtTenKhoa = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMaKhoa = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TongGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnClose = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoa)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dtgvKhoa
      // 
      this.dtgvKhoa.AllowUserToAddRows = false;
      this.dtgvKhoa.AllowUserToDeleteRows = false;
      this.dtgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgvKhoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.dtgvKhoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dtgvKhoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dtgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa,
            this.TongGS});
      this.dtgvKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
      this.dtgvKhoa.Location = new System.Drawing.Point(289, 12);
      this.dtgvKhoa.Name = "dtgvKhoa";
      this.dtgvKhoa.ReadOnly = true;
      this.dtgvKhoa.RowHeadersVisible = false;
      this.dtgvKhoa.Size = new System.Drawing.Size(365, 188);
      this.dtgvKhoa.TabIndex = 4;
      this.dtgvKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKhoa_CellClick);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnThemHoacSua);
      this.groupBox1.Controls.Add(this.btnXoa);
      this.groupBox1.Controls.Add(this.txtTongGS);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.txtTenKhoa);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtMaKhoa);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(271, 188);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thông tin khoa";
      // 
      // btnThemHoacSua
      // 
      this.btnThemHoacSua.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnThemHoacSua.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnThemHoacSua.Location = new System.Drawing.Point(109, 157);
      this.btnThemHoacSua.Name = "btnThemHoacSua";
      this.btnThemHoacSua.Size = new System.Drawing.Size(75, 23);
      this.btnThemHoacSua.TabIndex = 10;
      this.btnThemHoacSua.Text = "Thêm / Sửa";
      this.btnThemHoacSua.UseVisualStyleBackColor = true;
      this.btnThemHoacSua.Click += new System.EventHandler(this.btnThemHoacSua_Click);
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
      // txtTongGS
      // 
      this.txtTongGS.Enabled = false;
      this.txtTongGS.Location = new System.Drawing.Point(77, 109);
      this.txtTongGS.Name = "txtTongGS";
      this.txtTongGS.Size = new System.Drawing.Size(188, 20);
      this.txtTongGS.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label4.Location = new System.Drawing.Point(7, 112);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(64, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Tổng số GS";
      // 
      // txtTenKhoa
      // 
      this.txtTenKhoa.Location = new System.Drawing.Point(77, 69);
      this.txtTenKhoa.Name = "txtTenKhoa";
      this.txtTenKhoa.Size = new System.Drawing.Size(188, 20);
      this.txtTenKhoa.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.Location = new System.Drawing.Point(7, 72);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Tên Khoa";
      // 
      // txtMaKhoa
      // 
      this.txtMaKhoa.Location = new System.Drawing.Point(77, 29);
      this.txtMaKhoa.Name = "txtMaKhoa";
      this.txtMaKhoa.Size = new System.Drawing.Size(188, 20);
      this.txtMaKhoa.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(7, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Mã Khoa";
      // 
      // MaKhoa
      // 
      this.MaKhoa.HeaderText = "Mã Khoa";
      this.MaKhoa.Name = "MaKhoa";
      this.MaKhoa.ReadOnly = true;
      // 
      // TenKhoa
      // 
      this.TenKhoa.HeaderText = "Tên Khoa";
      this.TenKhoa.Name = "TenKhoa";
      this.TenKhoa.ReadOnly = true;
      // 
      // TongGS
      // 
      this.TongGS.HeaderText = "Tổng số GS";
      this.TongGS.Name = "TongGS";
      this.TongGS.ReadOnly = true;
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Tomato;
      this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.White;
      this.btnClose.Location = new System.Drawing.Point(12, 206);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(642, 48);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "Đóng";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmFalculty
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(666, 266);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.dtgvKhoa);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmFalculty";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Quản lý khoa";
      this.Load += new System.EventHandler(this.frmFalculty_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoa)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dtgvKhoa;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnThemHoacSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.TextBox txtTongGS;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtTenKhoa;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtMaKhoa;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
    private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
    private System.Windows.Forms.DataGridViewTextBoxColumn TongGS;
    private System.Windows.Forms.Button btnClose;
  }
}