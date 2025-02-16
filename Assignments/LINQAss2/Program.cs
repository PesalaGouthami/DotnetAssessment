using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQAss2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of companies");
            int noofcomp = int.Parse(Console.ReadLine());
            List<PlacedStudent> l = new List<PlacedStudent>();

            for (int i = 0; i < noofcomp; i++)
            {
                Console.WriteLine("Enter company name");
                string companyName = Console.ReadLine();
                Console.WriteLine("Enter student name");
                string studentName = Console.ReadLine();
                PlacedStudent ps=new PlacedStudent();
                ps._studentName = studentName;
                ps._companyName = companyName; 
                l.Add(ps);
            }

            var grouped = from student in l
                                  orderby student._studentName
                                  group student by student._companyName into g
                                  select new
                                  {
                                      CompanyName = g.Key,
                                      Students = g.OrderBy(s => s._studentName).ToList()
                                  };

            foreach (var group in grouped)
            {
                Console.Write($"Company Name: {group.CompanyName}\n");
                foreach (var student in group.Students)
                {
                    Console.Write($"{student._studentName}\n");
                }
            }
        }
    }
}
