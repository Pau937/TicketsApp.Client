using Microsoft.EntityFrameworkCore;
using TicketsApp.Core.Models;

namespace TicketsApp.DataAccess.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Ticket> Tickets {get; set;}

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
                
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = 1,
                    Name = "Bring Me The Horizon 2022",
                    Description = "Awesome event!",
                    ReturnDate = new System.DateTime(2022, 01, 31)
                },
                new Ticket
                {
                    Id = 2,
                    Name = "In Flames 2022 + support",
                    Description = "Promoting new album!",
                    ReturnDate = new System.DateTime(2022, 07, 31)
                },
                new Ticket
                {
                    Id = 3,
                    Name = "Soilwork 2021",
                    Description = "Back in Poland!",
                    ReturnDate = new System.DateTime(2021, 11, 30)
                }
            );
        }
    }
}
