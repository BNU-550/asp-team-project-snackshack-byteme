using Microsoft.EntityFrameworkCore.Migrations;

namespace Snack_Shack.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IsMinor = table.Column<bool>(type: "bit", nullable: false),
                    IsCustomer = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
