using System;
using System.Collections.Generic;

using Software_HardwareClasses;
namespace Software_HardwareClasses
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //worry about this later
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                return mCustomer;
            }
            set
            {
                mCustomer = value;
            }
        }



        public clsCustomerCollection()
        {
            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);                                             
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            // DB.AddParameter("@CustomerID", mCustomer.CustomerID);
            DB.AddParameter("@Member", mCustomer.member);
            DB.AddParameter("@DOB", mCustomer.DOB);
            DB.AddParameter("@Address", mCustomer.Address);
            DB.AddParameter("@Emailaddress", mCustomer.Emailaddress);
            DB.AddParameter("@FullName", mCustomer.FullName);
            DB.AddParameter("@Cardnumber", mCustomer.Cardnumber);
            DB.AddParameter("@Sortcode", mCustomer.Sortcode);



            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mCustomer.CustomerID);


            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mCustomer.CustomerID);
            DB.AddParameter("@Member", mCustomer.member);
            DB.AddParameter("@DOB", mCustomer.DOB);
            DB.AddParameter("@Address", mCustomer.Address);
            DB.AddParameter("@Emailaddress", mCustomer.Emailaddress);
            DB.AddParameter("@FullName", mCustomer.FullName);
            DB.AddParameter("@Cardnumber", mCustomer.Cardnumber);
            DB.AddParameter("@Sortcode", mCustomer.Sortcode);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByFullName(string FullName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", FullName);
            DB.Execute("sproc_tbLCustomer_FilterByFullName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();

            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                //AnCustomer.CustomerID = Convert.ToInt16(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.member = Convert.ToBoolean(DB.DataTable.Rows[Index]["Member"]);
                AnCustomer.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.Emailaddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                AnCustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AnCustomer.Cardnumber = Convert.ToInt64(DB.DataTable.Rows[Index]["Cardnumber"]);
                AnCustomer.Sortcode = Convert.ToString(DB.DataTable.Rows[Index]["Sortcode"]);

                mCustomerList.Add(AnCustomer);
                Index++;
            }



        }
    }
}

       
    

