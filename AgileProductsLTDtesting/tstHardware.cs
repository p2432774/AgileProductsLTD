using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstHardware
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsHardware hardware = new clsHardware();
            Assert.IsNotNull(hardware);
        }

        [TestMethod]
        public void DateAddedHardwareOK()
        {
            clsHardware hardware = new clsHardware();
            DateTime TestDate = DateTime.Now.Date;
            hardware.DateAdded = TestDate;
            Assert.AreEqual(hardware.DateAdded, TestDate);

        }

        [TestMethod]
        public void ActiveHardwareIDOK()
        {
            clsHardware hardware = new clsHardware();
            Boolean HardwareID = true;
            hardware.Active = HardwareID;
            Assert.AreEqual(hardware.Active, HardwareID);
        }
    }
}
