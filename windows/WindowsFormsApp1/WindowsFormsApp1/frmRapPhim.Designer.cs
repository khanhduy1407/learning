namespace WindowsFormsApp1
{
    partial class frmRapPhim
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapPhim));
      this.pnlManAnh = new System.Windows.Forms.Panel();
      this.txtTongTien = new System.Windows.Forms.TextBox();
      this.lbThanhTien = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnChon = new System.Windows.Forms.Button();
      this.btnHuy = new System.Windows.Forms.Button();
      this.btnKetThuc = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.lbTenKH = new System.Windows.Forms.Label();
      this.lbSdt = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtTenKH = new System.Windows.Forms.TextBox();
      this.txtSdt = new System.Windows.Forms.TextBox();
      this.dtgvInfo = new System.Windows.Forms.DataGridView();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlManAnh
      // 
      this.pnlManAnh.BackColor = System.Drawing.SystemColors.ActiveCaption;
      resources.ApplyResources(this.pnlManAnh, "pnlManAnh");
      this.pnlManAnh.Name = "pnlManAnh";
      // 
      // txtTongTien
      // 
      resources.ApplyResources(this.txtTongTien, "txtTongTien");
      this.txtTongTien.Name = "txtTongTien";
      this.txtTongTien.ReadOnly = true;
      // 
      // lbThanhTien
      // 
      resources.ApplyResources(this.lbThanhTien, "lbThanhTien");
      this.lbThanhTien.Name = "lbThanhTien";
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
      this.label1.Name = "label1";
      // 
      // btnChon
      // 
      resources.ApplyResources(this.btnChon, "btnChon");
      this.btnChon.Name = "btnChon";
      this.btnChon.UseVisualStyleBackColor = true;
      this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
      // 
      // btnHuy
      // 
      resources.ApplyResources(this.btnHuy, "btnHuy");
      this.btnHuy.Name = "btnHuy";
      this.btnHuy.UseVisualStyleBackColor = true;
      this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
      // 
      // btnKetThuc
      // 
      resources.ApplyResources(this.btnKetThuc, "btnKetThuc");
      this.btnKetThuc.Name = "btnKetThuc";
      this.btnKetThuc.UseVisualStyleBackColor = true;
      this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // lbTenKH
      // 
      resources.ApplyResources(this.lbTenKH, "lbTenKH");
      this.lbTenKH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
      this.lbTenKH.Name = "lbTenKH";
      // 
      // lbSdt
      // 
      resources.ApplyResources(this.lbSdt, "lbSdt");
      this.lbSdt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
      this.lbSdt.Name = "lbSdt";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.panel1.Controls.Add(this.dtgvInfo);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // txtTenKH
      // 
      resources.ApplyResources(this.txtTenKH, "txtTenKH");
      this.txtTenKH.Name = "txtTenKH";
      // 
      // txtSdt
      // 
      resources.ApplyResources(this.txtSdt, "txtSdt");
      this.txtSdt.Name = "txtSdt";
      // 
      // dtgvInfo
      // 
      this.dtgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      resources.ApplyResources(this.dtgvInfo, "dtgvInfo");
      this.dtgvInfo.Name = "dtgvInfo";
      // 
      // frmRapPhim
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtSdt);
      this.Controls.Add(this.txtTenKH);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.lbSdt);
      this.Controls.Add(this.lbTenKH);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnKetThuc);
      this.Controls.Add(this.btnHuy);
      this.Controls.Add(this.btnChon);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lbThanhTien);
      this.Controls.Add(this.txtTongTien);
      this.Controls.Add(this.pnlManAnh);
      this.Name = "frmRapPhim";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRapPhim_FormClosing);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlManAnh;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtTenKH;
    private System.Windows.Forms.TextBox txtSdt;
    private System.Windows.Forms.DataGridView dtgvInfo;
  }
}

