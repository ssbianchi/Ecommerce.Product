using Ecommerce.Product.CrossCutting.Entity;

namespace Ecommerce.Product.Domain.Entity.ProductType
{
    public class ProductType : Entity<int>
    {
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}
