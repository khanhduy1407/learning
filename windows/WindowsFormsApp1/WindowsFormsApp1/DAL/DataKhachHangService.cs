using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.DAL
{
  public class DataKhachHangService
  {
    private static ModelRapPhim dbContext;

    public DataKhachHangService()
    {
      dbContext = ModelRapPhim.Instance;
    }

    public List<KhachHang> LayDanhSachKhachHang()
    {
      return dbContext.KhachHangs.ToList();
    }
    
    public KhachHang TimKhachHang(int idKhachHang)
    {
      return dbContext.KhachHangs.Find(idKhachHang);
    }
  }
}
