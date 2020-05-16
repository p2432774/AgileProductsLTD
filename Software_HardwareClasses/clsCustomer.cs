using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Software_HardwareClasses
{
    public class clsCustomer
    {



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


        private Boolean mmember;
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


        private long mCardnumber;
        public long Cardnumber
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

        public object Active { get; set; }




        //FIND FUNCTIONS



        public bool Find(int CustomerID)
        {
            //create an instance of a data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the customer ID to search
            DB.AddParameter("@CustomerID", CustomerID);
            //executre stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record if found
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt16(DB.DataTable.Rows[0]["CustomerID"]);
                mmember = Convert.ToBoolean(DB.DataTable.Rows[0]["Member"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmailaddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mCardnumber = Convert.ToInt64(DB.DataTable.Rows[0]["Cardnumber"]);
                mSortcode = Convert.ToString(DB.DataTable.Rows[0]["Sortcode"]);

                return true;
            }

            else
            {
                return false;
            }
        }



        public string Valid(string member, string fullName, string DOB, string address, string emailaddress, string cardnumber, string sortcode)
        {
            String Error = "";
            DateTime TempDate;
            try
            {
                TempDate = Convert.ToDateTime(DOB);
                if (TempDate < DateTime.Now.Date.AddYears(-100))
                {
                    Error = Error + "date cannot be more than 100 years ago ";             
                }
                if (TempDate > DateTime.Now.Date.AddYears(-10))
                {
                    Error = Error + "date cannot be more less than 10 years ago ";
                }
            }
            catch
            {
                Error = Error + "not a valid date ";
            }
            
            if (sortcode.Length == 0)
            {
                Error = Error + "Sortcode cannot be null and must be 8 digits long including breaks : ";
            }
            if (sortcode.Length > 8)
            {
                Error = Error + "Sort code must be 8 digits long including breaks : ";
            }
            if (sortcode.Length < 8)
            {
                Error = Error + "Sort code must be 8 digits long including breaks : ";
            }

            if (cardnumber.Length != 9)
            {
                Error = Error + "Cardnumber must be 9 digits long including breaks : ";
            }
            if (cardnumber.Length < 9)
            {
                Error = Error + "Cardnumber must be 9 digits long including breaks : ";
            }
            if (cardnumber.Length > 9)
            {
                Error = Error + "Cardnumber must be 9 digits long including breaks : ";
            }
            if (emailaddress.Length == 0)
            {
                Error = Error + "Emailaddress must be between 3 and 64 characters : ";
            }
            if (emailaddress.Length < 3)
            {
                Error = Error + "Emailaddress must be between 3 and 64 characters : ";
            }
            if (emailaddress.Length > 64)
            {
                Error = Error + "Emailaddress must be between 3 and 64 characters : ";
            }
            if (address.Length < 1)
            {
                Error = Error + "Address must be longer than 1 character : ";
            }
            if (address.Length > 60)
            {
                Error = Error + "Address must be shorter then 60 character : ";
            }
            if (address.Length == 0)
            {
                Error = Error + "Address must be at least one character long : ";
            }
            if (fullName.Length > 40)
            {
                Error = Error + "Name cannot be longer than 40 characters : ";
            }
            if (fullName.Length < 2)
            {
                Error = Error + "Name cannot be Shrorter than 2 characters : ";
            }
            if (fullName.Length == 0)
            {
                Error = Error + "Field cannot be null : ";
            }
            if (member.Length != 4 )
            {
                Error = Error + "If already a member please log in : ";
            }
            


          return Error;
        }

        

    }
}



    


