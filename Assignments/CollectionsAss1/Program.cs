namespace CollectionsAss1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Entity> l = new List<Entity>();
            l.Add(new Entity( 200, "Dell", "Monitor", 3400.44));
            l.Add(new Entity(120, "Dell", "Laptop", 45000.00));
            l.Add(new Entity(150, "Microsoft", "Windows", 7000.50));
            l.Add(new Entity(100, "Logitech", "Optical", 540.00));
            //l.Sort();
            Console.WriteLine("Enter the sorting option\n1.Brandname\n2.Price");
            int ch=int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                l.Sort(new sortByBrand());
            }
            if (ch == 2)
            {
                l.Sort(new sortByPrice());
            }
            IEnumerator<Entity> ien = l.GetEnumerator();
            while (ien.MoveNext())
            {
                Console.WriteLine(ien.Current.ToString());
            }
        }
    }
    class Entity:IComparable<Entity>
    {
        public int productId;
        public string brandName;
        public string description;
        public double price;
        public Entity(int productId,
         string brandName,
        string description,
        double price)
        {
            this.productId = productId;
            this.brandName = brandName; 
            this.description = description;
            this.price = price;
        }
        public int CompareTo(Entity? other)
        {
            if (this.productId > other.productId)
            {
                return 1;
            }
            if (this.productId < other.productId)
            {
                return -1;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{productId} {brandName} {description} {price}";
        }
    }
    public class sortByBrand : IComparer<Entity> {
        int IComparer<Entity>.Compare(Entity? x, Entity? y)
        {
            if(x.brandName.CompareTo(y.brandName)==1)
            {
                return 1;
            }
            if (x.brandName.CompareTo(y.brandName) == -1)
            {
                return -1;
            }
            else
            {
                if(x.productId> y.productId)
                {
                    return 1;
                }
                else if(x.productId < y.productId)
                {
                    return -1;
                }
                return 0;
            }

        }
    }

    public class sortByPrice : IComparer<Entity> {
        int IComparer<Entity>.Compare(Entity?x,Entity? y)
        {
            if (x.price > y.price)
            {
                return 1;
            }
            else if (x.price < y.price)
            {
                return -1;
            }
            else
            {
                if (x.productId > y.productId)
                {
                    return 1;
                }
                else if (x.productId < y.productId)
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
