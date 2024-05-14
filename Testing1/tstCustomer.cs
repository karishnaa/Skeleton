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
        [TestMethod]
        public void FindMethodOK()
        {
            //CRATE AN INSTANCE OF CLASS WE WANT TO CREATE 
            clsCustomers ancustomers = new clsCustomers();
            //CREATE A BOOLEAN VARIABLE TO STORE THE RESULTS OF THE VALIDATION 
            Boolean Found = false;
            //CREATE SOME TEST DATA TO USE WITH THE METHOD 
            Int32 CustomersID = 1;
            //INVOKE THE METHOD
            Found = ancustomers.Find(CustomersID);
            //TEST TO SEE IF THE RESULT IS TRUE 
            Assert.IsTrue(Found);   
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            // Create an instance of the class we want to test
            clsCustomers anCustomers = new clsCustomers();

            // Create some test data for customer ID
            int testCustomerId = 1;

            // Set the customer ID property of the instance with the test data
            anCustomers.CustomerID = testCustomerId;

            // Test if the customer ID property returns the expected value
            Assert.AreEqual(testCustomerId, anCustomers.CustomerID);
        }


    }

}
