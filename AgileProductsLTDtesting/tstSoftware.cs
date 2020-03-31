using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstSoftware
    {
        [TestMethod]
        public void InstanceOK()
        {

            clsSoftware software = new clsSoftware();
            //test to see that it exists
            Assert.IsNotNull(software);
        }

        [TestMethod]
        public void SoftwareIDPropertyOK()
        {

            clsSoftware software = new clsSoftware();
            Int32 TestData = 1;
            software.SoftwareID = TestData;
            Assert.AreEqual(software.SoftwareID, TestData);
        }


        [TestMethod]
        public void SoftwareNameOK()
        {
            clsSoftware software = new clsSoftware();
            String TestData = "faran";
            software.SoftwareName = TestData;
            Assert.AreEqual(software.SoftwareName, TestData);
        }
        [TestMethod]
        public void SoftwareDescriptionOK()
        {
            clsSoftware software = new clsSoftware();
            String TestData = "Microsoft";
            software.SoftwareDesciption = TestData;
            Assert.AreEqual(software.SoftwareDesciption, TestData);
        }
        [TestMethod]
        public void SoftwarePriceOK()
        {
            clsSoftware software = new clsSoftware();
            Int32 TestData = 1;
            software.SoftwarePrice = TestData;
            Assert.AreEqual(software.SoftwarePrice, TestData);
        }

        [TestMethod]
        public void DateofarrivalOK()
        {
            clsSoftware software = new clsSoftware();
            DateTime TestData = DateTime.Now.Date;
            software.Dateofarrival = TestData;
            Assert.AreEqual(software.Dateofarrival, TestData);
        }

        [TestMethod]
        public void InstockOK()
        {
            clsSoftware software = new clsSoftware();

            Boolean TestData = true;
            software.Instock = TestData;
            Assert.AreEqual(software.Instock, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSoftware software = new clsSoftware();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SoftwareID = 1;
            //invoke the method
            Found = software.Find(SoftwareID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSoftwareIDFound()
        {
            //create an instance of the class we want to create
            clsSoftware software = new clsSoftware();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SoftwareID = 1;
            //invoke the method
            Found = software.Find(SoftwareID);
            //check the address no
            if (software.SoftwareID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSoftwareNameFound()
        {
            clsSoftware software = new clsSoftware();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SoftwareID = 68;
            Found = software.Find(SoftwareID);
            if (software.SoftwareName != "Microsoft Office365")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSoftwareDesciptionFound()
        {
            clsSoftware software = new clsSoftware();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SoftwareID = 1;
            Found = software.Find(SoftwareID);
            if (software.SoftwareDesciption != "1232")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSoftwarePriceFound()
        {
            //create an instance of the class we want to create
            clsSoftware software = new clsSoftware();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SoftwareID = 1;
            //invoke the method
            Found = software.Find(SoftwareID);
            //check the address no
            if (software.SoftwarePrice != 20.0000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateofarrivalFound()
        {
            clsSoftware software = new clsSoftware();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SoftwareID = 1;
            Found = software.Find(SoftwareID);

            if (software.Dateofarrival != Convert.ToDateTime("12/01/2019"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


      

        [TestMethod]
        public void TestInstockFound()
        {
            clsSoftware software = new clsSoftware();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SoftwareID = 1;
            Found = software.Find(SoftwareID);

            if (software.Instock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
