using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Data.Migrations
{
    public partial class bookv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "MyBook");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "MyBook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "MyBook");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "MyBook",
                nullable: true);
        }
    }
}
