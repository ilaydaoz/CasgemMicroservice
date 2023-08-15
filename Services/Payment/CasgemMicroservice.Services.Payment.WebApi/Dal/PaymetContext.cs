using Microsoft.EntityFrameworkCore;

namespace CasgemMicroservice.Services.Payment.WebApi.Dal
{
    public class PaymetContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost, 1433; database = CasgemPaymetDb; user=sa; password =123456Aa*");
        }
        public DbSet<PaymetDetail> PaymetDetails { get; set; }
    }
}
