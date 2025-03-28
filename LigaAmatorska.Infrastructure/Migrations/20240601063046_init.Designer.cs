﻿// <auto-generated />
using System;
using LigaAmatorska.Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LigaAmatorska.Infrastructure.Migrations
{
    [DbContext(typeof(LigaDbContext))]
    [Migration("20240601063046_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LigaAmatorska.Domain.Entities.Druzyna", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMenadzer")
                        .HasColumnType("int");

                    b.Property<int>("IdWynikowDruzyny")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdWynikowDruzyny");

                    b.ToTable("Druzyny");
                });

            modelBuilder.Entity("LigaAmatorska.Domain.Entities.Mecz", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("dataGodzina")
                        .HasColumnType("datetime2");

                    b.Property<int>("idDruzynaA")
                        .HasColumnType("int");

                    b.Property<int>("idDruzynaB")
                        .HasColumnType("int");

                    b.Property<int>("idSedzia")
                        .HasColumnType("int");

                    b.Property<int>("wynikA")
                        .HasColumnType("int");

                    b.Property<int>("wynikB")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Mecze");
                });

            modelBuilder.Entity("LigaAmatorska.Domain.Entities.Sedzia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("adresEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numerLicncji")
                        .HasColumnType("int");

                    b.Property<string>("numerTelefonu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Sedziowie");
                });

            modelBuilder.Entity("LigaAmatorska.Domain.Entities.Statystyki", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("asysty")
                        .HasColumnType("int");

                    b.Property<int?>("bloki")
                        .HasColumnType("int");

                    b.Property<int?>("eval")
                        .HasColumnType("int");

                    b.Property<int?>("faule")
                        .HasColumnType("int");

                    b.Property<int?>("minuty")
                        .HasColumnType("int");

                    b.Property<int?>("plusMinus")
                        .HasColumnType("int");

                    b.Property<int?>("przechwyty")
                        .HasColumnType("int");

                    b.Property<int?>("punkty")
                        .HasColumnType("int");

                    b.Property<int?>("rzuty1celne")
                        .HasColumnType("int");

                    b.Property<int?>("rzuty1oddane")
                        .HasColumnType("int");

                    b.Property<int?>("rzuty2celne")
                        .HasColumnType("int");

                    b.Property<int?>("rzuty2oddane")
                        .HasColumnType("int");

                    b.Property<int?>("rzuty3celne")
                        .HasColumnType("int");

                    b.Property<int?>("rzuty3oddane")
                        .HasColumnType("int");

                    b.Property<int?>("straty")
                        .HasColumnType("int");

                    b.Property<int?>("zbiorkiDef")
                        .HasColumnType("int");

                    b.Property<int?>("zbiorkiOff")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Statystyki");
                });

            modelBuilder.Entity("LigaAmatorska.Domain.Entities.TypUprawnien", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TypyUprawnien");
                });

            modelBuilder.Entity("LigaAmatorska.Domain.Entities.Uzytkkownik", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("adresEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("haslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idTypuUprawnien")
                        .HasColumnType("int");

                    b.Property<string>("imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numerTelefonu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Uzytkownicy");
                });

            modelBuilder.Entity("LigaAmatorska.Domain.Entities.WynikiDruzyny", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MeczeRozegrane")
                        .HasColumnType("int");

                    b.Property<int?>("Przegrane")
                        .HasColumnType("int");

                    b.Property<int?>("PunktyDuże")
                        .HasColumnType("int");

                    b.Property<int?>("PunktyMaxStracone")
                        .HasColumnType("int");

                    b.Property<int?>("PunktyMaxZdobyte")
                        .HasColumnType("int");

                    b.Property<double?>("PunktySrednieStracone")
                        .HasColumnType("float");

                    b.Property<double?>("PunktySrednieZdobyte")
                        .HasColumnType("float");

                    b.Property<int?>("PunktyStracone")
                        .HasColumnType("int");

                    b.Property<int?>("PunktyZdobyte")
                        .HasColumnType("int");

                    b.Property<int?>("Wygrane")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WynikiDruzynies");
                });

            modelBuilder.Entity("LigaAmatorska.Domain.Entities.Zawodnik", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("dataUrodzenia")
                        .HasColumnType("datetime2");

                    b.Property<int>("idDruzyny")
                        .HasColumnType("int");

                    b.Property<int>("idStatystyk")
                        .HasColumnType("int");

                    b.Property<string>("imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numer")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Zaowdnicy");
                });

            modelBuilder.Entity("LigaAmatorska.Domain.Entities.Druzyna", b =>
                {
                    b.HasOne("LigaAmatorska.Domain.Entities.WynikiDruzyny", "WynikiDruzyny")
                        .WithMany()
                        .HasForeignKey("IdWynikowDruzyny")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WynikiDruzyny");
                });
#pragma warning restore 612, 618
        }
    }
}
