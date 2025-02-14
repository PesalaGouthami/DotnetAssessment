namespace GSTCalculationAss3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Event name");
            string eventName=Console.ReadLine();
            Console.WriteLine("Enter the cost per day");
            int costperday=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of days");
            int noofdays=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of event\n1.Exhibition\n2.Stage Event");
            int ch=int.Parse(Console.ReadLine());
            Event e1;
            if (ch == 2)
            {
                Console.WriteLine("Enter the number of seats");
                int noofseats=int.Parse(Console.ReadLine());
                 e1=new StageEvent(eventName,"Stage",costperday,noofdays,noofseats);
                Console.WriteLine(e1.ToString());
                Console.WriteLine("Total amount: " +(double) e1.totalCost());
            }
            else if (ch == 1)
            {
                Console.WriteLine("Enter the number of stalls");
                int noofstalls = int.Parse(Console.ReadLine());
                 e1=new Exhibition(eventName,"Exhibition",costperday,noofdays,noofstalls);
                Console.WriteLine(e1.ToString());
                Console.WriteLine("Total amount: " + (double) e1.totalCost());
            }
            else
            {
                Console.WriteLine("Invalid Input ");
            }

        }
    }
    class Event
    {
        protected string _name;
        protected string _type;
        protected double _costPerDay;
        protected int _noOfDays;
        public Event()
        {
            
        }
        public Event(string _name,string _type,double _costPerDay,int _noOfDays)
        {
            this._name = _name;
            this._type = _type;
            this._costPerDay = _costPerDay;
            this._noOfDays = _noOfDays;
        }
        public override string ToString()
        {
            return $"Name:{_name}\nType:{_type}\n";
        }
        public virtual double totalCost()
        {
            return 0;
        }
    }
    class Exhibition : Event
    {
        private static int _gst = 5;
        private int _noOfStalls;
        public Exhibition()
        {
            
        }
        public Exhibition(string _name,string _type,double _costPerDay,int _noOfDays,int _noOfStalls):base(_name,_type,_costPerDay,_noOfDays)
        {
            this._noOfStalls= _noOfStalls;
        }
        public override double totalCost()
        {
            return _costPerDay * _noOfDays * (1+ _gst / 100.0);
        }
        public override string ToString()
        {
            return $"Name:{_name}\nType:{_type}\nNumber of stalls:{_noOfStalls}";
        }
    }
    class StageEvent : Event
    {
        private static int _gst = 15;
        private int _noOfSeats;
        public StageEvent()
        {
            
        }
        public StageEvent(string _name,string _type,double _costPerDay,int _noOfDays,int _noOfSeats):base(_name,_type,_costPerDay,_noOfDays)
        {
            this._noOfSeats= _noOfSeats;
        }

        public override double totalCost()
        {
            return _costPerDay * _noOfDays * (1+ _gst / 100.0);
        }
        public override string ToString()
        {
            return $"Name:{_name}\nType:{_type}\nNumber of seats:{_noOfSeats}";
        }
    }
}
