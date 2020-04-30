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

   

        public bool Find(int CustomerID)
        {
            //create an instance of a data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the customer ID to search
            DB.AddParameter("@CustomerID", CustomerID);
            //executre stored procedure
            DB.Execute("dbo.sproc_tblCustomer_FilterByCustomerID");
            //if one record if found
            if (DB.Count ==1)
            {
                mCustomerID = Convert.ToInt16(DB.DataTable.Rows[0]["CustomerID"]);
                mmember = Convert.ToBoolean(DB.DataTable.Rows[0]["Member"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmailaddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mCardnumber = Convert.ToInt16(DB.DataTable.Rows[0]["Cardnumber"]);
                mSortcode = Convert.ToString(DB.DataTable.Rows[0]["Sortcode"]);

                return true;
            }
            
            else
            {
                return false;
            }


           
        }
    }
}
