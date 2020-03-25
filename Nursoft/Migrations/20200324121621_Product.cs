using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursoft.Migrations
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    CategoryProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_CategoryProducts_CategoryProductId",
                        column: x => x.CategoryProductId,
                        principalTable: "CategoryProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mouse" },
                    { 2, "USB" },
                    { 3, "Adapter" },
                    { 4, "SSD" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryProductId", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 1, 1, "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box", "mouse.jpg", "GAMERS MOUSE" },
                    { 2, 2, "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box", "usb-hub.jpg", "USB 3.0 HUB" },
                    { 5, 2, "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box", "cable-organizer.jpg", "CABLE ORGANIZER" },
                    { 3, 3, "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box", "laptop-ac-power-adapter.jpg", "LAPTOP POWER ADAPTER" },
                    { 4, 3, "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box", "wifi-router.jpg", "WI-FI ROUTER REPIETER" },
                    { 6, 4, "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box", "126gb-ssd.jpg", "128GB SSD M.2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryProductId",
                table: "Products",
                column: "CategoryProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CategoryProducts");
        }
    }
}
