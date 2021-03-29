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
            ProductTes();
            //OrderTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
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

            
            foreach (var product in prodcutManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "----------Kategori----" + product.CategoryName);
            }
        }
    }
}
