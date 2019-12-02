using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    pmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cardOwnerName = table.Column<string>(type: "varchar(100)", nullable: false),
                    cardNumber = table.Column<string>(type: "varchar(16)", nullable: false),
                    expirationDate = table.Column<string>(type: "varchar(5)", nullable: false),
                    cvv = table.Column<string>(type: "varchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.pmId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentDetails");
        }
    }
}
