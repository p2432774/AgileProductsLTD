using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgileProductsLTDtesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }
    }
}
