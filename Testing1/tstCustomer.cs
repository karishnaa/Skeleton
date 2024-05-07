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
            clsCustomers anCustomers = new clsCustomers();
            // create some test data to assign to the property 
            Boolean TestData = true;
            // assign the data to the property 
            anCustomers.Active = TestData;
            // test to see that the two values are the same 
            Assert.AreEqual(anCustomers.Active, TestData);

        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            // create an instance of the class we want to create 
            clsCustomers anCustomers = new clsCustomers();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            anCustomers.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anCustomers.DateAdded, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomers anCustomers = new clsCustomers();
            //create some test data to assign to the property
            int testData = 1;
            //assign the data to the property
            anCustomers.CustomerID = testData;
            //test to see that the two values are the same
            Assert.AreEqual(testData, anCustomers.CustomerID);
        }
        [TestMethod]
        public void FullNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomers anCustomers = new clsCustomers();
            //create some test data to assign to the property
            string testData = "Karishna";
            //assign the data to the property
            anCustomers.FullName = testData;
            //test to see that the two values are the same
            Assert.AreEqual(testData, anCustomers.FullName);
        }
        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomers anCustomers = new clsCustomers();
            //create some test data to assign to the property
            string testData = "karishna@outlook.com";
            //assign the data to the property
            anCustomers.EmailAddress = testData;
            //test to see that the two values are the same
            Assert.AreEqual(testData, anCustomers.EmailAddress);
        }
        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomers anCustomers = new clsCustomers();
            //create some test data to assign to the property
            string testData = "07859875984";
            //assign the data to the property
            anCustomers.PhoneNumber = testData;
            //test to see that the two values are the same
            Assert.AreEqual(testData, anCustomers.PhoneNumber);
        }
        [TestMethod]
        public void DOBPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomers anCustomers = new clsCustomers();
            //create some test data to assign to the property
            DateTime testData = new DateTime(2003, 3, 24);
            //assign the data to the property
            anCustomers.DOB = testData;
            //test to see that the two values are the same
            Assert.AreEqual(testData, anCustomers.DOB);
        }
        [TestMethod]
        public void SubscribedPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomers anCustomers = new clsCustomers();
            //create some test data to assign to the property
            bool testData = true;
            //assign the data to the property
            anCustomers.Subscribed = testData;
            //test to see that the two values are the same
            Assert.AreEqual(testData, anCustomers.Subscribed);
        }




    }

}
