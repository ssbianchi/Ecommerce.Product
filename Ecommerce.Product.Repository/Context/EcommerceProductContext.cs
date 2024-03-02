using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Product.Repository.Context
{
    public class EcommerceProductContext : DbContext
    {
        public EcommerceProductContext(DbContextOptions<EcommerceProductContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EcommerceProductContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ILoggerFactory logger = LoggerFactory.Create(c => c.AddConsole());
            // optionsBuilder.UseLoggerFactory(logger);

            base.OnConfiguring(optionsBuilder);
        }

    }
}

