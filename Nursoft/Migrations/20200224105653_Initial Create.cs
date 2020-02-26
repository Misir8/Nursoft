using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursoft.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Subtitle = table.Column<string>(maxLength: 255, nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Image", "Subtitle", "Title" },
                values: new object[] { 1, "motherboard-1.jpg", "Just send valuable laptop, PC, MAC, Mobile,<br>Gaming Device or Smartphone and we'll take care of it.", "Fast & Quick Fix" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Image", "Subtitle", "Title" },
                values: new object[] { 2, "motherboard-3.jpg", null, "Any Kind of Upgrades" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Image", "Subtitle", "Title" },
                values: new object[] { 3, "data-recovery.jpg", "You Lose - We'll Find", "Data Recovery" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
