using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProcuctsLTDtesting
{
    [TestClass]
    public class tstHardware
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Test to see if the result is correct
            Assert.IsNotNull(hardware);
        }

        [TestMethod]
        public void  NameOK()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a test string variable with the string "Hardware Name"
            string TestName = "Hardware Name";
            //Assigns the test string to the Name variable
            hardware.Name = TestName;
            //Test to see if the result is correct
            Assert.AreEqual(hardware.Name, TestName);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a test string variable with the string "This is a product description"
            string TestDescription = "This is a product description";
            //Assigns the test string to the Description variable
            hardware.Description = TestDescription;
            //Test to see if the result is correct
            Assert.AreEqual(hardware.Description, TestDescription);
        }

        [TestMethod]
        public void PriceOK()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a test Int32 variable with the int 10
            Int32 TestPrice = 10;
            //Assigns the test Int32 to the Int32 variable Price
            hardware.Price = TestPrice;
            //Test to see if the result is correct
            Assert.AreEqual(hardware.Price, TestPrice);
        }

        [TestMethod]
        public void AmountInStockOK()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a test Int32 variable with the int 5
            Int32 TestStock = 5;
            //Assigns the test Int32 to the Int32 variable AmountInStock
            hardware.AmountInStock = TestStock;
            //Test to see if the result is correct
            Assert.AreEqual(hardware.AmountInStock, TestStock);
        }

        [TestMethod]
        public void StockRequiredOK()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a Boolean variable set to false
            Boolean TestStockRequired = false;
            //Assigns false to the Boolean variable StockRequired
            hardware.StockRequired = TestStockRequired;
            //Test to see if the result is correct
            Assert.AreEqual(hardware.StockRequired, TestStockRequired);
        }

        [TestMethod]
        public void DateAddedHardwareOK()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a test variable with a date 
            DateTime TestDate = DateTime.Now.Date;
            //Assigns the test date to the DateTime variable DateAdded
            hardware.DateAdded = TestDate;
            //Test to see if the result is correct
            Assert.AreEqual(hardware.DateAdded, TestDate);

        }

        [TestMethod]
        public void ActiveHardwareIDOK()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable set to true
            Boolean HardwareID = true;
            //Assigns true to the Boolean variable Active
            hardware.Active = HardwareID;
            //Test to see if the result is correct
            Assert.AreEqual(hardware.Active, HardwareID);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable for use with the validation
            Boolean Found = false;
            //Creates a test int variable
            Int32 HardwareID = 1;
            //Invoke the find method
            Found = hardware.Find(HardwareID);
            //Test to see if the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestHardwareIDFound()
        {
            //Creates and instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates another boolean variable this time to record if the data is ok
            Boolean OK = true;
            //Creates a test int variable
            Int32 TestHardwareID = 5;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Check the ID number
            if (hardware.HardwareID != 5)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //Creates and instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates another boolean variable this time to record if the data is ok
            Boolean OK = true;
            //Creates a test int variable
            Int32 TestHardwareID = 5;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Check the Name
            if (hardware.Name != "Test Name")
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //Creates and instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates another boolean variable this time to record if the data is ok
            Boolean OK = true;
            Int32 TestHardwareID = 5;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Check the Description
            if (hardware.Description != "Test Description")
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //Creates and instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates another boolean variable this time to record if the data is ok
            Boolean OK = true;
            Int32 TestHardwareID = 5;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Check the Price
            if (hardware.Price != 10)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAmountInStockFound()
        {
            //Creates and instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates another boolean variable this time to record if the data is ok
            Boolean OK = true;
            Int32 TestHardwareID = 5;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Check the AmountInStock
            if (hardware.AmountInStock != 10)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates a nother boolean variable thi time to record if the data is ok
            Boolean OK = true;
            //Creates a test int variable
            Int32 HardWareID = 5;
            //Invoke the find method
            Found = hardware.Find(HardWareID);
            //Check date
            if (hardware.DateAdded != Convert.ToDateTime("12/12/1212"))
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }
    }
}
