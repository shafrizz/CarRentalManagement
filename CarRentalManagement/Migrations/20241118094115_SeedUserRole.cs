using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e11c4bb4-97d9-4fca-b4d5-14192c5fe4d8", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOTKU5oihPd6NZ3m5ouYzUkZJ1r4EUNmrPHGknqIKBYTFgwHRodr4m71UzIAcYX6qg==", null, false, "67b64fdc-de0e-485a-baea-8b0972bd6c2a", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5620), new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5821), new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5824), new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5927), new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5930), new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5931), new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5933), new DateTime(2024, 11, 18, 17, 41, 15, 357, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9248), new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9262), new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9479), new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9482), new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9597), new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9600), new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9602), new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9604), new DateTime(2024, 11, 18, 17, 15, 29, 273, DateTimeKind.Local).AddTicks(9605) });
        }
    }
}
