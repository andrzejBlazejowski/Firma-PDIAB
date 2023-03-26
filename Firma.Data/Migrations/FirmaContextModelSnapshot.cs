﻿// <auto-generated />
using Firma.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Firma.Data.Migrations
{
    [DbContext(typeof(FirmaContext))]
    partial class FirmaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Firma.Data.Data.Cms.Aktualnosc", b =>
                {
                    b.Property<int>("IdAktualnosci")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAktualnosci"), 1L, 1);

                    b.Property<string>("LinkTytul")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Pozycja")
                        .HasColumnType("int");

                    b.Property<string>("Tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Tytuł")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdAktualnosci");

                    b.ToTable("Aktualnosc");
                });

            modelBuilder.Entity("Firma.Data.Data.Cms.Strona", b =>
                {
                    b.Property<int>("IdStrony")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdStrony"), 1L, 1);

                    b.Property<string>("LinkTytul")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Pozycja")
                        .HasColumnType("int");

                    b.Property<string>("Tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Tytuł")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdStrony");

                    b.ToTable("Strona");
                });

            modelBuilder.Entity("Firma.Data.Data.Sklep.Rodzaj", b =>
                {
                    b.Property<int>("IdRodzaju")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRodzaju"), 1L, 1);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRodzaju");

                    b.ToTable("Rodzaj");
                });

            modelBuilder.Entity("Firma.Data.Data.Sklep.Towar", b =>
                {
                    b.Property<int>("IdTowaru")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTowaru"), 1L, 1);

                    b.Property<decimal>("Cena")
                        .HasColumnType("money");

                    b.Property<string>("FotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kod")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RodzajId")
                        .HasColumnType("int");

                    b.HasKey("IdTowaru");

                    b.HasIndex("RodzajId");

                    b.ToTable("Towar");
                });

            modelBuilder.Entity("Firma.Data.Data.Sklep.Towar", b =>
                {
                    b.HasOne("Firma.Data.Data.Sklep.Rodzaj", "Rodzaj")
                        .WithMany("Towar")
                        .HasForeignKey("RodzajId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rodzaj");
                });

            modelBuilder.Entity("Firma.Data.Data.Sklep.Rodzaj", b =>
                {
                    b.Navigation("Towar");
                });
#pragma warning restore 612, 618
        }
    }
}
