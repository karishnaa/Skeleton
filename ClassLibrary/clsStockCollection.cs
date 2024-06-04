using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        
        //private data member for the stock list
        List<clsStock> mStockList = new List<clsStock>();
        //private member for thisstock
        clsStock mThisStock = new clsStock();
        //public property for the stock list
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStock ThisStock
        {
            get 
            {
                //return the private data
                return mThisStock;
            }
            set 
            { 
                //set the private data
                mThisStock = value;
            }
        }
        //constructor for the class
        public clsStockCollection()
        {
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockName", mThisStock.StockName);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@ArrivalDate", mThisStock.ArrivalDate);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStock 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@StockID", mThisStock.StockID);
            DB.AddParameter("@StockName", mThisStock.StockName);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@ArrivalDate", mThisStock.ArrivalDate);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockID", mThisStock.StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByStockName(string StockName)
        {
            //filters the record based on a full or partial stock name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the StockName parameter to the database
            DB.AddParameter("@StockName", StockName);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {   
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock object
                clsStock anStock = new clsStock();
                //read in the fields from the current record
                anStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                anStock.StockName = Convert.ToString(DB.DataTable.Rows[Index]["StockName"]);
                anStock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                anStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                anStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                anStock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                anStock.ArrivalDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ArrivalDate"]);
                //add the record to the private data member
                mStockList.Add(anStock);
                //point at the next record
                Index++;
            }
        }
    }

}