using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProcuctsLTDtesting
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
        public void  NameOK()
        {
            clsHardware hardware = new clsHardware();
            string TestName = "Hardware Name";
            hardware.Name = TestName;
            Assert.AreEqual(hardware.Name, TestName);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            clsHardware hardware = new clsHardware();
            string TestDescription = "This is a product description";
            hardware.Description = TestDescription;
            Assert.AreEqual(hardware.Description, TestDescription);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsHardware hardware = new clsHardware();
            int TestPrice = 10;
            hardware.Price = TestPrice;
            Assert.AreEqual(hardware.Price, TestPrice);
        }

        [TestMethod]
        public void AmountInStockOK()
        {
            clsHardware hardware = new clsHardware();
            int TestStock = 5;
            hardware.AmountInStock = TestStock;
            Assert.AreEqual(hardware.AmountInStock, TestStock);
        }

        [TestMethod]
        public void StockRequiredOK()
        {
            clsHardware hardware = new clsHardware();
            Boolean TestStockRequired = false;
            hardware.StockRequired = TestStockRequired;
            Assert.AreEqual(hardware.StockRequired, TestStockRequired);
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
