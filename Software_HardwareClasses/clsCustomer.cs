using System;

namespace Software_HardwareClasses
{
    public class clsCustomer
    {
       // public object Customer { get; set; }
       // public string Email { get; set; }
       // public string Name { get; set; }
       // public DateTime DOB { get; set; }



        private int mCustomerID;
        public int CustomerID
        {
            get
            {                
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }


        private bool mmember;
        public bool member
        {
            get
            {
                return mmember;
            }
            set
            {
                mmember = value;
            }
        }


        private string mSortcode;
        public string Sortcode
        {
            get
            {
                return mSortcode;
            }
            set
            {
                mSortcode = value;
            }
        }


        private string mFullName;
        public string FullName
        {
            get
            {
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }


        private int mCardnumber;
        public int Cardnumber
        {
            get
            {
                return mCardnumber;
            }
            set
            {
                mCardnumber = value;
            }
        }


        private string mEmailaddress;
        public string Emailaddress
        {
            get
            {
                return mEmailaddress;
            }
            set
            {
                mEmailaddress = value;
            }
        }


        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }


        private DateTime mDOB;
        public DateTime DOB
        {
            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }
        }

        //FIND FUNCTIONS

   

        public bool Find(int customerID)
        {
            //set the private data members to the dtest data value
            CustomerID = 21;
            mmember = true;
            mEmailaddress = "declan1998m@gmail.com";
            mFullName = "Declan Monaghan";
            mSortcode = "12 - 34 - 56";
            mCardnumber = 123456789;
            mAddress = "16 westadale court leicester le3 0gj";
            mDOB = Convert.ToDateTime("15/04/1998"); 



            //always return true
            return true;
        }
    }
}
