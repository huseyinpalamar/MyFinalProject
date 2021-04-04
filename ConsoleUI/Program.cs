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
            ProductTest();
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

        private static void ProductTest()
        {
            ProdcutManager prodcutManager = new ProdcutManager(new EfProductDal());

            var result = prodcutManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "----------Kategori----" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
           
        }
    }
}
