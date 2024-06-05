using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;
using System.CodeDom;
using System.Data;

namespace Testing5
{
    [TestClass]
    public class tstDeliveryCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // test to see that it exists
            Assert.IsNotNull(AllDeliveries);
        }

        [TestMethod]
        public void DeliveryListOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsDelivery> TestList = new List<clsDelivery>();
            // add an item to the list
            // create the item of test data
            clsDelivery TestItem = new clsDelivery();
            // set its properties
            TestItem.DeliveryID = 1;
            TestItem.OrderID = 1;
            TestItem.DeliveryAddress = "123 Test Street";
            TestItem.DateOfDelivery = DateTime.Now.Date;
            TestItem.Dispatched = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllDeliveries.DeliveryList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.DeliveryList, TestList);
        }

        [TestMethod]
        public void ThisDeliveryPropertyOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create some test data to assign to the property
            clsDelivery TestDelivery = new clsDelivery();
            // set the properties of the test object
            TestDelivery.DeliveryID = 1;
            TestDelivery.OrderID = 1;
            TestDelivery.DeliveryAddress = "123 Test Street";
            TestDelivery.DateOfDelivery = DateTime.Now.Date;
            TestDelivery.Dispatched = true;
            // assign the data to the property
            AllDeliveries.ThisDelivery = TestDelivery;
            // test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.ThisDelivery, TestDelivery);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsDelivery> TestList = new List<clsDelivery>();
            // add an item to the list
            // create the item of test data
            clsDelivery TestItem = new clsDelivery();
            // set its properties
            TestItem.DeliveryID = 1;
            TestItem.OrderID = 1;
            TestItem.DeliveryAddress = "123 Test Street";
            TestItem.DateOfDelivery = DateTime.Now.Date;
            TestItem.Dispatched = true;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllDeliveries.DeliveryList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create the item of test data
            clsDelivery TestItem = new clsDelivery();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.DeliveryID = 1;
            TestItem.OrderID = 1;
            TestItem.DeliveryAddress = "123 Test Street";
            TestItem.DateOfDelivery = DateTime.Now.Date;
            TestItem.Dispatched = true;
            // set ThisDelivery to the test data
            AllDeliveries.ThisDelivery = TestItem;
            // add the record
            PrimaryKey = AllDeliveries.Add();
            // set the primary key of the test data
            TestItem.DeliveryID = PrimaryKey;
            // find the record
            AllDeliveries.ThisDelivery.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.ThisDelivery, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create the item of test data
            clsDelivery TestItem = new clsDelivery();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.DeliveryID = 1;
            TestItem.OrderID = 1;
            TestItem.DeliveryAddress = "123 Test Street";
            TestItem.DateOfDelivery = DateTime.Now.Date;
            TestItem.Dispatched = true;
            // set ThisDelivery to the test data
            AllDeliveries.ThisDelivery = TestItem;
            // add the record
            PrimaryKey = AllDeliveries.Add();
            // set the primary key of the test data
            TestItem.DeliveryID = PrimaryKey;
            // find the record
            AllDeliveries.ThisDelivery.Find(PrimaryKey);
            // delete the record
            AllDeliveries.Delete();
            // now find the record
            Boolean Found = AllDeliveries.ThisDelivery.Find(PrimaryKey);
            // test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create the item of test data
            clsDelivery TestItem = new clsDelivery();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.DeliveryID = 1;
            TestItem.OrderID = 1;
            TestItem.DeliveryAddress = "123 Test Street";
            TestItem.DateOfDelivery = DateTime.Now.Date;
            TestItem.Dispatched = true;
            // set ThisDelivery to the test data
            AllDeliveries.ThisDelivery = TestItem;
            // add the record
            PrimaryKey = AllDeliveries.Add();
            // set the primary key of the test data
            TestItem.DeliveryID = PrimaryKey;
            // modify the test data
            TestItem.DeliveryID = 2;
            TestItem.OrderID = 2;
            TestItem.DeliveryAddress = "456 Test Street";
            TestItem.DateOfDelivery = DateTime.Now.Date;
            TestItem.Dispatched = false;
            // set the record based on the new test data
            AllDeliveries.ThisDelivery = TestItem;
            // update the record
            AllDeliveries.Update();
            // find the record
            AllDeliveries.ThisDelivery.Find(PrimaryKey);
            // test to see ThisDelivery matches the test data
            Assert.AreEqual(AllDeliveries.ThisDelivery, TestItem);
        }
        [TestMethod]
        public void ReportByDeliveryAddressMethodOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create an instance of the filtered data
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // apply a blank string (should return all records)
            FilteredDeliveries.ReportByDeliveryAddress("");
            // test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.Count, FilteredDeliveries.Count);
        }

        [TestMethod]
        public void ReportByDeliveryAddressNoneFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // apply a delivery address that doesn't exist
            FilteredDeliveries.ReportByDeliveryAddress("No deliveries found");
            // test to see that the two values are the same
            Assert.AreEqual(0, FilteredDeliveries.Count);
        }
        [TestMethod]
        public void ReportByDeliveryAddressTestDataFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a delivery address that doesn't exist
            FilteredDeliveries.ReportByDeliveryAddress("123 Test Street");
            // check that the correct number of records are found
            if (FilteredDeliveries.Count == 2)
            {
                // check that the first record is ID 1
                if (FilteredDeliveries.DeliveryList[0].DeliveryID != 1)
                {
                    OK = false;
                }
                // check that the first record is ID 2
                if (FilteredDeliveries.DeliveryList[1].DeliveryID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ReportByDateOfDeliveryMethodOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create an instance of the filtered data
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // apply a blank string (should return all records)
            FilteredDeliveries.ReportByDateOfDelivery("");
            // test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.Count, FilteredDeliveries.Count);
        }
        [TestMethod]
        public void ReportByDateOfDeliveryNoneFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // apply a date that doesn't exist
            FilteredDeliveries.ReportByDateOfDelivery("No deliveries found");
            // test to see that the two values are the same
            Assert.AreEqual(0, FilteredDeliveries.Count);
        }
        [TestMethod]
        public void ReportByDateOfDeliveryTestDataFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a date that doesn't exist
            FilteredDeliveries.ReportByDateOfDelivery("01/01/2021");
            // check that the correct number of records are found
            if (FilteredDeliveries.Count == 2)
            {
                // check that the first record is ID 1
                if (FilteredDeliveries.DeliveryList[0].DeliveryID != 1)
                {
                    OK = false;
                }
                // check that the first record is ID 2
                if (FilteredDeliveries.DeliveryList[1].DeliveryID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ReportByDispatchedMethodOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create an instance of the filtered data
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // apply a blank string (should return all records)
            FilteredDeliveries.ReportByDispatched("");
            // test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.Count, FilteredDeliveries.Count);
        }
        [TestMethod]
        public void ReportByDispatchedNoneFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // apply a dispatched status that doesn't exist
            FilteredDeliveries.ReportByDispatched("No deliveries found");
            // test to see that the two values are the same
            Assert.AreEqual(0, FilteredDeliveries.Count);
        }
        [TestMethod]
        public void ReportByDispatchedTestDataFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // var to store outcome
            Boolean OK = true;
            // apply a dispatched status that doesn't exist
            FilteredDeliveries.ReportByDispatched("True");
            // check that the correct number of records are found
            if (FilteredDeliveries.Count == 2)
            {
                // check that the first record is ID 1
                if (FilteredDeliveries.DeliveryList[0].DeliveryID != 1)
                {
                    OK = false;
                }
                // check that the first record is ID 2
                if (FilteredDeliveries.DeliveryList[1].DeliveryID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ReportByOrderIDMethodOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create an instance of the filtered data
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // apply a blank string (should return all records)
            FilteredDeliveries.ReportByOrderID("");
            // test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.Count, FilteredDeliveries.Count);
        }
        [TestMethod]
        public void ReportByOrderIDNoneFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // apply an order ID that doesn't exist
            FilteredDeliveries.ReportByOrderID("No deliveries found");
            // test to see that the two values are the same
            Assert.AreEqual(0, FilteredDeliveries.Count);
        }
        [TestMethod]
        public void ReportByOrderIDTestDataFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // var to store outcome
            Boolean OK = true;
            // apply an order ID that doesn't exist
            FilteredDeliveries.ReportByOrderID("1");
            // check that the correct number of records are found
            if (FilteredDeliveries.Count == 2)
            {
                // check that the first record is ID 1
                if (FilteredDeliveries.DeliveryList[0].DeliveryID != 1)
                {
                    OK = false;
                }
                // check that the first record is ID 2
                if (FilteredDeliveries.DeliveryList[1].DeliveryID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // test to see that the two values are the same
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // var to store the outcome
            Boolean Found = true;
            // find the record
            AllDeliveries.Find(1);
            // test to see that the two values are the same
            if (AllDeliveries.ThisDelivery.DeliveryID != 1)
            {
                Found = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestDeliveryIDFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // var to store the outcome
            Boolean Found = true;
            // find the record
            Boolean OK = true;
            // find the record
            AllDeliveries.Find(1);
            // check the delivery ID
            if (AllDeliveries.ThisDelivery.DeliveryID != 1)
            {
                OK = false;
            }
            // test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // var to store the outcome
            Boolean Found = true;
            // find the record
            Boolean OK = true;
            // find the record
            AllDeliveries.Find(1);
            // check the order ID
            if (AllDeliveries.ThisDelivery.OrderID != 1)
            {
                OK = false;
            }
            // test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // var to store the outcome
            Boolean Found = true;
            // find the record
            Boolean OK = true;
            // find the record
            AllDeliveries.Find(1);
            // check the delivery address
            if (AllDeliveries.ThisDelivery.DeliveryAddress != "123 Test Street")
            {
                OK = false;
            }
            // test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfDeliveryFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // var to store the outcome
            Boolean Found = true;
            // find the record
            Boolean OK = true;
            // find the record
            AllDeliveries.Find(1);
            // check the date of delivery
            if (AllDeliveries.ThisDelivery.DateOfDelivery != Convert.ToDateTime("01/01/2021"))
            {
                OK = false;
            }
            // test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDispatchedFound()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // var to store the outcome
            Boolean Found = true;
            // find the record
            Boolean OK = true;
            // find the record
            AllDeliveries.Find(1);
            // check the dispatched status
            if (AllDeliveries.ThisDelivery.Dispatched != true)
            {
                OK = false;
            }
            // test to see that the two values are the same
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StatisticsGroupedByDeliveryStatus()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create an instance of the filtered data
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // apply a blank string (should return all records)
            FilteredDeliveries.StatisticsGroupedByDeliveryStatus("");
            // test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.Count, FilteredDeliveries.Count);
        }

        [TestMethod]
        public void StatisticsGroupedByOrderID()
        {
            // create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            // create an instance of the filtered data
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            // apply a blank string (should return all records)
            FilteredDeliveries.StatisticsGroupedByOrderID("");
            // test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.Count, FilteredDeliveries.Count);
        }
        }

    }

