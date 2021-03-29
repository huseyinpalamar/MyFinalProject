using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
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

        public void Add(Product product)
        {
            if (product.ProductName.Length>2&&product.UnitPrice>0)
            {
                _productDal.Add(product);
            }
            else
            {
                Console.WriteLine("Eklenemedi!!");
            }
           
        }

        public void Delete(Product product)
        {


            Console.WriteLine("Silme Başarılı");
                
            
           
        }

        public List<Product> GetAll()
        {
            // iş kodlarını buraya yazıcaz 
            return _productDal.GetAll();
        }

        public Product GetAllByCategoryId(int id)
        {
            return _productDal.Get(p=>p.CategoryId==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
