namespace MobileValidationAss3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Mobile Number:");
                long mobNum = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter the alternate mobile number:");
                long altNum = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter the landline number:");
                long landNum = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Email Id:");
                string email = Console.ReadLine();
                Console.WriteLine("Enter the address:");
                string address = Console.ReadLine();
                ContactDetail contactDetail = new ContactDetail { Mobile = mobNum, AlternateMobile = altNum, Landline = landNum, Email = email, Address = address };
                ContactDetailBO contactDetailBO = new ContactDetailBO() ;
                contactDetailBO.Validate(contactDetail);
                Console.WriteLine(contactDetail.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class ContactDetail
    {
        private long _mobile;
        private long _alternateMobile;
        private long _landLine;
        private string _email;
        private string _address;

        public long Mobile{ get { return _mobile; } set { _mobile = value; } }
        public long AlternateMobile { get { return _alternateMobile; } set { _alternateMobile = value; } }
        public long Landline { get { return _landLine; } set { _landLine = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Address { get { return _address; } set { _address = value; } }

        public override string ToString()
        {
            return $"Contact Details:\nMobile: {_mobile}\nAlternate Mobile: {_alternateMobile}\nLandLine: {_landLine}\nEmail Id: {_email}\nAddress: {_address}";
        }
    }
    class ContactDetailBO
    {
        public void Validate(ContactDetail contactDetail)
        {
            if (contactDetail.Mobile == contactDetail.AlternateMobile)
            {
                throw new DuplicateNumberException("Exception:Same Mobile Number and Alternate Mobile Number");
            }
        }
    }
    class DuplicateNumberException:Exception
    {
        public DuplicateNumberException(string message):base(message)
        {
            
        }
    }
}
