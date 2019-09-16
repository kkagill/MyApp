using System.Collections.Generic;
using MyApp.Models;

namespace MyApp.Data.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacher(int id);
    }
}