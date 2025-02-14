namespace AccountDetailsAss2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Details(HolderName,Account Number,IFSC code,Contact Number)");
            string input=Console.ReadLine();

            string[] accountDetails = input.Split(",");
            string _holderName;
            long _accountNumber;
            string _IFSCCode;
            long _contactNumber;
            Console.WriteLine("Enter Account Type");
            string _accountType = Console.ReadLine();

            if (accountDetails.Length >= 0)
            {
                 _holderName = accountDetails[0];
               _accountNumber=long.Parse(accountDetails[1]);
                 _IFSCCode=accountDetails[2];
                 _contactNumber=long.Parse(accountDetails[3]);
                if (_accountType.Equals("saving"))
                {
                    Console.WriteLine("Enter the Interest Rate");
                    double interestRate = int.Parse(Console.ReadLine());
                    Account a1 = new SavingAccount(_holderName, _accountNumber, _IFSCCode, _contactNumber, interestRate);
                    a1.display();
                    Console.WriteLine("Interest Rate :" + interestRate);

                }
                else if (_accountType.Equals("current"))
                {
                    Console.WriteLine("Enter the Organization Name");
                    string _organizationName = Console.ReadLine();
                    Console.WriteLine("Enter TIN Number");
                    int _TIN = int.Parse(Console.ReadLine());
                    Account a1 = new CurrentAccount(_holderName, _accountNumber, _IFSCCode, _contactNumber, _organizationName,_TIN);
                    a1.display();
                    Console.WriteLine("Organization Name:"+_organizationName);
                    Console.WriteLine("TIN:"+_TIN);

                }
                else
                {
                    Console.WriteLine("Invalid Type");
                }

            }
        }
    }
    class Account
    {
        private string _holderName;
        private long _accountNumber;
        private string _IFSCCode;
        private long _contactNumber;
        public string HolderName
        {
            get { return _holderName; }
            set { _holderName = value; }
        }
        public long AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public string IFSCCode
        {
            get { return _IFSCCode; }
            set { _IFSCCode = value; }
        }
        public long ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }
        public Account()
        {

        }
        public Account(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber)
        {
            this._holderName = _holderName;
            this._accountNumber = _accountNumber;
            this._IFSCCode = _IFSCCode;
            this._contactNumber = _contactNumber;
        }
        public void display()
        {
            Console.WriteLine("Your Contact Details");
            Console.WriteLine( "HolderName: " +_holderName+"\nAccountNumber: "+_accountNumber+"\nIFSCCode: "+_IFSCCode+"\nContactNumber: "+_contactNumber);
        }
    } 
    class SavingAccount:Account
    {
        private double _interestRate;
        public void display()
        {
            base.display();
            Console.WriteLine("InterestRate"+_interestRate);
        }
        public SavingAccount()
        {
            
        }
        public SavingAccount(string _holderName,long _accountNumber, string _IFSCCode, long _contactNumber,double _interestRate):base(_holderName,_accountNumber,_IFSCCode, _contactNumber)
        {
            this._interestRate= _interestRate;
        }
    }
    class CurrentAccount : Account
    {
       private string _organizationName;
       private long _TIN;
        public void display()
        {
            base.display();
            Console.WriteLine("Organization Name:" + _organizationName + "TIN Number" + _TIN);
        }
        public CurrentAccount()
        {
            
        }
        public CurrentAccount(string _holderName,long _accountNumber,string _IFSCCode,long _contactNumber,string _organizationName,long _TIN):base(_holderName, _accountNumber, _IFSCCode, _contactNumber)
        {
            this._TIN = _TIN;   
            this._organizationName = _organizationName;
        }
    }

}
