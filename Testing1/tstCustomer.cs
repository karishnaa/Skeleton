using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //
            clsCustomers anCustomers = new clsCustomers();
            // test to see that it exists 
            Assert.IsNotNull(anCustomers);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            // create an instance of the class we want to create 
            clsCustomers AnCustomer = new clsCustomers();
            // create some test data to assign to the property 
            Boolean TestData = true;
            // assign the data to the property 
            AnCustomer.Active = TestData;
            // test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Active, TestData);

        }
    }
}
