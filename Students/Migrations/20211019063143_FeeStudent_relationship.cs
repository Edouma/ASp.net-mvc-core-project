using Microsoft.EntityFrameworkCore.Migrations;

namespace Students.Migrations
{
    public partial class FeeStudent_relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeeId",
                table: "students",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
