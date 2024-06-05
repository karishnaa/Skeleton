using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;
using System.CodeDom;
using System.Data;
using System.Diagnostics;

namespace Testing4
{
    [TestClass]
    public class tstOrdersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);

        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.IsPaid = true;
            TestItem.Notes = "Test";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderID = 1;
            TestOrder.CustomerID = 1;
            TestOrder.StaffID = 1;
            TestOrder.Date = DateTime.Now.Date;
            TestOrder.IsPaid = true;
            TestOrder.Notes = "Test";
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.IsPaid = true;
            TestItem.Notes = "Test";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.IsPaid = true;
            TestItem.Notes = "Test";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.IsPaid = true;
            TestItem.Notes = "Test";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.OrderID = 2;
            TestItem.CustomerID = 2;
            TestItem.StaffID = 2;
            TestItem.Date = DateTime.Now.Date;
            TestItem.IsPaid = false;
            TestItem.Notes = "Test2";
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.IsPaid = true;
            TestItem.Notes = "Test";
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByOrderIDMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create an instance of the filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //apply a blank string (should return all records)
            FilteredOrders.ReportByOrderID("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByOrderIDNoneFound()
        {
            //create an instance of the class we want to create
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //apply a OrderID that doesn't exist
            FilteredOrders.ReportByOrderID("0");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByOrderIDTestDataFound()
        {
            //create an instance of the class we want to create
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a OrderID that doesn't exist
            FilteredOrders.ReportByOrderID("1");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredOrders.OrdersList[0].OrderID != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 2
                if (FilteredOrders.OrdersList[1].OrderID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ReportByOrderIDTestDataFound2()
        {
            //create an instance of the class we want to create
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a OrderID that doesn't exist
            FilteredOrders.ReportByOrderID("2");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 1)
            {
                //check that the first record is ID 2
                if (FilteredOrders.OrdersList[0].OrderID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ReportByOrderIDTestDataFoundNone()
        {
            //create an instance of the class we want to create
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a OrderID that doesn't exist
            FilteredOrders.ReportByOrderID("3");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 0)
            {
                OK = true;
            }
            else
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StatisticsGroupedByOrderID()
        {
            //create an instance of the class we want to create
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a OrderID that doesn't exist
            FilteredOrders.ReportByOrderID("1");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredOrders.OrdersList[0].OrderID != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 2
                if (FilteredOrders.OrdersList[1].OrderID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StatisticsGroupedByDispatched()
        {
            //create an instance of the class we want to create
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a OrderID that doesn't exist
            FilteredOrders.ReportByOrderID("1");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredOrders.OrdersList[0].OrderID != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 2
                if (FilteredOrders.OrdersList[1].OrderID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);
        }

       

    }
}
