using ExercicioProposto_TratandoExcessoes.Entities;
using ExercicioProposto_TratandoExcessoes.Entities.Extensions;
using System.Globalization;

namespace ExercicioProposto_TratandoExcessoes;
internal class Program
{
    static void Main(string[] args)
    {
        //Fazer um programa para ler os dados de uma conta bancária e depois realizar um 
        //saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer 
        //ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de 
        //saque da conta. Implemente a conta bancária conforme projeto abaixo:
        try
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw Limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, initialBalance, withdrawLimit);

            Console.Write("\nEnter Amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            account.Withdraw(withdraw);

            Console.WriteLine("New Balance:  " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (DomainException ex)
        {
            Console.WriteLine($"Withdraw error: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
