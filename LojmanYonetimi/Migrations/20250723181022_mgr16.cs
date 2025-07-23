using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojmanYonetimi.Migrations
{
    /// <inheritdoc />
    public partial class mgr16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Gorevs_GorevId",
                table: "ApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Unvans_UnvanId",
                table: "ApplicationUsers");

            migrationBuilder.RenameIndex(
                name: "UK_AspNetUsers_KurumSicilNo",
                table: "ApplicationUsers",
                newName: "IX_ApplicationUsers_KurumSicilNo");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_NormalizedEmail",
                table: "ApplicationUsers",
                newName: "EmailIndex");

            migrationBuilder.AlterColumn<string>(
                name: "BirimAd",
                table: "Birims",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<int>(
                name: "UstBirimId",
                table: "Birims",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UnvanId",
                table: "ApplicationUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "MedeniDurum",
                table: "ApplicationUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "KurumSicilNo",
                table: "ApplicationUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<int>(
                name: "GorevId",
                table: "ApplicationUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "TercihEdilenKampus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasvuruId = table.Column<int>(type: "int", maxLength: 500, nullable: false),
                    KampusId = table.Column<int>(type: "int", maxLength: 500, nullable: false),
                    Ekleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duzenleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuzenlemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Silinmismi = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TercihEdilenKampus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TercihEdilenKonuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasvuruId = table.Column<int>(type: "int", maxLength: 500, nullable: false),
                    KonutId = table.Column<int>(type: "int", maxLength: 500, nullable: false),
                    Ekleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duzenleyen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuzenlemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Silinmismi = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TercihEdilenKonuts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Birims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UstBirimId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Birims_UstBirimId",
                table: "Birims",
                column: "UstBirimId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Gorevs_GorevId",
                table: "ApplicationUsers",
                column: "GorevId",
                principalTable: "Gorevs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Unvans_UnvanId",
                table: "ApplicationUsers",
                column: "UnvanId",
                principalTable: "Unvans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Birims_Birims_UstBirimId",
                table: "Birims",
                column: "UstBirimId",
                principalTable: "Birims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Gorevs_GorevId",
                table: "ApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Unvans_UnvanId",
                table: "ApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Birims_Birims_UstBirimId",
                table: "Birims");

            migrationBuilder.DropTable(
                name: "TercihEdilenKampus");

            migrationBuilder.DropTable(
                name: "TercihEdilenKonuts");

            migrationBuilder.DropIndex(
                name: "IX_Birims_UstBirimId",
                table: "Birims");

            migrationBuilder.DropColumn(
                name: "UstBirimId",
                table: "Birims");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUsers_KurumSicilNo",
                table: "ApplicationUsers",
                newName: "UK_AspNetUsers_KurumSicilNo");

            migrationBuilder.RenameIndex(
                name: "EmailIndex",
                table: "ApplicationUsers",
                newName: "IX_AspNetUsers_NormalizedEmail");

            migrationBuilder.AlterColumn<string>(
                name: "BirimAd",
                table: "Birims",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<int>(
                name: "UnvanId",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedeniDurum",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "KurumSicilNo",
                table: "ApplicationUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "GorevId",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Gorevs_GorevId",
                table: "ApplicationUsers",
                column: "GorevId",
                principalTable: "Gorevs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Unvans_UnvanId",
                table: "ApplicationUsers",
                column: "UnvanId",
                principalTable: "Unvans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
