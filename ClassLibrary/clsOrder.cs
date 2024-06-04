using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Data;
using System.Globalization;

namespace ClassLibrary
{
    public class clsOrder
    {
        // Private data member for the OrderID property
        private int mOrderID;

        // OrderID public property
        public int OrderID
        {
            get { return mOrderID; }
            set { mOrderID = value; }
        }

        // Private data member for the CustomerID property
        private int mCustomerID;

        // CustomerID public property
        public int CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }

        // Private data member for the StaffID property
        private int mStaffID;

        // StaffID public property
        public int StaffID
        {
            get { return mStaffID; }
            set { mStaffID = value; }
        }

        // Private data member for the Date property
        private DateTime mDate;

        // Date public property
        public DateTime Date
        {
            get { return mDate; }
            set { mDate = value; }
        }

        // Private data member for the IsPaid property
        private bool mIsPaid;

        // IsPaid public property
        public bool IsPaid
        {
            get { return mIsPaid; }
            set { mIsPaid = value; }
        }

        // Private data member for the Notes property
        private string mNotes;

        // Notes public property
        public string Notes
        {
            get { return mNotes; }
            set { mNotes = value; }
        }

        // Method to simulate finding an order by OrderID
        public bool Find(int orderID)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the order id to search for
            DB.AddParameter("@OrderID", orderID);
            // execute the stored procedure
            DB.Execute("dbo.sproc_tblOrder_FilterByOrderID");
            // if one record is found (there should either be one or zero)
            if (DB.Count == 1)
            {
                // set the private data to the test data values
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mIsPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["IsPaid"]);
                mNotes = Convert.ToString(DB.DataTable.Rows[0]["Notes"]);
                // return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating there is a problem
                return false;
            }


        }

      public string Valid(string customerID, string staffID, string date, string notes, string isPaid, string notes1)
        {
            // create a string variable to store the error
            String Error = "";
            // create a temporary variable to store date values
            DateTime DateTemp;
            // if the CustomerID is blank
            if (customerID.Length == 0)
            {
                // record the error
                Error = Error + "The Customer ID may not be blank : ";
            }
            // if the CustomerID is greater than 6 characters
            if (customerID.Length > 6)
            {
                // record the error
                Error = Error + "The Customer ID must be less than 6 characters : ";
            }
            // if the StaffID is blank
            if (staffID.Length == 0)
            {
                // record the error
                Error = Error + "The Staff ID may not be blank : ";
            }
            // if the StaffID is greater than 6 characters
            if (staffID.Length > 6)
            {
                // record the error
                Error = Error + "The Staff ID must be less than 6 characters : ";
            }
            try
            {
                // copy the DateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(date);
                // if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    // record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                // if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    // record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                // record the error
                Error = Error + "The date was not a valid date : ";
            }
            // if the Notes is blank
            if (notes.Length == 0)
            {
                // record the error
                Error = Error + "The Notes may not be blank : ";
            }
            // if the Notes is greater than 100 characters
            if (notes.Length > 100)
            {
                // record the error
                Error = Error + "The Notes must be less than 100 characters : ";
            }
            // return any error messages
            return Error;
        }

        public string Valid(string v1, string v2, string v3, string v4)
        {
            throw new NotImplementedException();
        }
    }
    /************************ STATISTICS GROUPED BY ORDER STATUS********************/
    public DataTable StatisticsGroupedByOrderStatus()
    {
        // create an instance of the data connection
        clsDataConnection DB = new clsDataConnection();
        // execute the stored procedure
        DB.Execute("dbo.sproc_tblOrder_StatisticsGroupedByOrderStatus");
        // return the data table
        return DB.DataTable;
    }

    /************************ STATISTICS GROUPED BY ORDER DISPATCHED****************/
    public DataTable StatisticsGroupedByOrderDispatched()
    {
        // create an instance of the data connection
        clsDataConnection DB = new clsDataConnection();
        // execute the stored procedure
        DB.Execute("dbo.sproc_tblOrder_StatisticsGroupedByOrderDispatched");
        // return the data table
        return DB.DataTable;
    }


}

