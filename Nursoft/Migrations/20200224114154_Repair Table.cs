using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursoft.Migrations
{
    public partial class RepairTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Repairs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 5000, nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repairs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Repairs",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "starting at...", "notebook-dark.png", "Laptop Repair" },
                    { 2, "starting at...", "computer-dark.png", "Computer Repair" },
                    { 3, "starting at...", "printer-dark.png", "Printer Repair" },
                    { 4, "starting at...", "mobile-dark.png", "Smartphone Repair" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repairs");
        }
    }
}
