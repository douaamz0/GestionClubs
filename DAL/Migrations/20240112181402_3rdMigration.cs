using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _3rdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListeMembreClub_Membres_MembreId",
                table: "ListeMembreClub");

            migrationBuilder.DropIndex(
                name: "IX_ListeMembreClub_MembreId",
                table: "ListeMembreClub");

            migrationBuilder.DropColumn(
                name: "MembreId",
                table: "ListeMembreClub");

            migrationBuilder.AddColumn<int>(
                name: "idClub",
                table: "Membres",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idClub",
                table: "Membres");

            migrationBuilder.AddColumn<int>(
                name: "MembreId",
                table: "ListeMembreClub",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListeMembreClub_MembreId",
                table: "ListeMembreClub",
                column: "MembreId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListeMembreClub_Membres_MembreId",
                table: "ListeMembreClub",
                column: "MembreId",
                principalTable: "Membres",
                principalColumn: "Id");
        }
    }
}
