using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //create test data
        string StockName = "";
        string Quantity = "23";
        string Price = "39.99";
        string ArrivalDate= "10/05/2024";
        string Description = "Comfortable Nike Hoodie";
        string Available = "true";
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(anStock);
        }
        [TestMethod]
        public void StockNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            string testName = "Nike Hoodie";
            //assign the data to the property
            anStock.StockName = testName;
            //test to see that the two values are the same
            Assert.AreEqual(testName, anStock.StockName);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            double testPrice = 16.99;
            //assign the data to the property
            anStock.Price = testPrice;
            //test to see that the two values are the same
            Assert.AreEqual(testPrice, anStock.Price);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            int testQuantity = 45;
            //assign the data to the property
            anStock.Quantity = testQuantity;
            //test to see that the two values are the same
            Assert.AreEqual(testQuantity, anStock.Quantity);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            bool testAvailable = true;
            //assign the data to the property
            anStock.Available = testAvailable;
            //test to see that the two values are the same
            Assert.AreEqual(testAvailable, anStock.Available);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            string testDescription = "Comfortable Nike Hoodie!";
            //assign the data to the property
            anStock.Description = testDescription;
            //test to see that the two values are the same
            Assert.AreEqual(testDescription, anStock.Description);
        }

        [TestMethod]
        public void ArrivalDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create some test data to assign to the property
            DateTime testArrivalDate = DateTime.Now.Date;
            //assign the data to the property
            anStock.ArrivalDate = testArrivalDate;
            //test to see that the two values are the same
            Assert.AreEqual(testArrivalDate, anStock.ArrivalDate);
        }
        /** FIND METHOD TEST **/
        [TestMethod]
        public void FindMethodOK()
        { 
            //create an instance of the new class we want to create
            clsStock anStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = anStock.Find(StockID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        
        }
        [TestMethod]
        public void TestStockIDFound() 
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = anStock.Find(StockID);
            //check the stock id
            if (anStock.StockID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockNameFound()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = anStock.Find(StockID);
            //check the stock name
            if (anStock.StockName != "Nike Hoodie")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = anStock.Find(StockID);
            //check the stock price
            if (anStock.Price != 39.99)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = anStock.Find(StockID);
            //check the stock quantity
            if (anStock.Quantity != 24)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = anStock.Find(StockID);
            //check the stock availibility
            if (anStock.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = anStock.Find(StockID);
            //check the stock description
            if (anStock.Description != "Comfortable Nike Hoodie")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestArrivalDateFound()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = anStock.Find(StockID);
            //check the stock arrival date
            if (anStock.ArrivalDate != Convert.ToDateTime("10/05/2024"))
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
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = anStock.Valid(StockName,Quantity,Price,ArrivalDate,Description,Available);
            //test to see if the result is correct
            //Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMinMinusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = ""; // Min -1: 0 characters
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMin()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "a"; // Min (Boundary): 1 character
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "aa"; // Min +1: 2 characters
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            // Max -1: 49
            StockName = StockName.PadRight(49, 'a');
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            // Max (Boundary): 50 characters
            StockName = StockName.PadRight(50, 'a');
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StockNameMid()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            // Mid: 25 characters
            StockName = StockName.PadRight(25, 'a');
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            // Max +1: 51 characters
            StockName = StockName.PadRight(51, 'a');
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockName = "";
            // Extreme max: 500 characters
            StockName = StockName.PadRight(500, 'a');
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ArrivalDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to -100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string ArrivalDate = TestDate.ToString();
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ArrivalDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to -1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string ArrivalDate = TestDate.ToString();
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ArrivalDateMin()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string ArrivalDate = TestDate.ToString();
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ArrivalDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to +1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string ArrivalDate = TestDate.ToString();
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ArrivalDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to +100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string ArrivalDate = TestDate.ToString();
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ArrivalDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            String ArrivalDate = "aa";
            //invoke the method
            Error = anStock.Valid(StockName, Quantity, Price, ArrivalDate, Description, Available);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



    }
}