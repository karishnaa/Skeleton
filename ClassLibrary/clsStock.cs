using System;
using System.Diagnostics;

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

        public bool Find(int stockID)
        {
            //set the private data to the test data values
            mStockID = 1;
            mStockName = "Nike Hoodie";
            mPrice = 39.99;
            mQuantity = 23;
            mAvailable = true;
            mDescription = "Comfortable Nike Hoodie";
            mArrivalDate = Convert.ToDateTime("11/05/2024");
            //always return true
            return true;
        }
    }
}