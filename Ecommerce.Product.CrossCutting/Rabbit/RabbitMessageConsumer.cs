using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.CrossCutting.Rabbit
{
    public class RabbitMessageConsumer
    {
        public int ProductId { get; set; }
        public int Qtd { get; set; }
    }
}
