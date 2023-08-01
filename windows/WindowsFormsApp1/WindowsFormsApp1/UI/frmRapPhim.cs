using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using System.Transactions;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
  public partial class frmRapPhim : Form
  {
    private readonly HoaDonBus hoaDonBus;
    private readonly KhachHangBus khachHangBus;
    private readonly ChiTietHoaDonBus chiTietHoaDonBus;

    private double tongTien = 0;

    CultureInfo culture = new CultureInfo("vi-VN");

    public frmRapPhim(HoaDonBus hoaDonBus, KhachHangBus khachHangBus, ChiTietHoaDonBus chiTietHoaDonBus)
    {
      InitializeComponent();
      init();

      this.hoaDonBus = hoaDonBus;
      this.khachHangBus = khachHangBus;
      this.chiTietHoaDonBus = chiTietHoaDonBus;

      LoadDtgvCollumnName();
      LoadDanhsachHoaDon();
      LoadDanhSachGheDaChon();
      LoadKhachHang();
    }

    private void LoadKhachHang()
    {
      cbKhachHang.ValueMember = "idKhachHang";
      cbKhachHang.DisplayMember = "Ten";
      cbKhachHang.DataSource = khachHangBus.LayDanhSachKhachHang();
    }

    private void LoadDanhSachGheDaChon()
    {
      // Lấy danh sách các ghế đã chọn từ database
      List<ChiTietHoaDon> dsGheDaChon = hoaDonBus.LayDanhSachGheDaMua();

      // Duyệt qua từng ghế đã chọn
      foreach (ChiTietHoaDon ghe in dsGheDaChon)
      {
        // Tìm button có tên là "btn" + số ghế đã chọn
        Button btnGhe = (Button)pnlManAnh.Controls.Find("btn" + ghe.TenGhe, false).FirstOrDefault();

        // Đổi màu của button đó sang màu vàng
        btnGhe.BackColor = Color.Yellow;
        btnGhe.Enabled = false;
      }
    }

    void LoadDtgvCollumnName()
    {
      // thiết lập tên cột cho dtgvInfo có 3 cột: tên khách hàng, sdt, tổng tiền
      dtgvInfo.ColumnCount = 3;
      dtgvInfo.Columns[0].Name = "Tên khách hàng";
      dtgvInfo.Columns[1].Name = "Số điện thoại";
      dtgvInfo.Columns[2].Name = "Tổng tiền";
    }

    private void init()
    {
      int x = 15, y = 15;
      for (int i = 1; i <= 20; i++)
      {
        KhoiTaoControls(i, x, y);
        if (i % 5 == 0)
        {
          x = 15;
          y += 50;
        }
        else
        {
          x += 50;
        }
      }
    }

    private void KhoiTaoControls(int i, int x, int y)
    {
      Button btnGhe = new Button();
      btnGhe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
      btnGhe.Size = new Size(50, 50);
      btnGhe.Name = "btn" + i;
      btnGhe.TabIndex = i;
      btnGhe.BackColor = Color.White;
      btnGhe.Text = i.ToString();
      btnGhe.Location = new Point(x, y);
      pnlManAnh.Controls.Add(btnGhe);
      btnGhe.Click += new System.EventHandler(this.BtnGhe_Click);
    }

    private void BtnGhe_Click(object sender, EventArgs e)
    {
      Button btnGhe = (Button)sender;

      if (btnGhe.BackColor == Color.White)
      {
        // Đổi màu của vị trí chưa bán vé sang màu xanh
        btnGhe.BackColor = Color.Blue;
        tongTien += hoaDonBus.TinhTien(btnGhe.Text);
      }
      else if (btnGhe.BackColor == Color.Blue)
      {
        // Đổi màu của vị trí đã chọn trở lại màu trắng
        btnGhe.BackColor = Color.White;
        tongTien -= hoaDonBus.TinhTien(btnGhe.Text);
      }
      else if (btnGhe.BackColor == Color.Yellow)
      {
        MessageBox.Show("Ghế đã được bán!!");
      }

      txtTongTien.Text = tongTien.ToString();
    }

    private void btnChon_Click(object sender, EventArgs e)
    {
      // PrintBill();

      try
      {
        // Lưu thông tin khách hàng vào database nếu chưa có và tự động tăng idKhachHang 
        int idKhachHang = int.Parse(cbKhachHang.SelectedValue.ToString());
        KhachHang kh = khachHangBus.TimKhachHang(idKhachHang);

        // Lưu hóa đơn vào database
        HoaDon hd = new HoaDon();
        hd.KhachHang = kh;
        hd.TongTien = (decimal)tongTien;
        hoaDonBus.ThemHoaDon(hd);

        // Lưu chi tiết hóa đơn vào database
        string[] soGhe = LaySoGhe().Split(',');
        foreach (string item in soGhe)
        {
          ChiTietHoaDon cthd = new ChiTietHoaDon();
          cthd.HoaDon = hd;
          cthd.TenGhe = int.Parse(item);
          chiTietHoaDonBus.ThemChiTietHoaDon(cthd);
        }

        LoadDanhsachHoaDon();

        //txtTenKH.Text = "";
        //txtSdt.Text = "";
        txtTongTien.Text = "0";
        tongTien = 0;

        foreach (Button btn in pnlManAnh.Controls.OfType<Button>())
        {
          if (btn.BackColor == Color.Blue)
          {
            btn.BackColor = Color.Yellow;
          }
        }
      } catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void LoadDanhsachHoaDon()
    {
      dtgvInfo.Rows.Clear();
      foreach (HoaDon item in this.hoaDonBus.LayDanhSachHoaDon())
      {
        dtgvInfo.Rows.Add(item.KhachHang.Ten, item.KhachHang.SDT, item.TongTien.ToString("c0", culture));
      }
    }

    void PrintBill()
    {
      PrintDialog printDialog = new PrintDialog();
      PrintDocument printDocument = new PrintDocument();
      printDocument.PrintPage += PrintDocument_PrintPage;

      if (printDialog.ShowDialog() == DialogResult.OK)
      {
        printDocument.PrinterSettings.PrinterName =
        printDialog.PrinterSettings.PrinterName;

        printDocument.DefaultPageSettings.PaperSize =
        printDialog.PrinterSettings.PaperSizes[8]; //giấy A4(1169 - 827)

        printDocument.DocumentName =
        $"Bill_" + DateTime.Now.ToString("ddMMyyy_hhmmss_tt");

        printDocument.Print();
      }
    }

    private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
      CultureInfo culture = new CultureInfo("vi-VN");

      Graphics graphic = e.Graphics;
      Font font = new Font("Courier New", 12);

      int startX = 10;
      int startY = 10;
      int offset = 40;

      graphic.DrawString("HÓA ĐƠN THANH TOÁN", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
      //graphic.DrawString("Tên khách hàng: " + txtTenKH.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
      //graphic.DrawString("Số điện thoại: " + txtSdt.Text, font, new SolidBrush(Color.Black), startX, startY + offset * 2);
      graphic.DrawString("Số ghế: " + LaySoGhe(), font, new SolidBrush(Color.Black), startX, startY + offset * 3);
      graphic.DrawString("Tổng tiền: " + tongTien.ToString("c0", culture), font, new SolidBrush(Color.Black), startX, startY + offset * 4);

      graphic.DrawString("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy"), font, new SolidBrush(Color.Black), startX, startY + offset * 6);
      graphic.DrawString("Giờ: " + DateTime.Now.ToString("hh:mm:ss"), font, new SolidBrush(Color.Black), startX, startY + offset * 7);
      
      graphic.DrawString("Cảm ơn quý khách!", new Font("Courier New", 16), new SolidBrush(Color.Black), startX, startY + offset * 9);
    }

    private string LaySoGhe()
    {
      string soGhe = "";

      // lấy số ghế đang chọn mà có màu xanh, nếu có 1 ghế hoặc ghế cuối cùng không có dấu phẩy
      foreach (Button btn in pnlManAnh.Controls.OfType<Button>())
      {
        if (btn.BackColor == Color.Blue)
        {
          if (soGhe == "")
          {
            soGhe += btn.Text;
          }
          else
          {
            soGhe += ", " + btn.Text;
          }
        }
      }

      return soGhe;
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Bạn có chắc muốn hủy chọn không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
      {
        //txtTenKH.Text = "";
        //txtSdt.Text = "";
        txtTongTien.Text = "0";
        tongTien = 0;

        foreach (Button btn in pnlManAnh.Controls.OfType<Button>())
        {
          if (btn.BackColor == Color.Blue)
          {
            btn.BackColor = Color.White;
          }
        }
      }
    }

    private void btnKetThuc_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void frmRapPhim_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
      {
        e.Cancel = true;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      frmKhachHang frm = new frmKhachHang(LaySoGhe());
      frm.ThayDoiThongTin += Frm_ThayDoiThongTin;
      frm.ShowDialog();
    }

    private void Frm_ThayDoiThongTin(string ten)
    {
      LoadKhachHang();
      MessageBox.Show(ten);
    }
  }
}
