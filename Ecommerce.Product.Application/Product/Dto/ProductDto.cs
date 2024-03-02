using Ecommerce.Product.CrossCutting.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.Application.Product.Dto
{
    public class ProductDto : OperationEntity<int>
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int ProductTypeId { get; set; }
        public double Price { get; set; }
        public int Qtd { get; set; }
    }
}
