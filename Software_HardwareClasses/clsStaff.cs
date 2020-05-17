using System;
namespace Software_HardwareClasses

{
    public class clsStaff

    {
        private Boolean mPermissionToChangeOrAdd;
        public bool PermissionToChangeOrAdd
        {
            get
            {
                return mPermissionToChangeOrAdd;
            }
            set
            {
                mPermissionToChangeOrAdd = value;
            }
        }

        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        private String mStaffFirstnameAndLastname;
        public string StaffFirstnameAndLastname
        {
            get
            {
                return mStaffFirstnameAndLastname;
            }
            set
            {
                mStaffFirstnameAndLastname = value;
            }
        }
        private string mStreetAddress;
        public string StreetAddress
        {
            get
            {
                return mStreetAddress;
            }
            set
            {
                mStreetAddress = value;
            }
        }
        private string mDepartment;
        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }

        }

        private string mPhoneNumber;
        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;

            }
        }

        private int mStaffID;

        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }


        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_filterByStaffID");
            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt16(DB.DataTable.Rows[0]["StaffID"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mStreetAddress = Convert.ToString(DB.DataTable.Rows[0]["StreetAddress"]);
                mStaffFirstnameAndLastname = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstnameAndLastname"]);
                mPermissionToChangeOrAdd = Convert.ToBoolean(DB.DataTable.Rows[0]["PermissionToChangeOrAdd"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string DateOfBirth, string Department, string StaffFirstnameAndLastname, string StreetAddress, string PhoneNumber)
        {
            String Error = "";
            DateTime DateTemp;

            if (Department.Length > 100)
            {
                Error = Error + ("The Department cannot have more than 100 letters : ");
            }

            if (StaffFirstnameAndLastname.Length > 100)
            {
                Error = Error + ("The Department cannot have more than 100 letters : ");
            }

            try
            { 
            DateTemp = Convert.ToDateTime(DateOfBirth);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    Error = Error + ("The Date cannot be less than 100 years of today (mm/dd/yyyy) : ");         
                 }
            DateTemp = Convert.ToDateTime(DateOfBirth);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + ("The Date cannot be in the future (mm/dd/yyyy) : ");
                }
            }
            catch
            {
                Error = Error + ("The date was not a valid date (mm/dd/yyyy) : ");
            }

            if (StaffFirstnameAndLastname.Length > 100)
            {
                Error = Error + ("The Firstname and Lastname cannot have more than 100 letters : ");
            }

          if (PhoneNumber.Length > 12)
            {
                Error = Error + ("The Phone number cannot be over 12 numbers : ");
            }
          if (StreetAddress.Length > 100)
            {
                Error = Error + ("The Staff Address cannot be over 100 characters : ");
            }
            return Error;

        }
    }
}
