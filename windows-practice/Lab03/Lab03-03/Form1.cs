using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{
  public partial class Form1 : Form
  {
    SVContext context = new SVContext();

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Gọi hàm tìm kiếm ban đầu khi Form được khởi động
      SearchByName();

      // và load dữ liệu từ database
      List<SV> listSV = context.SVs.ToList();
      LoadData(listSV);
    }

    private void LoadData(List<SV> listSV)
    {
      dataGridView1.Rows.Clear();
      foreach (var item in listSV)
      {
        int index = dataGridView1.Rows.Add();
        dataGridView1.Rows[index].Cells[0].Value = index + 1;
        dataGridView1.Rows[index].Cells[1].Value = item.MaSV;
        dataGridView1.Rows[index].Cells[2].Value = item.TenSV;
        dataGridView1.Rows[index].Cells[3].Value = item.Khoa;
        dataGridView1.Rows[index].Cells[4].Value = item.DiemTB;
      }
    }

    private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
    {
      openForm2();
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      openForm2();
    }

    private void openForm2()
    {
      Form2 sinhVienForm = new Form2();
      sinhVienForm.Show();
      sinhVienForm.ThemSV += SinhVienForm_ThemSV;
    }

    private void SinhVienForm_ThemSV(object sender, EventArgs e)
    {
      List<SV> listSV = context.SVs.ToList();
      LoadData(listSV);
    }

    private void toolStripTxtSearch_TextChanged(object sender, EventArgs e)
    {
      SearchByName();
    }

    private void SearchByName()
    {
      string searchText = toolStripTxtSearch.Text.ToLower(); // Lấy nội dung từ Textbox tìm kiếm và chuyển thành chữ thường

      DataGridView dgv = dataGridView1; // Thay dataGridView1 bằng tên DataGridView thật của bạn

      foreach (DataGridViewRow row in dgv.Rows)
      {
        if (row.Cells[2].Value != null)
        {
          string tenSinhVien = row.Cells[2].Value.ToString().ToLower();

          // So sánh tên sinh viên với nội dung tìm kiếm (không phân biệt hoa thường)
          if (tenSinhVien.Contains(searchText))
          {
            row.Visible = true; // Hiển thị dòng nếu tìm thấy
          }
          else
          {
            row.Visible = false; // Ẩn dòng nếu không tìm thấy
          }
        }
      }
    }
  }
}
