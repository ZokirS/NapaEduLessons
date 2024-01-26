using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NapaEduLessons1.Models;

namespace NapaEduLessons1.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                new Student
                {
                    StudentID = 1,
                    FirstName = "default",
                    LastName = "default",
                    BirthDate = DateTime.Now.AddDays(-1),
                    Address = "default",
                    City = "default",
                    Course = "default",
                },
                new Student
                {
                    StudentID = 2,
                    FirstName = "default2",
                    LastName = "default2",
                    BirthDate = DateTime.Now.AddDays(-2),
                    Address = "default2",
                    City = "default2",
                    Course = "default2",

                });
        }
    }
}
