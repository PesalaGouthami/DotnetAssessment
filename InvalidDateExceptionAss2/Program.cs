namespace InvalidDateExceptionAss2
{
    internal class Program:Exception
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the start date(dd/MM/yyyy hh:mm:ss tt):");
                string s1 = Console.ReadLine();
                DateTime start = DateTime.ParseExact(s1, "dd/MM/yyyy hh:mm:ss tt", null);
                Console.WriteLine("Enter the end date(dd/MM/yyyy hh:mm:ss tt):");
                string s2 = Console.ReadLine();
                DateTime end = DateTime.ParseExact(s2, "dd/MM/yyyy hh:mm:ss tt", null);
                Console.WriteLine("Starting Date:" + start.ToString("dd/MM/yyyyhh:mm:ss tt"));
                Console.WriteLine("Ending Date:"+end.ToString("dd/MM/yyyyhh:mm:ss tt"));
            }
            catch(Exception ex){
                    Console.WriteLine(ex.Message);
            }
        }
    }
}
