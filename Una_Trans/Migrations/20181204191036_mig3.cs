using Microsoft.EntityFrameworkCore.Migrations;

namespace Una_Trans.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RedVoznje_Karta_KartaId",
                table: "RedVoznje");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Karta_KartaRezervacijaId",
                table: "Rezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Grad_OdredisteRezervacijaId",
                table: "Rezervacija");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Grad_PolazisteRezervacijaId",
                table: "Rezervacija");

            migrationBuilder.DropIndex(
                name: "IX_Rezervacija_KartaRezervacijaId",
                table: "Rezervacija");

            migrationBuilder.DropIndex(
                name: "IX_Rezervacija_OdredisteRezervacijaId",
                table: "Rezervacija");

            migrationBuilder.DropIndex(
                name: "IX_RedVoznje_KartaId",
                table: "RedVoznje");

            migrationBuilder.DropColumn(
                name: "DatumPolaskaRezervacija",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "KartaRezervacijaId",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "OdredisteRezervacijaId",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "VrijemeDolaskaRezervacija",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "VrijemePolaskaRezervacija",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "RedVoznje");

            migrationBuilder.DropColumn(
                name: "KartaId",
                table: "RedVoznje");

            migrationBuilder.RenameColumn(
                name: "PolazisteRezervacijaId",
                table: "Rezervacija",
                newName: "RezervacijaRedVoznjeId");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacija_PolazisteRezervacijaId",
                table: "Rezervacija",
                newName: "IX_Rezervacija_RezervacijaRedVoznjeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_RedVoznje_RezervacijaRedVoznjeId",
                table: "Rezervacija",
                column: "RezervacijaRedVoznjeId",
                principalTable: "RedVoznje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_RedVoznje_RezervacijaRedVoznjeId",
                table: "Rezervacija");

            migrationBuilder.RenameColumn(
                name: "RezervacijaRedVoznjeId",
                table: "Rezervacija",
                newName: "PolazisteRezervacijaId");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacija_RezervacijaRedVoznjeId",
                table: "Rezervacija",
                newName: "IX_Rezervacija_PolazisteRezervacijaId");

            migrationBuilder.AddColumn<string>(
                name: "DatumPolaskaRezervacija",
                table: "Rezervacija",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KartaRezervacijaId",
                table: "Rezervacija",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OdredisteRezervacijaId",
                table: "Rezervacija",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VrijemeDolaskaRezervacija",
                table: "Rezervacija",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VrijemePolaskaRezervacija",
                table: "Rezervacija",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Cijena",
                table: "RedVoznje",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "KartaId",
                table: "RedVoznje",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_KartaRezervacijaId",
                table: "Rezervacija",
                column: "KartaRezervacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_OdredisteRezervacijaId",
                table: "Rezervacija",
                column: "OdredisteRezervacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_RedVoznje_KartaId",
                table: "RedVoznje",
                column: "KartaId");

            migrationBuilder.AddForeignKey(
                name: "FK_RedVoznje_Karta_KartaId",
                table: "RedVoznje",
                column: "KartaId",
                principalTable: "Karta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Karta_KartaRezervacijaId",
                table: "Rezervacija",
                column: "KartaRezervacijaId",
                principalTable: "Karta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Grad_OdredisteRezervacijaId",
                table: "Rezervacija",
                column: "OdredisteRezervacijaId",
                principalTable: "Grad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Grad_PolazisteRezervacijaId",
                table: "Rezervacija",
                column: "PolazisteRezervacijaId",
                principalTable: "Grad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
