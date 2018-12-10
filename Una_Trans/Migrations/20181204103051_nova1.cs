using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Una_Trans.Migrations
{
    public partial class nova1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VrijemePolaskaRezervacija",
                table: "Rezervacija",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "VrijemeDolaskaRezervacija",
                table: "Rezervacija",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "VrijemePolaskaRezervacija",
                table: "RedVoznje",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "VrijemeDolaskaRezervacija",
                table: "RedVoznje",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "VrijemePolaskaRezervacija",
                table: "Rezervacija",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VrijemeDolaskaRezervacija",
                table: "Rezervacija",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VrijemePolaskaRezervacija",
                table: "RedVoznje",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VrijemeDolaskaRezervacija",
                table: "RedVoznje",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
