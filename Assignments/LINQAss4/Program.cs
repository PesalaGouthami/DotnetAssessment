namespace LINQAss4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of halls:");
            int number=int.Parse(Console.ReadLine());
            List<Hall> list = new List<Hall>();
            Console.WriteLine("Enter the hall details");
            for (int i = 0; i < number; i++)
            {
                Hall hall = new Hall();
                string s=Console.ReadLine();
                string[] s1 = s.Split(",");
                hall._name = s1[0];
                hall._costPerDay =double.Parse(s1[1]);
                hall._owner = s1[2];
                list.Add(hall);
            }
            list = list.OrderBy(h => h._owner).ToList();
            Console.WriteLine("Hall list:");
            Console.WriteLine("{0,-15}{1,-10}{2,-10}","Name","Cost","Owner");
            foreach (var h in list)
            {
                Console.WriteLine(h);
            }
           
        }
    }
    class Hall:IComparable<Hall>
    {
        public string _name { get; set; }
        public double _costPerDay { get; set; }
        public string _owner { get; set; }
        
        public int CompareTo(Hall hall)
        {
            return this._owner.CompareTo(hall._owner);
        }
        public override string ToString()
        {
            return $"{_name}\t{_costPerDay}\t{_owner}";
        }
    }

}
