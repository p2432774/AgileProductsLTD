using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;
using System.Collections.Generic;

namespace AgileProcuctsLTDtesting
{
    [TestClass]
    public class tstHardwareCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //Creates instance of clsHardwareCollection
            clsHardwareCollection hardwarecollection = new clsHardwareCollection();
            //Test to see if it exists
            Assert.IsNotNull(AllAddresses);
        }

        [TestMethod]
        public void HardwareListOK()
        {
            //Creates instance of clsHardwareCollection
            clsHardwareCollection hardwareCollection = new clsHardwareCollection();
        }
    }
}
