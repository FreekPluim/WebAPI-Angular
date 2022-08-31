using Microsoft.EntityFrameworkCore.Migrations;

namespace Highscore_WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScoreDetails",
                columns: table => new
                {
                    ScoreDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScoreName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ScoreTimeinSec = table.Column<int>(type: "int", nullable: true),
                    DistanceInMeters = table.Column<int>(type: "int", nullable: true),
                    HighScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreDetails", x => x.ScoreDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScoreDetails");
        }
    }
}
