using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojmanYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class mgr11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PuanKuralis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SabitPuan = table.Column<decimal>(type: "decimal(18,2)", maxLength: 500, nullable: false),
                    KisiBasiKatSayisi = table.Column<decimal>(type: "decimal(18,2)", maxLength: 500, nullable: false),
                    YilKatSayi = table.Column<decimal>(type: "decimal(18,2)", maxLength: 500, nullable: false),
                    AylKatSayi = table.Column<decimal>(type: "decimal(18,2)", maxLength: 500, nullable: false),
                    AkademikTesvikPuan = table.Column<decimal>(type: "decimal(18,2)", maxLength: 500, nullable: false),
                    MaksimumPuan = table.Column<decimal>(type: "decimal(18,2)", maxLength: 500, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ekleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duzenleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuzenlemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Silinmismi = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuanKuralis", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PuanKuralis");
        }
    }
}
