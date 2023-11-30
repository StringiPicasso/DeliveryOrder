using DeliveryOrder.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryOrder.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Delivery> Deliveries { get; set; }
    }
}
