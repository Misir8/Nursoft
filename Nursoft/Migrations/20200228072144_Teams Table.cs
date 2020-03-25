using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursoft.Migrations
{
    public partial class TeamsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Position = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Image", "Name", "Position" },
                values: new object[] { 1, "member-1.jpg", "John Doe", "CEO & Founder" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Image", "Name", "Position" },
                values: new object[] { 2, "member-2.jpg", "Bryan Lewis", "Cheif Engineer" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Image", "Name", "Position" },
                values: new object[] { 3, "member-3.jpg", "David Hanson", "Technical Manager" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
