using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.BUS
{
  public class ChiTietHoaDonBus
  {
    private readonly DataChiTietHoaDonService dataChiTietHoaDonService;

    public ChiTietHoaDonBus(DataChiTietHoaDonService dataChiTietHoaDonService)
    {
      this.dataChiTietHoaDonService = dataChiTietHoaDonService;
    }

    public void ThemChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
    {
      dataChiTietHoaDonService.ThemChiTietHoaDon(chiTietHoaDon);
    }
  }
}
