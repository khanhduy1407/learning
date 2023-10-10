using Lab05.BUS;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05.GUI
{
  public partial class Form1 : Form
  {
    private readonly StudentService studentService = new StudentService();
    private readonly FacultyService facultyService = new FacultyService();

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        setGridViewStyle(dgvStudent);
        var listFacultys = facultyService.GetAll();
        var listStudents = studentService.GetAll();
        FillFalcultyCombobox(listFacultys);
        BindGrid(listStudents);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    //Hàm binding list dữ liệu khoa vào combobox có tên hiện thị là tên khoa, giá trị là Mã khoa
    private void FillFalcultyCombobox(List<Faculty> listFacultys)
    {
      listFacultys.Insert(0, new Faculty());
      this.cmbFaculty.DataSource = listFacultys;
      this.cmbFaculty.DisplayMember = "FacultyName";
      this.cmbFaculty.ValueMember = "FacultyID";
    }

    //Hàm binding gridView từ list sinh viên 
    private void BindGrid(List<Student> listStudent)
    {
      dgvStudent.Rows.Clear();
      foreach (var item in listStudent)
      {
        int index = dgvStudent.Rows.Add();
        dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
        dgvStudent.Rows[index].Cells[1].Value = item.FullName;
        if (item.Faculty != null)
        {
          dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
        }
        dgvStudent.Rows[index].Cells[3].Value = item.AverageScore + "";
        if (item.MajorID != null)
        {
          dgvStudent.Rows[index].Cells[4].Value = item.Major.Name + "";
        }
        ShowAvatar(item.Avatar);
      }
    }

    private void ShowAvatar(string ImageName)
    {
      if (string.IsNullOrEmpty(ImageName))
      {
        picAvatar.Image = null;
      }
      else
      {
        string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
        string imagePath = Path.Combine(parentDirectory, "Images", ImageName);
        picAvatar.Image = Image.FromFile(imagePath);
        picAvatar.Refresh();
      }
    }

    public void setGridViewStyle(DataGridView dgview)
    {
      dgview.BorderStyle = BorderStyle.None;
      dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
      dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      dgview.BackgroundColor = Color.White;
      dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }

    private void chkUnregisterMajor_CheckedChanged(object sender, EventArgs e)
    {
      var listStudents = new List<Student>();
      if (this.chkUnregisterMajor.Checked)
      {
        listStudents = studentService.GetAllHasNoMajor();
      }
      else
      {
        listStudents = studentService.GetAll();
      }
      BindGrid(listStudents);
    }

    private void đăngKýChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmRegister frmRegister = new frmRegister();
      frmRegister.Show();
    }
  }
}
