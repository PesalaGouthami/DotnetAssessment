namespace ArrayOfObjectsAss2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of customers");
            int count=int.Parse(Console.ReadLine());
            Customer[] cust=new Customer[count];
            for (int i = 0; i < cust.Length; i++)
            {
                Console.WriteLine("Enter the Feedback Rating");
                double feedback=double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the mobile number");
                string mobile=Console.ReadLine();
                Console.WriteLine("Enter the name");
                string name=Console.ReadLine();
                cust[i]=new Customer(feedback, mobile, name);
            }
            double rating = 0;
            for (int i = 0; i < cust.Length; i++)
            {
                Console.WriteLine("Customer " + i + ":" + cust[i].ToString()+" out of 5");
                rating += cust[i].avgfeedback();
            }
            Console.WriteLine("Average Feedback Rating:"+rating/count);
        }
    }
    class Customer
    {
        double feedbackRating;
        string mobileNumber;
        string name;
        public Customer(double feedbackRating,string mobileNumber,string name)
        {
            this.feedbackRating = feedbackRating;
            this.mobileNumber = mobileNumber;   
            this.name = name;
        }
        public double avgfeedback()
        {
            return feedbackRating;
        }
        public override string ToString()
        {
            return ""+feedbackRating;
        }
    }
}
