using Microsoft.EntityFrameworkCore.Migrations;

namespace FreshGroci1.Migrations
{
    public partial class changingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Cart_tbl_Product_ProductModel",
                table: "tbl_Cart");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Cart_ProductModel",
                table: "tbl_Cart");

            migrationBuilder.DropColumn(
                name: "ProductModel",
                table: "tbl_Cart");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "tbl_Cart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "tbl_Cart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "price",
                table: "tbl_Cart",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "tbl_Cart");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "tbl_Cart");

            migrationBuilder.DropColumn(
                name: "price",
                table: "tbl_Cart");

            migrationBuilder.AddColumn<int>(
                name: "ProductModel",
                table: "tbl_Cart",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Cart_ProductModel",
                table: "tbl_Cart",
                column: "ProductModel");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Cart_tbl_Product_ProductModel",
                table: "tbl_Cart",
                column: "ProductModel",
                principalTable: "tbl_Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
