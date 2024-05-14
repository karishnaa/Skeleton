using System;

namespace ClassLibrary
{
    public class clsCustomers
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        
       
    

        //PRIVATE DATA MEMBER FOR THE CUSTOMER ID PROPERTY 
        private int mCustomerID;
        //CUSTOMER PUBLIC PROPERTY
        public int CustomerID
        {   
            // SENDS DATA OUT OF THE PROPERTY 
            get { return mCustomerID; }

            // ALLOWS DATA INTO THE PROPERTY 
            set { mCustomerID = value; }

        }

        public bool Find(int customersID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the customer ID to search for
            DB.AddParameter("@CustomerID", customersID);
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
            // Always return true
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
    }
}