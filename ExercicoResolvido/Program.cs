using ExercicoResolvido.Entities;
using System.Globalization;

namespace ExercicoResolvido;
internal class Program
{
    static void Main(string[] args)
    {
        List<Employee> list = new List<Employee>();

        Console.Write("Enter  the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Employee #{i} data:");
            Console.Write("Outsourced (y/n): ");
            char resp = char.Parse(Console.ReadLine().ToLower());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (resp == 'y')
            {
                Console.Write("Additional charge: ");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
            }
            else
                list.Add(new Employee(name, hours, valuePerHour));
        }

        Console.WriteLine("\nPayments: ");
        foreach (Employee employee in list)
        {
            Console.WriteLine(employee.Name + " - $  " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
