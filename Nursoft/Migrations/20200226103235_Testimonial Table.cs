using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursoft.Migrations
{
    public partial class TestimonialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 5000, nullable: false),
                    Position = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Description", "Image", "Name", "Position" },
                values: new object[] { 1, "Thanks John, I was really pleased with Profix’s service. Would definitely recommend you and have alredy given out some of your business cards that were left with me. All the best for future succes.", "notebook-sm.png", "Michale John", "Co-Founder, InfoLabs" });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Description", "Image", "Name", "Position" },
                values: new object[] { 2, "Profix did great job with fixing my laptop for a good price. I recommend any body with laptop problems, they will give you excellent service to all his customers.", "computer-sm.png", "Merry Smith", "CFO, InfoTech" });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Description", "Image", "Name", "Position" },
                values: new object[] { 3, "Keep up the excellent work. Thank you so much for your help. This is simply unbelievable!", "mobile-sm.png", "Merry Doe", "CFO, InfoTech" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
