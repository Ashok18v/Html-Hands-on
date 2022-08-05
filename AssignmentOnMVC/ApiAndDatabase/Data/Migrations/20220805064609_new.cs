using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAndDatabase.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zoner = table.Column<string>(type: "Varchar(20)", nullable: false),
                    Release_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cost = table.Column<string>(type: "Varchar(8)", nullable: false),
                    Image = table.Column<string>(type: "Varchar(Max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");
        }
    }
}
