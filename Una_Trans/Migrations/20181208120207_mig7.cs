using Microsoft.EntityFrameworkCore.Migrations;

namespace Una_Trans.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KorisnikZakupId",
                table: "ZakupAutobusa",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KorisnikRezervacijaId",
                table: "Rezervacija",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ZakupAutobusa_KorisnikZakupId",
                table: "ZakupAutobusa",
                column: "KorisnikZakupId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_KorisnikRezervacijaId",
                table: "Rezervacija",
                column: "KorisnikRezervacijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Korisnik_KorisnikRezervacijaId",
                table: "Rezervacija",
                column: "KorisnikRezervacijaId",
                principalTable: "Korisnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZakupAutobusa_Korisnik_KorisnikZakupId",
                table: "ZakupAutobusa",
                column: "KorisnikZakupId",
                principalTable: "Korisnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Korisnik_KorisnikRezervacijaId",
                table: "Rezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_ZakupAutobusa_Korisnik_KorisnikZakupId",
                table: "ZakupAutobusa");

            migrationBuilder.DropIndex(
                name: "IX_ZakupAutobusa_KorisnikZakupId",
                table: "ZakupAutobusa");

            migrationBuilder.DropIndex(
                name: "IX_Rezervacija_KorisnikRezervacijaId",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "KorisnikZakupId",
                table: "ZakupAutobusa");

            migrationBuilder.DropColumn(
                name: "KorisnikRezervacijaId",
                table: "Rezervacija");
        }
    }
}
