using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);
        }
    }
}
