using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Una_Trans.Migrations
{
    public partial class dodanaKartaCijena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KartaCijena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CijenaKartaId = table.Column<int>(nullable: false),
                    CijenaRedVoznjeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KartaCijena", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KartaCijena_Karta_CijenaKartaId",
                        column: x => x.CijenaKartaId,
                        principalTable: "Karta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KartaCijena_RedVoznje_CijenaRedVoznjeId",
                        column: x => x.CijenaRedVoznjeId,
                        principalTable: "RedVoznje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KartaCijena_CijenaKartaId",
                table: "KartaCijena",
                column: "CijenaKartaId");

            migrationBuilder.CreateIndex(
                name: "IX_KartaCijena_CijenaRedVoznjeId",
                table: "KartaCijena",
                column: "CijenaRedVoznjeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KartaCijena");
        }
    }
}
