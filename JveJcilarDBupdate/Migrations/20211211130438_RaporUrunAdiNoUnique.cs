using Microsoft.EntityFrameworkCore.Migrations;

namespace JveJcilarDBupdate.Migrations
{
    public partial class RaporUrunAdiNoUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Raporlar_UrunAdi",
                table: "Raporlar");

            migrationBuilder.CreateIndex(
                name: "IX_Raporlar_UrunAdi",
                table: "Raporlar",
                column: "UrunAdi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Raporlar_UrunAdi",
                table: "Raporlar");

            migrationBuilder.CreateIndex(
                name: "IX_Raporlar_UrunAdi",
                table: "Raporlar",
                column: "UrunAdi",
                unique: true,
                filter: "[UrunAdi] IS NOT NULL");
        }
    }
}
