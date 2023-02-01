using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Address> Address { get; set; }
    }
}
