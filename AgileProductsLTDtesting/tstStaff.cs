using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;




namespace AgileProductsLTDtesting
{

    [TestClass]
    public class tstStaff
    {
        string PhoneNumber = "01234567891";
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
            if (AnStaff.DateOfBirth != Convert.ToDateTime("03/30/1980"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
            }
        
        [TestMethod]
        public void TestStaffDateOfBirthMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-99);
            string DateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TestStaffDateOfBirthMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffDateOfBirthMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-101);
            string DateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffDateOfBirthMaxMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-2);
            string DateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffDateOfBirthMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffDateOfBirthMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(+1);
            string DateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffDateOfBirthExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateOfBirth = TestDate.ToString();
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffDateOfBirthInvalidData()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string DateOfBirth = "This is not a date!";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);
            Assert.AreNotEqual(Error, "");

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
        public void TestDepartmentMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Department = "";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestDepartmentMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Department = "a";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestDepartmentMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Department = "aa";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestDepartmentMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Department = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestDepartmentMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Department = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestDepartmentMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Department = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestDepartmentMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Department = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TestDepartmentExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Department = "";
            Department = Department.PadRight(200, 'a');
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TestDepartmentExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Department = "";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

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
        public void TestStaffFirstNameAndLastnameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstnameAndLastname = "";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffFirstNameAndLastnameMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstnameAndLastname = "a";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffFirstNameAndLastnameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstnameAndLastname = "aa";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffFirstNameAndLastnameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstnameAndLastname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffFirstNameAndLastnameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstnameAndLastname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffFirstNameAndLastnameMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstnameAndLastname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffFirstNameAndLastnameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstnameAndLastname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffFirstNameAndLastnameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstnameAndLastname = "";
            StaffFirstnameAndLastname = StaffFirstnameAndLastname.PadRight(200, 'a');
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TestStaffFirstNameAndLastnameExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffFirstnameAndLastname = "";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

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
        public void TestPhoneNumberMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneNumberMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "1";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "11";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "11111111111";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneNumberMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "111111111111";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneNumberMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "111111";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "1111111111111";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "11111111111111";
            PhoneNumber = PhoneNumber.PadRight(1);
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "11111111111111");

        }
        [TestMethod]
        public void PhoneNumberExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TestStreetAddressFound()
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
        public void TestStreetAddressMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StreetAddress = "";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStreetAddressMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StreetAddress = "a";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStreetAddressMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StreetAddress = "aa";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStreetAddressMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StreetAddress = "";
            StreetAddress = StreetAddress.PadRight(99, 'a');
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStreetAddressMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StreetAddress = "";
            StreetAddress = StreetAddress.PadRight(100, 'a');
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStreetAddressMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StreetAddress = "";
            StreetAddress = StreetAddress.PadRight(50, 'a');
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TestStreetAddressMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StreetAddress = "";
            StreetAddress = StreetAddress.PadRight(101, 'a');
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TestStreetAddressExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StreetAddress = "";
            StreetAddress = StreetAddress.PadRight(200, 'a');
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TestStreetAddressExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StreetAddress = "";
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);

            Assert.AreEqual(Error, "");

        }

    
        [TestMethod]
        public void TestPermissionFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.PermissionToChangeOrAdd != false)
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
            Error = AnStaff.Valid(DateOfBirth, Department, StaffFirstnameAndLastname, StreetAddress, PhoneNumber);
            Assert.AreEqual(Error, "");

        }
    }
}
