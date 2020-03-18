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

        public string Valid(string phoneNumber, string dateOfBirth, string staffFirstnameAndLastname, string streetAddress, string department)
        {
            return "";
        }
        // public string Valid(string PhoneNumber, DateTime DateOfBirth, string StaffFirstnameAndLastname, string StreetAddress, string Department)

    }
}
