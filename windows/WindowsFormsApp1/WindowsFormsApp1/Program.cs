using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
  internal static class Program
  {
    private static ModelRapPhim dbContext;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      dbContext = ModelRapPhim.Instance;

      DataHoaDonService dataHoaDonService = new DataHoaDonService();
      HoaDonBus hoaDonBus = new HoaDonBus(dataHoaDonService);
      DataKhachHangService dataKhachHangService = new DataKhachHangService();
      KhachHangBus khachHangBus = new KhachHangBus(dataKhachHangService);
      DataChiTietHoaDonService dataChiTietHoaDonService = new DataChiTietHoaDonService();
      ChiTietHoaDonBus chiTietHoaDonBus = new ChiTietHoaDonBus(dataChiTietHoaDonService);

      Application.Run(new frmMain(hoaDonBus, khachHangBus, chiTietHoaDonBus));
    }
  }
}
