using ExercicioExemplo_TratandoExcessoes.Entities.Exceptions;

namespace ExercicioExemplo_TratandoExcessoes.Entities;
internal class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation()
    {
    }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        if (checkOut <= checkIn)
        {
            throw new DomainException("Check-Out date must be after Check-In date");
        }

        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int Duration()
    {
        TimeSpan duration = CheckOut.Subtract(CheckIn);
        return (int)duration.Days;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut)
    {
        DateTime now = DateTime.Now;

        if (checkIn < now || checkOut < now)
        {
            throw new DomainException("Reservation dates for update must be future");
        }
        if (checkOut <= checkIn)
        {
            throw new DomainException("Check-Out date must be after Check-In date");
        }

        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public override string ToString()
    {
        return "Room: "
            + RoomNumber
            + ", Check-in: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", Check-out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " Nigths";
    }
}
