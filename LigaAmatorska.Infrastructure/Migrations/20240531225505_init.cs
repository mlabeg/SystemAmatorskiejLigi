using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LigaAmatorska.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mecze",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataGodzina = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idDruzynaA = table.Column<int>(type: "int", nullable: false),
                    idDruzynaB = table.Column<int>(type: "int", nullable: false),
                    wynikA = table.Column<int>(type: "int", nullable: false),
                    wynikB = table.Column<int>(type: "int", nullable: false),
                    idSedzia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecze", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sedziowie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adresEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numerTelefonu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numerLicncji = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedziowie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Statystyki",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    minuty = table.Column<int>(type: "int", nullable: false),
                    rzuty2oddane = table.Column<int>(type: "int", nullable: false),
                    rzuty2celne = table.Column<int>(type: "int", nullable: false),
                    rzuty3oddane = table.Column<int>(type: "int", nullable: false),
                    rzuty3celne = table.Column<int>(type: "int", nullable: false),
                    rzuty1oddane = table.Column<int>(type: "int", nullable: false),
                    rzuty1celne = table.Column<int>(type: "int", nullable: false),
                    zbiorkiOff = table.Column<int>(type: "int", nullable: false),
                    zbiorkiDef = table.Column<int>(type: "int", nullable: false),
                    asysty = table.Column<int>(type: "int", nullable: false),
                    przechwyty = table.Column<int>(type: "int", nullable: false),
                    bloki = table.Column<int>(type: "int", nullable: false),
                    straty = table.Column<int>(type: "int", nullable: false),
                    faule = table.Column<int>(type: "int", nullable: false),
                    plusMinus = table.Column<int>(type: "int", nullable: false),
                    punkty = table.Column<int>(type: "int", nullable: false),
                    eval = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statystyki", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TypyUprawnien",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypyUprawnien", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Uzytkownicy",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adresEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numerTelefonu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idTypuUprawnien = table.Column<int>(type: "int", nullable: false),
                    haslo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzytkownicy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "WynikiDruzynies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wygrane = table.Column<int>(type: "int", nullable: false),
                    Przegrane = table.Column<int>(type: "int", nullable: false),
                    PunktyDuże = table.Column<int>(type: "int", nullable: false),
                    PunktyZdobyte = table.Column<int>(type: "int", nullable: false),
                    PunktyStracone = table.Column<int>(type: "int", nullable: false),
                    MeczeRozegrane = table.Column<int>(type: "int", nullable: false),
                    PunktySrednieZdobyte = table.Column<double>(type: "float", nullable: false),
                    PunktySrednieStracone = table.Column<double>(type: "float", nullable: false),
                    PunktyMaxZdobyte = table.Column<int>(type: "int", nullable: false),
                    PunktyMaxStracone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WynikiDruzynies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zaowdnicy",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numer = table.Column<int>(type: "int", nullable: false),
                    dataUrodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idStatystyk = table.Column<int>(type: "int", nullable: false),
                    idDruzyny = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaowdnicy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Druzyny",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idMenadzer = table.Column<int>(type: "int", nullable: false),
                    wynikiDruzynyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Druzyny", x => x.id);
                    table.ForeignKey(
                        name: "FK_Druzyny_WynikiDruzynies_wynikiDruzynyId",
                        column: x => x.wynikiDruzynyId,
                        principalTable: "WynikiDruzynies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Druzyny_wynikiDruzynyId",
                table: "Druzyny",
                column: "wynikiDruzynyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Druzyny");

            migrationBuilder.DropTable(
                name: "Mecze");

            migrationBuilder.DropTable(
                name: "Sedziowie");

            migrationBuilder.DropTable(
                name: "Statystyki");

            migrationBuilder.DropTable(
                name: "TypyUprawnien");

            migrationBuilder.DropTable(
                name: "Uzytkownicy");

            migrationBuilder.DropTable(
                name: "Zaowdnicy");

            migrationBuilder.DropTable(
                name: "WynikiDruzynies");
        }
    }
}
