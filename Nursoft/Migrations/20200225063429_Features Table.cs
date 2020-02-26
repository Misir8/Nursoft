using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursoft.Migrations
{
    public partial class FeaturesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Qualified Workers Lorem Ipsum is simply dummy text of the printi", "WE ARE FAST" },
                    { 2, "Repair on Demand Lorem Ipsum is simply dummy text of the printing", "NO FIX, NO FEE" },
                    { 3, "Guaranteed Service Lorem Ipsum is simply dummy text of the printing", "30 DAYS WARRANTY" },
                    { 4, "Available Anytime Lorem Ipsum is simply dummy text of the printing", "EXPERT STAFF" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");
        }
    }
}
