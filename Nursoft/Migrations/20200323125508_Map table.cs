using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursoft.Migrations
{
    public partial class Maptable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MapContacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lat = table.Column<string>(maxLength: 255, nullable: false),
                    Lng = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapContacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MapContacts",
                columns: new[] { "Id", "Lat", "Lng" },
                values: new object[] { 1, "40.5808780081475", "49.6863716840744" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MapContacts");
        }
    }
}
