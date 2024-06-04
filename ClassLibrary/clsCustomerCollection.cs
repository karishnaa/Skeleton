using ClassLibrary;
using System.Collections.Generic;
using System;
using System.Net.Mail;
using System.Security.Cryptography;

namespace ClassLibrary
{

    public class clsCustomerCollection

    {
        //private data member for the stock list
        List<clsCustomers> mCustomersList = new List<clsCustomers>();
        clsCustomers mThisCustomers = new clsCustomers();
        // Public Property For CustomersList 
        public List<clsCustomers> CustomersList
        {
            get
            {
                // return the private data 
                return mCustomersList;
            }
            set
            {
                // Set the private data 
                mCustomersList = value;
            }
        }
        //Public Property for count
        public int Count
        {
            get
            {
                return CustomersList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        // Public Property For ThisCustomers
        public clsCustomers ThisCustomers
        {
            get
            {
                // Return the private data 
                return mThisCustomers;
            }
            set
            {
                // Set the private data 
                mThisCustomers = value;
            }

        }

        //Constructor for the class
        public clsCustomerCollection()
        {
            // connects to the database
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");
            // populate the array list with the data table 
            PopulateArray(DB);
        }

        public int Add()
        {
            // add's a record to the database based on the values of mThisCustomers
            // connects to the database
            clsDataConnection DB = new clsDataConnection();
            // sets the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisCustomers.FullName);
            // sets the parameters for the stored procedure
            DB.AddParameter("@EmailAddress", mThisCustomers.EmailAddress);
            // sets the parameters for the stored procedure
            DB.AddParameter("@PhoneNumber", mThisCustomers.PhoneNumber);
            // sets the parameters for the stored procedure
            DB.AddParameter("@DOB", mThisCustomers.DOB);
            // sets the parameters for the stored procedure
            DB.AddParameter("@Subscribed", mThisCustomers.Subscribed);
            // execute the query returning the primary key value 
            return DB.Execute("sproc_tblCustomer_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of ThisCustomers
            // connects to the database
            clsDataConnection DB = new clsDataConnection();
            // sets the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomers.CustomerID);
            // sets the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisCustomers.FullName);
            // sets the parameters for the stored procedure
            DB.AddParameter("@EmailAddress", mThisCustomers.EmailAddress);
            // sets the parameters for the stored procedure
            DB.AddParameter("@PhoneNumber", mThisCustomers.PhoneNumber);
            // sets the parameters for the stored procedure
            DB.AddParameter("@DOB", mThisCustomers.DOB);
            // sets the parameters for the stored procedure
            DB.AddParameter("@Subscribed", mThisCustomers.Subscribed);
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            // deletes the record pointed to by ThisCustomers
            // connects to the database
            clsDataConnection DB = new clsDataConnection();
            // sends the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomers.CustomerID);
            // execute the stored procedure 
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByEmailAddress(string EmailAddress)
        {
            // filters the records based on a full or partial email address 
            // connects to the database
            clsDataConnection DB = new clsDataConnection();
            // sends the emailaddress paramteter to the database
            DB.AddParameter("@EmailAddress", EmailAddress);
            // execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByEmailAddress");
            // populate the array list with the data table 
            PopulateArray(DB);
        }
        
        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB 
            // Variable for the index 
            Int32 Index = 0;
            // Varaible to store the record count 
            Int32 RecordCount = 0;
            // gets the count of records 
            RecordCount = DB.Count;
            //clear the private array list 
            mCustomersList = new List<clsCustomers>();
            // whiles there are records to process 
            while (Index < RecordCount)
            {
                //create a blank customer object 
                clsCustomers anCustomers = new clsCustomers();
                //read in the fields for the current record
                anCustomers.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                anCustomers.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                anCustomers.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                anCustomers.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                anCustomers.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                anCustomers.Subscribed = Convert.ToBoolean(DB.DataTable.Rows[Index]["Subscribed"]);
                //add the record to the private data member
                mCustomersList.Add(anCustomers);
                //point at the next record
                Index++;
            }
        }

    }
}