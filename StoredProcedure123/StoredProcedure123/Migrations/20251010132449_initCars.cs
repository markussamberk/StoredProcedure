using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoredProcedure123.Migrations
{
    /// <inheritdoc />
    public partial class initCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    FirstName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TopSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HamburgersEaten = table.Column<int>(type: "int", nullable: false),
                    TimesRanOutOfGas = table.Column<int>(type: "int", nullable: false),
                    RacesWon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.FirstName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
