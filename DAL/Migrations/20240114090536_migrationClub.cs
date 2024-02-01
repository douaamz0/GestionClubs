using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class migrationClub : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activites_Clubs_ClubId",
                table: "Activites");

            migrationBuilder.DropIndex(
                name: "IX_Activites_ClubId",
                table: "Activites");

            migrationBuilder.DropColumn(
                name: "ClubId",
                table: "Activites");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClubId",
                table: "Activites",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activites_ClubId",
                table: "Activites",
                column: "ClubId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activites_Clubs_ClubId",
                table: "Activites",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id");
        }
    }
}
