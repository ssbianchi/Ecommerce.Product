using Ecommerce.Product.Repository.Context;

namespace Ecommerce.Product.Repository.Repository
{
    public class ProductInventoryRepository : UnitOfWork<ProductInventory>, IProductInventoryRepository
    {
        public ProductRepository(EcommerceProductContext context) : base(context)
        {
        }
    }
}
