using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRTechAPI.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sokak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KapiNo = table.Column<int>(type: "int", nullable: false),
                    DaireNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meslekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meslekler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sirketler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sirketler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotografYolu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IseGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IstenCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktiflik = table.Column<bool>(type: "bit", nullable: false),
                    MeslekId = table.Column<int>(type: "int", nullable: false),
                    DepartmanId = table.Column<int>(type: "int", nullable: false),
                    SirketId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresId = table.Column<int>(type: "int", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maas = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personeller_Adresler_AdresId",
                        column: x => x.AdresId,
                        principalTable: "Adresler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personeller_Departmanlar_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departmanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personeller_Meslekler_MeslekId",
                        column: x => x.MeslekId,
                        principalTable: "Meslekler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personeller_Sirketler_SirketId",
                        column: x => x.SirketId,
                        principalTable: "Sirketler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_AdresId",
                table: "Personeller",
                column: "AdresId");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_DepartmanId",
                table: "Personeller",
                column: "DepartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_MeslekId",
                table: "Personeller",
                column: "MeslekId");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_SirketId",
                table: "Personeller",
                column: "SirketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.DropTable(
                name: "Departmanlar");

            migrationBuilder.DropTable(
                name: "Meslekler");

            migrationBuilder.DropTable(
                name: "Sirketler");
        }
    }
}
