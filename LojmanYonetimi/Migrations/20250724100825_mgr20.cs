using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojmanYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class mgr20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KomisyonOnays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonutCikisBasvuruId = table.Column<int>(type: "int", nullable: false),
                    KomisyonUyeId = table.Column<int>(type: "int", nullable: false),
                    OnayDurumu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OnayTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ekleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duzenleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuzenlemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Silinmismi = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KomisyonOnays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KomisyonOnays_ApplicationUsers_KomisyonUyeId",
                        column: x => x.KomisyonUyeId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KomisyonOnays_KonutCikisBasvurus_KonutCikisBasvuruId",
                        column: x => x.KonutCikisBasvuruId,
                        principalTable: "KonutCikisBasvurus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KomisyonOnays_KomisyonUyeId",
                table: "KomisyonOnays",
                column: "KomisyonUyeId");

            migrationBuilder.CreateIndex(
                name: "IX_KomisyonOnays_KonutCikisBasvuruId",
                table: "KomisyonOnays",
                column: "KonutCikisBasvuruId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KomisyonOnays");
        }
    }
}
