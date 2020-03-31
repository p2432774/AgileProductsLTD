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
            software.SoftwareIDOK = TestData;
            Assert.AreEqual(software.SoftwareIDOK, TestData);
        }


        [TestMethod]
        public void SoftwareNameOK()
        {
            clsSoftware software = new clsSoftware();
            String TestData = "faran";
            software.softwareNameOK = TestData;
            Assert.AreEqual(software.softwareNameOK, TestData);
        }
        [TestMethod]
        public void SoftwareDescriptionOK()
        {
            clsSoftware software = new clsSoftware();
            String TestData = "Microsoft";
            software.SoftwareDescriptionOK = TestData;
            Assert.AreEqual(software.SoftwareDescriptionOK, TestData);
        }
        [TestMethod]
        public void SoftwarePriceOK()
        {
            clsSoftware software = new clsSoftware();
            Int32 TestData = 1;
            software.SoftwarePriceOK = TestData;
            Assert.AreEqual(software.SoftwarePriceOK, TestData);
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

    }
}
