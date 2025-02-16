namespace ArrayOfObjectsAss1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of employee details");
            int count=int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[count];
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the Employee Code:");
                int ecode=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Employee Name:");
                string empname=Console.ReadLine();
                Console.WriteLine("Enter the salary:");
                int salary=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the department Id:");
                int deptid=int.Parse(Console.ReadLine());
                employees[i]=new Employee(ecode,empname,salary,deptid);
            }
            int totalsalary = 0;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(employees[i].ToString());
                Console.WriteLine("================================");
                totalsalary += employees[i].totalsalary();
            }
            Console.WriteLine("TotalSalary:"+totalsalary);
        }
    }
    class Employee
    {
        int EmployeeCode;
        string EmployeeName;
        int salary;
        int deptId;
        public Employee(int EmployeeCode,string EmployeeName,int salary,int deptId)
        {
            this.EmployeeCode = EmployeeCode;  
            this.EmployeeName = EmployeeName;
            this.salary = salary;
            this.deptId = deptId;
        }
        public override string ToString()
        {
            return $"Employee Code:\t{EmployeeCode}\nEmployee Name:\t{EmployeeName}\nSalary:\t{salary}\nDeptId:\t{deptId}";
        }
        public int totalsalary()
        {
            return salary;
        }
    }
}
