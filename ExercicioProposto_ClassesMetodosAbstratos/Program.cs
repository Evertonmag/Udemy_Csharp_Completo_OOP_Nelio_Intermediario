using ExercicioProposto_ClassesMetodosAbstratos.Entities;
using System.Globalization;

namespace ExercicioProposto_ClassesMetodosAbstratos;
internal class Program
{
    static void Main(string[] args)
    {
        List<TaxPayer> taxPayers = new List<TaxPayer>();
         
        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Tax payer #{i} data: ");
            Console.Write("Individual or Company (i / c)? ");
            char resp = char.Parse(Console.ReadLine().ToLower());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Annual Income: ");
            double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (resp == 'i')
            {
                Console.Write("Health expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                taxPayers.Add(new Individual(name, annualIncome, healthExpenditures));
            }
            else
            {
                Console.Write("Number of employees: ");
                int numberOfEmployees = int.Parse(Console.ReadLine());

                taxPayers.Add(new Company(name, annualIncome, numberOfEmployees));
            }
        }

        Console.WriteLine("\nTaxes Paid: ");
        foreach (TaxPayer taxPayer in taxPayers)
        {
            Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
        }

        double sum = 0.0;
        foreach (TaxPayer tax in taxPayers)
        {
            sum += tax.Tax();
        }
        Console.WriteLine($"\nTotal Taxes: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}
