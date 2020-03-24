using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exsists
            Assert.IsNotNull(AnCustomer);
        }


        [TestMethod]
        public void MemeberOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.member = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.member, TestData);
        }

        [TestMethod]
        public void SortcodeOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "12-34-56";
            //assign the data to the property
            AnCustomer.Sortcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Sortcode, TestData);
        }

        [TestMethod]
        public void EmailaddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Declan1998m@gmail.com";
            //assign the data to the property
            AnCustomer.Emailaddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Emailaddress, TestData);
        }

        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "8 b abbotham road bideford ex393aq";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void FullNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "declan monaghan";
            //assign the data to the property
            AnCustomer.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FullName, TestData);
        }

        [TestMethod]
        public void CardnumberOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 123456789;
            //assign the data to the property
            AnCustomer.Cardnumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Cardnumber, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int16 TestData = 2;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to score the result of the validation
            Boolean Found = false;
            //acreate some test data to use wit the method
            Int16 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to score the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer no
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            //test to see tyhat the result is correct
            Assert.IsTrue(OK);

        }

        public void TestDOBFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to score the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the DOB
            if (AnCustomer.DOB != Convert.ToDateTime("15/04/1998"))
            {
                OK = false;
            }
            //test to see tyhat the result is correct
            Assert.IsTrue(OK);

        }
    }
}
