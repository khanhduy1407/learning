namespace Lab05.GUI
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
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.picAvatar = new System.Windows.Forms.PictureBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cmbFaculty = new System.Windows.Forms.ComboBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.chkUnregisterMajor = new System.Windows.Forms.CheckBox();
      this.dgvStudent = new System.Windows.Forms.DataGridView();
      this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.đăngKýChuyênNgànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.picAvatar);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.textBox3);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.cmbFaculty);
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 59);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(300, 323);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thông tin sinh viên";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(187, 294);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 11;
      this.button2.Text = "Xóa";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(79, 294);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 10;
      this.button1.Text = "Thêm / Sửa";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // picAvatar
      // 
      this.picAvatar.Location = new System.Drawing.Point(79, 139);
      this.picAvatar.Name = "picAvatar";
      this.picAvatar.Size = new System.Drawing.Size(120, 120);
      this.picAvatar.TabIndex = 9;
      this.picAvatar.TabStop = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 139);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(67, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Ảnh đại diện";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(79, 104);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(215, 20);
      this.textBox3.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 107);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Điểm TB";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 80);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Khoa";
      // 
      // cmbFaculty
      // 
      this.cmbFaculty.FormattingEnabled = true;
      this.cmbFaculty.Location = new System.Drawing.Point(79, 77);
      this.cmbFaculty.Name = "cmbFaculty";
      this.cmbFaculty.Size = new System.Drawing.Size(215, 21);
      this.cmbFaculty.TabIndex = 4;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(79, 51);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(215, 20);
      this.textBox2.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Họ tên";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(79, 25);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(215, 20);
      this.textBox1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Mã sinh viên";
      // 
      // chkUnregisterMajor
      // 
      this.chkUnregisterMajor.AutoSize = true;
      this.chkUnregisterMajor.Location = new System.Drawing.Point(730, 36);
      this.chkUnregisterMajor.Name = "chkUnregisterMajor";
      this.chkUnregisterMajor.Size = new System.Drawing.Size(164, 17);
      this.chkUnregisterMajor.TabIndex = 1;
      this.chkUnregisterMajor.Text = "Chưa đăng ký chuyên ngành";
      this.chkUnregisterMajor.UseVisualStyleBackColor = true;
      this.chkUnregisterMajor.CheckedChanged += new System.EventHandler(this.chkUnregisterMajor_CheckedChanged);
      // 
      // dgvStudent
      // 
      this.dgvStudent.AllowUserToAddRows = false;
      this.dgvStudent.AllowUserToDeleteRows = false;
      this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
      this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.Khoa,
            this.DTB,
            this.ChuyenNganh});
      this.dgvStudent.Cursor = System.Windows.Forms.Cursors.Hand;
      this.dgvStudent.Location = new System.Drawing.Point(318, 59);
      this.dgvStudent.Name = "dgvStudent";
      this.dgvStudent.RowHeadersVisible = false;
      this.dgvStudent.Size = new System.Drawing.Size(576, 323);
      this.dgvStudent.TabIndex = 2;
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
      this.ChuyenNganh.HeaderText = "Chuyên ngành";
      this.ChuyenNganh.Name = "ChuyenNganh";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(906, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // chứcNăngToolStripMenuItem
      // 
      this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýChuyênNgànhToolStripMenuItem});
      this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
      this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
      this.chứcNăngToolStripMenuItem.Text = "Chức năng";
      // 
      // đăngKýChuyênNgànhToolStripMenuItem
      // 
      this.đăngKýChuyênNgànhToolStripMenuItem.Name = "đăngKýChuyênNgànhToolStripMenuItem";
      this.đăngKýChuyênNgànhToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
      this.đăngKýChuyênNgànhToolStripMenuItem.Text = "Đăng ký chuyên ngành";
      this.đăngKýChuyênNgànhToolStripMenuItem.Click += new System.EventHandler(this.đăngKýChuyênNgànhToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(906, 394);
      this.Controls.Add(this.dgvStudent);
      this.Controls.Add(this.chkUnregisterMajor);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.PictureBox picAvatar;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbFaculty;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox chkUnregisterMajor;
    private System.Windows.Forms.DataGridView dgvStudent;
    private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
    private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
    private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
    private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
    private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenNganh;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem đăngKýChuyênNgànhToolStripMenuItem;
  }
}

