using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        
        //private data member for the stock list
        List<clsStock> mStockList = new List<clsStock>();
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
        public clsStock ThisStock { get; set; }
        //constructor for the class
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock anStock = new clsStock();
                //read in the fields for the current record
                anStock.StockID= Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
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