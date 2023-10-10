using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
  public class StudentService
  {
    public List<Student> GetAll()
    {
      StudentModel context = new StudentModel();
      return context.Students.ToList();
    }

    public List<Student> GetAllHasNoMajor()
    {
      StudentModel context = new StudentModel();
      return context.Students.Where(s => s.MajorID == null).ToList();
    }

    public List<Student> GetAllHasNoMajor(int facultyID)
    {
      StudentModel context = new StudentModel();
      return context.Students.Where(s => s.MajorID == null && s.FacultyID == facultyID).ToList();
    }

    public Student FindByID(string studentID)
    {
      StudentModel context = new StudentModel();
      return context.Students.FirstOrDefault(s => s.StudentID == studentID);
    }

    public void InsertUpdate(Student s)
    {
      StudentModel context = new StudentModel();
      context.Students.AddOrUpdate(s);
      context.SaveChanges();
    }
  }
}
