using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ngk3_weather_api.Migrations
{
    public partial class SeedObservationsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 1, new DateTime(2021, 12, 17, 12, 21, 8, 718, DateTimeKind.Unspecified).AddTicks(1648), 35L, 1100.1m, 30.2m, 1 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 18, new DateTime(2021, 12, 18, 11, 39, 18, 279, DateTimeKind.Unspecified).AddTicks(433), 11L, 1011m, -13m, 2 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 17, new DateTime(2021, 12, 18, 11, 44, 5, 325, DateTimeKind.Unspecified).AddTicks(8526), 19L, 1001.2m, -12m, 2 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 16, new DateTime(2021, 12, 18, 12, 21, 8, 718, DateTimeKind.Unspecified).AddTicks(1648), 35L, 1100.1m, -11m, 2 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 15, new DateTime(2021, 12, 16, 11, 39, 18, 279, DateTimeKind.Unspecified).AddTicks(433), 11L, 1011m, -27m, 2 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 14, new DateTime(2021, 12, 16, 11, 44, 5, 325, DateTimeKind.Unspecified).AddTicks(8526), 19L, 1001.2m, -24m, 2 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 13, new DateTime(2021, 12, 16, 12, 21, 8, 718, DateTimeKind.Unspecified).AddTicks(1648), 35L, 1100.1m, -20m, 2 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 12, new DateTime(2021, 12, 17, 11, 39, 18, 279, DateTimeKind.Unspecified).AddTicks(433), 11L, 1011m, -34m, 2 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 10, new DateTime(2021, 12, 17, 12, 21, 8, 718, DateTimeKind.Unspecified).AddTicks(1648), 35L, 1100.1m, -30.2m, 2 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 11, new DateTime(2021, 12, 17, 11, 44, 5, 325, DateTimeKind.Unspecified).AddTicks(8526), 19L, 1001.2m, -31m, 2 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 8, new DateTime(2021, 12, 18, 11, 44, 5, 325, DateTimeKind.Unspecified).AddTicks(8526), 19L, 1001.2m, 12m, 1 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 7, new DateTime(2021, 12, 18, 12, 21, 8, 718, DateTimeKind.Unspecified).AddTicks(1648), 35L, 1100.1m, 11m, 1 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 6, new DateTime(2021, 12, 16, 11, 39, 18, 279, DateTimeKind.Unspecified).AddTicks(433), 11L, 1011m, 27m, 1 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 5, new DateTime(2021, 12, 16, 11, 44, 5, 325, DateTimeKind.Unspecified).AddTicks(8526), 19L, 1001.2m, 24m, 1 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 4, new DateTime(2021, 12, 16, 12, 21, 8, 718, DateTimeKind.Unspecified).AddTicks(1648), 35L, 1100.1m, 20m, 1 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 3, new DateTime(2021, 12, 17, 11, 39, 18, 279, DateTimeKind.Unspecified).AddTicks(433), 11L, 1011m, 34m, 1 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 2, new DateTime(2021, 12, 17, 11, 44, 5, 325, DateTimeKind.Unspecified).AddTicks(8526), 19L, 1001.2m, 31m, 1 });

            migrationBuilder.InsertData(
                table: "WeatherObservations",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Temperature", "WeatherStationId" },
                values: new object[] { 9, new DateTime(2021, 12, 18, 11, 39, 18, 279, DateTimeKind.Unspecified).AddTicks(433), 11L, 1011m, 13m, 1 });

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$I.7FU5SjYL/fXL3Rbh8pnu3kJ3tuEZfx3CLcw47PTcddVnk7O0us.");

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$ZXERkH4BEl904IDO.T5rdO2cggyRBIkkguIeoCh2zgxLDiz24CGB.");

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$YDRRbSpTeuCpUI4iYXSrM.P5EPDk1uC17TVEl.OmD/6nXfI6cedta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WeatherObservations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$XjVT7tArgpNvBI93iIPpGuRHA03v1BQ7VObLETvIcwla8C54OuQP2");

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$tTIcnjGW/6SDxlS8TrOvdeqwRHxDPLXSShyH73YhSZfU.OSPLjA.O");

            migrationBuilder.UpdateData(
                table: "WeatherStations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$bZvszlwPLe7bLQwcUB7W/u7K3SvsqA8wKQikyWxv1dYXnXwZflkfm");
        }
    }
}
