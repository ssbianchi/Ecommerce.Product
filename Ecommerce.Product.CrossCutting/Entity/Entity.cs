﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.CrossCutting.Entity
{
    public abstract class Entity<T>
    {
        public virtual T Id { get; set; }
    }
}
