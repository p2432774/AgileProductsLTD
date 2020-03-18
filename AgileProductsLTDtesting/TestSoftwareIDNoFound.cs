using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgileProductsLTDtesting
{
    [TestClass]
   public class TestSoftwareIDNoFound
  {
       //private int SoftwareID;
   //    public bool OK { get; private set; }
    

        [TestMethod]
        public void testSoftwareIDNoFound()
        {
            clsoftware software = new clsoftware();
            Boolean Found = false;
            Int32 SoftwareID = 1;
            Boolean OK = true;
            Found = software.Find(SoftwareID);
            if (software.SoftwareID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
