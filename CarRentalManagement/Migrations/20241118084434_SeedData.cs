using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(6906), new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(6923), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(6925), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7115), new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7116), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7117), new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7117), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7180), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7182), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7184), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 11, 18, 16, 44, 33, 794, DateTimeKind.Local).AddTicks(7185), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
