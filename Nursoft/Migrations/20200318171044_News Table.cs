using Microsoft.EntityFrameworkCore.Migrations;

namespace Nursoft.Migrations
{
    public partial class NewsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Subtitle = table.Column<string>(maxLength: 1000, nullable: false),
                    Text = table.Column<string>(nullable: false),
                    Image = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Image", "Name", "Subtitle", "Text" },
                values: new object[] { 1, "article-1.jpg", "What is BGA", "A ball grid array (BGA) is a type of surface-mount packaging (a chip carrier) used for integrated circuits. BGA packages are used to permanently mount devices such as microprocessors. A BGA can provide more interc... pins than can be put on a dual in-line or flat package. The whole bottom surface of the device can be used, instead of just the perimeter. The leads are also on average shorter than with a perimeter-only type, leading to better performance at high speeds. Soldering of BGA devices requires precise control and is usually done by automated processes. BGA devices are not suitable for socket mounting, normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", "Why is it necessary to replace the north bridge, replace the south bridge, replace the video chip?For starters,you should explain what a chip is.BGA(Ball grid array) - this is the type of the chassis(chip), the outputs of which are balls of solder, located on the reverse side of the chip on the contact platform.This chip is installed on the motherboard using an infrared soldering station. As a rule, the laptop uses the following chips: north bridge, south bridge, video chip. Each of these chips performs its specific functions and is responsible for individual parts of the motherboard. Southbridge is a BGA chip that provides communication between the motherboard and its components and functions as an input and output concentrator.In other words, the south bridge functionally includes: an SMBus bus controller, a PCI or PCI - Express controller, a DMA controller, a SATA, a power management controller, a USB controller." });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Image", "Name", "Subtitle", "Text" },
                values: new object[] { 2, "article-2.jpg", "Calibrating the Home button in iPhone, iPad and iPod touch", "Over time, most owners of iOS-devices can have a small, but rather unpleasant problem with the Home button, which starts responding to the presses through time. Usually this does not happen immediately, but after about 1.5-2 years from the date of purchase.pins than can be put on a dual in-line or flat package. The whole bottom surface of the device can be used, instead of just the perimeter. The leads are also on average shorter than with a perimeter-only type, leading to better performance at high speeds. Soldering of BGA devices requires precise control and is usually done by automated processes. BGA devices are not suitable for socket mounting.normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", "Why is it necessary to replace the north bridge, replace the south bridge, replace the video chip?For starters,you should explain what a chip is.BGA(Ball grid array) - this is the type of the chassis(chip), the outputs of which are balls of solder,located on the reverse side of the chip on the contact platform.This chip is installed on the motherboard using an infrared soldering station.As a rule, the laptop uses the following chips: north bridge, south bridge, video chip. Each of these chips performs its specific functions and is responsible for individual parts of the motherboard.Southbridge is a BGA chip that provides communication between the motherboard and its components and functions as an input and output concentrator.In other words, the south bridge functionally includes: an SMBus bus controller, a PCI or PCI - Express controller, a DMA controller, a SATA, a power management controller, a USB controller" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Image", "Name", "Subtitle", "Text" },
                values: new object[] { 3, "article-3.jpg", "Replace videochip", "Over time, most owners of iOS-devices can have a small, but rather unpleasant problem with the Home button, which starts responding to the presses through time. Usually this does not happen immediately, but after about 1.5-2 years from the date of purchase.pins than can be put on a dual in-line or flat package. The whole bottom surface of the device can be used, instead of just the perimeter. The leads are also on average shorter than with a perimeter-only type, leading to better performance at high speeds. Soldering of BGA devices requires precise control and is usually done by automated processes. BGA devices are not suitable for socket mounting.normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English", "For starters, you should explain what a chip is. BGA (Ball grid array) - this is the type of the chassis (chip), the outputs of which are balls of solder, located on the reverse side of the chip on the contact platform. This chip is installed on the motherboard using an infrared soldering station.As a rule,the laptop uses the following chips: north bridge,south bridge, video chip.Each of these chips performs its specific functions and is responsible for individual parts of the motherboard.Southbridge is a BGA chip that provides communication between the motherboard and its components and functions as an input and output concentrator.In other words, the south bridge functionally includes: an SMBus bus controller, a PCI or PCI - Express controller, a DMA controller, a SATA, a power management controller, a USB controlle" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
