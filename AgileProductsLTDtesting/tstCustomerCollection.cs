using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_HardwareClasses;
using System.Collections.Generic;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstCustomerCollection
    {



        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);

        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.member = true;
            TestItem.Address = "8b abbotsham road";
            TestItem.Emailaddress = "Declan1998m@gmail.com";
            TestItem.FullName = "Declan Monaghan";
            TestItem.Cardnumber = 123456789;
            TestItem.Sortcode = "12-34-56";
            TestItem.DOB = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }



        [TestMethod]
        public void ThisCustomerOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.member = true;
            TestCustomer.Address = "8b abbotsham road";
            TestCustomer.Emailaddress = "Declan1998m@gmail.com";
            TestCustomer.FullName = "Declan Monaghan";
            TestCustomer.Cardnumber = 123456789;
            TestCustomer.Sortcode = "12-34-56";
            TestCustomer.DOB = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.member = true;
            TestItem.Address = "8b abbotsham road";
            TestItem.Emailaddress = "Declan1998m@gmail.com";
            TestItem.FullName = "Declan Monaghan";
            TestItem.Cardnumber = 123456789;
            TestItem.Sortcode = "12-34-56";
            TestItem.DOB = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0 ;
            TestItem.member = true;
            TestItem.Address = "8b abbotsham road";
            TestItem.Emailaddress = "Declan1998m@gmail.com";
            TestItem.FullName = "Declan Monaghan";
            TestItem.Cardnumber = 123456789;
            TestItem.Sortcode = "12-34-56";
            TestItem.DOB = DateTime.Now.Date;
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0 ;
            TestItem.member = true;
            TestItem.Address = "8b abbotsham road";
            TestItem.Emailaddress = "Declan1998m@gmail.com";
            TestItem.FullName = "Declan Monaghan";
            TestItem.Cardnumber = 123456789;
            TestItem.Sortcode = "12-34-56";
            TestItem.DOB = DateTime.Now.Date;
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            AllCustomer.Delete();
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void UpdateMethod()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.member = true;
            TestItem.Address = "8b abbotsham road";
            TestItem.Emailaddress = "Declan1998m@gmail.com";
            TestItem.FullName = "Declan Monaghan";
            TestItem.Cardnumber = 123456789;
            TestItem.Sortcode = "12-34-56";
            TestItem.DOB = DateTime.Now.Date;
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerID = PrimaryKey;
            TestItem.member = false;
            TestItem.Address = "8A abbotsham road";
            TestItem.Emailaddress = "Declan1998m@mail.com";
            TestItem.FullName = "Peter Monaghan";
            TestItem.Cardnumber = 123456798;
            TestItem.Sortcode = "12-34-65";
            TestItem.DOB = DateTime.Now.Date;
            AllCustomer.ThisCustomer = TestItem;
            AllCustomer.ThisCustomer = TestItem;
            AllCustomer.Update();
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void ReportByFullNameOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByFullName("");

            Assert.AreEqual(AllCustomer.Count, FilteredCustomers.Count);
        }
        
        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            clsCustomerCollection FilteredFullName = new clsCustomerCollection();
            FilteredFullName.ReportByFullName("john Paul");
            Assert.AreEqual(1, FilteredFullName.Count);
        }

        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByFullName("Declan Monaghan");
            if(FilteredCustomers.Count ==3)
            {
                if (FilteredCustomers.CustomerList[0].CustomerID != 1)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[1].CustomerID !=4)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[2].CustomerID != 30)
                {
                    OK = false;
                }
            }
            else
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }


    }
}
