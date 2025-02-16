using System.Net;
using System.Xml.Linq;

namespace InheritanceAss1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)Privilege Customer\n2)Senior Citizen Customer");
            Console.WriteLine("Enter the Customer Type");
            int ch=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the Age");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Address");
            string address=Console.ReadLine();
            Console.WriteLine("Enter the Mobile Number");
            string mobileno=Console.ReadLine();
            Console.WriteLine("Enter the Purchased Amount");
            int amount=int.Parse(Console.ReadLine());
            if (ch == 1)
            {
               PrivilegeCustomer p1=new PrivilegeCustomer(name,address, mobileno,age,amount);
                p1.DisplayCustomer();
                Console.WriteLine("Your bill amount is Rs "+amount);
                Console.WriteLine("Your bill amount is discount under privilege customer\n You have to pay Rs " +p1.GenerateBillAmount(amount));
            }
            else if (ch == 2)
            {
                SeniorCitizenCustomer s1 = new SeniorCitizenCustomer(name, address, mobileno,age, amount);
                s1.DisplayCustomer();
                Console.WriteLine("Your bill amount is Rs " + amount);
                Console.WriteLine("Your bill amount is discount under senior citizen customer\n You have to pay Rs " + s1.GenerateBillAmount(amount));
            }
            else
            {
                Console.WriteLine("Invalid Customer Type");
            }

        }
    }
    class Customer
    {
        string _name;
        string _address;
        string _mobileNumber;
        int _age;
        public void DisplayCustomer()
        {
            Console.WriteLine($"Bill Details\n Name {_name}\n Mobile {_mobileNumber}\n Age {_age}\n Address {_address}");
        }

        public Customer(string _name,string _address,string _mobileNumber,int _age)
        {
            this._name = _name;
            this._address = _address;
            this._mobileNumber = _mobileNumber; 
            this._age = _age;
        }
    }
    class SeniorCitizenCustomer:Customer
    {
        int amount;
        public SeniorCitizenCustomer(string _name, string _address, string _mobileNumber, int _age,int amount) : base(_name, _address, _mobileNumber,_age)
        {
            this.amount = amount;
        }
        public virtual double GenerateBillAmount(int amount)
        {
            return amount -( amount * 0.12);
        }
    }
    class PrivilegeCustomer:Customer
    {
        int amount;
        public PrivilegeCustomer(string _name, string _address, string _mobileNumber, int _age, int amount) : base(_name, _address, _mobileNumber, _age)
        {
            this.amount = amount;
            
        }
        public  double GenerateBillAmount(int amount)
        {
            return amount - (amount * 0.3);
        }
    }
}
