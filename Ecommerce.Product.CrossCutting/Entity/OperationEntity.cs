using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.CrossCutting.Entity
{
    public abstract class OperationEntity<T> : Entity<T>
    {
        [NotMapped]
        public virtual int? OperationId { get; set; }
    }
}
