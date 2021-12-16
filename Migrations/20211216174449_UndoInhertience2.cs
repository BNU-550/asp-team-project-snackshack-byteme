using Microsoft.EntityFrameworkCore.Migrations;

namespace Snack_Shack.Migrations
{
    public partial class UndoInhertience2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_DrinkSubCategories_DrinkSubCategoriesID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DrinkSubCategoriesID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AlcoholPercentage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ContainsAlcohol",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DrinkBrand",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DrinkCategory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DrinkSubCategoriesID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SubCategory",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    DrinkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrinkCategory = table.Column<int>(type: "int", nullable: false),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContainsAlcohol = table.Column<bool>(type: "bit", nullable: false),
                    AlcoholPercentage = table.Column<double>(type: "float", nullable: false),
                    DrinkBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    DrinkSubCategoriesID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.DrinkID);
                    table.ForeignKey(
                        name: "FK_Drinks_DrinkSubCategories_DrinkSubCategoriesID",
                        column: x => x.DrinkSubCategoriesID,
                        principalTable: "DrinkSubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Drinks_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_DrinkSubCategoriesID",
                table: "Drinks",
                column: "DrinkSubCategoriesID");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_ProductID",
                table: "Drinks",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.AddColumn<double>(
                name: "AlcoholPercentage",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ContainsAlcohol",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DrinkBrand",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DrinkCategory",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DrinkSubCategoriesID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubCategory",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_DrinkSubCategoriesID",
                table: "Products",
                column: "DrinkSubCategoriesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_DrinkSubCategories_DrinkSubCategoriesID",
                table: "Products",
                column: "DrinkSubCategoriesID",
                principalTable: "DrinkSubCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
