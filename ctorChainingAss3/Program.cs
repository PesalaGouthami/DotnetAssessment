namespace ctorChainingAss3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select the details you want to enter\n1.student\n2.faculty");
            int ch = int.Parse(Console.ReadLine());
            Person p;
            if (ch == 1) {
                Console.WriteLine("Enter the number of students you want to enter");
                int count=int.Parse(Console.ReadLine());
                Student[] students = new Student[count];
                string name;
                string city;
                int marks;
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine("Enter the name of the student");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the city");
                    city = Console.ReadLine();
                    Console.WriteLine("Enter the marks obtained");
                    marks = int.Parse(Console.ReadLine());
                    students[i]= new Student(name, city, marks);
                }
                for(int i = 0; i < students.Length; i++)
                {
                    if (students[i].IsOutStanding())
                    {
                        Console.WriteLine(students[i]);
                    }
                }     
            }
           else if (ch == 2)
            {
                Console.WriteLine("Enter the number of faculty you want to enter");
                int count = int.Parse(Console.ReadLine());
                Faculty[] faculty = new Faculty[count];
                string name;
                string city;
                int books;
                for (int i = 0; i < faculty.Length; i++)
                {
                    Console.WriteLine("Enter the name of the student");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the city");
                    city = Console.ReadLine();
                    Console.WriteLine("Enter the no of books published");
                    books = int.Parse(Console.ReadLine());
                    faculty[i] = new Faculty(name, city, books);
                }
                for (int i = 0; i < faculty.Length; i++)
                {
                    if (faculty[i].IsOutStanding())
                    {
                        Console.WriteLine(faculty[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
        }
    }
    class Person
    {
        string name;
        string city;
        public Person(string name, string city)
        {
            this.name = name;
            this.city = city;
        }
        public void display()
        {
            Console.WriteLine("Name:" + name + "\ncity:" + city);
        }
        public override string ToString()
        {
            return $"Name:{name}\nCity:{city}";
        }
    }
    class Student:Person
    {
        int totalMarks;
        public Student(string name, string city, int totalMarks):base(name,city)
        {
            this.totalMarks = totalMarks;
        }
        public bool IsOutStanding()
        {
            if (totalMarks > 90)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString()+$"\nTotal Marks Obtained:{totalMarks}";
        }
    }
    class Faculty : Person
    {
        int no_of_books_published;
        public Faculty(string name, string city, int no_of_books_published):base(name,city) 
        {
            this.no_of_books_published = no_of_books_published;
        }
        public bool IsOutStanding()
        {
            if (no_of_books_published >5)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nNo of Books Published:{no_of_books_published}";
        }
    }
}
