using Ecommerce.Product.Domain.Entity.Product.Repository;
using Ecommerce.Product.Repository.Context;

namespace Ecommerce.Product.Repository.Repository
{
    public class ProductRepository : UnitOfWork<Ecommerce.Product.Domain.Entity.Product.Product>, IProductRepository
    {
        public ProductRepository(EcommerceProductContext context) : base(context)
        {
        }
    }
}
