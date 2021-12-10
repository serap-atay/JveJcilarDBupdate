using Microsoft.EntityFrameworkCore.Migrations;

namespace JveJcilarDBupdate.Migrations
{
    public partial class KafeBilgiBos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Katlar_KafeBilgileri_KafeBilgiId",
                table: "Katlar");

            migrationBuilder.AlterColumn<int>(
                name: "KafeBilgiId",
                table: "Katlar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Katlar_KafeBilgileri_KafeBilgiId",
                table: "Katlar",
                column: "KafeBilgiId",
                principalTable: "KafeBilgileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Katlar_KafeBilgileri_KafeBilgiId",
                table: "Katlar");

            migrationBuilder.AlterColumn<int>(
                name: "KafeBilgiId",
                table: "Katlar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Katlar_KafeBilgileri_KafeBilgiId",
                table: "Katlar",
                column: "KafeBilgiId",
                principalTable: "KafeBilgileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
