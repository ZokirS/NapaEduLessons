using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NapaEduLessons1.Models;

namespace NapaEduLessons1.Configurations
{
    internal class PassportConfigurtion : IEntityTypeConfiguration<Passport>
    {
        public void Configure(EntityTypeBuilder<Passport> builder)
        {
            builder.HasData(
                new Passport
                {
                    PassportId = 1,
                    PersonId = 2,
                    FirstName = "John",
                    LastName = "Doe",
                    BirthDate = new DateTime(1980, 1, 1),
                    Series = "AA11111"
                },
                new Passport
                {
                    PassportId = 2,
                    PersonId = 1,
                    FirstName = "Jane",
                    LastName = "Doe",
                    BirthDate = new DateTime(1990, 2, 1),
                    Series = "BB22222"
                });
        }
    }
}
