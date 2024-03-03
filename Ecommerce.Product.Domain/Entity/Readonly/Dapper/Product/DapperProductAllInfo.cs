using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.Domain.Entity.Readonly.Dapper.Product
{
    public class DapperProductAllInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }
        public string ProductTypeName { get; set; }
        public int Qtd { get; set; }
        public double Price { get; set; }
    }
}
