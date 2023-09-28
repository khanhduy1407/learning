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
  public partial class Form2 : Form
  {
    public event EventHandler ThemSV;

    public Form2()
    {
      InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      // Tạo danh sách các khoa
      List<string> danhSachKhoa = new List<string>
      {
        "Công nghệ thông tin",
        "Ngôn ngữ Anh",
        "Quản trị kinh doanh"
      };

      // Gán danh sách khoa vào ComboBox
      comboBoxKhoa.DataSource = danhSachKhoa;
    }

    private void addBtn_Click(object sender, EventArgs e)
    {
      // Kiểm tra thông tin bắt buộc
      if (string.IsNullOrEmpty(txtMaSo.Text) || string.IsNullOrEmpty(txtTenSinhVien.Text) || string.IsNullOrEmpty(txtDiem.Text))
      {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // Kiểm tra Mã số Sinh Viên trùng
      string maSo = txtMaSo.Text;
      bool maSoTrung = CheckMaSoTrung(maSo);
      if (maSoTrung)
      {
        // Hiện thông báo khi mã số trùng
        DialogResult dialogResult = MessageBox.Show("Mã số sinh viên đã tồn tại. Bạn có muốn thêm sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dialogResult == DialogResult.Yes)
        {
          // Nếu người dùng chọn "Yes", trỏ chuột vào TextBox mã số
          txtMaSo.Focus();
          txtMaSo.SelectAll();
        } else
        {
          this.Close();
        }
        return;
      }

      // Lấy dữ liệu khoa từ ComboBox
      string khoa = comboBoxKhoa.SelectedItem.ToString();

      // Kiểm tra điểm trong phạm vi từ 0 đến 10
      double diem;
      if (!double.TryParse(txtDiem.Text, out diem) || diem < 0 || diem > 10)
      {
        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // Thêm dữ liệu vào database
      SVContext context = new SVContext();
      SV sv = new SV
      {
        MaSV = maSo,
        TenSV = txtTenSinhVien.Text,
        Khoa = khoa,
        DiemTB = diem
      };
      context.SVs.Add(sv);
      context.SaveChanges();

      // Đóng Form 2 và quay lại Form chính
      MessageBox.Show("Thêm Sinh Viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      ThemSV?.Invoke(this, EventArgs.Empty);
      this.Close();
    }

    private bool CheckMaSoTrung(string maSo)
    {
      DataGridView dgv = (DataGridView)Application.OpenForms["Form1"].Controls["dataGridView1"];
      foreach (DataGridViewRow row in dgv.Rows)
      {
        if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == maSo)
        {
          return true;
        }
      }
      return false;
    }

    private void exitBtn_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Bạn có chắc muốn hủy thêm SV không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.Close();
      }
    }
  }
}
