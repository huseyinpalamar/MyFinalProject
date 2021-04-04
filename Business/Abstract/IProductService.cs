using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product>GetById (int productId);
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice (decimal min, decimal max);
        IResult Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
    
}
