using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _4rdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activites_Clubs_IdClub",
                table: "Activites");

            migrationBuilder.DropTable(
                name: "ListeActiviteClub");

            migrationBuilder.DropTable(
                name: "ListeMembreClub");

            migrationBuilder.DropIndex(
                name: "IX_Activites_IdClub",
                table: "Activites");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ListeActiviteClub",
                columns: table => new
                {
                    IdClub = table.Column<int>(type: "int", nullable: false),
                    IdActivite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListeActiviteClub", x => new { x.IdClub, x.IdActivite });
                    table.ForeignKey(
                        name: "FK_ListeActiviteClub_Activites_IdActivite",
                        column: x => x.IdActivite,
                        principalTable: "Activites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListeActiviteClub_Clubs_IdClub",
                        column: x => x.IdClub,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListeMembreClub",
                columns: table => new
                {
                    IdClub = table.Column<int>(type: "int", nullable: false),
                    IdMembre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListeMembreClub", x => new { x.IdClub, x.IdMembre });
                    table.ForeignKey(
                        name: "FK_ListeMembreClub_Clubs_IdClub",
                        column: x => x.IdClub,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListeMembreClub_Membres_IdMembre",
                        column: x => x.IdMembre,
                        principalTable: "Membres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activites_IdClub",
                table: "Activites",
                column: "IdClub");

            migrationBuilder.CreateIndex(
                name: "IX_ListeActiviteClub_IdActivite",
                table: "ListeActiviteClub",
                column: "IdActivite");

            migrationBuilder.CreateIndex(
                name: "IX_ListeMembreClub_IdMembre",
                table: "ListeMembreClub",
                column: "IdMembre");

            migrationBuilder.AddForeignKey(
                name: "FK_Activites_Clubs_IdClub",
                table: "Activites",
                column: "IdClub",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
