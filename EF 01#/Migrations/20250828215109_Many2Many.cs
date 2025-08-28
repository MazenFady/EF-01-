using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_01_.Migrations
{
    /// <inheritdoc />
    public partial class Many2Many : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ins_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ins_id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    DepID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VarChar(20)", unicode: false, maxLength: 20, nullable: false),
                    Bouns = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Address = table.Column<string>(type: "NVarChar(100)", maxLength: 100, nullable: false),
                    HourRate = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Departmentins_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.DepID);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_Departmentins_id",
                        column: x => x.Departmentins_id,
                        principalTable: "Departments",
                        principalColumn: "ins_id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    LName = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "NVarChar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    DepId = table.Column<int>(type: "int", nullable: true),
                    Departmentins_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Departments_Departmentins_id",
                        column: x => x.Departmentins_id,
                        principalTable: "Departments",
                        principalColumn: "ins_id");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    TopID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VarChar(20)", unicode: false, maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "NVarChar(100)", maxLength: 100, nullable: false),
                    TopicID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.TopID);
                    table.ForeignKey(
                        name: "FK_Courses_Topics_TopicID",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Course_Insts",
                columns: table => new
                {
                    inst_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    courseTopID = table.Column<int>(type: "int", nullable: true),
                    instructorDepID = table.Column<int>(type: "int", nullable: true),
                    evaluate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Insts", x => new { x.inst_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_Course_Insts_Courses_courseTopID",
                        column: x => x.courseTopID,
                        principalTable: "Courses",
                        principalColumn: "TopID");
                    table.ForeignKey(
                        name: "FK_Course_Insts_Instructors_instructorDepID",
                        column: x => x.instructorDepID,
                        principalTable: "Instructors",
                        principalColumn: "DepID");
                });

            migrationBuilder.CreateTable(
                name: "Stud_Courses",
                columns: table => new
                {
                    stud_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: true),
                    courseTopID = table.Column<int>(type: "int", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Courses", x => new { x.stud_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_Stud_Courses_Courses_courseTopID",
                        column: x => x.courseTopID,
                        principalTable: "Courses",
                        principalColumn: "TopID");
                    table.ForeignKey(
                        name: "FK_Stud_Courses_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_courseTopID",
                table: "Course_Insts",
                column: "courseTopID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_instructorDepID",
                table: "Course_Insts",
                column: "instructorDepID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicID",
                table: "Courses",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Departmentins_id",
                table: "Instructors",
                column: "Departmentins_id");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_courseTopID",
                table: "Stud_Courses",
                column: "courseTopID");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_studentId",
                table: "Stud_Courses",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Departmentins_id",
                table: "Students",
                column: "Departmentins_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Insts");

            migrationBuilder.DropTable(
                name: "Stud_Courses");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
