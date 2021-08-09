using Microsoft.EntityFrameworkCore.Migrations;

namespace ChallengeDisneyAPI.Migrations
{
    public partial class muchosamuchos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Characters_CharactersId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CharactersId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CharactersId",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "CharactersMovie",
                columns: table => new
                {
                    CharactersId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharactersMovie", x => new { x.CharactersId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_CharactersMovie_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharactersMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharactersMovie_MoviesId",
                table: "CharactersMovie",
                column: "MoviesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharactersMovie");

            migrationBuilder.AddColumn<int>(
                name: "CharactersId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CharactersId",
                table: "Movies",
                column: "CharactersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Characters_CharactersId",
                table: "Movies",
                column: "CharactersId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
