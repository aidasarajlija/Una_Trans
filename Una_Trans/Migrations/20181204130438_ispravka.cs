using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Una_Trans.Migrations
{
    public partial class ispravka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumPolaskaRezervacija",
                table: "RedVoznje");

            migrationBuilder.RenameColumn(
                name: "VrijemePolaskaRezervacija",
                table: "RedVoznje",
                newName: "VrijemePolaskaRedVoznje");

            migrationBuilder.RenameColumn(
                name: "VrijemeDolaskaRezervacija",
                table: "RedVoznje",
                newName: "VrijemeDolaskaRedVoznje");

            migrationBuilder.AlterColumn<string>(
                name: "DatumPolaskaRezervacija",
                table: "Rezervacija",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "DatumPolaskaRedVoznje",
                table: "RedVoznje",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumPolaskaRedVoznje",
                table: "RedVoznje");

            migrationBuilder.RenameColumn(
                name: "VrijemePolaskaRedVoznje",
                table: "RedVoznje",
                newName: "VrijemePolaskaRezervacija");

            migrationBuilder.RenameColumn(
                name: "VrijemeDolaskaRedVoznje",
                table: "RedVoznje",
                newName: "VrijemeDolaskaRezervacija");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumPolaskaRezervacija",
                table: "Rezervacija",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumPolaskaRezervacija",
                table: "RedVoznje",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
