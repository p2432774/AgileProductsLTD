using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProcuctsLTDtesting
{
    [TestClass]
    public class tstHardware
    {

        //Creates test data 
        string HardWareID = "1";
        string Name = "Name";
        string Description = "This is a description";
        string Price = "125";
        string AmountInStock = "5";
        string StockRequired = "False";
        string DateAdded = DateTime.Now.Date.ToString();

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

        //    FIND -- FIND -- FIND -- FIND -- FIND -- FIND -- FIND -- FIND -- FIND -- FIND   

        [TestMethod]
        public void FindMethodOK()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable for use with the validation
            Boolean Found = false;
            //Creates a test int variable
            Int32 TestHardwareID = 120;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Test to see if the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestHardwareIDFound()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates another boolean variable this time to record if the data is ok
            Boolean OK = true;
            //Creates a test int variable
            Int32 TestHardwareID = 120;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Check the ID number
            if (hardware.HardwareID != 120)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates another boolean variable this time to record if the data is ok
            Boolean OK = true;
            //Creates a test int variable
            Int32 TestHardwareID = 120;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Check the Name
            if (hardware.Name != "DoNotRemove")
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates another boolean variable this time to record if the data is ok
            Boolean OK = true;
            Int32 TestHardwareID = 120;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Check the Description
            if (hardware.Description != "TestProduct")
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates another boolean variable this time to record if the data is ok
            Boolean OK = true;
            Int32 TestHardwareID = 120;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Check the Price
            if (hardware.Price != 100)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAmountInStockFound()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates another boolean variable this time to record if the data is ok
            Boolean OK = true;
            Int32 TestHardwareID = 120;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Check the AmountInStock
            if (hardware.AmountInStock != 5)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockRequiredFound()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a boolean variable to store the result of the search
            Boolean Found = false;
            //Creates another boolean variable this time to record if the data is ok
            Boolean OK = true;
            Int32 TestHardwareID = 120;
            //Invoke the find method
            Found = hardware.Find(TestHardwareID);
            //Check the AmountInStock
            if (hardware.StockRequired != false)
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
            Int32 HardWareID = 120;
            //Invoke the find method
            Found = hardware.Find(HardWareID);
            //Check date
            if (hardware.DateAdded != Convert.ToDateTime("17/05/2020"))
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        // VALIDATION -- VALIDATION -- VALIDATION --VALIDATION -- VALIDATION -- VALIDATION

        [TestMethod]
        public void ValidMethodOK()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Invoke the Validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Name = "";
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Name = "a";
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Name = "aa";
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

          [TestMethod]
        public void NameMaxLessOne()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Name = "";
            Name = Name.PadRight(24, 'a');
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Name = "";
            Name = Name.PadRight(13, 'a');
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Name = "";
            Name = Name.PadRight(26, 'a');
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Name = "";
            Name = Name.PadRight(500, 'a');
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Description = "";
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DesriptionMin()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Description = "a";
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DesriptionMinPlusOne()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Description = "aa";
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DesriptionMaxLessOne()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Description = "";
            Description = Description.PadRight(99, 'a');
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DesriptionMax()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Description = "";
            Description = Description.PadRight(100, 'a');
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DesriptionMid()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Description = "";
            Description = Description.PadRight(50, 'a');
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DesriptionMaxPlusOne()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Description = "";
            Description = Description.PadRight(101, 'a');
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DesriptionExtremeMax()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test string variable to pass to the method
            string Description = "";
            Description = Description.PadRight(500, 'a');
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Create a test date variable to pass to the method
            DateTime TestDate;
            //Sets TestDate to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever date is 100 years before
            TestDate = TestDate.AddYears(-100);
            //Converts the date to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //Create instance of clsHardWare
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test date variable to pass to the method
            DateTime TestDate;
            //Sets TestDate to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever date is 1 day before
            TestDate = TestDate.AddDays(-1);
            //Converts the date to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //Create instance of clsHardWare
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test date variable to pass to the method
            DateTime TestDate;
            //Sets TestDate to todays date
            TestDate = DateTime.Now.Date;
            //Converts the date to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //Create instance of clsHardWare
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a test date variable to pass to the method
            DateTime TestDate;
            //Sets TestDate to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever date is 1 day before
            TestDate = TestDate.AddDays(1);
            //Converts the date to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Create a test date variable to pass to the method
            DateTime TestDate;
            //Sets TestDate to todays date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever date is 100 years before
            TestDate = TestDate.AddYears(100);
            //Converts the date to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DataAddedInvalidData()
        {
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a string variable to store an error message
            String Error = "";
            //Creates a string variable and sets it value to a non date value
            string DateAdded = "This is not a date!";
            //Invoke the validation method
            Error = hardware.Valid(Name, Description, Price, AmountInStock, StockRequired, DateAdded);
            //Test to see if an error has occured
            Assert.AreNotEqual(Error, "");
        }
    }
}
