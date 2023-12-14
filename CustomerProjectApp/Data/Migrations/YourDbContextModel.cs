using CustomerProjectApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerProjectApp.Data.Migrations
{
    public class YourDbContextModel : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
