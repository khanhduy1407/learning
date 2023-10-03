using Lab04_4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_4
{
  public partial class Form1 : Form
  {
    DBContext context = new DBContext();
    CultureInfo culture = new CultureInfo("vi-VN");

    public Form1()
    {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    LoadDataInvoice();
    }

    private void LoadDataInvoice()
    {
      dtgvHD.Rows.Clear();

      // Thời gian giao hàng được thể hiện trong ngày hiện hành và tự động tìm kiếm
      // dữ liệu có Hóa Đơn phát sinh trong ngày hiện hành này
      List<Invoice> listInvoice = context.Invoices
        .Where(i => i.DeliveryDate >= dtpFrom.Value.Date && i.DeliveryDate <= dtpTo.Value.Date)
        .ToList();

      float total = 0;

      // List<Invoice> listInvoice = context.Invoices.ToList();
      foreach (var item in listInvoice)
      {
        int index = dtgvHD.Rows.Add();
        dtgvHD.Rows[index].Cells[0].Value = index + 1;
        dtgvHD.Rows[index].Cells[1].Value = item.InvoiceNo;
        // format dd/MM/yyyy
        dtgvHD.Rows[index].Cells[2].Value = item.OrderDate.ToString("dd/MM/yyyy");
        dtgvHD.Rows[index].Cells[3].Value = item.DeliveryDate.ToString("dd/MM/yyyy");
        
        // get total money from orders and product
        float totalMoney = 0;
        foreach (var order in item.Orders)
        {
          totalMoney += order.Quantity * (float)order.Price;
        }
        total += totalMoney;
        dtgvHD.Rows[index].Cells[4].Value = totalMoney.ToString("c0", culture);
      }

      txtTotal.Text = total.ToString("c0", culture);
    }

    private void chbAllThisMonth_CheckStateChanged(object sender, EventArgs e)
    {
      if (chbAllThisMonth.Checked)
      {
        DateTime now = DateTime.Now;
        dtpFrom.Value = new DateTime(now.Year, now.Month, 1);
        dtpTo.Value = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
      }
      else
      {
        dtpFrom.Value = DateTime.Now;
        dtpTo.Value = DateTime.Now;
      }

      LoadDataInvoice();
    }

    private void dtpFrom_ValueChanged(object sender, EventArgs e)
    {
      // nếu ngày bắt đầu lớn hơn ngày kết thúc thì ngày kết thúc sẽ bằng ngày bắt đầu
      if (dtpFrom.Value > dtpTo.Value)
      {
        dtpTo.Value = dtpFrom.Value;
      }

      LoadDataInvoice();
    }

    private void dtpTo_ValueChanged(object sender, EventArgs e)
    {
      // nếu ngày kết thúc nhỏ hơn ngày bắt đầu thì ngày bắt đầu sẽ bằng ngày kết thúc
      if (dtpTo.Value < dtpFrom.Value)
      {
        dtpFrom.Value = dtpTo.Value;
      }

      LoadDataInvoice();
    }
  }
}
