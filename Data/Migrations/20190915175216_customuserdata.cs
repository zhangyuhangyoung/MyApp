using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Data.Migrations
{
    public partial class customuserdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyBook",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    Author = table.Column<string>(maxLength: 60, nullable: false),
                    PublishedDate = table.Column<DateTime>(nullable: false),
                    Summary = table.Column<string>(maxLength: 600, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Status = table.Column<string>(nullable: false),
                    CheckedDate = table.Column<DateTime>(nullable: false),
                    ReturnedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyBook", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyBook");
        }
    }
}
