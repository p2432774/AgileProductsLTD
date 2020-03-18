using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;




namespace AgileProductsLTDtesting
{

    [TestClass]
    public class tstStaff
    {
        string PhoneNumber = "012345678911";
        string DateOfBirth = DateTime.Now.Date.ToString();
        string StaffFirstnameAndLastname = "Joe Bloggs";
        string StreetAddress = "Some Road";
        string Department = "Packager";
    

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void PermissionToChangeOrAddPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.PermissionToChangeOrAdd = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.PermissionToChangeOrAdd, TestData);

        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AnStaff.DateOfBirth = TestData;
            Assert.AreEqual(AnStaff.DateOfBirth, TestData);

        }
        [TestMethod]
        public void StaffFirstnameAndLastnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Mishal Nanalal";
            //assign the data to the property
            AnStaff.StaffFirstnameAndLastname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffFirstnameAndLastname, TestData);

        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Packager";
            //assign the data to the property
            AnStaff.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Department, TestData);

        }
        [TestMethod]
        public void StreetAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Melton Road";
            //assign the data to the property
            AnStaff.StreetAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StreetAddress, TestData);

        }
        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "1234567891";
            //assign the data to the property
            AnStaff.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.PhoneNumber, TestData);

        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffID, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            int StaffID = 1;
            Found = AnStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.StaffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffDateOfBirthFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.DateOfBirth != Convert.ToDateTime("30/03/1980"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDepartmentFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Department != "Packager")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestFirstNameAndLastnameFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.StaffFirstnameAndLastname != "Mishal Nanalal")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPhoneNumberFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.PhoneNumber != "12345678911")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStaffAddressFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.StreetAddress != "Melton Road")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPermissionFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.PermissionToChangeOrAdd != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            Error = AnStaff.Valid(PhoneNumber, DateOfBirth, StaffFirstnameAndLastname, StreetAddress, Department);
            Assert.AreEqual(Error, "");

        }
    }
}


