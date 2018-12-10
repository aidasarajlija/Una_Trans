using Microsoft.EntityFrameworkCore.Migrations;

namespace Una_Trans.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grad",
                table: "ZakupAutobusa");

            migrationBuilder.AddColumn<int>(
                name: "ZakupGradId",
                table: "ZakupAutobusa",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ZakupAutobusa_ZakupGradId",
                table: "ZakupAutobusa",
                column: "ZakupGradId");

            migrationBuilder.AddForeignKey(
                name: "FK_ZakupAutobusa_Grad_ZakupGradId",
                table: "ZakupAutobusa",
                column: "ZakupGradId",
                principalTable: "Grad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZakupAutobusa_Grad_ZakupGradId",
                table: "ZakupAutobusa");

            migrationBuilder.DropIndex(
                name: "IX_ZakupAutobusa_ZakupGradId",
                table: "ZakupAutobusa");

            migrationBuilder.DropColumn(
                name: "ZakupGradId",
                table: "ZakupAutobusa");

            migrationBuilder.AddColumn<string>(
                name: "Grad",
                table: "ZakupAutobusa",
                nullable: true);
        }
    }
}
