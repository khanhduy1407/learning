using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
  public partial class frmMain : Form
  {
    private readonly HoaDonBus hoaDonBus;
    private readonly KhachHangBus khachHangBus;
    private readonly ChiTietHoaDonBus chiTietHoaDonBus;

    public frmMain(HoaDonBus hoaDonBus, KhachHangBus khachHangBus, ChiTietHoaDonBus chiTietHoaDonBus)
    {
      InitializeComponent();
      this.hoaDonBus = hoaDonBus;
      this.khachHangBus = khachHangBus;
      this.chiTietHoaDonBus = chiTietHoaDonBus;
    }

    private void bánVéToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // mở frmRapPhim
      if (Application.OpenForms["frmRapPhim"] == null)
      {
        frmRapPhim frm = new frmRapPhim(hoaDonBus, khachHangBus, chiTietHoaDonBus);
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
