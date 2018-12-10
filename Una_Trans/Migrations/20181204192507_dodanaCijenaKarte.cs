using Microsoft.EntityFrameworkCore.Migrations;

namespace Una_Trans.Migrations
{
    public partial class dodanaCijenaKarte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Cijena",
                table: "KartaCijena",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "KartaCijena");
        }
    }
}
