using Ecommerce.Product.Domain.Entity.ProductInventory;
using Ecommerce.Product.Repository.Context;

namespace Ecommerce.Product.Repository.Repository
{
    public class ProductInventoryRepository : UnitOfWork<ProductInventory>, Ecommerce.Product.Domain.Entity.ProductInventory.Repository.IProductInvestoryRepository
    {
        public ProductInventoryRepository(EcommerceProductContext context) : base(context)
        {
        }
    }
}
