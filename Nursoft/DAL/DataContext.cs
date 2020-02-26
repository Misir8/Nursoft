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
        }
    }
}