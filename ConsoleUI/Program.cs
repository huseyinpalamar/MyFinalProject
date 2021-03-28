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
            //ProductTes();
            //OrderTest();
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void OrderTest()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());

            foreach (var order in orderManager.GetAll())
            {
                Console.WriteLine(order.OrderDate);
            }
        }

        private static void ProductTes()
        {
            ProdcutManager prodcutManager = new ProdcutManager(new EfProductDal());

            prodcutManager.Add(new Entities.Concrete.Product { ProductName = "asasdsa", CategoryId = 2, UnitPrice = 100, UnitsInStock = 40 });
            prodcutManager.Delete(new Entities.Concrete.Product { ProductId = 78 });
            foreach (var product in prodcutManager.GetAll())
            {
                Console.WriteLine(product.ProductName + ":" + product.CategoryId);
            }
        }
    }
}
