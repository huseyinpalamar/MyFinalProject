using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdcutManager prodcutManager = new ProdcutManager(new EfProductDal());

            foreach (var product in prodcutManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName+":"+product.CategoryId);
            }
        }
    }
}
