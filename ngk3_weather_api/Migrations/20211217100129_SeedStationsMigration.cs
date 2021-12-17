using Microsoft.EntityFrameworkCore.Migrations;

namespace ngk3_weather_api.Migrations
{
    public partial class SeedStationsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WeatherStations",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "Password", "Username" },
                values: new object[] { 1, 56.234153999999997, 10.238569999999999, "Lystrup", "$2a$11$XjVT7tArgpNvBI93iIPpGuRHA03v1BQ7VObLETvIcwla8C54OuQP2", "lystrup1" });

            migrationBuilder.InsertData(
                table: "WeatherStations",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "Password", "Username" },
                values: new object[] { 2, 45.572113999999999, 6.8293480000000004, "Les Arcs", "$2a$11$tTIcnjGW/6SDxlS8TrOvdeqwRHxDPLXSShyH73YhSZfU.OSPLjA.O", "lesarcs1" });

            migrationBuilder.InsertData(
                table: "WeatherStations",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "Password", "Username" },
                values: new object[] { 3, -53.093660999999997, 73.527350999999996, "Heard Island & McDonald Islands", "$2a$11$bZvszlwPLe7bLQwcUB7W/u7K3SvsqA8wKQikyWxv1dYXnXwZflkfm", "mcd1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
