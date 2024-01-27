using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NapaEduLessons1.Models;

namespace NapaEduLessons1.Configurations
{
    internal class PeopleConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                new Person
                {
                    PersonId = 1,
                    Age = 43,
                    Name = "Jane",
                },
                new Person
                {
                    PersonId = 2,
                    Age = 33,
                    Name = "John"
                });
        }
    }
}
