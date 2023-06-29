﻿// <auto-generated />
using System;
using CoreAracKiralama.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreAracKiralama.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230511140407_CreateDb")]
    partial class CreateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreAracKiralama.Models.Araclar", b =>
                {
                    b.Property<int>("AracNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Fiyat")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VitesDurumu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yakit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AracNo");

                    b.ToTable("Araclar");
                });

            modelBuilder.Entity("CoreAracKiralama.Models.Islemler", b =>
                {
                    b.Property<int>("IslemNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlisSaati")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("AlisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("AlisYeri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AracSecimi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IadeSaati")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IadeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("IadeYeri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IslemNo");

                    b.ToTable("Islemler");
                });

            modelBuilder.Entity("CoreAracKiralama.Models.Kampanyalar", b =>
                {
                    b.Property<int>("KampanyaNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kampanya")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("KampanyaNo");

                    b.ToTable("Kampanyalar");
                });
#pragma warning restore 612, 618
        }
    }
}
