namespace Lab05.GUI
{
  partial class frmRegister
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
      this.label1 = new System.Windows.Forms.Label();
      this.cmbFaculty = new System.Windows.Forms.ComboBox();
      this.cmbMajor = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.dgvStudent = new System.Windows.Forms.DataGridView();
      this.button1 = new System.Windows.Forms.Button();
      this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Khoa";
      // 
      // cmbFaculty
      // 
      this.cmbFaculty.FormattingEnabled = true;
      this.cmbFaculty.Location = new System.Drawing.Point(94, 12);
      this.cmbFaculty.Name = "cmbFaculty";
      this.cmbFaculty.Size = new System.Drawing.Size(176, 21);
      this.cmbFaculty.TabIndex = 1;
      this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
      // 
      // cmbMajor
      // 
      this.cmbMajor.FormattingEnabled = true;
      this.cmbMajor.Location = new System.Drawing.Point(94, 39);
      this.cmbMajor.Name = "cmbMajor";
      this.cmbMajor.Size = new System.Drawing.Size(176, 21);
      this.cmbMajor.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Chuyên ngành";
      // 
      // dgvStudent
      // 
      this.dgvStudent.AllowUserToAddRows = false;
      this.dgvStudent.AllowUserToDeleteRows = false;
      this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
      this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.MSSV,
            this.HoTen,
            this.Khoa,
            this.DTB,
            this.ChuyenNganh});
      this.dgvStudent.Cursor = System.Windows.Forms.Cursors.Hand;
      this.dgvStudent.Location = new System.Drawing.Point(12, 66);
      this.dgvStudent.Name = "dgvStudent";
      this.dgvStudent.RowHeadersVisible = false;
      this.dgvStudent.Size = new System.Drawing.Size(606, 246);
      this.dgvStudent.TabIndex = 4;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(329, 32);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Đăng ký";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // Chon
      // 
      this.Chon.HeaderText = "Chọn";
      this.Chon.Name = "Chon";
      this.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      // 
      // MSSV
      // 
      this.MSSV.HeaderText = "MSSV";
      this.MSSV.Name = "MSSV";
      // 
      // HoTen
      // 
      this.HoTen.HeaderText = "Họ Tên";
      this.HoTen.Name = "HoTen";
      // 
      // Khoa
      // 
      this.Khoa.HeaderText = "Khoa";
      this.Khoa.Name = "Khoa";
      // 
      // DTB
      // 
      this.DTB.HeaderText = "DTB";
      this.DTB.Name = "DTB";
      // 
      // ChuyenNganh
      // 
      this.ChuyenNganh.HeaderText = "Chuyên Ngành";
      this.ChuyenNganh.Name = "ChuyenNganh";
      // 
      // frmRegister
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(630, 324);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dgvStudent);
      this.Controls.Add(this.cmbMajor);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cmbFaculty);
      this.Controls.Add(this.label1);
      this.Name = "frmRegister";
      this.Text = "frmRegister";
      this.Load += new System.EventHandler(this.frmRegister_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cmbFaculty;
    private System.Windows.Forms.ComboBox cmbMajor;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dgvStudent;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
    private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
    private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
    private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
    private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
    private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenNganh;
  }
}