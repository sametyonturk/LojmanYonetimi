using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LojmanYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class mgr15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kampus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kampus",
                keyColumn: "Id",
                keyValue: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kampus",
                columns: new[] { "Id", "Aktif", "DuzenlemeTarihi", "Duzenleyen", "EklemeTarihi", "Ekleyen", "KampusAd" },
                values: new object[,]
                {
                    { 2, true, new DateTime(2025, 7, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "system", new DateTime(2025, 7, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "system", "Uzaktan Eğitim Kampüsü" },
                    { 10, true, new DateTime(2025, 7, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "system", new DateTime(2025, 7, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "system", "Merkez Kampüs" }
                });
        }
    }
}
