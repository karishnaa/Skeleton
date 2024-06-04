using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Data;
using System.Globalization;


namespace ClassLibrary
{
    public class clsDelivery
    {
        // Private data member for the DeliveryID property
        private int mDeliveryID;

        // DeliveryID public property
        public int DeliveryID
        {
            get { return mDeliveryID; }
            set { mDeliveryID = value; }
        }

        // Private data member for the OrderID property
        private int mOrderID;

        // OrderID public property
        public int OrderID
        {
            get { return mOrderID; }
            set { mOrderID = value; }
        }

        // Private data member for the DeliveryAddress property
        private string mDeliveryAddress;

        // DeliveryAddress public property
        public string DeliveryAddress
        {
            get { return mDeliveryAddress; }
            set { mDeliveryAddress = value; }
        }

        // Private data member for the DateOfDelivery property
        private DateTime mDateOfDelivery;

        // DateOfDelivery public property
        public DateTime DateOfDelivery
        {
            get { return mDateOfDelivery; }
            set { mDateOfDelivery = value; }
        }

        // Private data member for the Dispatched property
        private bool mDispatched;

        // Dispatched public property
        public bool Dispatched
        {
            get { return mDispatched; }
            set { mDispatched = value; }
        }

        // Method to simulate finding a delivery by DeliveryID
        public bool Find(int deliveryID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the delivery ID to search for
            DB.AddParameter("@DeliveryID", deliveryID);
            // Execute the stored procedure
            DB.Execute("dbo.sproc_tblDelivery_FilterByDeliveryID");
            // If one record is found (there should either be one or zero)
            if (DB.Count == 1)
            {
                // Set the private data to the test data values
                mDeliveryID = Convert.ToInt32(DB.DataTable.Rows[0]["DeliveryID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mDateOfDelivery = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfDelivery"]);
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                // Return that everything worked OK
                return true;
            }
            // If no record was found
            else
            {
                // Return false indicating there is a problem
                return false;
            }


          
        }

        public string Valid(string deliveryAddress, string dateOfDelivery, string deliveryAddress1)
        {
            // Create a string variable to store the error
            String Error = "";
            // Create a temporary variable to store date values
            DateTime DateTemp;
            // If the DeliveryAddress is blank
            if (deliveryAddress.Length == 0)
            {
                // Record the error
                Error = Error + "The delivery address may not be blank : ";
            }
            // If the DeliveryAddress is greater than 50 characters
            if (deliveryAddress.Length > 50)
            {
                // Record the error
                Error = Error + "The delivery address must be less than 50 characters : ";
            }
            try
            {
                // Copy the DateOfDelivery value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfDelivery);
                // If the date is less than the current date
                if (DateTemp < DateTime.Now.Date)
                {
                    // Record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                // If the date is greater than the current date
                if (DateTemp > DateTime.Now.Date)
                {
                    // Record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                // Record the error
                Error = Error + "The date was not a valid date : ";
            }
            // Return any error messages
            return Error;
        }
    }
    /************************ STATISTICS GROUPED BY DELIVERY STATUS*********/
    public DataTable StatisticsGroupedByDeliveryStatus()
    {
        // Create an instance of the data connection
        clsDataConnection DB = new clsDataConnection();
        // Execute the stored procedure
        DB.Execute("dbo.sproc_tblDelivery_StatisticsGroupedByDeliveryStatus");
        // Return the datatable with the data
        return DB.DataTable;
    }

    

    /************************ STATISTICS GROUPED BY ORDER ID******************/
    public DataTable StatisticsGroupedByOrderID()
    {
        // Create an instance of the data connection
        clsDataConnection DB = new clsDataConnection();
        // Execute the stored procedure
        DB.Execute("dbo.sproc_tblDelivery_StatisticsGroupedByOrderID");
        // Return the datatable with the data
        return DB.DataTable;
    }
}

