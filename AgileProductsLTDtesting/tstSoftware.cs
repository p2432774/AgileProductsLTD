using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstSoftware
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsSoftware software = new clsSoftware();
            Assert.IsNotNull(software);
       
        }

    }
    [TestMethod]
    public void NameSoftwareOK()
    {
        clsSoftware software = new clsSoftware();
        string TestData = "faran";
        software.softwareNameOK = TestData;
        Assert.AreEqual(software.softwareNameOK, TestData);
    }
    [TestMethod]
    public void DecriptionSoftwareOK()
    {
        clsSoftware software = new clsSoftware();
        string TestData = "Microsoft";
        software.descriptionSoftwareOK = TestData;
        Assert.AreEqual(software.descriptionSoftwareOK, TestData);
    }
    [TestMethod]
    public void PriceSoftwareOK()
    {
        clsSoftware software = new clsSoftware();
        int TestData = 1;
        software.Price = TestData;
        Assert.AreEqual(software.Price, TestData);
    }

    [TestMethod]
    public void ActivePropertyok()
    {
        clsSoftware software = new clsSoftware();
        Boolean TestData = true;
        software.Active = TestData;
        Assert.AreEqual(software.Active, TestData);
    }

}
}
