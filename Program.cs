using System;
using System.Collections.Generic;
using Exec_Fixação_Herança_Polimorf.Entities;
namespace Exec_Fixação_Herança_Polimorf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int num = Convert.ToInt32(Console.ReadLine());

            List<Product> prod = new List<Product>(); 
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char type = Convert.ToChar(Console.ReadLine());

                switch (type)
                {
                    case 'c':
                        Console.Write("Name: ");
                        string name_c = Console.ReadLine();
                        Console.Write("Price: ");
                        double pri_c = Convert.ToDouble(Console.ReadLine());
                        prod.Add(new Product(name_c,pri_c));
                        break;
                    case 'u':
                        Console.Write("Name: ");
                        string name_u = Console.ReadLine();
                        Console.Write("Price: ");
                        double pri_u= Convert.ToDouble(Console.ReadLine());
                        Console.Write("Manufactore date (DD/MM/YYYY): ");
                        DateTime dt_u= Convert.ToDateTime(Console.ReadLine());
                        prod.Add(new UsedProduct(name_u, pri_u, dt_u)); 
                        break;
                    case 'i':
                        Console.Write("Name: ");
                        string name_i = Console.ReadLine();
                        Console.Write("Price: ");
                        double pri_i = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Customs fee: ");
                        double fee = Convert.ToDouble(Console.ReadLine());
                        prod.Add(new ImportedProduct(name_i, pri_i, fee));
                        break;
                    default:
                        Console.WriteLine("Inválido");
                        break;
                }

            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product item in prod)
            {
                Console.WriteLine(item.priceTag());
            }
        }
    }
}
