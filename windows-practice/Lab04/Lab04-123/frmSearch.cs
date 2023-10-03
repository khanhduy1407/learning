using Lab04_123.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_123
{
  public partial class frmSearch : Form
  {
    StudentContextDB context = new StudentContextDB();

    public frmSearch()
    {
      InitializeComponent();
    }

    private void frmSearch_Load(object sender, EventArgs e)
    {
      GetComboBoxFaculty();
      LoadDataSV();
    }

    private void GetComboBoxFaculty()
    {
      this.cbKhoa.DataSource = null;

      List<Faculty> listFalcultys = context.Faculties.ToList();
      this.cbKhoa.DataSource = listFalcultys;
      this.cbKhoa.DisplayMember = "FacultyName";
      this.cbKhoa.ValueMember = "FacultyID";
    }

    private void LoadDataSV()
    {
      dtgvSV.Rows.Clear();

      List<Student> listSV = context.Students.ToList();
      foreach (var item in listSV)
      {
        int index = dtgvSV.Rows.Add();
        dtgvSV.Rows[index].Cells[0].Value = item.StudentID;
        dtgvSV.Rows[index].Cells[1].Value = item.FullName;
        dtgvSV.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
        dtgvSV.Rows[index].Cells[3].Value = item.AverageScore;
      }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
      // Khi người dùng click vào button tìm kiếm sẽ tìm kiếm thông tin sinh viên thỏa 
      // các điều kiện tìm kiếm(không nhập có nghĩa là bỏ qua điều kiện tìm kiếm
      // đó)
      string msv = txtMSV.Text;
      string hoten = txtHoTen.Text.ToLower();
      string khoa = cbKhoa.Text;

      // Lấy danh sách sinh viên
      List<Student> listSV = context.Students.ToList();

      // Lọc danh sách sinh viên theo điều kiện
      if (!string.IsNullOrEmpty(msv))
      {
        listSV = listSV.Where(p => p.StudentID.Contains(msv)).ToList();
      }
      if (!string.IsNullOrEmpty(hoten))
      {
        listSV = listSV.Where(p => p.FullName.ToLower().Contains(hoten)).ToList();
      }
      if (!string.IsNullOrEmpty(khoa))
      {
        listSV = listSV.Where(p => p.Faculty.FacultyName.Contains(khoa)).ToList();
      }

      // Hiển thị danh sách sinh viên lên datagridview
      dtgvSV.Rows.Clear();
      foreach (var item in listSV)
      {
        int index = dtgvSV.Rows.Add();
        dtgvSV.Rows[index].Cells[0].Value = item.StudentID;
        dtgvSV.Rows[index].Cells[1].Value = item.FullName;
        dtgvSV.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
        dtgvSV.Rows[index].Cells[3].Value = item.AverageScore;
      }

      // Hiển thị số lượng sinh viên tìm được
      txtCount.Text = listSV.Count.ToString();
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      // Khi người dùng click vào button xóa: Trả lại giá trị mặc định như khi load form tìm kiếm.
      txtMSV.Text = "";
      txtHoTen.Text = "";
      txtCount.Text = "";
      cbKhoa.SelectedIndex = 0;
      LoadDataSV();
    }

    private void btnReturn_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
