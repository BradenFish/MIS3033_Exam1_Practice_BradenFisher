using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MIS3033_Exam1_Practice_BradenFisher.Migrations
{
    /// <inheritdoc />
    public partial class createdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "stuTbl",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    grade = table.Column<double>(type: "REAL", nullable: false),
                    gradeLevel = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stuTbl", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stuTbl");
        }
    }
}
