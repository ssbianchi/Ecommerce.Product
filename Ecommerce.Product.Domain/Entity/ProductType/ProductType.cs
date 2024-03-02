using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.Domain.Entity.ProductType
{
    public class ProductType : Entity<int>
    {
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}
