using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LigaAmatorska.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mecz_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DruzynaAId",
                table: "Mecze",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DruzynaBId",
                table: "Mecze",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mecze_DruzynaAId",
                table: "Mecze",
                column: "DruzynaAId");

            migrationBuilder.CreateIndex(
                name: "IX_Mecze_DruzynaBId",
                table: "Mecze",
                column: "DruzynaBId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mecze_Druzyny_DruzynaAId",
                table: "Mecze",
                column: "DruzynaAId",
                principalTable: "Druzyny",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mecze_Druzyny_DruzynaBId",
                table: "Mecze",
                column: "DruzynaBId",
                principalTable: "Druzyny",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mecze_Druzyny_DruzynaAId",
                table: "Mecze");

            migrationBuilder.DropForeignKey(
                name: "FK_Mecze_Druzyny_DruzynaBId",
                table: "Mecze");

            migrationBuilder.DropIndex(
                name: "IX_Mecze_DruzynaAId",
                table: "Mecze");

            migrationBuilder.DropIndex(
                name: "IX_Mecze_DruzynaBId",
                table: "Mecze");

            migrationBuilder.DropColumn(
                name: "DruzynaAId",
                table: "Mecze");

            migrationBuilder.DropColumn(
                name: "DruzynaBId",
                table: "Mecze");
        }
    }
}
