using Classes_Metodos_Abstratos.Entitites;
using Classes_Metodos_Abstratos.Entitites.Enums;
using System.Globalization;

namespace Classes_Metodos_Abstratos;
internal class Program
{
    static void Main(string[] args)
    {
        //ClasseAbstrata();
        MetodoAbstrato();
    }

    static void ClasseAbstrata()
    {
        List<Account> accounts = new List<Account>();

        accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
        accounts.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
        accounts.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
        accounts.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

        double sum = 0.0;

        foreach (Account account in accounts)
        {
            sum += account.Balance;
        }

        Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

        foreach (Account acc in accounts)
        {
            acc.Withdraw(10.0);
        }
        foreach (Account acc in accounts)
        {
            Console.WriteLine("Upadate balance for account: "
                + acc.Number
                + ": "
                + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)
                );
        }
    }

    static void MetodoAbstrato()
    {
        List<Shape> shapes = new List<Shape>();

        Console.Write("Enter the number of shapes ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Shape #{i} data: ");
            Console.Write("Rectangle or Circle (r/c)? ");
            char resp = char.Parse(Console.ReadLine().ToLower());
            Console.Write("Color (Black / Blue / Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if (resp == 'r')
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("height: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                shapes.Add(new Rectangle(width, height, color));
            }
            else
            {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                shapes.Add(new Circle(radius, color));
            }
        }

        Console.WriteLine("\nShapes Areas");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
