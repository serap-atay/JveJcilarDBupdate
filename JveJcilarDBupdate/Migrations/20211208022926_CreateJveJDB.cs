using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JveJcilarDBupdate.Migrations
{
    public partial class CreateJveJDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KafeBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EklenmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KafeBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Fotograf = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    EklenmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Katlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    KafeBilgiId = table.Column<int>(type: "int", nullable: false),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    EklenmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Katlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Katlar_KafeBilgileri_KafeBilgiId",
                        column: x => x.KafeBilgiId,
                        principalTable: "KafeBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Fotograf = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    EklenmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Masalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    MasaDurumu = table.Column<bool>(type: "bit", nullable: false),
                    KatId = table.Column<int>(type: "int", nullable: false),
                    EklenmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Masalar_Katlar_KatId",
                        column: x => x.KatId,
                        principalTable: "Katlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    MasaId = table.Column<int>(type: "int", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    EklenmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => new { x.MasaId, x.UrunId });
                    table.ForeignKey(
                        name: "FK_Siparisler_Masalar_MasaId",
                        column: x => x.MasaId,
                        principalTable: "Masalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siparisler_Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Katlar_KafeBilgiId",
                table: "Katlar",
                column: "KafeBilgiId");

            migrationBuilder.CreateIndex(
                name: "IX_Masalar_KatId",
                table: "Masalar",
                column: "KatId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_UrunId",
                table: "Siparisler",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "Masalar");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Katlar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "KafeBilgileri");
        }
    }
}
