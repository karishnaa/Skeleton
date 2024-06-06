using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Data;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {

        //good test data 
        //create some test data to pass the method
        string Name = "Zainab";
        string Position = "Designer";
        string Email = "zainab@gmail.com";
        float  Salary = 3.5F;
        string DOB = DateTime.Now.ToShortDateString();

      

        
        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void instanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void IsAvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.IsAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.IsAvailable, TestData);
        }
        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = new DateTime(2001, 01, 01);
            //assign the data to the property
            AnStaff.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DOB, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);

        }
        [TestMethod]
        public void NameNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Zainab";
            //assign the data to the property
            AnStaff.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Name, TestData);
        }
        [TestMethod]
        public void PositionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Designer";
            //assign the data to the property
            AnStaff.Position = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Position, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "zainab@gmail.com";
            //assign the data to the property
            AnStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Email, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            float TestData = 3000.00F;
            //assign the data to the property
            AnStaff.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Salary, TestData);
        }
        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 2;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 2;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the Staff id property
            if (AnStaff.StaffId != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 2;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the DateOfBirth property
            if (AnStaff.DOB != Convert.ToDateTime("09/09/2024")
)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsAvailableFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 2;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the IsAvailable property
            if (AnStaff.IsAvailable != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 2;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the Name property
            if (AnStaff.Name.Trim() != "zainab")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 2;
            //invoke the method
            Found = AnStaff.Find(StaffId);
           //check the Email property
            if (AnStaff.Email.Trim() != "zainab@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPositionlFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 2;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the Position property
            if (AnStaff.Position.Trim() != "Designer")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 2;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the Salary property
            if (Found)
            {
                // Check the Salary property
                if (AnStaff.Salary != 5000.00F)


                {
                    OK = false;
                }
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
     public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid (Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
                                  //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The Name must be more than 6 characters :");
        }
        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
                                   //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The Name must be more than 6 characters :");
        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
          //  string Staff = "aaaaa"; //this should be ok
                                      //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaa"; //this should be ok
                                       //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaa"; //this should be ok
                                    //invoke the method
            Error = AnStaff.Valid(Name, Position, DOB, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The Name must be more than 6 characters :The date was not a valid date : ");
        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aaaaaaa"; //this should be ok
                                    //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "The Name must be more than 6 characters :The date was not a valid date : ");
        }
        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "The Name must be more than 6 characters :");
        }
        

        [TestMethod]
        public void DOBExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff Anstaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = Anstaff.Valid(Name, DOB, Position, Salary,  Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(Name, Position, DOB, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(Name, Position, DOB, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(Name, Position, DOB, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The date was not a valid date : ");
        }
        [TestMethod]
        public void DOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "The date was not a valid date : ");
        }
        [TestMethod]
        public void DOBInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the DOB to a non date value
            string DOB = "this is not a date!";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Name = "";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The Email must be more than 9 characters");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The Email must be more than 9 characters");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aaaaaaaa";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The Email must be more than 9 characters");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aaaaaaaaa";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "aaaaaaaaaa";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "The Email must be more than 9 characters");
        }
        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aaaa";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "The Email must be more than 9 characters");
        }
        [TestMethod]
        public void PositionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PositionMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Position = "a";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Position = "aa";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Position = "";
            Position = Position.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Position = "";
            Position = Position.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "";
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PositionMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //this should pass
        string Position = "";
            Position = Position.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //float variable to store any error message
            string Error = "";
            //this should fail
            float Salary = 3.00f;
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "The Salary must be less than 50 characters : ");
        }
        [TestMethod]
        public void SalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //float variable to store any error message
            string Error = "";
            //this should pass
            float Salary = 3.00f;
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //float variable to store any error message
           string Error = "";
            //this should pass
            float Salary = 3.00f;
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //float variable to store any error message
           string Error = "";
            //this should pass
            float Salary = 5001.00f;
           
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //float variable to store any error message
            string Error = "";
            //this should pass
            float Salary = 3.00f;
         
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //float variable to store any error message
            string Error = "";
            //this should fail
            float Salary = 3.00f;
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //float variable to store any error message
            string Error = "";
            //this should pass
            float Salary = 3.00f;
   
            //invoke the method
            Error = AnStaff.Valid(Name, DOB, Position, Salary, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatStatisticsGroupedByIsAvailable()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //invoke the method
            DataTable dT = AnStaff.StatisticsGroupByIsAvailable();  //.StatisticsGroupedByIsAvailable();
           //According to the last executed stored procedure, there should be three rows of data
            int noOfRecord = 2;
            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);

        }
        [TestMethod]
        public void StatStatisticsGroupedByDOB()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //invoke the method
            DataTable dT = AnStaff.StatisticsGroupByDOB(); //StatisticsGroupedByDOB();
            //According to the last executed stored procedure, there should be 10 rows of data
            int noOfRecord = 8;
            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);

        }


    }

}









    

