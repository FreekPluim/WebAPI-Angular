using Microsoft.EntityFrameworkCore.Migrations;

namespace Highscore_WebAPI.Migrations
{
    public partial class AddedDistance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ScoreTimeinSec",
                table: "ScoreDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HighScore",
                table: "ScoreDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000000)");

            migrationBuilder.AddColumn<int>(
                name: "DistanceInMeters",
                table: "ScoreDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistanceInMeters",
                table: "ScoreDetails");

            migrationBuilder.AlterColumn<string>(
                name: "ScoreTimeinSec",
                table: "ScoreDetails",
                type: "nvarchar(1000000)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "HighScore",
                table: "ScoreDetails",
                type: "nvarchar(1000000)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
