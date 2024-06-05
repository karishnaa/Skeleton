using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
            [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsCustomerCollection allCustomers = new clsCustomerCollection();
                //test to see that it exists
                Assert.IsNotNull(allCustomers);
            }

            [TestMethod]
            public void CustomerListOK()
            {
                // create an instance of the clscustomercollection class 
                clsCustomerCollection allCustomers = new clsCustomerCollection();
                // Create a test list of customers
                List<clsCustomers> TestList = new List<clsCustomers>();
                // Create a test customer item
                clsCustomers TestItem = new clsCustomers();
                // Set the properties of the test customer item
                TestItem.CustomerID = 1;
                TestItem.FullName = "Karishna";
                TestItem.EmailAddress = "Karishna@gmail.com";
                TestItem.PhoneNumber = "01854956825";
                TestItem.DOB = Convert.ToDateTime("10/05/2004");
                TestItem.Subscribed = true;
                // add the test item to the test list 
                TestList.Add(TestItem);
                // the test list is assigned to the customerlist 
                allCustomers.CustomersList = TestList;
                // tests if the customerlist return the test list 
                Assert.AreEqual(allCustomers.CustomersList,TestList);

            }
           
            [TestMethod]
            public void ThisCustomersPropertyOK()
            {
                // create an instance of the clscustomercollection class 
                clsCustomerCollection allCustomers = new clsCustomerCollection();
                // Create a test customer item
                clsCustomers TestCustomers = new clsCustomers();
                // Set the properties of the test customer item
                TestCustomers.CustomerID = 1;
                TestCustomers.FullName = "Karishna";
                TestCustomers.EmailAddress = "Karishna@gmail.com";
                TestCustomers.PhoneNumber = "01854956825";
                TestCustomers.DOB = Convert.ToDateTime("10/05/2004");
                TestCustomers.Subscribed = true;
                //assign the data to the property
                allCustomers.ThisCustomers = TestCustomers;
                // tests if the customerlist return the test list 
                Assert.AreEqual(allCustomers.ThisCustomers,TestCustomers);
            }
            [TestMethod]
            public void ListAndCountOK()
            {
                // create an instance of the clscustomercollection class 
                clsCustomerCollection allCustomers = new clsCustomerCollection();
                // create an test list of customers 
                List<clsCustomers> TestList = new List<clsCustomers>();
                // create a test customer item 
                clsCustomers TestItem = new clsCustomers();
                // Set the properties of the test customer item
                TestItem.CustomerID = 1;
                TestItem.FullName = "Karishna";
                TestItem.EmailAddress = "Karishna@gmail.com";
                TestItem.PhoneNumber = "01854956825";
                TestItem.DOB = Convert.ToDateTime("10/05/2004");
                TestItem.Subscribed = true;
                // Add the test item to the test list 
                TestList.Add(TestItem);
                // assign the test list to the customerlist 
                allCustomers.CustomersList = TestList;
                // tests if the customerlist return the test list 
                Assert.AreEqual(allCustomers.CustomersList.Count, TestList.Count);
            }
            [TestMethod]
            public void AddMethodOK()
            {
                // create an instance of the clscustomercollection class 
                clsCustomerCollection allCustomers = new clsCustomerCollection();
                // create a test customer item
                clsCustomers TestItem = new clsCustomers();
                // variable to store the primary key 
                int PrimaryKey = 0;
                // set its properties
                TestItem.CustomerID = 1;
                TestItem.FullName = "Karishna Patel";
                TestItem.EmailAddress = "karishna@gmail.com";
                TestItem.PhoneNumber = "01854956825";
                TestItem.DOB = Convert.ToDateTime("10/05/2004");
                TestItem.Subscribed = true;
                // set ThisCustomers to the test data
                allCustomers.ThisCustomers = TestItem;
                // add the record  
                PrimaryKey = allCustomers.Add();
                // set the primary set of the test data 
                TestItem.CustomerID = PrimaryKey;
                // find the record 
                allCustomers.ThisCustomers.Find(PrimaryKey);
                // test to see that the two values are the same
                Assert.AreEqual(allCustomers.ThisCustomers, TestItem);
            }
            [TestMethod]
            public void UpdateMethodOK()
            {
                // create an instance of the clscustomercollection class 
                clsCustomerCollection allCustomers = new clsCustomerCollection();
                // create a test customer item
                clsCustomers TestItem = new clsCustomers();
                // variable to store the primary key 
                Int32 PrimaryKey = 0;
                // set its properties 
                TestItem.CustomerID = 1;
                TestItem.FullName = "Karishna Patel";
                TestItem.EmailAddress = "karishna@gmail.com";
                TestItem.PhoneNumber = "01854956825";
                TestItem.DOB = Convert.ToDateTime("10/05/2004");
                TestItem.Subscribed = true;
                // set ThisCustomers to the test data
                allCustomers.ThisCustomers = TestItem;
                // add the record 
                PrimaryKey = allCustomers.Add();
                // set the primary set of the test data 
                TestItem.CustomerID = PrimaryKey;
                // modiy the test record 
                TestItem.FullName = "Karishna Patel";
                TestItem.EmailAddress = "karishnap@outlook.com";
                TestItem.PhoneNumber = "0748578958421";
                TestItem.DOB = Convert.ToDateTime("10/05/2004");
                TestItem.Subscribed = true;
                // set the record based on the new test data 
                allCustomers.ThisCustomers = TestItem;
                // updates the record
                allCustomers.Update();
                // find the record 
                allCustomers.ThisCustomers.Find(PrimaryKey);
                // tests to see if ThisCustomers matches the test data 
                Assert.AreEqual(allCustomers.ThisCustomers, TestItem);
            }
            [TestMethod]
            public void DeleteMethodOK()
            {
                // create an instance of the class we want to create 
                clsCustomerCollection allCustomers = new clsCustomerCollection();
                // create the item of the test data 
                clsCustomers TestItem = new clsCustomers();
                // varaible to store the primary key 
                Int32 PrimaryKey = 0;
                // set its properties 
                TestItem.CustomerID = 1;
                TestItem.FullName = "Karishna Patel";
                TestItem.EmailAddress = "karishna@gmail.com";
                TestItem.PhoneNumber = "01854956825";
                TestItem.DOB = Convert.ToDateTime("10/05/2004");
                TestItem.Subscribed = true;
                // set thiscustomers to the test data 
                allCustomers.ThisCustomers = TestItem;
                // add the record 
                PrimaryKey = allCustomers.Add();
                //set the primary key of the test data
                TestItem.CustomerID = PrimaryKey;
                TestItem.FullName = "Karishna Patel";
                TestItem.EmailAddress = "karishnap@outlook.com";
                TestItem.PhoneNumber = "0748578958421";
                TestItem.DOB = Convert.ToDateTime("10/05/2004");
                TestItem.Subscribed = true;
                // set thiscustomers to the test data 
                allCustomers.ThisCustomers = TestItem;
                // add the record 
                PrimaryKey = allCustomers.Add();
                TestItem.CustomerID = PrimaryKey;
                allCustomers.ThisCustomers.Find(PrimaryKey);
                allCustomers.Delete();
                Boolean Found = allCustomers.ThisCustomers.Find(PrimaryKey);
                Assert.IsFalse(Found);
            }
            [TestMethod]
            public void ReportByEmailAddressMethodOK()
            {
                //create an instance of the class containng unfiltered results 
                clsCustomerCollection allCustomers = new clsCustomerCollection();
                //CreateInstanceBinder an instance of the filtered data 
                clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
                //apply a blank string (this should return all records)
                FilteredCustomers.ReportByEmailAddress("");
                // test to see that two values are the same 
                Assert.AreEqual(allCustomers.Count, FilteredCustomers.Count);

            }
            [TestMethod]
            public void ReportByEmailAddressNoneFound()
            {
                // create an instance of the class we want to create 
                clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
                // apply a emailaddress that does not exist 
                FilteredCustomers.ReportByEmailAddress("xxx");
                //test to see that there are no records 
                Assert.AreEqual(0,FilteredCustomers.Count);

            }

            [TestMethod]
            public void ReportByEmailAddressTestDataFound()
            {
                //create an instance of the filtered data 
                clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
                // variable to store the outcome
                Boolean OK = true;
                // apply a postcode that does not exist 
                FilteredCustomers.ReportByEmailAddress("test");
                // checks that the correct number of the records are found 
                if (FilteredCustomers.Count == 2)
                {
                    // checks to see that the first record is 25
                    if (FilteredCustomers.CustomersList[0].CustomerID != 29)
                    {
                        OK = false;
                    }
                    //checks to see tha the first record is 26
                    if (FilteredCustomers.CustomersList[1].CustomerID !=30) 
                    { 
                        OK = false;

                    }
                }
                else
                {
                    OK = false;
                }
                // test to see that there are no records 
                Assert.IsTrue(OK);
            }
        }

    }
