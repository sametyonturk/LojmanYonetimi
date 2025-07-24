using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojmanYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class mgr18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tahsis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonutId = table.Column<int>(type: "int", nullable: false),
                    BasvuruId = table.Column<int>(type: "int", nullable: false),
                    TahsisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamPuan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ekleyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duzenleyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuzenlemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Silinmismi = table.Column<bool>(type: "bit", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tahsis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KonutCikisBasvurus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TahsisId = table.Column<int>(type: "int", nullable: false),
                    GirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BasvuruTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BasvuruId = table.Column<int>(type: "int", nullable: false),
                    CikisBasvuruDurumEnum = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Ekleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duzenleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuzenlemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Silinmismi = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonutCikisBasvurus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KonutCikisBasvurus_Basvurus_BasvuruId",
                        column: x => x.BasvuruId,
                        principalTable: "Basvurus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KonutCikisBasvurus_Tahsis_TahsisId",
                        column: x => x.TahsisId,
                        principalTable: "Tahsis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KonutCikisBasvurus_BasvuruId",
                table: "KonutCikisBasvurus",
                column: "BasvuruId");

            migrationBuilder.CreateIndex(
                name: "IX_KonutCikisBasvurus_TahsisId",
                table: "KonutCikisBasvurus",
                column: "TahsisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KonutCikisBasvurus");

            migrationBuilder.DropTable(
                name: "Tahsis");
        }
    }
}
