using Lab05.BUS;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05.GUI
{
  public partial class frmRegister : Form
  {
    private readonly StudentService studentService = new StudentService();
    private readonly FacultyService facultyService = new FacultyService();
    private readonly MajorService majorService = new MajorService();

    public frmRegister()
    {
      InitializeComponent();
    }

    private void frmRegister_Load(object sender, EventArgs e)
    {
      try
      {
        var listFacultys = facultyService.GetAll();
        FillFalcultyCombobox(listFacultys);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void FillFalcultyCombobox(List<Faculty> listFacultys)
    {
      this.cmbFaculty.DataSource = listFacultys;
      this.cmbFaculty.DisplayMember = "FacultyName";
      this.cmbFaculty.ValueMember = "FacultyID";
    }

    private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
    {
      Faculty selectedFaculty = cmbFaculty.SelectedItem as Faculty;
      if (selectedFaculty != null)
      {
        var listMajors = majorService.GetAllByFaculty(selectedFaculty.FacultyID);
        FillMajorCombobox(listMajors);
      }
    }

    private void FillMajorCombobox(List<Major> listMajors)
    {
      listMajors.Insert(0, new Major());
      this.cmbMajor.DataSource = listMajors;
      this.cmbMajor.DisplayMember = "Name";
      this.cmbMajor.ValueMember = "MajorID";
    }

    private void BindGrid(List<Student> listStudent)
    {
      dgvStudent.Rows.Clear();
      foreach (var item in listStudent)
      {
        int index = dgvStudent.Rows.Add();
        dgvStudent.Rows[index].Cells[1].Value = item.StudentID;
        dgvStudent.Rows[index].Cells[2].Value = item.FullName;
        if (item.Faculty != null)
        {
          dgvStudent.Rows[index].Cells[3].Value = item.Faculty.FacultyName;
        }
        dgvStudent.Rows[index].Cells[4].Value = item.AverageScore + "";
        if (item.Major != null)
        {
          dgvStudent.Rows[index].Cells[5].Value = item.Major.Name + "";
        }
      }
    }
  }
}
