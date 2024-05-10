using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        public bool Available { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            tstStock StockName = new tstStock();
            //test to see that it exists
            Assert.IsNotNull(StockName);
        }
        [TestMethod]
        public void AvailableOK()
        {
            //create an instance of the class we want to create
            tstStock Available = new tstStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            Available.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Available.Available, TestData);
        }
    }
}
