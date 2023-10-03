using Lab04_123.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_123
{
  public partial class frmFalculty : Form
  {
    StudentContextDB context = new StudentContextDB();
    public event EventHandler CapNhat;

    public frmFalculty()
    {
      InitializeComponent();
    }

    private void frmFalculty_Load(object sender, EventArgs e)
    {
      LoadDataKhoa();
    }

    private void LoadDataKhoa()
    {
      dtgvKhoa.Rows.Clear();

      List<Faculty> listFalcultys = context.Faculties.ToList();
      foreach (var item in listFalcultys)
      {
        int index = dtgvKhoa.Rows.Add();
        dtgvKhoa.Rows[index].Cells[0].Value = item.FacultyID;
        dtgvKhoa.Rows[index].Cells[1].Value = item.FacultyName;
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnThemHoacSua_Click(object sender, EventArgs e)
    {
      // Kiểm tra các thông tin bắt buộc
      if (string.IsNullOrEmpty(txtMaKhoa.Text) || string.IsNullOrEmpty(txtTenKhoa.Text))
      {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // Kiểm tra mã khoa đã tồn tại hay chưa bằng AddOrUpdate
      Faculty falculty = new Faculty()
      {
        FacultyID = int.Parse(txtMaKhoa.Text),
        FacultyName = txtTenKhoa.Text
      };
      context.Faculties.AddOrUpdate(falculty);
      context.SaveChanges();

      // thông báo thêm hoặc sửa thành công
      MessageBox.Show("Thêm hoặc sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

      // cập nhật lại dữ liệu ở form 1
      CapNhat?.Invoke(this, new EventArgs());

      LoadDataKhoa();
      ResetData();
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      // Kiểm tra xem FacultyID cần xóa có tồn tại trong CSDL hay không
      int facultyID = int.Parse(txtMaKhoa.Text);
      Faculty falculty = context.Faculties.SingleOrDefault(x => x.FacultyID == facultyID);
      if (falculty == null)
      {
        MessageBox.Show("Mã khoa không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // Kiểm tra xem khoa có sinh viên hay không
      List<Student> listSV = context.Students.Where(x => x.FacultyID == facultyID).ToList();
      if (listSV.Count > 0)
      {
        // thông báo nếu chọn yes thì xóa tất cả sinh viên trong khoa đó trước khi xóa khoa
        DialogResult dr = MessageBox.Show("Khoa này có sinh viên. Bạn có muốn xóa tất cả sinh viên trong khoa này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
          foreach (var item in listSV)
          {
            context.Students.Remove(item);
          }
          context.SaveChanges();

          // sau khi xóa sinh viên xong thì xóa khoa
          context.Faculties.Remove(falculty);
          context.SaveChanges();

          // thông báo xóa thành công
          MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

          // cập nhật lại dữ liệu ở form 1
          CapNhat?.Invoke(this, new EventArgs());

          LoadDataKhoa();
          ResetData();
        }
        else
        {
          return;
        }
      }
    }

    private void ResetData()
    {
      txtMaKhoa.Clear();
      txtTenKhoa.Clear();

      btnXoa.Enabled = false;
    }

    private void dtgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      txtMaKhoa.Clear();
      txtTenKhoa.Clear();

      int index = e.RowIndex;
      if (index >= 0)
      {
        DataGridViewRow row = dtgvKhoa.Rows[index];
        txtMaKhoa.Text = row.Cells[0].Value.ToString();
        txtTenKhoa.Text = row.Cells[1].Value.ToString();
      }

      btnXoa.Enabled = true;
    }
  }
}
