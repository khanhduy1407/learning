using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_01
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}", DateTime.Now.ToString("dd/mm/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Filter = "Media Files|*.mp3;*.mp4;*.avi;*.mkv|All Files|*.*";

      if (ofd.ShowDialog() == DialogResult.OK)
      {
        this.axWindowsMediaPlayer1.URL = ofd.FileName;
      }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        Application.Exit();
      }
    }
  }
}
