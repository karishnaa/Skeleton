using System;
using System.Data;
using System.Linq;
using System.Net.Mail;

namespace ClassLibrary
{
    public class clsCustomers
    {
       
        //private data member for the customer id property
        private int mCustomerID;
        //customer id public property
        public int CustomerID
        {
            //sends data out of the property
            get { return mCustomerID; }

            //allows data into the property 
            set { mCustomerID = value; }

        }

        public bool Find(int CustomerID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the customer ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            // Execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");

            // Check if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mSubscribed = Convert.ToBoolean(DB.DataTable.Rows[0]["Subscribed"]);
                // Return true to indicate success
                return true;
            }
            else
            {
                // If no record was found, return false
                return false;
            }
        }


        //PRIVATE DATA MEMBER FOR THE CUSTOMER ID PROPERTY 
        private string mFullName;
        //CUSTOMER PUBLIC PROPERTY
        public string FullName
        {
            // SENDS DATA OUT OF THE PROPERTY 
            get { return mFullName; }

            // ALLOWS DATA INTO THE PROPERTY 
            set { mFullName = value; }

        }
        public bool Find(string testFullName)
        {
            //SET THE PRIVATE DATA MEMEBERS TO THE TEST DATA VALUE 
            mFullName = testFullName;
            //ALWAYS RETURN TRUE
            return true;
        }

        private string mEmailAddress;
        public string EmailAddress
        {
            // SENDS DATA OUT OF THE PROPERTY 
            get { return mEmailAddress; }

            // ALLOWS DATA INTO THE PROPERTY 
            set { mEmailAddress = value; }
        }

        private string mPhoneNumber;
        public string PhoneNumber
        { 
            // SENDS DATA OUT OF THE PROPERTY 
            get { return mPhoneNumber; }

            // ALLOWS DATA INTO THE PROPERTY 
            set { mPhoneNumber = value; }
        }

        private DateTime mDOB;
        public DateTime DOB
        {
            // Sends data out of the property 
            get { return mDOB; }

            // Allows data into the property 
            set { mDOB = value; }
        }
  
        public bool Find(DateTime testDOB)
        {
            // Set the private data member to the test data value 
            mDOB = Convert.ToDateTime("03/03/2003");
            // Always returnrotrue
            return true;
        }


        private bool mSubscribed;
        public bool Subscribed
        {
            // SENDS DATA OUT OF THE PROPERTY 
            get { return mSubscribed; }

            // ALLOWS DATA INTO THE PROPERTY 
            set { mSubscribed = value; }
        }

        public bool Find(bool testSubscribed)
        {
            //SET THE PRIVATE DATA MEMEBERS TO THE TEST DATA VALUE 
            Subscribed = testSubscribed;
            //ALWAYS RETURN TRUE
            return true;
        }


        public string Valid(string FullName, string EmailAddress, string PhoneNumber, string DOB)
        {
            //Full Name Validation
            String Error = "";
            DateTime DateTemp;
            if (FullName.Length == 0)
            {
                Error = Error + "full name cannot be blank :";

            }
            else if (FullName.Length < 2) // Assuming the minimum length of the full name is 2 characters
            {
                Error += "The full name must be at least 2 characters long: ";
            }

            if (FullName.Length > 50)
            {
                Error = Error + "full nane must be less than 50 characters:";
            }

            //DOB Validation
           try
            {
                DateTemp = Convert.ToDateTime(DOB);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be today's date : ";
                }
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    Error = Error + "Date cannot be less than 100 years";
                }

            }
            catch
            {
                Error = Error + "Date was not a valid date";
            }


            //Email Address Validation 
            if (EmailAddress.Length == 0)
            {
                Error += "Email address cannot be blank.";
            }
            else if (!EmailAddress.Contains("@"))
            {
                Error += "Email address must contain an @ symbol.";
            }
            else if (EmailAddress.Length < 5)
            {
                Error += "Email address must be at least 5 characters long.";
            }
            else if (EmailAddress.Length > 50) // Maximum length minus one is 50 characters
            {
                Error += "Email address must be at most 50 characters long.";
            }


            //Phone Number Validation
            if (PhoneNumber.Length == 0)
            {
                Error += "The phone number may not be blank: ";
            }
            else if (PhoneNumber.Length < 11)
            {
                Error += "The phone number must be at least 11 digits long: ";
            }
            else if (PhoneNumber.Length > 15)
            {
                Error += "The phone number must be less than 15 digits: ";
            }
            else if (!PhoneNumber.All(char.IsDigit))
            {
                Error += "The phone number must contain only digits: ";
            }
            else if (PhoneNumber.Length < 10)
            {
                Error += "The phone number must be at least 10 digits long: "; // Added for PhoneNumberMinLessOne
            }
            else if (PhoneNumber.Any(char.IsLetter))
            {
                Error += "The phone number must not contain alphabetic characters: "; // Added for PhoneNumberNonDigits
            }

            return Error;
        }
        public DataTable StatisticsGroupedByDOB()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Count_GroupByDOB");
            //there should be either zero one or many records
            return DB.DataTable;

        }

        public DataTable StatisticsGroupedBySubscribed()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Count_GroupBySubscribed");
            //there should be either zero one or many records
            return DB.DataTable;
        }
    }
}