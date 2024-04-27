using WebApplicationAPIBasic.Models;

namespace WebApplicationAPIBasic.Services.Interfaces
{
    public interface IStudentService
    {
        ICollection<Student> GetStudents();
        Student GetStudent(int id);
        bool AddStudent(Student student);
        bool UpdateStudent(int id, Student student);
        bool DeleteStudent(int id);
    }
}
