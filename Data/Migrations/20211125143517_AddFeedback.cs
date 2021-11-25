using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Snack_Shack.Data.Migrations
{
    public partial class AddFeedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedbackID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    FeedbackMessage = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CustomerReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedbackID);
                    table.ForeignKey(
                        name: "FK_Feedback_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_OrderID",
                table: "Feedback",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");
        }
    }
}
