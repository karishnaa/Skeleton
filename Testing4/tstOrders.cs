using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        // create test data
        string OrderID = "1";
        string CustomerID = "1";
        string StaffID = "1";
        string StockID = "1";
        string OrderDate = DateTime.Now.Date.ToString();
        string IsPaid = "True";
        string Notes = "Test Notes";

        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrder.OrderID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrder.CustomerID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrder.StaffID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffID, TestData);
        }
        [TestMethod]
        public void StockIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrder.StockID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.StockID, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            AnOrder.OrderDate = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void IsPaidPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Boolean TestData = true;
            // assign the data to the property
            AnOrder.IsPaid = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.IsPaid, TestData);
        }
        [TestMethod]
        public void NotesPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            string TestData = "Test Notes";
            // assign the data to the property
            AnOrder.Notes = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.Notes, TestData);
        }
        // Find method
        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the result of the validation
            Boolean Found = false;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the OrderID
            if (AnOrder.OrderID != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the CustomerID
            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the StaffID
            if (AnOrder.StaffID != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockIDFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the StockID
            if (AnOrder.StockID != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the OrderDate
            if (AnOrder.OrderDate != Convert.ToDateTime("01/01/2021"))
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsPaidFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the IsPaid
            if (AnOrder.IsPaid != true)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNotesFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrder.Find(OrderID);
            // check the Notes
            if (AnOrder.Notes != "Test Notes")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string OrderID = ""; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMinBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string OrderID = "1"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string OrderID = "11"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string OrderID = "123456"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMaxBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string OrderID = "1234567"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string OrderID = "12345678"; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string OrderID = "123456"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string OrderID = "";
            OrderID = OrderID.PadRight(500, '1'); // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string CustomerID = ""; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string CustomerID = "1"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string CustomerID = "11"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string CustomerID = "123456"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMaxBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string CustomerID = "1234567"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string CustomerID = "12345678"; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string CustomerID = "123456"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, '1'); // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StaffID = ""; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMinBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StaffID = "1"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StaffID = "11"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StaffID = "123456"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMaxBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StaffID = "1234567"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StaffID = "12345678"; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StaffID = "123456"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StaffID = "";
            StaffID = StaffID.PadRight(500, '1'); // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockIDMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StockID = ""; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockIDMinBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StockID = "1"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIDMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StockID = "11"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIDMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StockID = "123456"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIDMaxBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StockID = "1234567"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIDMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StockID = "12345678"; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockIDMid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StockID = "123456"; // this should be OK
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockIDExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to test the method
            string StockID = "";
            StockID = StockID.PadRight(500, '1'); // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // set the date to today's date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            // change the date to the minimum date
            TestDate = DateTime.Parse("01/01/1900");
            // convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // set the date to today's date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            // change the date to the minimum date
            TestDate = DateTime.Parse("01/01/1900");
            // convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // set the date to today's date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            // change the date to the minimum date
            TestDate = DateTime.Parse("01/01/1900");
            // convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // set the date to today's date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            // change the date to the minimum date
            TestDate = DateTime.Parse("01/01/1900");
            // add one day to the date
            TestDate = TestDate.AddDays(1);
            // convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // set the date to today's date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            // change the date to the maximum date
            TestDate = DateTime.Parse("31/12/2099");
            // convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // set the date to an invalid date
            string OrderDate = "This is not a date!";
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void IsPaidMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // set the IsPaid to an invalid value
            string IsPaid = ""; // this should trigger an error
            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void IsPaidMinBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the IsPaid to the minimum value
            string IsPaid = "True"; // this should be OK

            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IsPaidMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the IsPaid to the maximum value
            string IsPaid = "True"; // this should be OK

            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void IsPaidMaxBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the IsPaid to the maximum value
            string IsPaid = "True"; // this should be OK

            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void IsPaidMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the IsPaid to the maximum value
            string IsPaid = "True"; // this should be OK

            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void IsPaidMid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the IsPaid to the mid value
            string IsPaid = "True"; // this should be OK

            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void IsPaidExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the IsPaid to the extreme max value
            string IsPaid = "True"; // this should be OK

            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NotesMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the Notes to the min less one value
            string Notes = ""; // this should trigger an error

            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void NotesMinBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the Notes to the min boundary value
            string Notes = "a"; // this should be OK

            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NotesMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the Notes to the min plus one value
            string Notes = "aa"; // this should be OK

            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NotesMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the Notes to the max less one value
            string Notes = "";
        }
        [TestMethod]
        public void NotesMaxBoundary()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the Notes to the max boundary value
            string Notes = "" +
                "";
        }
        [TestMethod]
        public void NotesMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the Notes to the max plus one value
            string Notes = "";
        }
        [TestMethod]
        public void NotesMid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the Notes to the mid value
            string Notes = "a"; // this should be OK

            // invoke the method
            Error = AnOrder.Valid(OrderID, CustomerID, StaffID, StockID, OrderDate, IsPaid, Notes);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NotesExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";

            // set the Notes to the extreme max value
            string Notes = "";

        }












    }
}