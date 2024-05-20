using System;
using System.Diagnostics;
using System.Reflection.Emit;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the stock id property
        private Int32 mStockID;

        //stock id public property
        public int StockID
        {
            get
            {
                //this line of code sends data out of the property
                return mStockID;
            }
            set
            {
                //this line of code allows data into the property
                mStockID = value;
            }
        }
        //private data member for stock name property
        private string mStockName;
        //stock name public property
        public string StockName
        {
            get
            {
                //this line of code sends data out of the property
                return mStockName;
            }
            set
            {
                //this line of code allows data into the property
                mStockName = value;
            }
        }
        //private data member for the price property
        private double mPrice;
        //price public property
        public double Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }


        //private data member for the quantity property
        private Int32 mQuantity;

        //quantity public property
        public int Quantity
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mStockID = value;
            }
        }
        //private data member for the available property
        private bool mAvailable;
        //available public property
        public bool Available
        {
            get 
            {
                //this line of code sends data out of the property
                return mAvailable;
            }
            set 
            {
                //this line of code allows data into the property
                mAvailable = value;
            }
        }
        //private data member for the description property
        private string mDescription;
        //description public quantity
        public string Description
        {
            get 
            {
                //this line of code sends data out of the property
                return mDescription;
            }
            set 
            {
                //this line of code allows data into the property
                mDescription = value; 
            }
        }
        //private data member for the arrival date property
        private DateTime mArrivalDate;
        //arrival date public quantity
        public DateTime ArrivalDate
        {
            get
            {
                //this line of code sends data out of the property
                return mArrivalDate;
            }
            set
            {
                //this line of code allows data into the property
                mArrivalDate = value; 
            }
        }
        /** FIND METHOD **/
        public bool Find(int stockID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock id to search for
            DB.AddParameter("@StockID", stockID);
            //execute the stored procedure
            DB.Execute("dbo.sproc_tblStock_FilterByStockID");
            //if one record is found (there should either be one or zero)
            if (DB.Count == 1)
            {
                //set the private data to the test data values
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mStockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mArrivalDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ArrivalDate"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }
    }
}