using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class Tutorial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OpvoedingsCentra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BtwNummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpvoedingsCentra", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnthaalMoeders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BtwNummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OverheidsInstellingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnthaalMoeders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnthaalMoeders_OpvoedingsCentra_OverheidsInstellingId",
                        column: x => x.OverheidsInstellingId,
                        principalTable: "OpvoedingsCentra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kinderen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Geslacht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnthaalMoederId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kinderen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kinderen_OnthaalMoeders_OnthaalMoederId",
                        column: x => x.OnthaalMoederId,
                        principalTable: "OnthaalMoeders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    OnthaalMoederId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_OnthaalMoeders_OnthaalMoederId",
                        column: x => x.OnthaalMoederId,
                        principalTable: "OnthaalMoeders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kinderen_OnthaalMoederId",
                table: "Kinderen",
                column: "OnthaalMoederId");

            migrationBuilder.CreateIndex(
                name: "IX_OnthaalMoeders_OverheidsInstellingId",
                table: "OnthaalMoeders",
                column: "OverheidsInstellingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_OnthaalMoederId",
                table: "Reviews",
                column: "OnthaalMoederId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kinderen");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "OnthaalMoeders");

            migrationBuilder.DropTable(
                name: "OpvoedingsCentra");
        }
    }
}
