using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstFindMethodOK
    {
        [TestMethod]
        public void FindMethodOK()
        {
            clsoftware software = new clsoftware();
            Boolean Found = false;
            Int32 SoftwareID = 1;
            Found = software.Find(SoftwareID);
            Assert.IsTrue(Found);



        }

    }
    }
