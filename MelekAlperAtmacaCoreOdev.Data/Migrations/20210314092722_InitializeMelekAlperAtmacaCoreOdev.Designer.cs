﻿// <auto-generated />
using MelekAlperAtmacaCoreOdev.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MelekAlperAtmacaCoreOdev.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210314092722_InitializeMelekAlperAtmacaCoreOdev")]
    partial class InitializeMelekAlperAtmacaCoreOdev
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MelekAlperAtmacaCoreOdev.Core.Models.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OgrenciNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("OgrenciID");

                    b.ToTable("TblOgrenci");

                    b.HasData(
                        new
                        {
                            OgrenciID = 1,
                            Adi = "Melek",
                            OgrenciNo = "1010101010",
                            Soyadi = "Alper Atmaca"
                        },
                        new
                        {
                            OgrenciID = 2,
                            Adi = "Kenan Durmuş",
                            OgrenciNo = "2010101010",
                            Soyadi = "Atmaca"
                        },
                        new
                        {
                            OgrenciID = 3,
                            Adi = "Fıstık",
                            OgrenciNo = "3010101010",
                            Soyadi = "Alper Atmaca"
                        });
                });

            modelBuilder.Entity("MelekAlperAtmacaCoreOdev.Core.Models.OgrenciDers", b =>
                {
                    b.Property<int>("OgrenciDersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DersAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DersKodu")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.HasKey("OgrenciDersID");

                    b.HasIndex("OgrenciID");

                    b.ToTable("TblOgrenciDers");

                    b.HasData(
                        new
                        {
                            OgrenciDersID = 1,
                            DersAdi = "Yazılım",
                            DersKodu = "YZLM-101",
                            OgrenciID = 1
                        },
                        new
                        {
                            OgrenciDersID = 2,
                            DersAdi = "Donanım",
                            DersKodu = "DNM-101",
                            OgrenciID = 2
                        },
                        new
                        {
                            OgrenciDersID = 3,
                            DersAdi = "Görsel Prog.",
                            DersKodu = "GRSP-101",
                            OgrenciID = 1
                        },
                        new
                        {
                            OgrenciDersID = 4,
                            DersAdi = "Mikroişlemciler",
                            DersKodu = "MKR-101",
                            OgrenciID = 2
                        },
                        new
                        {
                            OgrenciDersID = 5,
                            DersAdi = "Havlama",
                            DersKodu = "HAV-101",
                            OgrenciID = 3
                        });
                });

            modelBuilder.Entity("MelekAlperAtmacaCoreOdev.Core.Models.OgrenciDers", b =>
                {
                    b.HasOne("MelekAlperAtmacaCoreOdev.Core.Models.Ogrenci", "Ogrenci")
                        .WithMany("OgrenciDers")
                        .HasForeignKey("OgrenciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("MelekAlperAtmacaCoreOdev.Core.Models.Ogrenci", b =>
                {
                    b.Navigation("OgrenciDers");
                });
#pragma warning restore 612, 618
        }
    }
}
