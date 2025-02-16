namespace SeatBookingAss3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the booking details");
                string details = Console.ReadLine();
                Console.WriteLine("Enter the seat number to book");
                int seats = int.Parse(Console.ReadLine());
                char[] arr = details.ToCharArray();
                if (seats < arr.Length && arr[seats-1]=='0')
                {
                    throw new SeatNotAvailableException("Booked Successfully");
                }
               else if (seats < arr.Length && arr[seats-1]!='0')
                {
                    throw new SeatNotAvailableException("seat booked already");
                }
                else
                {
                    throw new SeatNotAvailableException("Array Index out of bounds");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class SeatNotAvailableException : Exception
    {
        public SeatNotAvailableException(string message) : base(message)
        {
        }
    }
}
