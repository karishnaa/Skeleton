using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsDeliveryCollection
    {
       //private data member for the delivery list
       List<clsDelivery> mDeliveryList = new List<clsDelivery>();
        //private data member thisDelivery
        clsDelivery mThisDelivery = new clsDelivery();

        //public property for the delivery list
        public List<clsDelivery> DeliveryList
        {
            get
            {
                //return the private data
                return mDeliveryList;
            }
            set
            {
                //set the private data
                mDeliveryList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mDeliveryList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisDelivery
        public clsDelivery ThisDelivery
        {
            get
            {
                //return the private data
                return mThisDelivery;
            }
            set
            {
                //set the private data
                mThisDelivery = value;
            }
        }

        //constructor for the class
        public clsDeliveryCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection dB)
        {
            throw new NotImplementedException();
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisDelivery
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DeliveryID", mThisDelivery.DeliveryID);
            DB.AddParameter("@OrderID", mThisDelivery.OrderID);
            DB.AddParameter("@DeliveryDate", mThisDelivery.DateOfDelivery);
            DB.AddParameter("@DeliveryAddress", mThisDelivery.DeliveryAddress);
            DB.AddParameter("@DeliveryDispatched", mThisDelivery.Dispatched);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblDelivery_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisDelivery
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DeliveryID", mThisDelivery.DeliveryID);
            DB.AddParameter("@OrderID", mThisDelivery.OrderID);
            DB.AddParameter("@DeliveryAddress", mThisDelivery.DeliveryAddress);
            DB.AddParameter("@DeliveryDate", mThisDelivery.DateOfDelivery);
            DB.AddParameter("@DeliveryDispatched", mThisDelivery.Dispatched);
            // execute the procedure
            DB.Execute("sproc_tblDelivery_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisDelivery
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DeliveryID", mThisDelivery.DeliveryID);
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_Delete");
        }

        public void ReportByDeliveryAddress(string DeliveryAddress)
        {
            //filters the records based on a full or partial address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the address parameter to the database
            DB.AddParameter("@DeliveryAddress", DeliveryAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_FilterByDeliveryAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByDeliveryDate(string DeliveryDate)
        {
            //filters the records based on a full or partial date
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the date parameter to the database
            DB.AddParameter("@DeliveryDate", DeliveryDate);
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_FilterByDeliveryDate");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByDeliveryPostCode(string DeliveryPostCode)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the post code parameter to the database
            DB.AddParameter("@DeliveryPostCode", DeliveryPostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_FilterByDeliveryPostCode");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByDeliveryStatus(string DeliveryStatus)
        {
            //filters the records based on a full or partial status
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the status parameter to the database
            DB.AddParameter("@DeliveryStatus", DeliveryStatus);
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_FilterByDeliveryStatus");
            //populate the array list with the data table
            PopulateArray(DB);

        }

        public void ReportByOrderID(string OrderID)
        {
            //filters the records based on a full or partial order ID
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the order ID parameter to the database
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_FilterByOrderID");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void Find(int DeliveryID)
        {
            //find a record based on the primary key
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DeliveryID", DeliveryID);
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_FilterByDeliveryID");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mDeliveryList = new List<clsDelivery>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank delivery
                clsDelivery AnDelivery = new clsDelivery();
                //read in the fields from the current record
                AnDelivery.DeliveryID = Convert.ToInt32(DB.DataTable.Rows[Index]["DeliveryID"]);
                AnDelivery.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnDelivery.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                AnDelivery.DateOfDelivery = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);
                AnDelivery.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["DeliveryDispatched"]);
                //add the record to the private data member
                mDeliveryList.Add(AnDelivery);
                //point at the next record
                Index++;
            }
        }

    

    }
}
