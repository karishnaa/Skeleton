using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsDeliveryCollection
    {
        List<clsDelivery> mDeliveryList = new List<clsDelivery>();
        clsDelivery mThisDelivery = new clsDelivery();

        // public property for the delivery list
        public List<clsDelivery> DeliveryList
        {
            get
            {
                return mDeliveryList;
            }
            set
            {
                mDeliveryList = value;
            }
        }

        // public property for count
        public int Count
        {
            get
            {
                return mDeliveryList.Count;
            }
            set
            {
                // we shall worry about this later
            }
        }

        public clsDelivery ThisDelivery
        {
            get
            {
                return mThisDelivery;
            }
            set
            {
                mThisDelivery = value;
            }
        }

        public clsDeliveryCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblDelivery_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DeliveryID", mThisDelivery.DeliveryID);
            DB.AddParameter("@OrderID", mThisDelivery.OrderID);
            DB.AddParameter("@DeliveryAddress", mThisDelivery.DeliveryAddress);
            DB.AddParameter("@DateOfDelivery", mThisDelivery.DateOfDelivery);
            DB.AddParameter("@Dispatched", mThisDelivery.Dispatched);
            return DB.Execute("sproc_tblDelivery_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DeliveryID", mThisDelivery.DeliveryID);
            DB.AddParameter("@OrderID", mThisDelivery.OrderID);
            DB.AddParameter("@DeliveryAddress", mThisDelivery.DeliveryAddress);
            DB.AddParameter("@DateOfDelivery", mThisDelivery.DateOfDelivery);
            DB.AddParameter("@Dispatched", mThisDelivery.Dispatched);
            DB.Execute("sproc_tblDelivery_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DeliveryID", mThisDelivery.DeliveryID);
            DB.Execute("sproc_tblDelivery_Delete");
        }

        public void ReportByDeliveryAddress(string DeliveryAddress)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DeliveryAddress", DeliveryAddress);
            DB.Execute("sproc_tblDelivery_FilterByDeliveryAddress");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mDeliveryList = new List<clsDelivery>();
            while (Index < RecordCount)
            {
                clsDelivery AnDelivery = new clsDelivery();
                AnDelivery.DeliveryID = Convert.ToInt32(DB.DataTable.Rows[Index]["DeliveryID"]);
                AnDelivery.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnDelivery.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                AnDelivery.DateOfDelivery = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfDelivery"]);
                AnDelivery.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                mDeliveryList.Add(AnDelivery);
                Index++;
            }
        }

        
    }
}
