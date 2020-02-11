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
}
