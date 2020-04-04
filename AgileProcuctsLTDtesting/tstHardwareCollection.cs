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
            Assert.IsNotNull(hardwarecollection);
        }

        [TestMethod]
        public void HardwareListOK()
        {
            //Creates instance of clsHardwareCollection
            clsHardwareCollection hardwareCollection = new clsHardwareCollection();
            //Creates a list with test data
            List<clsHardware> hardwareList = new List<clsHardware>();
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Sets the properties
            hardware.Name = "Name";
            hardware.Description = "This is a description";
            hardware.Price = 175;
            hardware.AmountInStock = 5;
            hardware.StockRequired = true;
            hardware.DateAdded = DateTime.Now.Date;

        }
    }
}
