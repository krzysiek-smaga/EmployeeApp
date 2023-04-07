using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "HireDate", "ManagerId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 8, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4312), null, "CEO" },
                    { 2, new DateTime(2023, 3, 10, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4369), 1, "Director One" },
                    { 3, new DateTime(2023, 3, 12, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4371), 1, "Director Two" },
                    { 4, new DateTime(2023, 3, 14, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4374), 2, "Manager One" },
                    { 5, new DateTime(2023, 3, 16, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4376), 2, "Manager Two" },
                    { 6, new DateTime(2023, 3, 18, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4379), 3, "Manager Three" },
                    { 7, new DateTime(2023, 3, 20, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4381), 4, "Regular Employee One" },
                    { 8, new DateTime(2023, 3, 23, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4383), 4, "Regular Employee Two" },
                    { 9, new DateTime(2023, 3, 26, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4386), 4, "Regular Employee Three" },
                    { 10, new DateTime(2023, 3, 29, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4388), 5, "Regular Employee Four" },
                    { 11, new DateTime(2023, 4, 1, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4390), 5, "Regular Employee Five" },
                    { 12, new DateTime(2023, 4, 4, 16, 23, 53, 657, DateTimeKind.Local).AddTicks(4393), 6, "Regular Employee Six" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
