using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_chanse99.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieTitle = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "MovieTitle", "Notes", "Rating", "Year" },
                values: new object[] { 1, "Action/Adventure", "Ryan Coogler", false, "", "Black Panther: Wakanda Forever", "", "PG-13", (ushort)2022 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "MovieTitle", "Notes", "Rating", "Year" },
                values: new object[] { 2, "Adventure/Comedy", "Joel Crawford", false, "", "Puss in Boots: The Last Wish", "", "PG", (ushort)2022 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "MovieTitle", "Notes", "Rating", "Year" },
                values: new object[] { 3, "Drama/Comedy", "Marc Forster", false, "", "A Man Called Otto", "", "PG-13", (ushort)2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
