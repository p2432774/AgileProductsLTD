using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;
using System.Collections.Generic;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstStaffCollection
    {
        public object TestStaff { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

/*       [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 2;
            AllStaff.Count = SomeCount;
            Assert.AreEqual(AllStaff.Count, SomeCount);

        }
*/
        [TestMethod]
        public void ThisStaffPropertyOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 1;
            TestItem.PermissionToChangeOrAdd = false;
            TestItem.PhoneNumber = "1234567891";
            TestItem.StaffFirstnameAndLastname = "Mishal Nanalal";
            TestItem.StreetAddress = "Melton Road";
            TestItem.Department = "Packager";
            TestItem.DateOfBirth = DateTime.Now.Date;

            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 1;
            TestItem.PermissionToChangeOrAdd = false;
            TestItem.PhoneNumber = "1234567891";
            TestItem.StaffFirstnameAndLastname = "Mishal Nanalal";
            TestItem.StreetAddress = "Melton Road";
            TestItem.Department = "Packager";
            TestItem.DateOfBirth = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 1;
            TestItem.PermissionToChangeOrAdd = false;
            TestItem.PhoneNumber = "1234567891";
            TestItem.StaffFirstnameAndLastname = "Mishal Nanalal";
            TestItem.StreetAddress = "Melton Road";
            TestItem.Department = "Packager";
            TestItem.DateOfBirth = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

 /*       [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.AreEqual(AllStaff.Count, 2);
*/



        }
    }

}
