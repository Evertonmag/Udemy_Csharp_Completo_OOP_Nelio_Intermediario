using ExercicioExemplo_TratandoExcessoes.Entities;
using ExercicioExemplo_TratandoExcessoes.Entities.Exceptions;

namespace ExercicioExemplo_TratandoExcessoes;
internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in Date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out Date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine("\nEnter data to update the reservation");
            Console.Write("Check-in Date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out Date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());


            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);
        }
        catch (DomainException ex)
        {
            Console.WriteLine($"Error in Reservation {ex.Message}");
        }
        catch(FormatException ex)
        {
            Console.WriteLine($"Format error: {ex.Message}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
