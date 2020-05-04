using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerID = "3";
        string FullName = "Declan Monaghan";
        string Address = "8b abbotsham road";
        string Emailaddress = "Declan1998m@gmail.com";
        string Cardnumber = "123456789";
        string Sortcode = "12-34-56";
        string DOB = "15/04/1998";
        string member = "true";


        // OK TESTS


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exsists
            Assert.IsNotNull(AnCustomer);
        }


        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int16 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
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
        public void ValidMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(member, FullName, DOB, Address, Emailaddress, Cardnumber, Sortcode);
            Assert.AreEqual(Error, "");
        }

        //FOUND TESTS

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
            Int16 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer no
            if (AnCustomer.CustomerID != 1)
            {
                OK = false;
            }
            //test to see tyhat the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to score the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check sortcode
            if (AnCustomer.Address != ("8 b abbotham road bideford ex393aq"))
            {
                OK = false;
            }
            //test to see tyhat the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestMemberFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to score the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.member != false)
            {
                OK = false;
            }
            //test to see tyhat the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestCardnumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to score the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            if (AnCustomer.Cardnumber != 123456789)
            {
                OK = false;
            }
            //test to see tyhat the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to score the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check DOB
            if (AnCustomer.DOB != Convert.ToDateTime("15/04/1998"))
            {
                OK = false;
            }
            //test to see tyhat the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestSortcodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to score the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check sortcode
            if (AnCustomer.Sortcode != "12-34-56")
            {
                OK = false;
            }
            //test to see tyhat the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestEmailaddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to score the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int16 CustomerID = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check sortcode
            if (AnCustomer.Emailaddress != "Declan1998m@gmail.com")
            {
                OK = false;
            }
            //test to see tyhat the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void SortcodeNull()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Sortcode = "";
            Error = AnCustomer.Valid(Cardnumber, member, FullName, DOB, Address, Emailaddress, Sortcode);
            Assert.AreEqual(Error, "");
            //should fail
        }


        [TestMethod]
        public void SortcodeMinMinusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Sortcode = "aaaaaaa";
            Error = AnCustomer.Valid(Cardnumber, member, FullName, DOB, Address, Emailaddress, Sortcode);
            Assert.AreEqual(Error, "");
            //should fail
        }


        [TestMethod]
        public void SortcodeMin()
        { clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Sortcode = "aaaaaaaa";
            Error = AnCustomer.Valid(Cardnumber, member, FullName, DOB, Address, Emailaddress, Sortcode);
            Assert.AreEqual(Error, "");
            //should pass
        }

        [TestMethod]
        public void SortcodeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Sortcode = "aaaaaaaa";
            Error = AnCustomer.Valid(Cardnumber, member, FullName, DOB, Address, Emailaddress, Sortcode);
            Assert.AreEqual(Error, "");
            //should pass
        }

        [TestMethod]
        public void SortcodeMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Sortcode = "12345678";
            Error = AnCustomer.Valid(Cardnumber, member, FullName, DOB, Address, Emailaddress, Sortcode);
            Assert.AreEqual(Error, "");
            //should fail
        }


    }
}
