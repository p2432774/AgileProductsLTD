using System;

namespace Software_HardwareClasses
{
    public class clsCustomer
    {
        public bool member { get; set; }
        public String Sortcode { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String Name { get; set; }
        public String FullName { get; set; }
        public String Emailaddress { get; set; }
        public Int32 Cardnumber { get; set; }
        public DateTime DOB { get; set; }
        public Int32 CustomerID { get; set; }

        public bool Find(int customerID)
        {
            //set the private data members to the dtest data value
            CustomerID = 21;
            //always return true
            return true;
        }
    }
}