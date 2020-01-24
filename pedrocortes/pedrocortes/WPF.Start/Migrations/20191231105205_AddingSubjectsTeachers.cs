using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF.Start.Migrations
{
    public partial class AddingSubjectsTeachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject_Name",
                table: "Entity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_Name",
                table: "Entity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject_Name",
                table: "Entity");

            migrationBuilder.DropColumn(
                name: "Teacher_Name",
                table: "Entity");
        }
    }
}
