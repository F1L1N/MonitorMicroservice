using Microsoft.EntityFrameworkCore.Migrations;

namespace MonitorMicroservice.Migrations
{
    public partial class addAnalyzes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalyzesBloodBio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyzesBloodBio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnalyzesBloodClynic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(nullable: false),
                    Hemoglobin = table.Column<double>(nullable: false),
                    Erythrocyte = table.Column<double>(nullable: false),
                    Leukocyte = table.Column<double>(nullable: false),
                    Platelet = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyzesBloodClynic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnalyzesBloodGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyzesBloodGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnalyzesCoprogram",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyzesCoprogram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnalyzesIFA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyzesIFA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnalyzesUrine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyzesUrine", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalyzesBloodBio");

            migrationBuilder.DropTable(
                name: "AnalyzesBloodClynic");

            migrationBuilder.DropTable(
                name: "AnalyzesBloodGroup");

            migrationBuilder.DropTable(
                name: "AnalyzesCoprogram");

            migrationBuilder.DropTable(
                name: "AnalyzesIFA");

            migrationBuilder.DropTable(
                name: "AnalyzesUrine");
        }
    }
}
