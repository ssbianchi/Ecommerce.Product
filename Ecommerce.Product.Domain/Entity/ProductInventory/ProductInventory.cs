using Ecommerce.Product.CrossCutting.Entity;

namespace Ecommerce.Product.Domain.Entity.ProductInventory
{
    public class ProductInventory : Entity<int>
    {
        public int Qtd { get; set; }
    }
}
