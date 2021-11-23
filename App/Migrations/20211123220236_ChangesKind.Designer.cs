﻿// <auto-generated />
using System;
using App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(OnthaalMoederContext))]
    [Migration("20211123220236_ChangesKind")]
    partial class ChangesKind
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Models.Kind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Geslacht")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFlink")
                        .HasColumnType("bit");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OnthaalMoederId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OnthaalMoederId");

                    b.ToTable("Kinderen");
                });

            modelBuilder.Entity("App.Models.OnthaalMoeder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BtwNummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OverheidsInstellingId")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OverheidsInstellingId");

                    b.ToTable("OnthaalMoeders");
                });

            modelBuilder.Entity("App.Models.OverheidsInstelling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BtwNummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("OpvoedingsCentra");
                });

            modelBuilder.Entity("App.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OnthaalMoederId")
                        .HasColumnType("int");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("OnthaalMoederId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("App.Models.Kind", b =>
                {
                    b.HasOne("App.Models.OnthaalMoeder", "OnthaalMoeder")
                        .WithMany("Kinderen")
                        .HasForeignKey("OnthaalMoederId");

                    b.Navigation("OnthaalMoeder");
                });

            modelBuilder.Entity("App.Models.OnthaalMoeder", b =>
                {
                    b.HasOne("App.Models.OverheidsInstelling", null)
                        .WithMany("Onthaalmoeders")
                        .HasForeignKey("OverheidsInstellingId");
                });

            modelBuilder.Entity("App.Models.Review", b =>
                {
                    b.HasOne("App.Models.OnthaalMoeder", "OnthaalMoeder")
                        .WithMany("Reviews")
                        .HasForeignKey("OnthaalMoederId");

                    b.Navigation("OnthaalMoeder");
                });

            modelBuilder.Entity("App.Models.OnthaalMoeder", b =>
                {
                    b.Navigation("Kinderen");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("App.Models.OverheidsInstelling", b =>
                {
                    b.Navigation("Onthaalmoeders");
                });
#pragma warning restore 612, 618
        }
    }
}
