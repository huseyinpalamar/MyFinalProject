using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProdcutManager : IProductService
    {
        IProductDal _productDal;

        public ProdcutManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
           


            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
           
        }

        public IDataResult<List<Product>> GetAll()
        {
            //// iş kodlarını buraya yazıcaz 
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Product>>(Messages.ProductListingFailed);
            }
            return new SuccessDataResult<List<Product>>( _productDal.GetAll(),Messages.ProductListingSuccessful);
        }

        public IDataResult<List<Product>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.CategoryId==categoryId));
              
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=>p.ProductId==productId));       
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            if (DateTime.Now.Hour == 10)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.ProductListingFailed);
            }
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(), Messages.ProductListingSuccessful);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult();
        }
    }
}
