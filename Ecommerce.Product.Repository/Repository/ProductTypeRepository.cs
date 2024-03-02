using Ecommerce.Product.Repository.Context;

namespace Ecommerce.Product.Repository.Repository
{
    public class ProductTypeRepository : UnitOfWork<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(EcommerceProductContext context) : base(context)
        {
        }
    }
}