using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            //
            clsCustomers anCustomers = new clsCustomers();
            // test to see that it exists 
            Assert.IsNotNull(anCustomers);
        }
    }
}
