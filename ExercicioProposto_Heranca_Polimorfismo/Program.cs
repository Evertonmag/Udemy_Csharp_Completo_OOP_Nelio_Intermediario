using ExercicioProposto_Heranca_Polimorfismo.Entities;
using System;
using System.Globalization;

namespace ExercicioProposto_Heranca_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter  the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or Imported (c / u / i)? ");
                char resp = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (resp == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                    products.Add(new Product(name, price));
            }

            Console.WriteLine("\nPrice Tags");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
