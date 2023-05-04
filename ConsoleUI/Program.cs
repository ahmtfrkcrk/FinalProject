using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //S"O"LID
        //Open Closed Principle 
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAllByCategoryId(3))
            {
                Console.WriteLine(product.ProductName);
            }

            foreach (var product2 in productManager.GetByUnitPrice(18,21))
            {
                Console.WriteLine("{0}======{1}",product2.ProductName,product2.UnitPrice);
            }

            Console.ReadLine();
        }
    }
}
