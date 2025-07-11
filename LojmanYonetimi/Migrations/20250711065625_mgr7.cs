using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojmanYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class mgr7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnvanId",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Unvans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnvanAd = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnvanKisaAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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
                    table.PrimaryKey("PK_Unvans", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_UnvanId",
                table: "ApplicationUsers",
                column: "UnvanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Unvans_UnvanId",
                table: "ApplicationUsers",
                column: "UnvanId",
                principalTable: "Unvans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Unvans_UnvanId",
                table: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Unvans");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_UnvanId",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "UnvanId",
                table: "ApplicationUsers");
        }
    }
}
