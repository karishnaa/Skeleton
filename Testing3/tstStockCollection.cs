using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;

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
        /** commented out to stop data from being created each time i run tests
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection allStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.StockName = "Nike Hoodie";
            TestItem.Quantity = 23;
            TestItem.Price = 39.99;
            TestItem.ArrivalDate = Convert.ToDateTime("10/05/2024");
            TestItem.Description = "Comfortable Nike Hoodie";
            TestItem.Available = true;
            //set thisstock to the test data
            allStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = allStock.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            allStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allStock.ThisStock, TestItem);

        }**/
        /** commented out to stop data from new records being created each time i run tests
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instacne of the class we want to create
            clsStockCollection allStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockName = "Nike Hoodie";
            TestItem.Quantity = 23;
            TestItem.Price = 39.99;
            TestItem.ArrivalDate = DateTime.Now;
            TestItem.Description = "Comfortable Nike Hoodie";
            TestItem.Available = true;
            //set thisstock to the test data
            allStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = allStock.Add();
            //set the primary ket of the test data
            TestItem.StockID = PrimaryKey;
            //modify the record
            TestItem.StockName = "Nike Bag";
            TestItem.Quantity = 20;
            TestItem.Price = 20;
            TestItem.ArrivalDate = DateTime.Now;
            TestItem.Description = "Comfortable Nike Bag";
            TestItem.Available = false;
            //set the record based on the new test data
            allStock.ThisStock = TestItem;
            //update the record
            allStock.Update();
            //find the record
            allStock.ThisStock.Find(PrimaryKey);
            //test to see if ThisStock matches the test data
            Assert.AreEqual(allStock.ThisStock, TestItem);
        }
        **/
        /** commented out to stop data from being created each time i run tests
        [TestMethod]
        public void DeleteMethodOK() 
        {
            //create an instance of the class we want to create
            clsStockCollection allStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockName = "Nike Hoodie";
            TestItem.Quantity = 23;
            TestItem.Price = 39.99;
            TestItem.ArrivalDate = Convert.ToDateTime("10/05/2024");
            TestItem.Description = "Comfortable Nike Hoodie";
            TestItem.Available = true;
            //set ThisStock to the test data
            allStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = allStock.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the record
            allStock.ThisStock.Find(PrimaryKey);
            //delete the record
            allStock.Delete();
            //now find the record
            Boolean Found = allStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }**/
        [TestMethod]
        public void ReportByStockNameMethodOk() 
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection allStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStock.ReportByStockName("");
            //test to see that the two values are the same
            Assert.AreEqual(allStock.Count, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportByStockNameNoneFound() 
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a stock name that doesn't exist
            FilteredStock.ReportByStockName("Bape Hoodie");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportByStockNameDataFound() 
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a stock name that doesn't exist
            FilteredStock.ReportByStockName("hii");
            //check that the correct number of records are found
            if (FilteredStock.Count == 2)
            {
                //check to see that the first record is 100
                if (FilteredStock.StockList[0].StockID != 34)
                {
                    OK = false;
                }
                //check to see that the second record is 102
                if (FilteredStock.StockList[1].StockID != 35)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
        
    }
}
