using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class TstHardware
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsHardware hardware = new clsHardware();
            Assert.IsNotNull(hardware);
        }
    }
}
