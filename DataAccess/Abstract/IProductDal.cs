using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // product ile veri tabanında yapacağım operasyonları içeren interface
    public interface IProductDal:IEntityRepository<Product> //jenerik yapı. 
    {
        List<ProductDetailDto> GetProductDetails();  
    }
}
