using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreAracKiralama.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Araclar",
                columns: table => new
                {
                    AracNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitesDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yakit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araclar", x => x.AracNo);
                });

            migrationBuilder.CreateTable(
                name: "Islemler",
                columns: table => new
                {
                    IslemNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracSecimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AlisYeri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IadeYeri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IadeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlisSaati = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IadeSaati = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Islemler", x => x.IslemNo);
                });

            migrationBuilder.CreateTable(
                name: "Kampanyalar",
                columns: table => new
                {
                    KampanyaNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kampanya = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kampanyalar", x => x.KampanyaNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Araclar");

            migrationBuilder.DropTable(
                name: "Islemler");

            migrationBuilder.DropTable(
                name: "Kampanyalar");
        }
    }
}
