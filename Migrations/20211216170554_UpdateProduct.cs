using Microsoft.EntityFrameworkCore.Migrations;

namespace Snack_Shack.Migrations
{
    public partial class UpdateProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductID1",
                table: "Products",
                column: "ProductID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Products_ProductID1",
                table: "Products",
                column: "ProductID1",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ProductID1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductID1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductID1",
                table: "Products");
        }
    }
}
