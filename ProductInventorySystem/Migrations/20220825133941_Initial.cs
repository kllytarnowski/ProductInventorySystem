using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductInventorySystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Classification = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Shade = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    AvailableQuantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("9808", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
