using ExercicioProposto.Entities;
using ExercicioProposto.Entities.Enums;
using System.Globalization;

namespace ExercicioProposto;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter client data: ");
        Console.Write("Nome: ");
        string clientName = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime birth = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter order data: ");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        Client client = new Client(clientName, email, birth);
        Order order = new Order(DateTime.Now, status, client);

        Console.Write("How many items to this order? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter #{i} item data:");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();
            Console.Write("Product Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product = new Product(productName, price);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            OrderItem orderItem = new OrderItem(quantity, price, product);

            order.AddItem(orderItem);
        }

        Console.WriteLine("\nOrder summary:");
        Console.WriteLine(order);
    }
}