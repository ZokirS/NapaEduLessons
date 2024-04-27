using WebApplicationAPIBasic.Context;
using WebApplicationAPIBasic.Models;
using WebApplicationAPIBasic.Services.Interfaces;

namespace WebApplicationAPIBasic.Services
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;

        public StudentService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public bool AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteStudent(int id)
        {
            var result = _context.Students.Find(id);
            if (result != null)
            {
                _context.Students.Remove(result);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Student GetStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                return student;
            }
            return new Student();
        }

        public ICollection<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public bool UpdateStudent(int id, Student student)
        {
            var result = _context.Students.Find(id);
            if (result != null)
            {
                result.FirstName = student.FirstName;
                result.LastName = student.LastName;
                result.BirthDate = student.BirthDate;
                _context.Students.Update(result);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
