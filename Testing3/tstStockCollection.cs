using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection allStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(allStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection allStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an Item to the List
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.StockID = 1;
            TestItem.StockName = "Nike Hoodie";
            TestItem.Quantity = 23;
            TestItem.Price = 39.99;
            TestItem.ArrivalDate = Convert.ToDateTime("10/05/2024");
            TestItem.Description = "Comfortable Nike Hoodie";
            TestItem.Available = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            allStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allStock.StockList, TestList);

        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection allStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.StockID = 1;
            TestStock.StockName = "Nike Hoodie";
            TestStock.Quantity = 23;
            TestStock.Price = 39.99;
            TestStock.ArrivalDate = Convert.ToDateTime("10/05/2024");
            TestStock.Description = "Comfortable Nike Hoodie";
            TestStock.Available = true;
            //assign the data to the property
            allStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(allStock.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection allStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.StockID = 1;
            TestItem.StockName = "Nike Hoodie";
            TestItem.Quantity = 23;
            TestItem.Price = 39.99;
            TestItem.ArrivalDate = Convert.ToDateTime("10/05/2024");
            TestItem.Description = "Comfortable Nike Hoodie";
            TestItem.Available = true;
            //add the item to the test list
            TestList.Add(TestItem); 
            //assign the data to the property
            allStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual (allStock.StockList.Count, TestList.Count);
        }
    }
}
