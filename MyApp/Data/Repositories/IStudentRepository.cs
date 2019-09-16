using System.Collections.Generic;
using MyApp.Models;

namespace MyApp.Data.Repositories
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(int id);
        void Save();
        void Edit(Student student);
        void Delete(Student student);
    }
}