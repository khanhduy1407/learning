using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4.DTO
{
  public class NhaQuanLy: NhanVien
  {
    public string ChucVu { get; set; }
    public int SoNgayCongTrongThang { get; set; }
    public double BacLuong { get; set; }

    public NhaQuanLy(string hoTen, int namSinh, string bangCap, string chucVu, int soNgayCongTrongThang, double bacLuong)
        : base(hoTen, namSinh, bangCap)
    {
      ChucVu = chucVu;
      SoNgayCongTrongThang = soNgayCongTrongThang;
      BacLuong = bacLuong;
    }

    public override double TinhLuong()
    {
      return SoNgayCongTrongThang * BacLuong;
    }

    public override void XuatThongTin()
    {
      base.XuatThongTin();
      Console.WriteLine("Chuc vu: " + ChucVu);
      Console.WriteLine("So ngay cong trong thang: " + SoNgayCongTrongThang);
      Console.WriteLine("Bac luong: " + BacLuong);
      Console.WriteLine("Luong thang: " + TinhLuong());
      Console.WriteLine("----------------------");
    }
  }
}
