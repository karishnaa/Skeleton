using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        // private data member for the list
        List<clsOrder> mOrdersList = new List<clsOrder>();
        // private data member thisOrder
        clsOrder mThisOrder = new clsOrder();


        // public property for the order list
        public List<clsOrder> OrdersList
        {
            get
            {
                // return the private data
                return mOrdersList;
            }
            set
            {
                // set the private data
                mOrdersList = value;
            }
        }

        // public property for count
        public int Count
        {
            get
            {
                // return the count of the list
                return mOrdersList.Count;
            }
            set
            {
                // we shall worry about this later
            }
        }

        // public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                // return the private data
                return mThisOrder;
            }
            set
            {
                // set the private data
                mThisOrder = value;
            }
        }

        // constructor for the class
        public clsOrdersCollection()
        {
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // populate the array list based on the data table in the parameter DB
            Int32 Index = 0;
            Int32 RecordCount = 0;
            // get the count of records
            RecordCount = DB.Count;
            // clear the private array list
            mOrdersList = new List<clsOrder>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank order
                clsOrder AnOrder = new clsOrder();
                // read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AnOrder.IsPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsPaid"]);
                AnOrder.Notes = Convert.ToString(DB.DataTable.Rows[Index]["Notes"]);
                // add the record to the private data member
                mOrdersList.Add(AnOrder);
                // point at the next record
                Index++;
            }
        }

        public int Add()
        {
            // adds a new record to the database based on the values of mThisOrder
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.AddParameter("@IsPaid", mThisOrder.IsPaid);
            DB.AddParameter("@Notes", mThisOrder.Notes);
            // execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            // update an existing record based on the values of thisOrder
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.AddParameter("@IsPaid", mThisOrder.IsPaid);
            DB.AddParameter("@Notes", mThisOrder.Notes);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            // deletes the record pointed to by thisOrder
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByCustomerID(int CustomerID)
        {
            // filters the records based on a full or partial customer ID
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the customer ID parameter to the database
            DB.AddParameter("@CustomerID", CustomerID);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCustomerID");
            // populate the array list with the data table
            PopulateArray(DB);


        }

        public void ReportByStaffID(int StaffID)
        {
            // filters the records based on a full or partial staff ID
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the staff ID parameter to the database
            DB.AddParameter("@StaffID", StaffID);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByStaffID");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByDate(DateTime Date)
        {
            // filters the records based on a full or partial date
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the date parameter to the database
            DB.AddParameter("@Date", Date);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByDate");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByIsPaid(bool IsPaid)
        {
            // filters the records based on a full or partial IsPaid
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the IsPaid parameter to the database
            DB.AddParameter("@IsPaid", IsPaid);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByIsPaid");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByNotes(string Notes)
        {
            // filters the records based on a full or partial notes
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the notes parameter to the database
            DB.AddParameter("@Notes", Notes);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByNotes");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        public void Find(int OrderID)
        {
            // find a record based on the primary key
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@OrderID", OrderID);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mThisOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mThisOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mThisOrder.StaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mThisOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mThisOrder.IsPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["IsPaid"]);
                mThisOrder.Notes = Convert.ToString(DB.DataTable.Rows[0]["Notes"]);
            }
            // if no record is found
            else
            {
                // set the private data members to null
                mThisOrder = null;
            }
        }

        private void PopulateArray(clsDataConnection DB)
        {
            // populate the array list based on the data table in the parameter DB
            Int32 Index = 0;
            Int32 RecordCount = 0;
            // get the count of records
            RecordCount = DB.Count;
            // clear the private array list
            mOrdersList = new List<clsOrder>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank order
                clsOrder AnOrder = new clsOrder();
                // read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AnOrder.IsPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsPaid"]);
                AnOrder.Notes = Convert.ToString(DB.DataTable.Rows[Index]["Notes"]);
                // add the record to the private data member
                mOrdersList.Add(AnOrder);
                // point at the next record
                Index++;
            }
        }


          


    }
}
