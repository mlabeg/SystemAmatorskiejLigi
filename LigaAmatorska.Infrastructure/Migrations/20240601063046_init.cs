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
                    minuty = table.Column<int>(type: "int", nullable: true),
                    rzuty2oddane = table.Column<int>(type: "int", nullable: true),
                    rzuty2celne = table.Column<int>(type: "int", nullable: true),
                    rzuty3oddane = table.Column<int>(type: "int", nullable: true),
                    rzuty3celne = table.Column<int>(type: "int", nullable: true),
                    rzuty1oddane = table.Column<int>(type: "int", nullable: true),
                    rzuty1celne = table.Column<int>(type: "int", nullable: true),
                    zbiorkiOff = table.Column<int>(type: "int", nullable: true),
                    zbiorkiDef = table.Column<int>(type: "int", nullable: true),
                    asysty = table.Column<int>(type: "int", nullable: true),
                    przechwyty = table.Column<int>(type: "int", nullable: true),
                    bloki = table.Column<int>(type: "int", nullable: true),
                    straty = table.Column<int>(type: "int", nullable: true),
                    faule = table.Column<int>(type: "int", nullable: true),
                    plusMinus = table.Column<int>(type: "int", nullable: true),
                    punkty = table.Column<int>(type: "int", nullable: true),
                    eval = table.Column<int>(type: "int", nullable: true)
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
                    idTypuUprawnien = table.Column<int>(type: "int", nullable: true),
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
                    Wygrane = table.Column<int>(type: "int", nullable: true),
                    Przegrane = table.Column<int>(type: "int", nullable: true),
                    PunktyDuże = table.Column<int>(type: "int", nullable: true),
                    PunktyZdobyte = table.Column<int>(type: "int", nullable: true),
                    PunktyStracone = table.Column<int>(type: "int", nullable: true),
                    MeczeRozegrane = table.Column<int>(type: "int", nullable: true),
                    PunktySrednieZdobyte = table.Column<double>(type: "float", nullable: true),
                    PunktySrednieStracone = table.Column<double>(type: "float", nullable: true),
                    PunktyMaxZdobyte = table.Column<int>(type: "int", nullable: true),
                    PunktyMaxStracone = table.Column<int>(type: "int", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMenadzer = table.Column<int>(type: "int", nullable: false),
                    IdWynikowDruzyny = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Druzyny", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Druzyny_WynikiDruzynies_IdWynikowDruzyny",
                        column: x => x.IdWynikowDruzyny,
                        principalTable: "WynikiDruzynies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Druzyny_IdWynikowDruzyny",
                table: "Druzyny",
                column: "IdWynikowDruzyny");
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
