using Ecommerce.Product.Domain.Entity.ProductType;
using Ecommerce.Product.Domain.Entity.ProductType.Repository;
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