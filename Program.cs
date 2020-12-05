using System;
using Exec_Fixação_Herança_Polimorf.Entities;
namespace Exec_Fixação_Herança_Polimorf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char type = Convert.ToChar(Console.ReadLine());

                switch (type)
                {
                    case 'c':
                        Console.Write("Name: ");
                        string name_c = Console.ReadLine();
                        Console.Write("Price: ");
                        double pri_c = Convert.ToDouble(Console.ReadLine());
                        Product prod_c = new Product(name_c,pri_c);
                        break;
                    case 'u':
                        Console.Write("Name: ");
                        string name_u = Console.ReadLine();
                        Console.Write("Price: ");
                        double pri_u= Convert.ToDouble(Console.ReadLine());
                        Console.Write("Manufactore date (DD/MM/YYYY): ");
                        DateTime dt_u= Convert.ToDateTime(Console.ReadLine());
                        Product prod_u = new UsedProduct(name_u, pri_u, dt_u); 
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
