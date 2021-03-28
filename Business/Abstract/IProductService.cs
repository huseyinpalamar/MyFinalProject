﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
    
}
