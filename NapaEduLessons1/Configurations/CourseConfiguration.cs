using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NapaEduLessons1.Models;

namespace NapaEduLessons1.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(

                new Course
                {
                    CourseId = 1,
                    CourseName = "Math",
                    StartDate = DateTime.Now,
                },
                new Course
                {
                    CourseId = 2,
                    CourseName = "Biology",
                    StartDate = DateTime.Now.AddMonths(-3),
                },
                new Course
                {
                    CourseId= 3,
                    CourseName = "Physics",
                    StartDate= DateTime.Now,
                }
            );
        }
    }
}
