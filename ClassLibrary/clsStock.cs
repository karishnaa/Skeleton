using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
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
                mQuantity = value;
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

        public string Valid(string StockName, string Quantity, string Price, string ArrivalDate, string Description, string Available)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DateTemp;
            float PriceTemp;
            int QuantityTemp;
            //if the stockname is blank
            if (StockName.Length == 0) 
            {
                //record the error
                Error = Error + " The Stock Name may not be blank";

            }
            //if the stockname is more than 50 characters 
            if (StockName.Length > 50) 
            {
                //record the error
                Error = Error + " The Stock Name may not be more than 50 characters";

            }
            //validation for ArrivalDate
            try
            {
                //copy the arrival date to the datetemp variable
                DateTemp = Convert.ToDateTime(ArrivalDate);
                //check to see if the data is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + " The date cannot be in the future";
                }
                
            }
            catch
            {
                //record the error
                Error = Error + " The date was not a valid date";
            }
            //validation for Price
            try
            {
                //convert to float
                PriceTemp = float.Parse(Price);
                
                //check to see if the data is less than 0
                if (PriceTemp < 0)
                {
                    //record the error
                    Error = Error + " The price cannot be below 0";
                }
                //check to see if the data is more than 100,000
                if (PriceTemp > 100000)
                {
                    //record the error
                    Error = Error + " The price cannot be above 100,000";
                }
            }
            catch //catch out all non float data
            {
                //record the error
                Error = Error + " The price was not a valid price";
            }
            //validation for Quantity
            try
            {
                //convert to integer
                QuantityTemp = Convert.ToInt32(Quantity);

                //check to see if the data is less than 0
                if (QuantityTemp < 0)
                {
                    //record the error
                    Error = Error + " The Quantity cannot be below 0";
                }
                //check to see if the data is more than 10,000
                if (QuantityTemp > 10000)
                {
                    //record the error
                    Error = Error + " The quantity cannot be above 10,000";
                }
            }
            catch //catch out all non integer datatypes
            {
                //record the error
                Error = Error + " The quantity was not a valid number";
            }
           
            //validation for Description
            //check if there is more than 50 characters 
            if (Description.Length > 50)
            {
                //record the error
                Error = Error + " The description may not be more than 50 characters";
            }
            //return any error messages
            return Error;
        }
        /************************ STATISTICS GROUPED BY PRICE METHOD ******************************/
        public DataTable StatisticsGroupedByPrice()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Count_GroupByPrice");
            //there should be either zero one or many records
            return DB.DataTable;

        }
        /************************ STATISTICS GROUPED BY QUANTITY METHOD ******************************/
        public DataTable StatisticsGroupedByQuantity()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Count_GroupByQuantity");
            //there should be either zero one or many records
            return DB.DataTable;

        }
    }
}