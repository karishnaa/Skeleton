using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(anStock);
        }
        [TestMethod]
        public void StockNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            string testName = "Nike Hoodie";
            //assign the data to the property
            anStock.StockName = testName;
            //test to see that the two values are the same
            Assert.AreEqual(testName, anStock.StockName);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            double testPrice = 16.99;
            //assign the data to the property
            anStock.Price = testPrice;
            //test to see that the two values are the same
            Assert.AreEqual(testPrice, anStock.Price);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            int testQuantity = 45;
            //assign the data to the property
            anStock.Quantity = testQuantity;
            //test to see that the two values are the same
            Assert.AreEqual(testQuantity, anStock.Quantity);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            bool testAvailable = true;
            //assign the data to the property
            anStock.Available = testAvailable;
            //test to see that the two values are the same
            Assert.AreEqual(testAvailable, anStock.Available);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            string testDescription = "Comfortable Nike Hoodie!";
            //assign the data to the property
            anStock.Description = testDescription;
            //test to see that the two values are the same
            Assert.AreEqual(testDescription, anStock.Description);
        }

        [TestMethod]
        public void ArrivalDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            DateTime testArrivalDate = DateTime.Now.Date;
            //assign the data to the property
            anStock.ArrivalDate = testArrivalDate;
            //test to see that the two values are the same
            Assert.AreEqual(testArrivalDate, anStock.ArrivalDate);
        }
    }
}