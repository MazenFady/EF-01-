using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_01_.Migrations
{
    /// <inheritdoc />
    public partial class One2Many : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Departmentins_id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Departmentins_id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Departmentins_id",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "ins_id",
                table: "Departments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepId",
                table: "Students",
                column: "DepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_ins_id",
                table: "Departments",
                column: "ins_id",
                principalTable: "Instructors",
                principalColumn: "DepID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepId",
                table: "Students",
                column: "DepId",
                principalTable: "Departments",
                principalColumn: "ins_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_ins_id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "Departmentins_id",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ins_id",
                table: "Departments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Departmentins_id",
                table: "Students",
                column: "Departmentins_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Departmentins_id",
                table: "Students",
                column: "Departmentins_id",
                principalTable: "Departments",
                principalColumn: "ins_id");
        }
    }
}
