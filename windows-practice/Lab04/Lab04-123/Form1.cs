using Lab04_123.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_123
{
  public partial class Form1 : Form
  {
    StudentContextDB context = new StudentContextDB();

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
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

    private void btnThem_Click(object sender, EventArgs e)
    {

      // Kiểm tra các thông tin bắt buộc
      if (string.IsNullOrEmpty(txtMSV.Text) || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtDiem.Text))
      {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      string maSV = txtMSV.Text;
      string tenSV = txtHoTen.Text;
      // get FacultyID from cbKhoa
      int khoa = (int)cbKhoa.SelectedValue;
      double diemTB;

      // Kiểm tra mã số sinh viên có 10 kí tự
      if (maSV.Length != 10)
      {
        MessageBox.Show("Mã số sinh viên phải có 10 kí tự!");
        return;
      }

      // Kiểm tra Mã số Sinh Viên trùng
      bool maSoTrung = CheckMaSoTrung(maSV);
      if (maSoTrung)
      {
        // Hiện thông báo khi mã số trùng
        DialogResult dialogResult = MessageBox.Show("Mã số sinh viên đã tồn tại. Bạn có muốn thêm sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dialogResult == DialogResult.Yes)
        {
          // Nếu người dùng chọn "Yes", trỏ chuột vào TextBox mã số
          txtMSV.Focus();
          txtMSV.SelectAll();
        }
        else
        {
          this.Close();
        }
        return;
      }

      // Lấy index khoa từ cbKhoa

      // Kiểm tra điểm trong phạm vi từ 0 đến 10
      if (!double.TryParse(txtDiem.Text, out diemTB) || diemTB < 0 || diemTB > 10)
      {
        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // Thêm dữ liệu vào database
      Student sv = new Student
      {
        StudentID = maSV,
        FullName = tenSV,
        FacultyID = khoa,
        AverageScore = diemTB,
      };
      context.Students.Add(sv);
      context.SaveChanges();
      MessageBox.Show("Thêm Sinh Viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
      LoadDataSV();
      ResetData();
    }

    private bool CheckMaSoTrung(string maSo)
    {
      DataGridView dgv = dtgvSV;
      foreach (DataGridViewRow row in dgv.Rows)
      {
        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maSo)
        {
          return true;
        }
      }
      return false;
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
      // Kiểm tra dữ liệu nhập liệu
      if (string.IsNullOrWhiteSpace(txtMSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
      {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        return;
      }

      // Kiểm tra mã số sinh viên
      if (txtMSV.Text.Length != 10)
      {
        MessageBox.Show("Mã số sinh viên phải có 10 kí tự!");
        return;
      }

      // Tìm sinh viên theo mã số
      var student = context.Students.SingleOrDefault(s => s.StudentID == txtMSV.Text);

      if (student == null)
      {
        MessageBox.Show("Không tìm thấy MSSV cần sửa!");
        return;
      }

      // Cập nhật thông tin sinh viên
      student.FullName = txtHoTen.Text;
      student.FacultyID = (int)cbKhoa.SelectedValue;
      student.AverageScore = double.Parse(txtDiem.Text);

      context.SaveChanges();

      MessageBox.Show("Cập nhật dữ liệu thành công!");

      // Load lại DataGridView và reset dữ liệu
      LoadDataSV();
      ResetData();
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      // Kiểm tra xem MSSV cần xóa có tồn tại trong CSDL hay không
      string mssvXoa = txtMSV.Text;
      var student = context.Students.SingleOrDefault(s => s.StudentID == mssvXoa);

      if (student == null)
      {
        MessageBox.Show("Không tìm thấy MSSV cần xóa!");
        return;
      }

      // Hiển thị cảnh báo YES/NO
      DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

      if (result == DialogResult.Yes)
      {
        // Xóa sinh viên khỏi CSDL
        context.Students.Remove(student);
        context.SaveChanges();

        MessageBox.Show("Xóa sinh viên thành công!");

        // Load lại DataGridView và reset dữ liệu
        LoadDataSV();
        ResetData();
      }
    }

    private void ResetData()
    {
      txtMSV.Clear();
      txtHoTen.Clear();
      txtDiem.Clear();

      btnSua.Enabled = false;
      btnXoa.Enabled = false;
    }

    private void dtgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      txtMSV.Clear();
      txtHoTen.Clear();
      txtDiem.Clear();

      int index = e.RowIndex;
      if (index >= 0)
      {
        DataGridViewRow row = dtgvSV.Rows[index];
        txtMSV.Text = row.Cells[0].Value.ToString();
        txtHoTen.Text = row.Cells[1].Value.ToString();
        cbKhoa.Text = row.Cells[2].Value.ToString();
        txtDiem.Text = row.Cells[3].Value.ToString();
      }

      btnSua.Enabled = true;
      btnXoa.Enabled = true;
    }

    private void thôngTinCácKhoaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmFalculty frm = new frmFalculty();
      frm.Show();

      // Đăng ký sự kiện
      frm.CapNhat += Frm_CapNhat;
    }

    private void Frm_CapNhat(object sender, EventArgs e)
    {
      // Load lại ComboBox Khoa
      GetComboBoxFaculty();
      // Load lại DataGridView Sinh Viên
      LoadDataSV();
    }

    private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmSearch frm = new frmSearch();
      frm.ShowDialog();
    }
  }
}
