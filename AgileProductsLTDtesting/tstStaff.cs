using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgileProductsLTDtesting
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        AnStaff = (clsStaff)Session["AnStaff"];
        Response.Write(AnStaff.Department);
    }
    [TestClass]
    public class tstStaff
    {
        public object AnStaff { get; private set; }

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
            Boolean TestData = true;
            AnStaff.PermissionToChangeOrAdd = TestData;

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
            string TestData = "01234567891";
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
    }
}

