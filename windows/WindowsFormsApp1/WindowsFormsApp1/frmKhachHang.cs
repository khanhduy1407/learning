using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
  public delegate void ThayDoiThongTin(string ten);

  public partial class frmKhachHang : Form
  {
    public event ThayDoiThongTin ThayDoiThongTin;
    
    public frmKhachHang(string thongTinVe)
    {
      InitializeComponent();
      LoadDanhSachKhachHang();
      lblThongTinVe.Text = thongTinVe;
    }

    private void LoadDanhSachKhachHang()
    {
      using (var dbContext = new ModelRapPhim())
      {
        dtgvKhachHang.Rows.Clear();
        foreach (KhachHang item in dbContext.KhachHangs.ToList())
        {
          dtgvKhachHang.Rows.Add(item.Ten, item.SDT);
        }
      }
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
      string ten = txtTen.Text;
      string sdt = txtSDT.Text;
      if (ten == "" || sdt == "")
      {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        return;
      }
      else if (sdt.Length != 10)
      {
        MessageBox.Show("Số điện thoại không hợp lệ");
        return;
      }
      else
      {
        using (var dbContext = new ModelRapPhim())
        {
          KhachHang kh = new KhachHang { Ten = ten, SDT = sdt };
          dbContext.KhachHangs.Add(kh);
          dbContext.SaveChanges();

          LoadDanhSachKhachHang();
          ThayDoiThongTin(ten);
        }
      }
    }
  }
}
