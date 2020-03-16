using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstHardware
    {
        [TestMethod]
        public void HardwareTest()
        {
            clsHardware hardware = new clsHardware();
            Assert.IsNotNull(hardware);

        }
    }
}