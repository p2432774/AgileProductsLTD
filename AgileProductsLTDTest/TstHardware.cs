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
            ClsHardware hardware = new ClsHardware();
            Assert.IsNotNull(hardware);
        }
    }
}
