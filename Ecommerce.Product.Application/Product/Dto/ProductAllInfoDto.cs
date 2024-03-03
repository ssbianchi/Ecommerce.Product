using Ecommerce.Product.CrossCutting.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.Application.Product.Dto
{
    public class ProductAllInfoDto : Entity<int>
    {
        public string Name { get; set; }
        public string Descricao { get; set; }
        public string ProductTypeName { get; set; }
        public int Qtd { get; set; }
        public double Price { get; set; }
    }
}
