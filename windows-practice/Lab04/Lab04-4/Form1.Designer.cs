namespace Lab04_4
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
      this.chbAllThisMonth = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dtpFrom = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.dtpTo = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.dtgvHD = new System.Windows.Forms.DataGridView();
      this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dtpTo);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.dtpFrom);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.chbAllThisMonth);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(340, 100);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thông tin đơn hàng";
      // 
      // chbAllThisMonth
      // 
      this.chbAllThisMonth.AutoSize = true;
      this.chbAllThisMonth.Location = new System.Drawing.Point(6, 30);
      this.chbAllThisMonth.Name = "chbAllThisMonth";
      this.chbAllThisMonth.Size = new System.Drawing.Size(134, 17);
      this.chbAllThisMonth.TabIndex = 0;
      this.chbAllThisMonth.Text = "Xem tất cả trong tháng";
      this.chbAllThisMonth.UseVisualStyleBackColor = true;
      this.chbAllThisMonth.CheckStateChanged += new System.EventHandler(this.chbAllThisMonth_CheckStateChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Thời gian giao hàng";
      // 
      // dtpFrom
      // 
      this.dtpFrom.CustomFormat = "dd/MM/yyyy";
      this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpFrom.Location = new System.Drawing.Point(113, 57);
      this.dtpFrom.Name = "dtpFrom";
      this.dtpFrom.Size = new System.Drawing.Size(96, 20);
      this.dtpFrom.TabIndex = 2;
      this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(215, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(14, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "~";
      // 
      // dtpTo
      // 
      this.dtpTo.CustomFormat = "dd/MM/yyyy";
      this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpTo.Location = new System.Drawing.Point(235, 57);
      this.dtpTo.Name = "dtpTo";
      this.dtpTo.Size = new System.Drawing.Size(96, 20);
      this.dtpTo.TabIndex = 4;
      this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(405, 99);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Tổng tiền";
      // 
      // txtTotal
      // 
      this.txtTotal.Location = new System.Drawing.Point(463, 92);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.ReadOnly = true;
      this.txtTotal.Size = new System.Drawing.Size(100, 20);
      this.txtTotal.TabIndex = 2;
      this.txtTotal.Text = "0";
      this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // dtgvHD
      // 
      this.dtgvHD.AllowUserToAddRows = false;
      this.dtgvHD.AllowUserToDeleteRows = false;
      this.dtgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgvHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.dtgvHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dtgvHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dtgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoHD,
            this.NgayDat,
            this.NgayGiao,
            this.ThanhTien});
      this.dtgvHD.Cursor = System.Windows.Forms.Cursors.Hand;
      this.dtgvHD.Location = new System.Drawing.Point(12, 118);
      this.dtgvHD.Name = "dtgvHD";
      this.dtgvHD.ReadOnly = true;
      this.dtgvHD.RowHeadersVisible = false;
      this.dtgvHD.Size = new System.Drawing.Size(551, 199);
      this.dtgvHD.TabIndex = 3;
      // 
      // STT
      // 
      this.STT.HeaderText = "STT";
      this.STT.Name = "STT";
      this.STT.ReadOnly = true;
      // 
      // SoHD
      // 
      this.SoHD.HeaderText = "Số HĐ";
      this.SoHD.Name = "SoHD";
      this.SoHD.ReadOnly = true;
      // 
      // NgayDat
      // 
      this.NgayDat.HeaderText = "Ngày Đặt Hàng";
      this.NgayDat.Name = "NgayDat";
      this.NgayDat.ReadOnly = true;
      // 
      // NgayGiao
      // 
      this.NgayGiao.HeaderText = "Ngày Giao Hàng";
      this.NgayGiao.Name = "NgayGiao";
      this.NgayGiao.ReadOnly = true;
      // 
      // ThanhTien
      // 
      this.ThanhTien.HeaderText = "Thành Tiền";
      this.ThanhTien.Name = "ThanhTien";
      this.ThanhTien.ReadOnly = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(575, 329);
      this.Controls.Add(this.dtgvHD);
      this.Controls.Add(this.txtTotal);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DateTimePicker dtpTo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dtpFrom;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox chbAllThisMonth;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtTotal;
    private System.Windows.Forms.DataGridView dtgvHD;
    private System.Windows.Forms.DataGridViewTextBoxColumn STT;
    private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
    private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
    private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiao;
    private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
  }
}

