using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstOrder
    {
        public object AnOrder { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
  
        [TestMethod]
        public void OrderIDPropertyOK()
        {
         clsOrder AnOrder = new clsOrder();
         Int32 TestData = 1;
         AnOrder.OrderID = TestData;
         Assert.AreEqual(AnOrder.OrderID, TestData);
        }
        [TestMethod]
        public void OrderLineCollectionIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void ShippedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Active = TestData;
            Assert.AreEqual(AnOrder.Active, TestData);
        }
        [TestMethod]
        public void ShippingViaPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "RoyalMail";
            AnOrder.ShippingVia = TestData;
            Assert.AreEqual(AnOrder.ShippingVia, TestData);
        }

    }

}
