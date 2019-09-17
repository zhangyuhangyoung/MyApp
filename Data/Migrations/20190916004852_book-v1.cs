using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Data.Migrations
{
    public partial class bookv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "MyBook",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "MyBook",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
