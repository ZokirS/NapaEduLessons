using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NapaEduLessons1.Migrations
{
    public partial class StudentsCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Course",
                table: "Students");

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesCourseId = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesCourseId, x.StudentsStudentID });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Course_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsStudentID",
                        column: x => x.StudentsStudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsStudentID",
                table: "CourseStudent",
                column: "StudentsStudentID");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Course",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1,
                columns: new[] { "Address", "BirthDate", "City", "Course" },
                values: new object[] { "default", new DateTime(2024, 1, 26, 19, 58, 18, 853, DateTimeKind.Local).AddTicks(9901), "default", "default" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2,
                columns: new[] { "Address", "BirthDate", "City", "Course" },
                values: new object[] { "default2", new DateTime(2024, 1, 25, 19, 58, 18, 853, DateTimeKind.Local).AddTicks(9913), "default2", "default2" });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 1,
                column: "ManufacturedDate",
                value: new DateTime(2023, 1, 27, 19, 58, 18, 854, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 2,
                column: "ManufacturedDate",
                value: new DateTime(2014, 1, 27, 19, 58, 18, 854, DateTimeKind.Local).AddTicks(185));
        }
    }
}
