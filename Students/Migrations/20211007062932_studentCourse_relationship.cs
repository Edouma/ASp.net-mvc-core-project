using Microsoft.EntityFrameworkCore.Migrations;

namespace Students.Migrations
{
    public partial class studentCourse_relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Course1Id",
                table: "students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_Course1Id",
                table: "students",
                column: "Course1Id");

            migrationBuilder.AddForeignKey(
                name: "FK_students_courses_Course1Id",
                table: "students",
                column: "Course1Id",
                principalTable: "courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_courses_Course1Id",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_Course1Id",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Course1Id",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "students");
        }
    }
}
