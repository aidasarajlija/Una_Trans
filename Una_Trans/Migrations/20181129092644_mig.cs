using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Una_Trans.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Karta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZakupAutobusa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImePrezimeFirma = table.Column<int>(nullable: false),
                    JMBG = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Grad = table.Column<string>(nullable: true),
                    RutaPutovanja = table.Column<string>(nullable: true),
                    BrojPutnika = table.Column<int>(nullable: false),
                    AdresaPolaska = table.Column<string>(nullable: true),
                    DatumPolaska = table.Column<DateTime>(nullable: false),
                    DatumDolaska = table.Column<DateTime>(nullable: false),
                    VrijemePolaska = table.Column<DateTime>(nullable: false),
                    VrijemeDolaska = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZakupAutobusa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RedVoznje",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumPolaskaRezervacija = table.Column<DateTime>(nullable: false),
                    VrijemePolaskaRezervacija = table.Column<DateTime>(nullable: false),
                    VrijemeDolaskaRezervacija = table.Column<DateTime>(nullable: false),
                    PolazisteId = table.Column<int>(nullable: false),
                    OdredisteId = table.Column<int>(nullable: false),
                    KartaId = table.Column<int>(nullable: false),
                    Cijena = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedVoznje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedVoznje_Karta_KartaId",
                        column: x => x.KartaId,
                        principalTable: "Karta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RedVoznje_Grad_OdredisteId",
                        column: x => x.OdredisteId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RedVoznje_Grad_PolazisteId",
                        column: x => x.PolazisteId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumPolaskaRezervacija = table.Column<DateTime>(nullable: false),
                    VrijemePolaskaRezervacija = table.Column<DateTime>(nullable: false),
                    VrijemeDolaskaRezervacija = table.Column<DateTime>(nullable: false),
                    PolazisteRezervacijaId = table.Column<int>(nullable: false),
                    OdredisteRezervacijaId = table.Column<int>(nullable: false),
                    KartaRezervacijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Karta_KartaRezervacijaId",
                        column: x => x.KartaRezervacijaId,
                        principalTable: "Karta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Grad_OdredisteRezervacijaId",
                        column: x => x.OdredisteRezervacijaId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Grad_PolazisteRezervacijaId",
                        column: x => x.PolazisteRezervacijaId,
                        principalTable: "Grad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RedVoznje_KartaId",
                table: "RedVoznje",
                column: "KartaId");

            migrationBuilder.CreateIndex(
                name: "IX_RedVoznje_OdredisteId",
                table: "RedVoznje",
                column: "OdredisteId");

            migrationBuilder.CreateIndex(
                name: "IX_RedVoznje_PolazisteId",
                table: "RedVoznje",
                column: "PolazisteId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_KartaRezervacijaId",
                table: "Rezervacija",
                column: "KartaRezervacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_OdredisteRezervacijaId",
                table: "Rezervacija",
                column: "OdredisteRezervacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_PolazisteRezervacijaId",
                table: "Rezervacija",
                column: "PolazisteRezervacijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RedVoznje");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "ZakupAutobusa");

            migrationBuilder.DropTable(
                name: "Karta");

            migrationBuilder.DropTable(
                name: "Grad");
        }
    }
}
