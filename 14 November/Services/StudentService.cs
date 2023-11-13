using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14_November.DAL;
using _14_November.Models;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace _14_November.Services
{
    internal class StudentService
    {
        static AppDbContext _context = new AppDbContext();

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        //FirstOrDefault ile olan versiya
        public Student GetById(int id)
        {
            Student student = _context.Students.FirstOrDefault(s => s.Id == id);
            return student;
        }
        //Find ile olan versiya
        public Student GetById1(int id)
        {
            Student student = _context.Students.Find(id);
            return student;
        }

        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Student StudentWeWantToRemove = GetById(id);
            if (StudentWeWantToRemove != null)
            {
                _context.Students.Remove(StudentWeWantToRemove);
            }
            _context.SaveChanges();

        }


    }
}
