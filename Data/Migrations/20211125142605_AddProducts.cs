using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Snack_Shack.Data.Migrations
{
    public partial class AddProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentID = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    CardHolderName = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    ExpiryDate = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    CardCVV = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "money", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrinkCategory = table.Column<int>(type: "int", nullable: true),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContainsAlcohol = table.Column<bool>(type: "bit", nullable: true),
                    AlcoholPercentage = table.Column<double>(type: "float", nullable: true),
                    DrinkBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodCategory = table.Column<int>(type: "int", nullable: true),
                    Calories = table.Column<int>(type: "int", maxLength: 4, nullable: true),
                    ContainsNuts = table.Column<bool>(type: "bit", nullable: true),
                    ContainsGluten = table.Column<bool>(type: "bit", nullable: true),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: true),
                    IsVegan = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    TableNo = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentID = table.Column<string>(type: "nvarchar(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_Payment_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payment",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false),
                    Quantity = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.UnitPrice);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItem_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductsProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrderID, x.ProductsProductID });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductsProductID",
                        column: x => x.ProductsProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentID",
                table: "Order",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PersonID",
                table: "Order",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductsProductID",
                table: "OrderProduct",
                column: "ProductsProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
