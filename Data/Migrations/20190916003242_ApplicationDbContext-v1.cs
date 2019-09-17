using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Data.Migrations
{
    public partial class ApplicationDbContextv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "MyBook",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnedDate",
                table: "MyBook",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckedDate",
                table: "MyBook",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "MyBook",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnedDate",
                table: "MyBook",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckedDate",
                table: "MyBook",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
