using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojmanYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class mgr6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Konuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BinaId = table.Column<int>(type: "int", nullable: false),
                    OdaTipiId = table.Column<int>(type: "int", nullable: false),
                    KatEnum = table.Column<int>(type: "int", nullable: false),
                    DaireNo = table.Column<int>(type: "int", nullable: false),
                    DaireAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MetreKare = table.Column<int>(type: "int", nullable: false),
                    IsitmaTuruEnum = table.Column<int>(type: "int", nullable: false),
                    DaireTuruEnum = table.Column<int>(type: "int", nullable: false),
                    Esyalimi = table.Column<bool>(type: "bit", nullable: false),
                    KonutDurumEnum = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Ekleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duzenleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuzenlemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Silinmismi = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Konuts_Binas_BinaId",
                        column: x => x.BinaId,
                        principalTable: "Binas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Konuts_OdaTipis_OdaTipiId",
                        column: x => x.OdaTipiId,
                        principalTable: "OdaTipis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Konuts_BinaId",
                table: "Konuts",
                column: "BinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Konuts_OdaTipiId",
                table: "Konuts",
                column: "OdaTipiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Konuts");
        }
    }
}
