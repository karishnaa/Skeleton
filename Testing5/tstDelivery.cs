using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Data;

namespace Testing5
{
    [TestClass]
    public class tstDelivery
    {
        

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //test to see that it exists
            Assert.IsNotNull(Delivery);
        }

        [TestMethod]
        public void DeliveryIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Delivery.DeliveryID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Delivery.DeliveryID, TestData);
            

            
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Delivery.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Delivery.OrderID, TestData);
            
        }

        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //create some test data to assign to the property
            string TestData = "123 Fake Street";
            //assign the data to the property
            Delivery.DeliveryAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Delivery.DeliveryAddress, TestData);
            
           
        }

        [TestMethod]
        public void DateOfDeliveryPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Delivery.DateOfDelivery = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Delivery.DateOfDelivery, TestData);

            
        }

        [TestMethod]
        public void DispatchedPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //create some test data to assign to the property
            bool TestData = true;
            //assign the data to the property
            Delivery.Dispatched = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Delivery.Dispatched, TestData);
            
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestDeliveryIDFound()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //check the DeliveryID
            if (Delivery.DeliveryID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //check the OrderID
            if (Delivery.OrderID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //check the DeliveryAddress
            if (Delivery.DeliveryAddress != "123 Fake Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfDeliveryFound()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //check the DateOfDelivery
            if (Delivery.DateOfDelivery != Convert.ToDateTime("16/04/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDispatchedFound()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //check the Dispatched
            if (Delivery.Dispatched != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFindMethodNotFound()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //check the DeliveryID
            if (Delivery.DeliveryID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryIDNotFound()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //check the DeliveryID
            if (Delivery.DeliveryID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderIDNotFound()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //check the OrderID
            if (Delivery.OrderID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryAddressNotFound()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //check the DeliveryAddress
            if (Delivery.DeliveryAddress != "123 Fake Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfDeliveryNotFound()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //check the DateOfDelivery
            if (Delivery.DateOfDelivery != Convert.ToDateTime("16/04/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDispatchedNotFound()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = Delivery.Find(DeliveryID);
            //check the Dispatched
            if (Delivery.Dispatched != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = Delivery.Valid("123 Fake Street", "16/04/2021");
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to test the method
            string DeliveryAddress = ""; //this should trigger an error
            //invoke the method
            Error = Delivery.Valid(DeliveryAddress, "16/04/2021");
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to test the method
            string DeliveryAddress = "a"; //this should be ok
            //invoke the method
            Error = Delivery.Valid(DeliveryAddress, "16/04/2021");
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to test the method
            string DeliveryAddress = "aa"; //this should be ok
            //invoke the method
            Error = Delivery.Valid(DeliveryAddress, "16/04/2021");
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to test the method
            string DeliveryAddress = "" +
                "";
        }
        [TestMethod]
        public void DeliveryAddressMaxBoundary()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to test the method
            string DeliveryAddress = "";
        }
        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to test the method
            string DeliveryAddress = "";
        }
        [TestMethod]
        public void DeliveryAddressMid()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to test the method
            string DeliveryAddress = "";
        }

        [TestMethod]
        public void DateOfDeliveryExtremeMin()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the minimum date is for the system
            TestDate = DateTime.MinValue;
            //convert the date variable to a string variable
            string DateOfDelivery = TestDate.ToString();
            //invoke the method
            Error = Delivery.Valid("123 Fake Street", DateOfDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfDeliveryMinLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to one less than today's date
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfDelivery = TestDate.ToString();
            //invoke the method
            Error = Delivery.Valid("123 Fake Street", DateOfDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfDeliveryMinBoundary()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfDelivery = TestDate.ToString();
            //invoke the method
            Error = Delivery.Valid("123 Fake Street", DateOfDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfDeliveryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to one more than today's date
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfDelivery = TestDate.ToString();
            //invoke the method
            Error = Delivery.Valid("123 Fake Street", DateOfDelivery);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfDeliveryExtremeMax()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the maximum date is for the system
            TestDate = DateTime.MaxValue;
            //convert the date variable to a string variable
            string DateOfDelivery = TestDate.ToString();
            //invoke the method
            Error = Delivery.Valid("123 Fake Street", DateOfDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfDeliveryInvalidData()
        {
            //create an instance of the class we want to create
            clsDelivery Delivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //set the date to a non date value
            string DateOfDelivery = "this is not a date!";
            //invoke the method
            Error = Delivery.Valid("123 Fake Street", DateOfDelivery);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
       

        

    }
}
