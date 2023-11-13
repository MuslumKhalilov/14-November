using System.Runtime.InteropServices;
using _14_November.Models;
using _14_November.Services;

namespace _14_November
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StudentService studentService = new StudentService();

            Student student = new Student
            {
                Name = "Murad",
                Surname = "Ganbarov",
                AvgPoint = 90
            };

            Student student1 = new Student
            {
                Name = "Muslum",
                Surname = "Khalilov",
                AvgPoint = 90
            };


            //studentService.Create(student);

            //studentService.Create(student1);

            //studentService.Delete(2);

            //Student student2 = studentService.GetById(4);
            //Console.WriteLine(student2.Name+" "+student2.Surname+" "+student2.AvgPoint);

            //List<Student> students = studentService.GetAll();
            //foreach (Student student3 in students)
            //{
            //    Console.WriteLine(student3.Name + " " + student3.Surname + " " + student3.AvgPoint);
            //}

        }
    }
}