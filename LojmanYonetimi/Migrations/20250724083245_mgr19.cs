using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojmanYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class mgr19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CikisEksikKaydis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonutCikisBasvuruId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Giderildimi = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EkleenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GiderilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GeriBildirim = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Ekleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duzenleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuzenlemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Silinmismi = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CikisEksikKaydis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CikisEksikKaydis_KonutCikisBasvurus_KonutCikisBasvuruId",
                        column: x => x.KonutCikisBasvuruId,
                        principalTable: "KonutCikisBasvurus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CikisEksikKaydis_KonutCikisBasvuruId",
                table: "CikisEksikKaydis",
                column: "KonutCikisBasvuruId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CikisEksikKaydis");
        }
    }
}
