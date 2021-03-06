﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
