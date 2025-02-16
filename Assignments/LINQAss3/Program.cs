namespace LINQAss3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of events");
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter event details in CSV(Event Name,Organiser Name,Event Cost)");
            List<Event> events = new List<Event>();
            Event e=null;
            for (int i = 0; i < number; i++)
            {
                e= new Event();
                string s1=Console.ReadLine();
                string[] s2 = s1.Split(",");
                e._eventName = s2[0];
                e._organizerName = s2[1];
                e._eventCost =double.Parse(s2[2]);
                events.Add(e);
            }
            e.Display(events);
        }
    }
    class Event
    {
        public string _eventName { get; set; }
        public string _organizerName { get; set; }
        public double _eventCost { get; set; }
        public override string ToString()
        {
            return $"{_eventName}|{_organizerName}|{_eventCost}";
        }
        public void Display(List<Event> eventList)
        {
            Console.WriteLine("List of Events");
            
            eventList.ForEach(e => Console.WriteLine(e.ToString()));
        }
    }
}
