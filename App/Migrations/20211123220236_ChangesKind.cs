using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class ChangesKind : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFlink",
                table: "Kinderen",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFlink",
                table: "Kinderen");
        }
    }
}
