﻿namespace NapaEduLessons1.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
        public List<Student> Students { get; set; }
    }
}
