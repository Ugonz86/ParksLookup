using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true),
                    Alerts = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Alerts", "Info", "Name" },
                values: new object[,]
                {
                    { 1, "Rain - 39°F", "39000 State Route 706 E, Ashford, WA 98304", "Mt. Rainier" },
                    { 2, "Rain 40°F - FMultiple Closures Due to Weather", "3002 Mt Angeles Rd, Port Angeles, WA 98362", "Olympic" },
                    { 3, "Rain - 39°F - State Route 20 Closed for the Season", "North Cascades Highway, North Cascades National Park, WA", "North Cascades" },
                    { 4, "Rain - 43°F", "Eastsound, Orcas Island, WA", "Sucia Island" },
                    { 5, "Rain - 40°F", "Whidbey Island", "Ebey's Landing" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
