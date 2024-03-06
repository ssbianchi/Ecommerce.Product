using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.Rabbit.Consumer.WebApi.Product
{
    public interface IProductAPI
    {
        Task<bool> UpdateProduct(int productId, int qtd);
    }
}
