using Ecommerce.Product.Domain.Entity.Product.Repository;
using Ecommerce.Product.Domain.Entity.ProductInventory.Repository;
using Ecommerce.Product.Domain.Entity.ProductType.Repository;
using Ecommerce.Product.Domain.Entity.Readonly.Repository;
using Ecommerce.Product.Repository.Context;
using Ecommerce.Product.Repository.Repository;
using Ecommerce.Product.Repository.Repository.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Product.Repository
{
    public static class ConfigurationModule
    {
        public static void RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EcommerceProductContext>(c =>
            {
                connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ecommerce_Product;Trusted_Connection=True;";
                c.UseSqlServer(connectionString);
            });

            //Use for Dapper
            services.Configure<ConnectionStringOptions>(c =>
            {
                c.ConnectionString = connectionString;
            });

            services.AddScoped<IReadonlyRepository, ReadonlyRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
            services.AddScoped<IProductInvestoryRepository, ProductInventoryRepository>();

        }

    }
}