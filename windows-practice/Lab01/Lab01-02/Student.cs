using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
  internal class Student
  {
    //1. Field 
    private string studentID;
    private string fullName;
    private float averageScore;
    private string faculty;
    
    //2. Property 
    public string StudentID { get => studentID; set => studentID = value; }
    
    public string FullName { get => fullName; set => fullName = value; }
    
    public float AverageScore
    {
      get => averageScore; set => averageScore = value;
    }
    
    public string Faculty { get => faculty; set => faculty = value; }
    
    //3.Constructor 
    public Student() { }
    
    public Student(string studentID, string fullName, float averageScore, string faculty)
    {
      this.studentID = studentID;
      this.fullName = fullName;
      this.averageScore = averageScore;
      this.faculty = faculty;
    }
    
    //4. Methods 
    public void Input()
    {
      Console.Write("Nhap MSSV: ");
      StudentID = Console.ReadLine();
      Console.Write("Nhap Ho ten Sinh vien: ");
      FullName = Console.ReadLine();
      Console.Write("Nhap Điem TB: ");
      AverageScore = float.Parse(Console.ReadLine()); //ép sang kiểu float 
      Console.Write("Nhap Khoa: ");
      Faculty = Console.ReadLine();
    }
    
    public void Show()
    {
      Console.WriteLine("MSSV: {0}, Ho Ten: {1}, Khoa: {2}, ĐiemTB: {3}", this.StudentID, this.fullName, this.Faculty, this.AverageScore);
    }
  }
}
