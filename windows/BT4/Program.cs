using BT4.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<NhanVien> danhSachNhanVien = new List<NhanVien>();

      // nhập số lượng nhân viên
      Console.Write("Nhap so luong nhan vien: ");
      int soLuongNhanVien = int.Parse(Console.ReadLine());

      // Vòng lặp nhập thông tin nhân viên theo số lượng đã nhập và loại nhân viên
      for (int i = 0; i < soLuongNhanVien; i++)
      {
        Console.WriteLine("\n\n- Nhap thong tin nhan vien thu " + (i + 1) + ":");
        Console.Write("Nhap loai nhan vien (1 - Nha khoa hoc, 2 - Nha quan ly, 3 - Nhan vien phong thi nghiem): ");
        int loaiNhanVien = int.Parse(Console.ReadLine());

        switch (loaiNhanVien)
        {
          case 1:
            NhaKhoaHoc nhaKhoaHoc = NhapThongTinNhaKhoaHoc();
            danhSachNhanVien.Add(nhaKhoaHoc);
            break;
          case 2:
            NhaQuanLy nhaQuanLy = NhapThongTinNhaQuanLy();
            danhSachNhanVien.Add(nhaQuanLy);
            break;
          case 3:
            NhanVienPhongThiNghiem nhanVienPhongThiNghiem = NhapThongTinNhanVienPhongThiNghiem();
            danhSachNhanVien.Add(nhanVienPhongThiNghiem);
            break;
          default:
            Console.WriteLine("Loai nhan vien khong hop le!");
            break;
        }
      }

      // Xuất danh sách nhân viên
      Console.WriteLine("\n\n====== DANH SACH NHAN VIEN ======");
      foreach (NhanVien nhanVien in danhSachNhanVien)
      {
        nhanVien.XuatThongTin();
      }

      // Tính tổng lương đã chi trả cho từng loại đối tượng
      double tongLuongNhaKhoaHoc = 0;
      double tongLuongNhaQuanLy = 0;
      double tongLuongNhanVienPhongThiNghiem = 0;

      foreach (NhanVien nhanVien in danhSachNhanVien)
      {
        if (nhanVien is NhaKhoaHoc)
        {
          tongLuongNhaKhoaHoc += nhanVien.TinhLuong();
        }
        else if (nhanVien is NhaQuanLy)
        {
          tongLuongNhaQuanLy += nhanVien.TinhLuong();
        }
        else if (nhanVien is NhanVienPhongThiNghiem)
        {
          tongLuongNhanVienPhongThiNghiem += nhanVien.TinhLuong();
        }
      }

      // In tổng lương đã chi trả cho từng loại đối tượng
      Console.WriteLine("\nTong luong da chi tra:");
      Console.WriteLine("Nha khoa hoc: " + tongLuongNhaKhoaHoc);
      Console.WriteLine("Nha quan ly: " + tongLuongNhaQuanLy);
      Console.WriteLine("Nhan vien phong thi nghiem: " + tongLuongNhanVienPhongThiNghiem);

      Console.ReadLine();
    }

    static NhaKhoaHoc NhapThongTinNhaKhoaHoc()
    {
      Console.Write("Ho va ten: ");
      string hoTen = Console.ReadLine();

      Console.Write("Nam sinh: ");
      int namSinh = int.Parse(Console.ReadLine());

      Console.Write("Bang cap: ");
      string bangCap = Console.ReadLine();

      Console.Write("Chuc vu: ");
      string chucVu = Console.ReadLine();

      Console.Write("So bai bao da cong bo: ");
      int soBaiBaoDaCongBo = int.Parse(Console.ReadLine());

      Console.Write("So ngay cong trong thang: ");
      int soNgayCongTrongThang = int.Parse(Console.ReadLine());

      Console.Write("Bac luong: ");
      double bacLuong = double.Parse(Console.ReadLine());

      return new NhaKhoaHoc(hoTen, namSinh, bangCap, chucVu, soBaiBaoDaCongBo, soNgayCongTrongThang, bacLuong);
    }

    static NhaQuanLy NhapThongTinNhaQuanLy()
    {
      Console.Write("Ho va ten: ");
      string hoTen = Console.ReadLine();

      Console.Write("Nam sinh: ");
      int namSinh = int.Parse(Console.ReadLine());

      Console.Write("Bang cap: ");
      string bangCap = Console.ReadLine();

      Console.Write("Chuc vu: ");
      string chucVu = Console.ReadLine();

      Console.Write("So ngay cong trong thang: ");
      int soNgayCongTrongThang = int.Parse(Console.ReadLine());

      Console.Write("Bac luong: ");
      double bacLuong = double.Parse(Console.ReadLine());

      return new NhaQuanLy(hoTen, namSinh, bangCap, chucVu, soNgayCongTrongThang, bacLuong);
    }

    static NhanVienPhongThiNghiem NhapThongTinNhanVienPhongThiNghiem()
    {
      Console.Write("Ho va ten: ");
      string hoTen = Console.ReadLine();

      Console.Write("Nam sinh: ");
      int namSinh = int.Parse(Console.ReadLine());

      Console.Write("Bang cap: ");
      string bangCap = Console.ReadLine();

      Console.Write("Luong trong thang: ");
      double luongTrongThang = double.Parse(Console.ReadLine());

      return new NhanVienPhongThiNghiem(hoTen, namSinh, bangCap, luongTrongThang);
    }
  }
}
