namespace WindowsFormsApp1
{
  partial class frmKhachHang
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
      this.txtTen = new System.Windows.Forms.TextBox();
      this.txtSDT = new System.Windows.Forms.TextBox();
      this.btnThem = new System.Windows.Forms.Button();
      this.btnSua = new System.Windows.Forms.Button();
      this.btnXoa = new System.Windows.Forms.Button();
      this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
      this.lblThongTinVe = new System.Windows.Forms.Label();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
      this.SuspendLayout();
      // 
      // txtTen
      // 
      this.txtTen.Location = new System.Drawing.Point(12, 43);
      this.txtTen.Name = "txtTen";
      this.txtTen.Size = new System.Drawing.Size(162, 20);
      this.txtTen.TabIndex = 0;
      // 
      // txtSDT
      // 
      this.txtSDT.Location = new System.Drawing.Point(12, 69);
      this.txtSDT.Name = "txtSDT";
      this.txtSDT.Size = new System.Drawing.Size(162, 20);
      this.txtSDT.TabIndex = 1;
      // 
      // btnThem
      // 
      this.btnThem.Location = new System.Drawing.Point(180, 43);
      this.btnThem.Name = "btnThem";
      this.btnThem.Size = new System.Drawing.Size(55, 46);
      this.btnThem.TabIndex = 2;
      this.btnThem.Text = "Thêm";
      this.btnThem.UseVisualStyleBackColor = true;
      this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
      // 
      // btnSua
      // 
      this.btnSua.Location = new System.Drawing.Point(241, 43);
      this.btnSua.Name = "btnSua";
      this.btnSua.Size = new System.Drawing.Size(55, 46);
      this.btnSua.TabIndex = 3;
      this.btnSua.Text = "Sửa";
      this.btnSua.UseVisualStyleBackColor = true;
      // 
      // btnXoa
      // 
      this.btnXoa.Location = new System.Drawing.Point(302, 43);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(55, 46);
      this.btnXoa.TabIndex = 4;
      this.btnXoa.Text = "Xóa";
      this.btnXoa.UseVisualStyleBackColor = true;
      // 
      // dtgvKhachHang
      // 
      this.dtgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
      this.dtgvKhachHang.Location = new System.Drawing.Point(12, 95);
      this.dtgvKhachHang.Name = "dtgvKhachHang";
      this.dtgvKhachHang.Size = new System.Drawing.Size(345, 166);
      this.dtgvKhachHang.TabIndex = 5;
      // 
      // lblThongTinVe
      // 
      this.lblThongTinVe.AutoSize = true;
      this.lblThongTinVe.Location = new System.Drawing.Point(12, 9);
      this.lblThongTinVe.Name = "lblThongTinVe";
      this.lblThongTinVe.Size = new System.Drawing.Size(16, 13);
      this.lblThongTinVe.TabIndex = 6;
      this.lblThongTinVe.Text = "...";
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Tên";
      this.Column1.Name = "Column1";
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Số điện thoại";
      this.Column2.Name = "Column2";
      // 
      // frmKhachHang
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(369, 277);
      this.Controls.Add(this.lblThongTinVe);
      this.Controls.Add(this.dtgvKhachHang);
      this.Controls.Add(this.btnXoa);
      this.Controls.Add(this.btnSua);
      this.Controls.Add(this.btnThem);
      this.Controls.Add(this.txtSDT);
      this.Controls.Add(this.txtTen);
      this.Name = "frmKhachHang";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmKhachHang";
      ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtTen;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.DataGridView dtgvKhachHang;
    private System.Windows.Forms.Label lblThongTinVe;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
  }
}