using Microsoft.EntityFrameworkCore.Migrations;

namespace Snack_Shack.Data.Migrations
{
    public partial class Money : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "People",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "People",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);
        }
    }
}
