using System.ComponentModel.DataAnnotations;

namespace NapaEduLessons1.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Course> Courses { get; set; }
    }
}
