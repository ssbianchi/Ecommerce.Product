using Ecommerce.Product.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.Repository
{
    public static class ConfigurationModule
    {
        public static void RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EcommerceContext>(c =>
            {
                connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Ecommerce_Product;Trusted_Connection=True;";
                c.UseSqlServer(connectionString);
            });

            //Use for Dapper
            //services.Configure<ConnectionStringOptions>(c =>
            //{
            //    c.ConnectionString = connectionString;
            //});

            //services.AddScoped<IReadonlyRepository, ReadonlyRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
            services.AddScoped<IProductInventoryRepository, ProductInventoryRepository>();

        }

    }
}