using Microsoft.EntityFrameworkCore.Migrations;

namespace Students.Migrations
{
    public partial class ammend_Relationship_Student_Fee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_Fees_FeeId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_FeeId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "FeeId",
                table: "students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Fees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fees_StudentId",
                table: "Fees",
                column: "StudentId",
                unique: true,
                filter: "[StudentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Fees_students_StudentId",
                table: "Fees",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "studentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fees_students_StudentId",
                table: "Fees");

            migrationBuilder.DropIndex(
                name: "IX_Fees_StudentId",
                table: "Fees");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Fees");

            migrationBuilder.AddColumn<int>(
                name: "FeeId",
                table: "students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_FeeId",
                table: "students",
                column: "FeeId",
                unique: true,
                filter: "[FeeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_students_Fees_FeeId",
                table: "students",
                column: "FeeId",
                principalTable: "Fees",
                principalColumn: "FeeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
