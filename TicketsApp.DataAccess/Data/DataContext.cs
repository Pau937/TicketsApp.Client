using Microsoft.EntityFrameworkCore;
using TicketsApp.Core.Models;

namespace TicketsApp.DataAccess
{
    public class DataContext : DbContext
    {
        public DbSet<Ticket> Tickets {get; set;}

        public DataContext(DbContextOptions options) : base(options) { }
    }
}
