using Microsoft.EntityFrameworkCore.Migrations;

namespace Una_Trans.Migrations
{
    public partial class ispravka1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_RedVoznje_RezervacijaRedVoznjeId",
                table: "Rezervacija");

            migrationBuilder.RenameColumn(
                name: "RezervacijaRedVoznjeId",
                table: "Rezervacija",
                newName: "KartaCijenaId");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacija_RezervacijaRedVoznjeId",
                table: "Rezervacija",
                newName: "IX_Rezervacija_KartaCijenaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_KartaCijena_KartaCijenaId",
                table: "Rezervacija",
                column: "KartaCijenaId",
                principalTable: "KartaCijena",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_KartaCijena_KartaCijenaId",
                table: "Rezervacija");

            migrationBuilder.RenameColumn(
                name: "KartaCijenaId",
                table: "Rezervacija",
                newName: "RezervacijaRedVoznjeId");

            migrationBuilder.RenameIndex(
                name: "IX_Rezervacija_KartaCijenaId",
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
    }
}
