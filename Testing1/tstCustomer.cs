using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Linq;
using System.Net.Mail;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //Create customer test data
        string FullName = "Karishna";
        string EmailAddress = "Karishna@gmail.com";
        string PhoneNumber = "07485748951";
        string DOB = "03/06/2003";

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsCustomers anCustomers = new clsCustomers();
            //Test to see if it exists
            Assert.IsNotNull(anCustomers);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomers anCustomers = new clsCustomers();
            // Test data to assign to the CustomerID property
            int testData = 1;
            //assign the data to the property
            anCustomers.CustomerID = testData;
            //test to see that the two values are the same
            Assert.AreEqual(testData, anCustomers.CustomerID);
        }
        [TestMethod]
        public void FullNamePropertyOK()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Test data to assign to the FullName property
            string testFullName = "Karishna";
            // Assign the test data to the FullName property
            anCustomers.FullName = testFullName;
            // test to see that the two values are the same
            Assert.AreEqual(testFullName, anCustomers.FullName);
        }
        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Test data to assign to the EmailAddress property
            string testEmailAddress = "karishna@outlook.com";
            // Assign the test data to the EmailAddress property
            anCustomers.EmailAddress = testEmailAddress;
            // test to see that the two values are the same
            Assert.AreEqual(testEmailAddress, anCustomers.EmailAddress);
        }
        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Test data to assign to the PhoneNumber property
            string testPhoneNumber = "07859875984";
            // Assign the test data to the PhoneNumber property
            anCustomers.PhoneNumber = testPhoneNumber;
            // test to see that the two values are the same
            Assert.AreEqual(testPhoneNumber, anCustomers.PhoneNumber);
        }
        [TestMethod]
        public void DOBPropertyOK()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Test data to assign to the DOB property
            DateTime testDOB = new DateTime(2003, 3, 24);
            // Assign the test data to the DOB property
            anCustomers.DOB = testDOB;
            // test to see that the two values are the same
            Assert.AreEqual(testDOB, anCustomers.DOB);
        }
        [TestMethod]
        public void SubscribedPropertyOK()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Test data to assign to the Subscribed property
            bool testSubscribed  = true;
            // Assign the test data to the Subscribed property
            anCustomers.Subscribed = testSubscribed;
            // test to see that the two values are the same
            Assert.AreEqual(testSubscribed, anCustomers.Subscribed);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the new class we want to create
            clsCustomers anCustomers = new clsCustomers();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 6;
            //invoke the method
            Found = anCustomers.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Boolean variable to store the result of the find operation
            Boolean Found = false;
            // Boolean variable to store the outcome of the test
            Boolean OK = true;
            // Test data for the CustomerID
            Int32 CustomerID = 1;
            // Execute the find method
            Found = anCustomers.Find(CustomerID);
            // Check if the CustomerID found matches the test data
            if (anCustomers.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFullNameFound()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Boolean variable to store the result of the find operation
            Boolean Found = false;
            // Boolean variable to store the outcome of the test
            Boolean OK = true;
            // Test data for the CustomerID
            Int32 CustomerID = 1;
            // Execute the find method
            Found = anCustomers.Find(CustomerID);
            // Check if the FullName found matches the test data
            if (anCustomers.FullName != "Karishna")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailAddressFound()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Boolean variable to store the result of the find operation
            Boolean Found = false;
            // Boolean variable to store the outcome of the test
            Boolean OK = true;
            // Test data for the CustomerID
            Int32 CustomerID = 1;
            // Execute the find method
            Found = anCustomers.Find(CustomerID);
            // Check if the EmailAddress found matches the test data
            if (anCustomers.EmailAddress != "KARISHNA@GMAIL,COM")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Boolean variable to store the result of the find operation
            Boolean Found = false;
            // Boolean variable to store the outcome of the test
            Boolean OK = true;
            // Test data for the CustomerID
            Int32 CustomerID = 1;
            // Execute the find method
            Found = anCustomers.Find(CustomerID);
            // Check if the PhoneNumber found matches the test data
            if (anCustomers.PhoneNumber != "07142578965")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFound()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Boolean variable to store the result of the find operation
            Boolean Found = false;
            // Boolean variable to store the outcome of the test
            Boolean OK = true;
            // Test data for the CustomerID
            Int32 CustomerID = 1;
            // Execute the find method
            Found = anCustomers.Find(CustomerID);
            // Check if the DOB found matches the test data
            if (anCustomers.DOB != Convert.ToDateTime("04-04-2003"))
            {
       
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSubscribedFound()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Boolean variable to store the result of the find operation
            Boolean Found = false;
            // Boolean variable to store the outcome of the test
            Boolean OK = true;
            // Test data for the CustomerID
            Int32 CustomerID = 1;
            // Execute the find method
            Found = anCustomers.Find(CustomerID);
            // Check if the Subscribed status found matches the test data
            if (anCustomers.Subscribed != true)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomers anCustomers = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
       
        [TestMethod]
        public void FullNameMax()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            //this should pass 
            string FullName = new string('a', 100); // maximum valid length
            //invoke the method
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMid()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            //this should pass
            string FullName = new string('a', 50); // mid-range valid length
            //invoke the method
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinPlusOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            //this should pass
            string FullName = "aa";
            //invoke the method
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxLessOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            //this should pass
            string FullName = new string('a', 99);
            //invoke the method
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinLessOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            // this should fail
            string FullName = "";
            //invoke the method
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMin()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            // this should fail
            string FullName = "a";
            //invoke the method
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            // this should fail 
            string FullName = new string('a', 101);
            //invoke the method
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        // Validation For DOB 
        [TestMethod]
        public void DOBExtremeMin()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            string Error = "";
            DateTime TestDate = DateTime.Now.Date.AddYears(-18).AddDays(1); // Just under 18 years old
            string DOB = TestDate.ToString("dd-mm-yyyy");
            //invoke the method
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinLessOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            //this should pass 
            DateTime TestDate = DateTime.Now.Date.AddYears(-18).AddDays(-1);
            string DOB = TestDate.ToString("dd-MM-yyyy");
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            Assert.AreEqual("", Error, "Expected no error for a date one day less than today.");
        }
        [TestMethod]
        public void DOBMin()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            string DOB = TestDate.ToString("dd-MM-yyyy");
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBMinPlusOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            DateTime TestDate = DateTime.Now.Date.AddYears(-18).AddDays(-1); ;
            string DOB = TestDate.ToString("dd-MM-yyyy");
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            Assert.AreEqual("", Error, "Expected an error for a date one day in the future.");
        }
        [TestMethod]
        public void DOBMaxLessOne()
        {
            clsCustomers anCustomers = new clsCustomers();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date.AddYears(-99).AddDays(1); // Just under 99 years old
            string DOB = TestDate.ToString("dd-mm-yyyy");
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBExtremeMax()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            string Error = "";
            DateTime TestDate = DateTime.Now.Date.AddYears(-99).AddDays(-1);
            string DOB = TestDate.ToString("dd-MM-yyyy"); // Correct date format for comparison
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            Assert.AreNotEqual(Error,"");
        }


        [TestMethod]
        public void DOBInvalidData()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string DOB = "this is not a date!";
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB);
            Assert.AreNotEqual("", Error, "Expected an error for invalid date data.");
        }
        // Validation for Phone Number 
        [TestMethod]
        public void PhoneNumberMin()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string PhoneNumber = "1234567890"; // minimum valid length
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMax()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string PhoneNumber = new string('1', 20); // maximum valid length
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreEqual(Error, "");
        }
       
        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string PhoneNumber = "12345678901"; // minimum plus one digit
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string PhoneNumber = new string('1', 19); // maximum length minus one
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string PhoneNumber = "123456789"; // less than minimum length
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string PhoneNumber = new string('1', 21);
            // Call the Valid method and store the result
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberNonDigits()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string PhoneNumber = "abcde"; // contains non-digit characters
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreNotEqual(Error, "");
        }
        // Validation For Email Address
        [TestMethod]
        public void EmailMin()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string EmailAddress = new string('a', 5) + "@aaaaaa.com";// minimum valid length
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            string Error = "";
            string EmailAddress = new string('a', 253) + "@aaaaaa.com";
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string EmailAddress = new string('a', 127) + "@aaaaaaa.com"; // mid-range valid length
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string EmailAddress = "a@b.cd"; // minimum plus one character
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void EmailMaxLessOne()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            String Error = "";
            string EmailAddress = new string('a', 242) + "@aaaaaa.com"; // maximum length minus one
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailNoAtSymbol()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            //String variable to store any error message
            string Error = "";
            string EmailAddress = "emailaddress.com"; // missing '@' symbol
            Error = anCustomers.Valid(FullName, EmailAddress, PhoneNumber, DOB.ToString());
            Assert.AreNotEqual(Error, "");
        }
        // Test method to check the number of records returned by the StatisticsGroupedByDOB method
        [TestMethod]
        public void StatStatisticsGroupedByDOB()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Call the StatisticsGroupedByDOB method and store the result in a DataTable
            DataTable dT = anCustomers.StatisticsGroupedByDOB();
            // Define the expected number of records
            int noOfRecord = 8;
            // Check if the actual number of records matches the expected number of records
            Assert.AreEqual(noOfRecord, dT.Rows.Count);

        }
        // Test method to check the number of records returned by the StatisticsGroupedBySubscribed method
        [TestMethod]
        public void StatStatisticsGroupedBySubscribed()
        {
            // Create an instance of the clsCustomers class
            clsCustomers anCustomers = new clsCustomers();
            // Call the StatisticsGroupedBySubscribed method and store the result in a DataTable
            DataTable dT = anCustomers.StatisticsGroupedBySubscribed();
            // Define the expected number of records
            int noOfRecord = 2;
            // Check if the actual number of records matches the expected number of records
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }









    }
}


