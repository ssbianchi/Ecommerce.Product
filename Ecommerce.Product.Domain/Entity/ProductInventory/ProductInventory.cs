using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.Domain.Entity.ProductInventory
{
    public class ProductInventory : Entity<int>
    {
        public int Qtd { get; set; }
    }
}
