using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursoft.Migrations
{
    public partial class addedcounter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specifications_Products_productId",
                table: "Specifications");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "Specifications",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Specifications_productId",
                table: "Specifications",
                newName: "IX_Specifications_ProductId");

            migrationBuilder.CreateTable(
                name: "Counters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<int>(type: "int", nullable: false),
                    Project = table.Column<int>(type: "int", nullable: false),
                    Computer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Counters",
                columns: new[] { "Id", "Client", "Computer", "Project" },
                values: new object[] { 1, 3720, 2730, 4170 });

            migrationBuilder.AddForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications");

            migrationBuilder.DropTable(
                name: "Counters");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Specifications",
                newName: "productId");

            migrationBuilder.RenameIndex(
                name: "IX_Specifications_ProductId",
                table: "Specifications",
                newName: "IX_Specifications_productId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specifications_Products_productId",
                table: "Specifications",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
