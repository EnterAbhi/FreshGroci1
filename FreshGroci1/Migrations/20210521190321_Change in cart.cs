using Microsoft.EntityFrameworkCore.Migrations;

namespace FreshGroci1.Migrations
{
    public partial class Changeincart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "tbl_Cart",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "tbl_Cart");
        }
    }
}
