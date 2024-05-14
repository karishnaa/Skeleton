using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstDelivery
    {
        public object AnDelivery { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //test to see that it exists
            Assert.IsNotNull(AnDelivery);
        }

        [TestMethod]
        public void DeliveryIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnDelivery.DeliveryID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.DeliveryID, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //create some test data to assign to the property
            int TestData = 1001;
            //assign the data to the property
            AnDelivery.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.OrderID, TestData);
        }

        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //create some test data to assign to the property
            string TestData = "123 Main Street";
            //assign the data to the property
            AnDelivery.DeliveryAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.DeliveryAddress, TestData);
        }

        [TestMethod]
        public void DateOfDeliveryPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //create some test data to assign to the property
            DateTime TestData = new DateTime(2024, 5, 13);
            //assign the data to the property
            AnDelivery.DateOfDelivery = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.DateOfDelivery, TestData);
        }

        [TestMethod]
        public void DispatchedPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            AnDelivery.Dispatched = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.Dispatched, TestData);
        }
    }
}
