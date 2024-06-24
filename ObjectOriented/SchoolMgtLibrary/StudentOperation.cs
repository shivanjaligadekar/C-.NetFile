using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace SchoolMgtLibrary;

public class StudentOperation
{
    static List<Student> studentList = new List<Student>();

    static StudentOperation()
    {
        studentList.Add(new Student(1, "mahi","pune"));
        studentList.Add(new Student(2, "ruhi", "mumbai"));
        studentList.Add(new Student(3, "juhi", "nashik"));
    }
    public void AddStudent(Student student)
    {
        //Student s=new Student(rno:student.RollNo);
        Student s=new Student();
        s.RollNo = student.RollNo;
        s.City = student.City;
        s.StudentName = student.StudentName;
        studentList.Append(s);

    }
    public void UpdateStudent(Student student)
    { 

    }
    public void DeleteStudent(Student student) 
    {

    }
    public List<Student> Getstudents()
    {
        return studentList;
    }
    }
