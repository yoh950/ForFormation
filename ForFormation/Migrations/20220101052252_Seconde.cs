using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForFormation.Migrations
{
    public partial class Seconde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FormationId",
                table: "Avis",
                newName: "FormationsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FormationsId",
                table: "Avis",
                newName: "FormationId");
        }
    }
}
