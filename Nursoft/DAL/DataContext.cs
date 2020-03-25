using Microsoft.EntityFrameworkCore;
using Nursoft.Models;

namespace Nursoft.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<MapContact> MapContacts { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasData(
                new Slider
                {
                    Id = 1,
                    Title = "Fast & Quick Fix",
                    Subtitle = "Just send valuable laptop, PC, MAC, Mobile,<br>Gaming Device or Smartphone and we'll take care of it.",
                    Image = "motherboard-1.jpg"
                },
                new Slider
                {
                    Id = 2,
                    Title = "Any Kind of Upgrades",
                    Image = "motherboard-3.jpg"
                },
                new Slider
                {
                    Id = 3,
                    Title = "Data Recovery",
                    Subtitle = "You Lose - We'll Find",
                    Image = "data-recovery.jpg"
                }
            );

            modelBuilder.Entity<Repair>().HasData(
                new Repair
                {
                    Id = 1,
                    Name = "Laptop Repair",
                    Description = "starting at...",
                    Image = "notebook-dark.png"
                },
                new Repair
                {
                    Id = 2,
                    Name = "Computer Repair",
                    Description = "starting at...",
                    Image = "computer-dark.png"
                },
                new Repair
                {
                    Id = 3,
                    Name = "Printer Repair",
                    Description = "starting at...",
                    Image = "printer-dark.png"
                },
                new Repair
                {
                    Id = 4,
                    Name = "Smartphone Repair",
                    Description = "starting at...",
                    Image = "mobile-dark.png"
                }
            );
            modelBuilder.Entity<Feature>().HasData(
                new Feature{Id = 1, Name = "WE ARE FAST", Description = "Qualified Workers Lorem Ipsum is simply dummy text of the printi"},
                new Feature{Id = 2, Name = "NO FIX, NO FEE", Description = "Repair on Demand Lorem Ipsum is simply dummy text of the printing"},
                new Feature{Id = 3, Name = "30 DAYS WARRANTY", Description = "Guaranteed Service Lorem Ipsum is simply dummy text of the printing"},
                new Feature{Id = 4, Name = "EXPERT STAFF", Description = "Available Anytime Lorem Ipsum is simply dummy text of the printing"}
            );

            modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    Id = 1,
                    Name = "Data backup &amp; recovery",
                    Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                    Image = "item-1.jpg"
                },
                new Service
                {
                    Id = 2,
                    Name = "Laptop &amp; Mac Upgrade",
                    Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                    Image = "item-2.jpg"
                },
                new Service
                {
                    Id = 3,
                    Name = "Data backup &amp; recovery",
                    Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                    Image = "item-3.jpg"
                },
                new Service
                {
                    Id = 4,
                    Name = "Data backup &amp; recovery",
                    Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                    Image = "item-4.jpg"
                },
                new Service
                {
                    Id = 5,
                    Name = "Data backup &amp; recovery",
                    Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                    Image = "item-5.jpg"
                },
                new Service
                {
                    Id = 6,
                    Name = "Data backup &amp; recovery",
                    Description = "We working hard to build a reputation of customer satisfaction through technical excellence and friendly staff",
                    Image = "item-6.jpg"
                }
            );

            modelBuilder.Entity<Testimonial>().HasData(
                new Testimonial
                {
                    Id = 1,
                    Name = "Michale John",
                    Description = "Thanks John, I was really pleased with Profix’s service. Would definitely recommend you and have alredy given out some of your business cards that were left with me. All the best for future succes.",
                    Position = "Co-Founder, InfoLabs",
                    Image = "notebook-sm.png"
                },
                new Testimonial
                {
                    Id = 2,
                    Name = "Merry Smith",
                    Description = "Profix did great job with fixing my laptop for a good price. I recommend any body with laptop problems, they will give you excellent service to all his customers.",
                    Position = "CFO, InfoTech",
                    Image = "computer-sm.png"
                },
                new Testimonial
                {
                    Id = 3,
                    Name = "Merry Doe",
                    Description = "Keep up the excellent work. Thank you so much for your help. This is simply unbelievable!",
                    Position = "CFO, InfoTech",
                    Image = "mobile-sm.png"
                }
            );

            modelBuilder.Entity<ContactUs>().HasData(
                new ContactUs{Id = 1, Address = "Sumqayit seheri 5 mkr", Email = "example@gmail.com", Phone = "+994-50-555-55-55"}
            );

            modelBuilder.Entity<About>().HasData(
                new About
                {
                    Id = 1,
                    Description = "The most comprehensive repairs available at Profix. Any device, mobile, tablet or laptop can be repaired or upgraded by us, learn more about us and see why we are the best choice for device repairs and upgrades.",
                    Image = "measurements.jpg"
                    
                }
            );

            modelBuilder.Entity<Team>().HasData(
                new Team {Id = 1, Name = "John Doe", Position = "CEO & Founder", Image = "member-1.jpg"},
                new Team {Id = 2, Name = "Bryan Lewis", Position = "Cheif Engineer", Image = "member-2.jpg"},
                new Team {Id = 3, Name = "David Hanson", Position = "Technical Manager", Image = "member-3.jpg"}
                
            );

            modelBuilder.Entity<News>().HasData(
                new News { Id = 1, Name = "What is BGA", Subtitle = "A ball grid array (BGA) is a type of surface-mount packaging (a chip carrier) used for integrated circuits. BGA packages are used to permanently mount devices such as microprocessors. A BGA can provide more interc... pins than can be put on a dual in-line or flat package. The whole bottom surface of the device can be used, instead of just the perimeter. The leads are also on average shorter than with a perimeter-only type, leading to better performance at high speeds. Soldering of BGA devices requires precise control and is usually done by automated processes. BGA devices are not suitable for socket mounting, normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Text = "Why is it necessary to replace the north bridge, replace the south bridge, replace the video chip?For starters,you should explain what a chip is.BGA(Ball grid array) - this is the type of the chassis(chip), the outputs of which are balls of solder, located on the reverse side of the chip on the contact platform.This chip is installed on the motherboard using an infrared soldering station. As a rule, the laptop uses the following chips: north bridge, south bridge, video chip. Each of these chips performs its specific functions and is responsible for individual parts of the motherboard. Southbridge is a BGA chip that provides communication between the motherboard and its components and functions as an input and output concentrator.In other words, the south bridge functionally includes: an SMBus bus controller, a PCI or PCI - Express controller, a DMA controller, a SATA, a power management controller, a USB controller.", Image = "article-1.jpg" },
                new News { Id = 2, Name = "Calibrating the Home button in iPhone, iPad and iPod touch", Subtitle = "Over time, most owners of iOS-devices can have a small, but rather unpleasant problem with the Home button, which starts responding to the presses through time. Usually this does not happen immediately, but after about 1.5-2 years from the date of purchase.pins than can be put on a dual in-line or flat package. The whole bottom surface of the device can be used, instead of just the perimeter. The leads are also on average shorter than with a perimeter-only type, leading to better performance at high speeds. Soldering of BGA devices requires precise control and is usually done by automated processes. BGA devices are not suitable for socket mounting.normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Text = "Why is it necessary to replace the north bridge, replace the south bridge, replace the video chip?For starters,you should explain what a chip is.BGA(Ball grid array) - this is the type of the chassis(chip), the outputs of which are balls of solder,located on the reverse side of the chip on the contact platform.This chip is installed on the motherboard using an infrared soldering station.As a rule, the laptop uses the following chips: north bridge, south bridge, video chip. Each of these chips performs its specific functions and is responsible for individual parts of the motherboard.Southbridge is a BGA chip that provides communication between the motherboard and its components and functions as an input and output concentrator.In other words, the south bridge functionally includes: an SMBus bus controller, a PCI or PCI - Express controller, a DMA controller, a SATA, a power management controller, a USB controller", Image = "article-2.jpg" },
                new News { Id = 3, Name = "Replace videochip", Subtitle = "Over time, most owners of iOS-devices can have a small, but rather unpleasant problem with the Home button, which starts responding to the presses through time. Usually this does not happen immediately, but after about 1.5-2 years from the date of purchase.pins than can be put on a dual in-line or flat package. The whole bottom surface of the device can be used, instead of just the perimeter. The leads are also on average shorter than with a perimeter-only type, leading to better performance at high speeds. Soldering of BGA devices requires precise control and is usually done by automated processes. BGA devices are not suitable for socket mounting.normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English", Text = "For starters, you should explain what a chip is. BGA (Ball grid array) - this is the type of the chassis (chip), the outputs of which are balls of solder, located on the reverse side of the chip on the contact platform. This chip is installed on the motherboard using an infrared soldering station.As a rule,the laptop uses the following chips: north bridge,south bridge, video chip.Each of these chips performs its specific functions and is responsible for individual parts of the motherboard.Southbridge is a BGA chip that provides communication between the motherboard and its components and functions as an input and output concentrator.In other words, the south bridge functionally includes: an SMBus bus controller, a PCI or PCI - Express controller, a DMA controller, a SATA, a power management controller, a USB controlle", Image = "article-3.jpg" }
            );

            modelBuilder.Entity<MapContact>().HasData(
                new MapContact{Id = 1, Lat = "40.5808780081475", Lng = "49.6863716840744"}
            );

            modelBuilder.Entity<CategoryProduct>().HasData(
                new CategoryProduct{Id = 1, Name = "Mouse"},
                new CategoryProduct{Id = 2, Name = "USB"}, 
                new CategoryProduct{Id = 3, Name = "Adapter"},
                new CategoryProduct{Id = 4, Name = "SSD"}
            );

            modelBuilder.Entity<Product>().HasData(
                new Product{Id = 1, Name = "GAMERS MOUSE", CategoryProductId = 1, Image = "mouse.jpg", Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box", },
                new Product{Id = 2, Name = "USB 3.0 HUB", CategoryProductId = 2, Image = "usb-hub.jpg", Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box"},
                new Product{Id = 3, Name = "LAPTOP POWER ADAPTER", CategoryProductId = 3, Image = "laptop-ac-power-adapter.jpg", Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box"},
                new Product{Id = 4, Name = "WI-FI ROUTER REPIETER", CategoryProductId = 3, Image = "wifi-router.jpg", Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box"},
                new Product{Id = 5, Name = "CABLE ORGANIZER", CategoryProductId = 2, Image = "cable-organizer.jpg", Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box"},
                new Product{Id = 6, Name = "128GB SSD M.2", CategoryProductId = 4, Image = "126gb-ssd.jpg", Description = "13.7 inch USB extension cable extension perfect for travel USB hub / Adds 4 USB 3.0 ports to your computer / Backward compatible with USB 2.0 and 1.1 specifications Ready Out-of-Box"}

            );
        }
    }
}