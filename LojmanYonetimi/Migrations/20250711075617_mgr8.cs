using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojmanYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class mgr8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GorevId",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Gorevs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GorevAd = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GorevKisaAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    Puan = table.Column<int>(type: "int", nullable: false),
                    Ekleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duzenleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuzenlemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Silinmismi = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorevs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_GorevId",
                table: "ApplicationUsers",
                column: "GorevId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Gorevs_GorevId",
                table: "ApplicationUsers",
                column: "GorevId",
                principalTable: "Gorevs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Gorevs_GorevId",
                table: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Gorevs");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_GorevId",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "GorevId",
                table: "ApplicationUsers");
        }
    }
}
