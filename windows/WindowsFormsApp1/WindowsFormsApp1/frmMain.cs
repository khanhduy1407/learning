using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }

    private void bánVéToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // mở frmRapPhim
      if (Application.OpenForms["frmRapPhim"] == null)
      {
        frmRapPhim frm = new frmRapPhim();
        frm.MdiParent = this;
        frm.Show();
      }
      else
      {
        Application.OpenForms["frmRapPhim"].Activate();
      }
    }
  }
}
