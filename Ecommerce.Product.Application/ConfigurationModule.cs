using Ecommerce.Product.Application.Product;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Product.Application
{
    public static class ConfigurationModule
    {
        public static void RegisterApplication(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(ConfigurationModule).Assembly);

            service.AddScoped<IProductService, ProductService>();
        }
    }
}