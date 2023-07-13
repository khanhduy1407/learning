using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<Student> studentList = new List<Student>();
      
      bool exit = false;
      
      while (!exit)
      {
        Console.WriteLine("=== MENU ===");
        Console.WriteLine("1. Them sinh vien");
        Console.WriteLine("2. Hien thi danh sach sinh vien");
        Console.WriteLine("3. Hien thi danh sach sinh vien thuoc khoa CNTT");
        Console.WriteLine("4. Hien thi danh sach sinh vien co diem TB >= 5");
        Console.WriteLine("5. Hien thi danh sach sinh vien duoc sap xep theo diem TB tang dan");
        Console.WriteLine("6. Hien thi danh sach sinh vien thuoc khoa CNTT va co diem TB >= 5");
        Console.WriteLine("7. Hien thi sinh vien co diem TB cao nhat thuoc khoa CNTT");
        Console.WriteLine("8. Hien thi so luong cua tung xep loai trong danh sach");
        Console.WriteLine("0. Thoat");
        Console.Write("Chon chuc nang (0-2): ");
       
        string choice = Console.ReadLine();
        
        switch (choice)
        {
          case "1":
            AddStudent(studentList);
            break;
          case "2":
            DisplayStudentList(studentList);
            break;
          case "3":
            DisplayStudentsByFaculty(studentList, "CNTT");
            break;
          case "4":
            DisplayStudentsWithHighAverageScore(studentList, 5);
            break;
          case "5":
            SortStudentsByAverageScore(studentList);
            break;
          case "6":
            DisplayStudentsByFacultyAndScore(studentList, "CNTT", 5);
            break;
          case "7":
            DisplayStudentsWithHighestAverageScoreByFaculty(studentList, "CNTT");
            break;
          case "8":
            DisplayStudentsByScore(studentList);
            break;
          case "0":
            exit = true;
            Console.WriteLine("Ket thuc chuong trinh.");
            break;
          default:
            Console.WriteLine("Tuy chon khong hop le. Vui long chon lai.");
            break;
        }
        
        Console.WriteLine();
      }
    }

    static void AddStudent(List<Student> studentList)
    {
      Console.WriteLine("\n=== Nhap thong tin sinh vien ===");
      Student student = new Student();
      student.Input();
      studentList.Add(student);
      Console.WriteLine("Them sinh vien thanh cong!");
    }
    
    static void DisplayStudentList(List<Student> studentList)
    {
      Console.WriteLine("\n=== Danh sach chi tiet thong tin sinh vien ===");
      
      foreach (Student student in studentList)
      {
        student.Show();
      }
    }

    //case 3: DS Sinh viên khoa CNTT
    static void DisplayStudentsByFaculty(List<Student> studentList, string faculty)
    {
      Console.WriteLine("\n=== Danh sach sinh vien thuoc khoa {0}", faculty);
      var students = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
      DisplayStudentList(students);
    }
    
    //case 4: Xuất ra thông tin sinh viên có điểm TB lớn hơn bằng 5.
    static void DisplayStudentsWithHighAverageScore(List<Student> studentList, float minDTB)
    {
      Console.WriteLine("\n=== Danh sach sinh vien có diem TB >= {0}", minDTB);
      var students = studentList.Where(s => s.AverageScore >= minDTB).ToList();
      DisplayStudentList(students);
    }
    
    //case 5: Xuất ra danh sách sinh viên được sắp xếp theo điểm trung bình tăng dần
    static void SortStudentsByAverageScore(List<Student> studentList)
    {
      Console.WriteLine("\n=== Danh sach sinh vien duoc sap xep theo diem trung binh tang dan === ");
     
      var sortedStudents = studentList.OrderBy(s => s.AverageScore).ToList();
      DisplayStudentList(sortedStudents);
    }
    
    //case 6: DS sinh vien co DTB >=5 va thuoc khoa CNTT
    static void DisplayStudentsByFacultyAndScore(List<Student> studentList, string faculty, float minDTB)
    {
      Console.WriteLine("\n=== Danh sach sinh vien co diem TB >= {0} va thuoc khoa {1}", minDTB, faculty);
      var students = studentList.Where(s => s.AverageScore >= minDTB && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
      DisplayStudentList(students);
    }

    //case 7: Xuất ra danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa "CNTT"
    static void DisplayStudentsWithHighestAverageScoreByFaculty(List<Student> studentList, string faculty)
    {
      Console.WriteLine("\n=== Danh sach sinh vien co diem trung binh cao nhat va thuoc khoa {0}", faculty);
      var students = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
      var maxDTB = students.Max(s => s.AverageScore);
      var studentsWithMaxDTB = students.Where(s => s.AverageScore == maxDTB).ToList();
      DisplayStudentList(studentsWithMaxDTB);
    }

    //case 8: Hãy cho biết số lượng của từng xếp loại trong danh sách? Biết rằng theo thang điểm 10
    // Từ 9,0 đến 10,0: Xuất sắc; Từ 8,0 đến cận 9,0: Giỏi; Từ 7,0 đến cận 8,0: Khá;
    // Từ 5,0 đến cận 7,0: Trung bình; Từ 4,0 đến cận 5,0: Yếu; Dưới 4,0: Kém.
    static void DisplayStudentsByScore(List<Student> studentList)
    {
      Console.WriteLine("\n=== Danh sach sinh vien theo xep loai ===");
      var students = studentList.OrderBy(s => s.AverageScore).ToList();
      var xuatSac = students.Where(s => s.AverageScore >= 9).ToList();
      var gioi = students.Where(s => s.AverageScore >= 8 && s.AverageScore < 9).ToList();
      var kha = students.Where(s => s.AverageScore >= 7 && s.AverageScore < 8).ToList();
      var trungBinh = students.Where(s => s.AverageScore >= 5 && s.AverageScore < 7).ToList();
      var yeu = students.Where(s => s.AverageScore >= 4 && s.AverageScore < 5).ToList();
      var kem = students.Where(s => s.AverageScore < 4).ToList();
      Console.WriteLine("Xuat sac: {0}", xuatSac.Count);
      Console.WriteLine("Gioi: {0}", gioi.Count);
      Console.WriteLine("Kha: {0}", kha.Count);
      Console.WriteLine("Trung binh: {0}", trungBinh.Count);
      Console.WriteLine("Yeu: {0}", yeu.Count);
      Console.WriteLine("Kem: {0}", kem.Count);
    }
  }
}
