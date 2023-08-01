using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.BUS
{
  public class KhachHangBus
  {
    private readonly DataKhachHangService dataKhachHangService;

    public KhachHangBus(DataKhachHangService dataKhachHangService)
    {
      this.dataKhachHangService = dataKhachHangService;
    }

    public List<KhachHang> LayDanhSachKhachHang()
    {
      return dataKhachHangService.LayDanhSachKhachHang();
    }

    public KhachHang TimKhachHang(int idKhachHang)
    {
      return dataKhachHangService.TimKhachHang(idKhachHang);
    }
  }
}
