using Ecommerce.Product.CrossCutting.Entity;

namespace Ecommerce.Product.Domain.Entity.Product
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductInventoryId { get; set; }
        public double Price { get; set; }
    }
}
