using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursoft.Migrations
{
    public partial class ServicesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff", "item-1.jpg", "Data backup &amp; recovery" },
                    { 2, "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff", "item-2.jpg", "Laptop &amp; Mac Upgrade" },
                    { 3, "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff", "item-3.jpg", "Data backup &amp; recovery" },
                    { 4, "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff", "item-4.jpg", "Data backup &amp; recovery" },
                    { 5, "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff", "item-5.jpg", "Data backup &amp; recovery" },
                    { 6, "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff", "item-6.jpg", "Data backup &amp; recovery" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
