using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.BUS
{
  public class HoaDonBus
  {
    private readonly DataHoaDonService dataHoaDonService;

    public HoaDonBus(DataHoaDonService dataHoaDonService)
    {
      this.dataHoaDonService = dataHoaDonService;
    }

    public double TinhTien(string soTTGhe)
    {
      // Xác định giá tiền
      decimal hangGhe = Math.Ceiling(decimal.Parse(soTTGhe) / 5);
      switch (hangGhe)
      {
        case 1:
          return 30000;
        case 2:
          return 40000;
        case 3:
          return 50000;
        case 4:
          return 60000;
        default:
          return 70000;
      }
    }

    public List<ChiTietHoaDon> LayDanhSachGheDaMua()
    {
      return dataHoaDonService.LayDanhSachGheDaMua();
    }

    public List<HoaDon> LayDanhSachHoaDon()
    {
      return dataHoaDonService.LayDanhSachHoaDon();
    }

    public void ThemHoaDon(HoaDon hoaDon)
    {
      dataHoaDonService.ThemHoaDon(hoaDon);
    }
  }
}
