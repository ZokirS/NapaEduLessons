using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NapaEduLessons1.Models;

namespace NapaEduLessons1.Configurations
{
    internal class VehiclesConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                new Vehicle
                {
                    VehicleId = 1,
                    PersonId = 1,
                    BrandName = "BMW",
                    Model = "M3",
                    ManufacturedDate = DateTime.Now.AddYears(-1),
                    Mileage = 100,
                },
                new Vehicle
                {
                    VehicleId = 2,
                    PersonId = 1,
                    BrandName = "Audi",
                    Model = "A6",
                    ManufacturedDate = DateTime.Now.AddYears(-10),
                    Mileage = 40000,
                },
                new Vehicle
                {
                    VehicleId = 3,
                    PersonId = 2,
                    BrandName = "Chevrolet",
                    Model = "Camaro",
                    ManufacturedDate = new DateTime(2020, 12, 25),
                    Mileage = 100,
                },
                new Vehicle
                {
                    VehicleId = 4,
                    PersonId = 2,
                    BrandName = "Tesla",
                    Model = "Model S",
                    ManufacturedDate = new DateTime(2023, 6, 7),
                    Mileage = 180,
                });
        }
    }
}
