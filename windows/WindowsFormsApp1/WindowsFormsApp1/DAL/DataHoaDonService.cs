using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.DAL
{
  public class DataHoaDonService
  {
    private static ModelRapPhim dbContext;

    public DataHoaDonService()
    {
      dbContext = ModelRapPhim.Instance;
    }

    public List<ChiTietHoaDon> LayDanhSachGheDaMua()
    {
      return dbContext.ChiTietHoaDons.ToList();
    }

    public List<HoaDon> LayDanhSachHoaDon()
    {
      return dbContext.HoaDons.Include("KhachHang").ToList();
    }

    public void ThemHoaDon(HoaDon hoaDon)
    {
      dbContext.HoaDons.Add(hoaDon);
      dbContext.SaveChanges();
    }
  }
}
