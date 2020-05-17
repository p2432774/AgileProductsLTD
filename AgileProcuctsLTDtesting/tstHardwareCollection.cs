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

        [TestMethod]
        public void AddMethodOK()
        {
            //Create instance of clsHardwareCollection
            clsHardwareCollection hardwareCollection = new clsHardwareCollection();
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a primary key ID 
            Int32 PrimaryKey = 0;
            //Sets the properties
            hardware.HardwareID = 1;
            hardware.Name = "SecondName";
            hardware.Description = "This is a description";
            hardware.Price = 175;
            hardware.AmountInStock = 5;
            hardware.StockRequired = true;
            hardware.DateAdded = DateTime.Now.Date;
            //Assigns the data to the ThisHardwareProduct 
            hardwareCollection.ThisHardwareProduct = hardware;
            //Adds the record
            PrimaryKey = hardwareCollection.Add();
            //Sets the primary key for the data
            hardware.HardwareID = PrimaryKey;
            //Find the record
            hardwareCollection.ThisHardwareProduct.Find(PrimaryKey);
            //Test to see if the result is correct
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create instance of clsHardwareCollection
            clsHardwareCollection hardwareCollection = new clsHardwareCollection();
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a primary key ID 
            Int32 PrimaryKey = 0;
            //Sets the properties
            hardware.HardwareID = 1;
            hardware.Name = "SecondName";
            hardware.Description = "This is a description";
            hardware.Price = 175;
            hardware.AmountInStock = 5;
            hardware.StockRequired = true;
            hardware.DateAdded = DateTime.Now.Date;
            //Assigns the data to the ThisHardwareProduct 
            hardwareCollection.ThisHardwareProduct = hardware;
            //Adds the record
            PrimaryKey = hardwareCollection.Add();
            //Sets the primary key for the data
            hardware.HardwareID = PrimaryKey;
            //Finds the record
            hardwareCollection.Delete();
            //Now find the record
            Boolean Found = hardwareCollection.ThisHardwareProduct.Find(PrimaryKey);
            //Test to see if it is found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Creates instance of clsHardwareCollection
            clsHardwareCollection hardwareCollection = new clsHardwareCollection();
            //Creates instance of clsHardware
            clsHardware hardware = new clsHardware();
            //Creates a primary key ID 
            Int32 PrimaryKey = 0;
            //Sets the properties
            hardware.HardwareID = 1;
            hardware.Name = "FirstName";
            hardware.Description = "This is a description";
            hardware.Price = 175;
            hardware.AmountInStock = 5;
            hardware.StockRequired = true;
            hardware.DateAdded = DateTime.Now.Date;
            //Sets ThisHardwareProduct to the data
            hardwareCollection.ThisHardwareProduct = hardware;
            //Adds the record
            PrimaryKey = hardwareCollection.Add();
            //Set the primary key of the test data
            hardware.HardwareID = PrimaryKey;
            //Modify the properties
            hardware.HardwareID = 1;
            hardware.Name = "SecondName";
            hardware.Description = "This is a second description";
            hardware.Price = 200;
            hardware.AmountInStock = 10;
            hardware.StockRequired = false;
            hardware.DateAdded = DateTime.Now.Date;
            //Set the record based on the new data
            hardwareCollection.ThisHardwareProduct = hardware;
            //Update the record
            hardwareCollection.Update();
            //Find the primary key
            hardwareCollection.ThisHardwareProduct.Find(PrimaryKey);
            //Test to see if the result is correct
            Assert.AreEqual(hardwareCollection.ThisHardwareProduct, hardware);
        }

        [TestMethod]
        public void FilterByPriceMethodOK()
        {
            //Creates instance of clsHardwareCollection
            clsHardwareCollection FilterBy = new clsHardwareCollection();
            FilterBy.FilterByPrice(100);
            //Test to see if the result is correct
            Assert.AreEqual(1, FilterBy.Count);
        }

        [TestMethod]
        public void FilterByPriceDataFound()
        {
            //Creates instance of clsHardwareCollection
            clsHardwareCollection hardwareCollection = new clsHardwareCollection();
            //Creates a Boolean variable to store the outcome 
            Boolean OK = true;
            //Apply a test price
            hardwareCollection.FilterByPrice(100);
            //Check if any record matches the price
            if (hardwareCollection.Count == 1)
            {
                if (hardwareCollection.HardwareProductList[0].HardwareID != 120)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            } 
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }
    }
}
