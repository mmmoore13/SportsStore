﻿using System.Collections.Generic;
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        }.AsQueryable<Product>();
    }
}