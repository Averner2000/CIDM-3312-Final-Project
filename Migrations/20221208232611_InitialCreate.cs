using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allegiances",
                columns: table => new
                {
                    AllegianceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AllianceName = table.Column<string>(type: "TEXT", nullable: false),
                    AllyStatus = table.Column<string>(type: "TEXT", nullable: false),
                    WarStatus = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allegiances", x => x.AllegianceId);
                });

            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryName = table.Column<string>(type: "TEXT", nullable: false),
                    CountryNeighbor = table.Column<string>(type: "TEXT", nullable: false),
                    Export = table.Column<string>(type: "TEXT", nullable: false),
                    Import = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Dragons",
                columns: table => new
                {
                    DragonId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DragonName = table.Column<string>(type: "TEXT", nullable: false),
                    DragonRace = table.Column<string>(type: "TEXT", nullable: false),
                    DragonEC = table.Column<string>(type: "TEXT", nullable: false),
                    DragonAffinity = table.Column<string>(type: "TEXT", nullable: false),
                    DragonBounty = table.Column<int>(type: "INTEGER", nullable: false),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: false),
                    AllegianceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dragons", x => x.DragonId);
                    table.ForeignKey(
                        name: "FK_Dragons_Allegiances_AllegianceId",
                        column: x => x.AllegianceId,
                        principalTable: "Allegiances",
                        principalColumn: "AllegianceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dragons_Countrys_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countrys",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dragons_AllegianceId",
                table: "Dragons",
                column: "AllegianceId");

            migrationBuilder.CreateIndex(
                name: "IX_Dragons_CountryId",
                table: "Dragons",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dragons");

            migrationBuilder.DropTable(
                name: "Allegiances");

            migrationBuilder.DropTable(
                name: "Countrys");
        }
    }
}
