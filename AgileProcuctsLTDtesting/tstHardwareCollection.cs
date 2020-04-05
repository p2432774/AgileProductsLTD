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
            hardware.HardwareID = 1;
            hardware.Name = "Name";
            hardware.Description = "This is a description";
            hardware.Price = 175;
            hardware.AmountInStock = 5;
            hardware.StockRequired = true;
            hardware.DateAdded = DateTime.Now.Date;
            //Add the item to the list
            hardwareList.Add(hardware);
            //Assign the data to a product
            hardwareCollection.HardwareProductList = hardwareList;
            //Test to see if the result is correct
            Assert.AreEqual(hardwareCollection.HardwareProductList, hardwareList);
        }

        [TestMethod]
        public void ThisHardwareOK()
        {
            //Creates instance of clsHardwareCollection
            clsHardwareCollection HardwareCollection = new clsHardwareCollection();
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Sets the properties
            hardware.HardwareID = 1;
            hardware.Name = "Name";
            hardware.Description = "This is a description";
            hardware.Price = 175;
            hardware.AmountInStock = 5;
            hardware.StockRequired = true;
            hardware.DateAdded = DateTime.Now.Date;
            //Assign data to a product
            HardwareCollection.ThisHardwareProduct = hardware;
            //Test to see if the result is correct
            Assert.AreEqual(HardwareCollection.ThisHardwareProduct, hardware);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Creates instance of clsHardwareCollection
            clsHardwareCollection hardwareCollection = new clsHardwareCollection();
            //Creates a list with test data
            List<clsHardware> hardwareList = new List<clsHardware>();
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Sets the properties
            hardware.HardwareID = 1;
            hardware.Name = "Name";
            hardware.Description = "This is a description";
            hardware.Price = 175;
            hardware.AmountInStock = 5;
            hardware.StockRequired = true;
            hardware.DateAdded = DateTime.Now.Date;
            //Add the item to the list
            hardwareList.Add(hardware);
            //Assigns data to product
            hardwareCollection.HardwareProductList = hardwareList;
            //Test to see if the result is correct
            Assert.AreEqual(hardwareCollection.Count, hardwareList.Count);
        }
    }
}
