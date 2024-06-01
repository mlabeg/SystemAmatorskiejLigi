using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LigaAmatorska.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class akualnosci : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Druzyny_WynikiDruzynies_IdWynikowDruzyny",
                table: "Druzyny");

            migrationBuilder.RenameColumn(
                name: "wynikB",
                table: "Mecze",
                newName: "WynikB");

            migrationBuilder.RenameColumn(
                name: "wynikA",
                table: "Mecze",
                newName: "WynikA");

            migrationBuilder.RenameColumn(
                name: "idSedzia",
                table: "Mecze",
                newName: "IdSedzia");

            migrationBuilder.RenameColumn(
                name: "idDruzynaB",
                table: "Mecze",
                newName: "IdDruzynaB");

            migrationBuilder.RenameColumn(
                name: "idDruzynaA",
                table: "Mecze",
                newName: "IdDruzynaA");

            migrationBuilder.RenameColumn(
                name: "dataGodzina",
                table: "Mecze",
                newName: "DataGodzina");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Mecze",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "IdSedzia",
                table: "Mecze",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdWynikowDruzyny",
                table: "Druzyny",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Aktualnoscis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tresc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDodania = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktualnoscis", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Druzyny_WynikiDruzynies_IdWynikowDruzyny",
                table: "Druzyny",
                column: "IdWynikowDruzyny",
                principalTable: "WynikiDruzynies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Druzyny_WynikiDruzynies_IdWynikowDruzyny",
                table: "Druzyny");

            migrationBuilder.DropTable(
                name: "Aktualnoscis");

            migrationBuilder.RenameColumn(
                name: "WynikB",
                table: "Mecze",
                newName: "wynikB");

            migrationBuilder.RenameColumn(
                name: "WynikA",
                table: "Mecze",
                newName: "wynikA");

            migrationBuilder.RenameColumn(
                name: "IdSedzia",
                table: "Mecze",
                newName: "idSedzia");

            migrationBuilder.RenameColumn(
                name: "IdDruzynaB",
                table: "Mecze",
                newName: "idDruzynaB");

            migrationBuilder.RenameColumn(
                name: "IdDruzynaA",
                table: "Mecze",
                newName: "idDruzynaA");

            migrationBuilder.RenameColumn(
                name: "DataGodzina",
                table: "Mecze",
                newName: "dataGodzina");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Mecze",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "idSedzia",
                table: "Mecze",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdWynikowDruzyny",
                table: "Druzyny",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Druzyny_WynikiDruzynies_IdWynikowDruzyny",
                table: "Druzyny",
                column: "IdWynikowDruzyny",
                principalTable: "WynikiDruzynies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
