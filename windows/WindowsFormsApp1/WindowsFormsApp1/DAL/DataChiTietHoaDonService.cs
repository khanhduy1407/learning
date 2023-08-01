using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.DAL
{
  public class DataChiTietHoaDonService
  {
    private static ModelRapPhim dbContext;

    public DataChiTietHoaDonService()
    {
      dbContext = ModelRapPhim.Instance;
    }

    public void ThemChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
    {
      dbContext.ChiTietHoaDons.Add(chiTietHoaDon);
      dbContext.SaveChanges();
    }
  }
}
