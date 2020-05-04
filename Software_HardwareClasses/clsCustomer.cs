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

      

        public string Valid(string member, string fullName, string dOB, string address, string emailaddress, string cardnumber, string sortcode)
        {
            String Error = "";
            if (Sortcode.Length == 0)
            {
                Error = Error + "Sort codecan not be null and must be 8 digits long including breaks : ";
            }
            if (Sortcode.Length !=8)
            {
                Error = Error + "Sort code must be 8 digits long including breaks : ";                   
            }
            if (Sortcode.Length > 8)
            {
                Error = Error + "Sort code must be 8 digits long including breaks : ";
            }           
            if (Sortcode.Length < 8)
            {
                Error = Error + "Sort code must be 8 digits long including breaks : ";
            }
            return Error;
        }

   


    }

}

    


