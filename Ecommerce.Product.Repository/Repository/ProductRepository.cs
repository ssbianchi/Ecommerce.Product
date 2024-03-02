using Ecommerce.Product.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.Repository.Repository
{
    public class ProductRepository : UnitOfWork<Product>, IProductRepository
    {
        public ProductRepository(EcommerceProductContext context) : base(context)
        {
        }
    }
}
