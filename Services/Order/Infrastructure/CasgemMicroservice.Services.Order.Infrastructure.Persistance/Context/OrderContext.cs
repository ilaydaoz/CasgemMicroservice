using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CasgemMicroservice.Services.Order.Infrastructure.Persistance.Context
{
    public class OrderContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost, 1433; database = CasgemOrderDb; user=sa; password =123456Aa*");
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ordering> Orderings { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
