using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NapaEduLessons1.Migrations
{
    public partial class VehiclesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufacturedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicle_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 1, 26, 19, 58, 18, 853, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 1, 25, 19, 58, 18, 853, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "VehicleId", "BrandName", "ManufacturedDate", "Mileage", "Model", "PersonId" },
                values: new object[,]
                {
                    { 1, "BMW", new DateTime(2023, 1, 27, 19, 58, 18, 854, DateTimeKind.Local).AddTicks(182), 100, "M3", 1 },
                    { 2, "Audi", new DateTime(2014, 1, 27, 19, 58, 18, 854, DateTimeKind.Local).AddTicks(185), 40000, "A6", 1 },
                    { 3, "Chevrolet", new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Camaro", 2 },
                    { 4, "Tesla", new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 180, "Model S", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_PersonId",
                table: "Vehicle",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 1, 26, 19, 31, 14, 835, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 1, 25, 19, 31, 14, 835, DateTimeKind.Local).AddTicks(4621));
        }
    }
}
