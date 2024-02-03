using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NapaEduLessons1.Migrations
{
    public partial class CourseConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "CourseName", "StartDate" },
                values: new object[,]
                {
                    { 1, "Math", new DateTime(2024, 1, 30, 19, 52, 42, 31, DateTimeKind.Local).AddTicks(7559) },
                    { 2, "Biology", new DateTime(2023, 10, 30, 19, 52, 42, 31, DateTimeKind.Local).AddTicks(7561) },
                    { 3, "Physics", new DateTime(2024, 1, 30, 19, 52, 42, 31, DateTimeKind.Local).AddTicks(7562) }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 1, 29, 19, 52, 42, 31, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 1, 28, 19, 52, 42, 31, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 1,
                column: "ManufacturedDate",
                value: new DateTime(2023, 1, 30, 19, 52, 42, 31, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 2,
                column: "ManufacturedDate",
                value: new DateTime(2014, 1, 30, 19, 52, 42, 31, DateTimeKind.Local).AddTicks(7479));
        
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 1, 29, 19, 16, 6, 380, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 1, 28, 19, 16, 6, 380, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 1,
                column: "ManufacturedDate",
                value: new DateTime(2023, 1, 30, 19, 16, 6, 380, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 2,
                column: "ManufacturedDate",
                value: new DateTime(2014, 1, 30, 19, 16, 6, 380, DateTimeKind.Local).AddTicks(4017));
        }
    }
}
