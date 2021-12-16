using Microsoft.EntityFrameworkCore.Migrations;

namespace Snack_Shack.Migrations
{
    public partial class UnDoInheritence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Products_ProductID1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductID1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ContainsGluten",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ContainsNuts",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FoodCategory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsVegan",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsVegetarian",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductID1",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodCategory = table.Column<int>(type: "int", nullable: false),
                    Calories = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    ContainsNuts = table.Column<bool>(type: "bit", nullable: false),
                    ContainsGluten = table.Column<bool>(type: "bit", nullable: false),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: false),
                    IsVegan = table.Column<bool>(type: "bit", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Food_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_ProductID",
                table: "Food",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "Products",
                type: "int",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ContainsGluten",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ContainsNuts",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FoodCategory",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVegan",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVegetarian",
                table: "Products",
                type: "bit",
                nullable: true);

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
    }
}
