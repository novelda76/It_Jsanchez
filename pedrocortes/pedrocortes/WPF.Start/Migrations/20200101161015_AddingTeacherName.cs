using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF.Start.Migrations
{
    public partial class AddingTeacherName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeacherName",
                table: "Entity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeacherName",
                table: "Entity");
        }
    }
}
