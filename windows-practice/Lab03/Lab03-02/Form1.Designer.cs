namespace Lab03_02
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.richText = new System.Windows.Forms.RichTextBox();
      this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tạoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mởTậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.lưuNộiDungVănBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.comboBoxFont = new System.Windows.Forms.ToolStripComboBox();
      this.comboBoxSize = new System.Windows.Forms.ToolStripComboBox();
      this.boldButton = new System.Windows.Forms.ToolStripButton();
      this.italicButton = new System.Windows.Forms.ToolStripButton();
      this.underlineButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.địnhDạngToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(593, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.comboBoxFont,
            this.comboBoxSize,
            this.boldButton,
            this.italicButton,
            this.underlineButton,
            this.toolStripSeparator3});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(593, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // richText
      // 
      this.richText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.richText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richText.Location = new System.Drawing.Point(12, 52);
      this.richText.Name = "richText";
      this.richText.Size = new System.Drawing.Size(569, 307);
      this.richText.TabIndex = 2;
      this.richText.Text = "";
      // 
      // hệThốngToolStripMenuItem
      // 
      this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoToolStripMenuItem,
            this.mởTậpTinToolStripMenuItem,
            this.toolStripSeparator1,
            this.lưuNộiDungVănBảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
      this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
      this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
      this.hệThốngToolStripMenuItem.Text = "Hệ thống";
      // 
      // địnhDạngToolStripMenuItem
      // 
      this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
      this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
      this.địnhDạngToolStripMenuItem.Text = "Định dạng";
      this.địnhDạngToolStripMenuItem.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
      // 
      // tạoToolStripMenuItem
      // 
      this.tạoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tạoToolStripMenuItem.Image")));
      this.tạoToolStripMenuItem.Name = "tạoToolStripMenuItem";
      this.tạoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
      this.tạoToolStripMenuItem.Text = "Tạo văn bản mới";
      this.tạoToolStripMenuItem.Click += new System.EventHandler(this.tạoToolStripMenuItem_Click);
      // 
      // mởTậpTinToolStripMenuItem
      // 
      this.mởTậpTinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mởTậpTinToolStripMenuItem.Image")));
      this.mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
      this.mởTậpTinToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
      this.mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
      this.mởTậpTinToolStripMenuItem.Click += new System.EventHandler(this.mởTậpTinToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
      // 
      // lưuNộiDungVănBảnToolStripMenuItem
      // 
      this.lưuNộiDungVănBảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lưuNộiDungVănBảnToolStripMenuItem.Image")));
      this.lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
      this.lưuNộiDungVănBảnToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
      this.lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu nội dung văn bản";
      this.lưuNộiDungVănBảnToolStripMenuItem.Click += new System.EventHandler(this.lưuNộiDungVănBảnToolStripMenuItem_Click);
      // 
      // thoátToolStripMenuItem
      // 
      this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
      this.thoátToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
      this.thoátToolStripMenuItem.Text = "Thoát";
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton1.Text = "toolStripButton1";
      this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
      // 
      // toolStripButton2
      // 
      this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
      this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton2.Text = "toolStripButton2";
      this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // comboBoxFont
      // 
      this.comboBoxFont.Name = "comboBoxFont";
      this.comboBoxFont.Size = new System.Drawing.Size(121, 25);
      // 
      // comboBoxSize
      // 
      this.comboBoxSize.Name = "comboBoxSize";
      this.comboBoxSize.Size = new System.Drawing.Size(121, 25);
      // 
      // boldButton
      // 
      this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.boldButton.Image = ((System.Drawing.Image)(resources.GetObject("boldButton.Image")));
      this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.boldButton.Name = "boldButton";
      this.boldButton.Size = new System.Drawing.Size(23, 22);
      this.boldButton.Text = "toolStripButton3";
      this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
      // 
      // italicButton
      // 
      this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.italicButton.Image = ((System.Drawing.Image)(resources.GetObject("italicButton.Image")));
      this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.italicButton.Name = "italicButton";
      this.italicButton.Size = new System.Drawing.Size(23, 22);
      this.italicButton.Text = "toolStripButton4";
      this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
      // 
      // underlineButton
      // 
      this.underlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.underlineButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineButton.Image")));
      this.underlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.underlineButton.Name = "underlineButton";
      this.underlineButton.Size = new System.Drawing.Size(23, 22);
      this.underlineButton.Text = "toolStripButton5";
      this.underlineButton.Click += new System.EventHandler(this.underlineButton_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(593, 371);
      this.Controls.Add(this.richText);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.RichTextBox richText;
    private System.Windows.Forms.ToolStripMenuItem tạoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mởTậpTinToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripButton toolStripButton2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripComboBox comboBoxFont;
    private System.Windows.Forms.ToolStripComboBox comboBoxSize;
    private System.Windows.Forms.ToolStripButton boldButton;
    private System.Windows.Forms.ToolStripButton italicButton;
    private System.Windows.Forms.ToolStripButton underlineButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
  }
}

