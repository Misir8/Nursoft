﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nursoft.DAL;

namespace Nursoft.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200324121621_Product")]
    partial class Product
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nursoft.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The most comprehensive repairs available at Profix. Any device, mobile, tablet or laptop can be repaired or upgraded by us, learn more about us and see why we are the best choice for device repairs and upgrades.",
                            Image = "measurements.jpg"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.CategoryProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("CategoryProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mouse"
                        },
                        new
                        {
                            Id = 2,
                            Name = "USB"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Adapter"
                        },
                        new
                        {
                            Id = 4,
                            Name = "SSD"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Nursoft.Models.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ContactUses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Sumqayit seheri 5 mkr",
                            Email = "example@gmail.com",
                            Phone = "+994-50-555-55-55"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Features");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Qualified Workers Lorem Ipsum is simply dummy text of the printi",
                            Name = "WE ARE FAST"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Repair on Demand Lorem Ipsum is simply dummy text of the printing",
                            Name = "NO FIX, NO FEE"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Guaranteed Service Lorem Ipsum is simply dummy text of the printing",
                            Name = "30 DAYS WARRANTY"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Available Anytime Lorem Ipsum is simply dummy text of the printing",
                            Name = "EXPERT STAFF"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.MapContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lat")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Lng")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("MapContacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Lat = "40.5808780081475",
                            Lng = "49.6863716840744"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Subtitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "article-1.jpg",
                            Name = "What is BGA",
                            Subtitle = "A ball grid array (BGA) is a type of surface-mount packaging (a chip carrier) used for integrated circuits. BGA packages are used to permanently mount devices such as microprocessors. A BGA can provide more interc... pins than can be put on a dual in-line or flat package. The whole bottom surface of the device can be used, instead of just the perimeter. The leads are also on average shorter than with a perimeter-only type, leading to better performance at high speeds. Soldering of BGA devices requires precise control and is usually done by automated processes. BGA devices are not suitable for socket mounting, normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Text = "Why is it necessary to replace the north bridge, replace the south bridge, replace the video chip?For starters,you should explain what a chip is.BGA(Ball grid array) - this is the type of the chassis(chip), the outputs of which are balls of solder, located on the reverse side of the chip on the contact platform.This chip is installed on the motherboard using an infrared soldering station. As a rule, the laptop uses the following chips: north bridge, south bridge, video chip. Each of these chips performs its specific functions and is responsible for individual parts of the motherboard. Southbridge is a BGA chip that provides communication between the motherboard and its components and functions as an input and output concentrator.In other words, the south bridge functionally includes: an SMBus bus controller, a PCI or PCI - Express controller, a DMA controller, a SATA, a power management controller, a USB controller."
                        },
                        new
                        {
                            Id = 2,
                            Image = "article-2.jpg",
                            Name = "Calibrating the Home button in iPhone, iPad and iPod touch",
                            Subtitle = "Over time, most owners of iOS-devices can have a small, but rather unpleasant problem with the Home button, which starts responding to the presses through time. Usually this does not happen immediately, but after about 1.5-2 years from the date of purchase.pins than can be put on a dual in-line or flat package. The whole bottom surface of the device can be used, instead of just the perimeter. The leads are also on average shorter than with a perimeter-only type, leading to better performance at high speeds. Soldering of BGA devices requires precise control and is usually done by automated processes. BGA devices are not suitable for socket mounting.normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Text = "Why is it necessary to replace the north bridge, replace the south bridge, replace the video chip?For starters,you should explain what a chip is.BGA(Ball grid array) - this is the type of the chassis(chip), the outputs of which are balls of solder,located on the reverse side of the chip on the contact platform.This chip is installed on the motherboard using an infrared soldering station.As a rule, the laptop uses the following chips: north bridge, south bridge, video chip. Each of these chips performs its specific functions and is responsible for individual parts of the motherboard.Southbridge is a BGA chip that provides communication between the motherboard and its components and functions as an input and output concentrator.In other words, the south bridge functionally includes: an SMBus bus controller, a PCI or PCI - Express controller, a DMA controller, a SATA, a power management controller, a USB controller"
                        },
                        new
                        {
                            Id = 3,
                            Image = "article-3.jpg",
                            Name = "Replace videochip",
                            Subtitle = "Over time, most owners of iOS-devices can have a small, but rather unpleasant problem with the Home button, which starts responding to the presses through time. Usually this does not happen immediately, but after about 1.5-2 years from the date of purchase.pins than can be put on a dual in-line or flat package. The whole bottom surface of the device can be used, instead of just the perimeter. The leads are also on average shorter than with a perimeter-only type, leading to better performance at high speeds. Soldering of BGA devices requires precise control and is usually done by automated processes. BGA devices are not suitable for socket mounting.normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English",
                            Text = "For starters, you should explain what a chip is. BGA (Ball grid array) - this is the type of the chassis (chip), the outputs of which are balls of solder, located on the reverse side of the chip on the contact platform. This chip is installed on the motherboard using an infrared soldering station.As a rule,the laptop uses the following chips: north bridge,south bridge, video chip.Each of these chips performs its specific functions and is responsible for individual parts of the motherboard.Southbridge is a BGA chip that provides communication between the motherboard and its components and functions as an input and output concentrator.In other words, the south bridge functionally includes: an SMBus bus controller, a PCI or PCI - Express controller, a DMA controller, a SATA, a power management controller, a USB controlle"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryProductId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CategoryProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryProductId = 1,
                            Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box",
                            Image = "mouse.jpg",
                            Name = "GAMERS MOUSE"
                        },
                        new
                        {
                            Id = 2,
                            CategoryProductId = 2,
                            Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box",
                            Image = "usb-hub.jpg",
                            Name = "USB 3.0 HUB"
                        },
                        new
                        {
                            Id = 3,
                            CategoryProductId = 3,
                            Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box",
                            Image = "laptop-ac-power-adapter.jpg",
                            Name = "LAPTOP POWER ADAPTER"
                        },
                        new
                        {
                            Id = 4,
                            CategoryProductId = 3,
                            Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box",
                            Image = "wifi-router.jpg",
                            Name = "WI-FI ROUTER REPIETER"
                        },
                        new
                        {
                            Id = 5,
                            CategoryProductId = 2,
                            Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box",
                            Image = "cable-organizer.jpg",
                            Name = "CABLE ORGANIZER"
                        },
                        new
                        {
                            Id = 6,
                            CategoryProductId = 4,
                            Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box",
                            Image = "126gb-ssd.jpg",
                            Name = "128GB SSD M.2"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.Repair", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Repairs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "starting at...",
                            Image = "notebook-dark.png",
                            Name = "Laptop Repair"
                        },
                        new
                        {
                            Id = 2,
                            Description = "starting at...",
                            Image = "computer-dark.png",
                            Name = "Computer Repair"
                        },
                        new
                        {
                            Id = 3,
                            Description = "starting at...",
                            Image = "printer-dark.png",
                            Name = "Printer Repair"
                        },
                        new
                        {
                            Id = 4,
                            Description = "starting at...",
                            Image = "mobile-dark.png",
                            Name = "Smartphone Repair"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                            Image = "item-1.jpg",
                            Name = "Data backup &amp; recovery"
                        },
                        new
                        {
                            Id = 2,
                            Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                            Image = "item-2.jpg",
                            Name = "Laptop &amp; Mac Upgrade"
                        },
                        new
                        {
                            Id = 3,
                            Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                            Image = "item-3.jpg",
                            Name = "Data backup &amp; recovery"
                        },
                        new
                        {
                            Id = 4,
                            Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                            Image = "item-4.jpg",
                            Name = "Data backup &amp; recovery"
                        },
                        new
                        {
                            Id = 5,
                            Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                            Image = "item-5.jpg",
                            Name = "Data backup &amp; recovery"
                        },
                        new
                        {
                            Id = 6,
                            Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                            Image = "item-6.jpg",
                            Name = "Data backup &amp; recovery"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "motherboard-1.jpg",
                            Subtitle = "Just send valuable laptop, PC, MAC, Mobile,<br>Gaming Device or Smartphone and we'll take care of it.",
                            Title = "Fast & Quick Fix"
                        },
                        new
                        {
                            Id = 2,
                            Image = "motherboard-3.jpg",
                            Title = "Any Kind of Upgrades"
                        },
                        new
                        {
                            Id = 3,
                            Image = "data-recovery.jpg",
                            Subtitle = "You Lose - We'll Find",
                            Title = "Data Recovery"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "member-1.jpg",
                            Name = "John Doe",
                            Position = "CEO & Founder"
                        },
                        new
                        {
                            Id = 2,
                            Image = "member-2.jpg",
                            Name = "Bryan Lewis",
                            Position = "Cheif Engineer"
                        },
                        new
                        {
                            Id = 3,
                            Image = "member-3.jpg",
                            Name = "David Hanson",
                            Position = "Technical Manager"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.Testimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Testimonials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Thanks John, I was really pleased with Profix’s service. Would definitely recommend you and have alredy given out some of your business cards that were left with me. All the best for future succes.",
                            Image = "notebook-sm.png",
                            Name = "Michale John",
                            Position = "Co-Founder, InfoLabs"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Profix did great job with fixing my laptop for a good price. I recommend any body with laptop problems, they will give you excellent service to all his customers.",
                            Image = "computer-sm.png",
                            Name = "Merry Smith",
                            Position = "CFO, InfoTech"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Keep up the excellent work. Thank you so much for your help. This is simply unbelievable!",
                            Image = "mobile-sm.png",
                            Name = "Merry Doe",
                            Position = "CFO, InfoTech"
                        });
                });

            modelBuilder.Entity("Nursoft.Models.Product", b =>
                {
                    b.HasOne("Nursoft.Models.CategoryProduct", "CategoryProduct")
                        .WithMany("Products")
                        .HasForeignKey("CategoryProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}