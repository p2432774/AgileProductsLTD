using System;

namespace AgileProductsLTDtesting
{
    public class clsStaff
    {
        public bool PermissionToChangeOrAdd { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
        public string StaffFirstnameAndLastname { get; internal set; }
        public string Department { get; internal set; }
        public string StreetAddress { get; internal set; }
        public string PhoneNumber { get; internal set; }
        public int StaffID { get; internal set; }
    }
}