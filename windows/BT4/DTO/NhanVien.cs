using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4.DTO
{
  public class NhanVien
  {
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string BangCap { get; set; }

    public NhanVien(string hoTen, int namSinh, string bangCap)
    {
      HoTen = hoTen;
      NamSinh = namSinh;
      BangCap = bangCap;
    }

    public virtual double TinhLuong()
    {
      return 0;
    }

    public virtual void XuatThongTin()
    {
      Console.WriteLine("Ho va ten: " + HoTen);
      Console.WriteLine("Nam sinh: " + NamSinh);
      Console.WriteLine("Bang cap: " + BangCap);
    }
  }
}
