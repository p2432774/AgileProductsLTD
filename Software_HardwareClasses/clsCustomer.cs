using System;

namespace Software_HardwareClasses
{
    public class clsCustomer
    {
        public bool member { get; set; }
        public string Sortcode { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Emailaddress { get; set; }
        public int Cardnumber { get; set; }
        public object Customer { get; set; }

        //CustomerID private member variable
        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return CustomerID;
            }
            set
            {
                //this line of code allows data into the property
                CustomerID = value;
            }
        }
        public object DOB { get; set; }

        public bool Find(int customerID)
        {
            //set the private data members to the dtest data value
            CustomerID = 21;
            //always return true
            return true;
        }
    }
}