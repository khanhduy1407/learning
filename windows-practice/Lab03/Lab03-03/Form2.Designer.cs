namespace Lab03_03
{
  partial class Form2
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
      this.txtMaSo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtTenSinhVien = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.comboBoxKhoa = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtDiem = new System.Windows.Forms.TextBox();
      this.addBtn = new System.Windows.Forms.Button();
      this.exitBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Mã Số Sinh Viên";
      // 
      // txtMaSo
      // 
      this.txtMaSo.Location = new System.Drawing.Point(72, 25);
      this.txtMaSo.Name = "txtMaSo";
      this.txtMaSo.Size = new System.Drawing.Size(152, 20);
      this.txtMaSo.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(223, 88);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Tên Sinh Viên";
      // 
      // txtTenSinhVien
      // 
      this.txtTenSinhVien.Location = new System.Drawing.Point(282, 65);
      this.txtTenSinhVien.Name = "txtTenSinhVien";
      this.txtTenSinhVien.Size = new System.Drawing.Size(172, 20);
      this.txtTenSinhVien.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(72, 131);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Khoa";
      // 
      // comboBoxKhoa
      // 
      this.comboBoxKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxKhoa.FormattingEnabled = true;
      this.comboBoxKhoa.Location = new System.Drawing.Point(110, 114);
      this.comboBoxKhoa.Name = "comboBoxKhoa";
      this.comboBoxKhoa.Size = new System.Drawing.Size(166, 21);
      this.comboBoxKhoa.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(46, 183);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(49, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "ĐIểm TB";
      // 
      // txtDiem
      // 
      this.txtDiem.Location = new System.Drawing.Point(102, 175);
      this.txtDiem.Name = "txtDiem";
      this.txtDiem.Size = new System.Drawing.Size(100, 20);
      this.txtDiem.TabIndex = 7;
      // 
      // addBtn
      // 
      this.addBtn.BackColor = System.Drawing.Color.LightGreen;
      this.addBtn.Location = new System.Drawing.Point(250, 150);
      this.addBtn.Name = "addBtn";
      this.addBtn.Size = new System.Drawing.Size(194, 158);
      this.addBtn.TabIndex = 8;
      this.addBtn.Text = "Thêm Mới";
      this.addBtn.UseVisualStyleBackColor = false;
      this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
      // 
      // exitBtn
      // 
      this.exitBtn.BackColor = System.Drawing.Color.Tomato;
      this.exitBtn.Location = new System.Drawing.Point(635, 370);
      this.exitBtn.Name = "exitBtn";
      this.exitBtn.Size = new System.Drawing.Size(243, 210);
      this.exitBtn.TabIndex = 9;
      this.exitBtn.Text = "Thoát";
      this.exitBtn.UseVisualStyleBackColor = false;
      this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(470, 322);
      this.Controls.Add(this.exitBtn);
      this.Controls.Add(this.addBtn);
      this.Controls.Add(this.txtDiem);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.comboBoxKhoa);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtTenSinhVien);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtMaSo);
      this.Controls.Add(this.label1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Thêm Sinh Viên";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMaSo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTenSinhVien;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBoxKhoa;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtDiem;
    private System.Windows.Forms.Button addBtn;
    private System.Windows.Forms.Button exitBtn;
  }
}