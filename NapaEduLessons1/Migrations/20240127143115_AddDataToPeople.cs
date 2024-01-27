using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NapaEduLessons1.Migrations
{
    public partial class AddDataToPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 43, "Jane" },
                    { 2, 33, "John" }
                });

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

            migrationBuilder.InsertData(
                table: "Passport",
                columns: new[] { "PassportId", "BirthDate", "FirstName", "LastName", "PersonId", "Series" },
                values: new object[] { 1, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", 2, "AA11111" });

            migrationBuilder.InsertData(
                table: "Passport",
                columns: new[] { "PassportId", "BirthDate", "FirstName", "LastName", "PersonId", "Series" },
                values: new object[] { 2, new DateTime(1990, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Doe", 1, "BB22222" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Passport",
                keyColumn: "PassportId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passport",
                keyColumn: "PassportId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 1, 26, 19, 18, 59, 54, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 1, 25, 19, 18, 59, 54, DateTimeKind.Local).AddTicks(9621));
        }
    }
}
