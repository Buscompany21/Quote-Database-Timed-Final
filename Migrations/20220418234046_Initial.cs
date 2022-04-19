using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "quotes",
                columns: table => new
                {
                    QuoteFull = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Citation = table.Column<string>(nullable: true),
                    CitationVar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quotes", x => x.QuoteFull);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quotes");
        }
    }
}
