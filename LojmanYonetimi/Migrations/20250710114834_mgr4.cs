using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojmanYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class mgr4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Binas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KampusId = table.Column<int>(type: "int", nullable: false),
                    BinaAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BinaNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AsansorVarmi = table.Column<bool>(type: "bit", nullable: false),
                    CatiVarmi = table.Column<bool>(type: "bit", nullable: false),
                    OtoparkVarmi = table.Column<bool>(type: "bit", nullable: false),
                    EngelliGirisiVarmi = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Binas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Binas_Kampus_KampusId",
                        column: x => x.KampusId,
                        principalTable: "Kampus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Binas_KampusId",
                table: "Binas",
                column: "KampusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Binas");
        }
    }
}
