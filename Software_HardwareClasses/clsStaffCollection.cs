using System;
using Software_HardwareClasses;
using System.Collections.Generic;

namespace AgileProductsLTDtesting
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }

        public object ThisStaff { get; set; }

        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.PermissionToChangeOrAdd = Convert.ToBoolean(DB.DataTable.Rows[Index]["PermissionToChangeOrAdd"]);
                AnStaff.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnStaff.StaffFirstnameAndLastname = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstnameAndLastname"]);
                AnStaff.StreetAddress = Convert.ToString(DB.DataTable.Rows[Index]["StreetAddress"]);
                AnStaff.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                AnStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                mStaffList.Add(AnStaff);
                Index++;
            }
        }

    }
}