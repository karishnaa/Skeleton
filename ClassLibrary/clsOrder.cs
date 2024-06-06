using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsOrder
    {
        private int mOrderID;
        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }

        private int mCustomerID;
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        private int mStaffID;
        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        private int mStockID;
        public int StockID
        {
            get
            {
                return mStockID;
            }
            set
            {
                mStockID = value;
            }
        }
        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        private bool mIsPaid;
        public bool IsPaid
        {
            get
            {
                return mIsPaid;
            }
            set
            {
                mIsPaid = value;
            }
        }
        private string mNotes;
        public string Notes
        {
            get
            {
                return mNotes;
            }
            set
            {
                mNotes = value;
            }
        }


        public bool Find(int orderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", orderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mIsPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["IsPaid"]);
                mNotes = Convert.ToString(DB.DataTable.Rows[0]["Notes"]);
                return true;
            }
            else
            {
                return false;
            }

        }
        public string Valid(string OrderID, string CustomerID, string StaffID, string StockID, string OrderDate, string IsPaid, string Notes)
        {
            string Error = "";
            DateTime DateTemp;
            if (OrderID.Length == 0)
            {
                Error = Error + "The Order ID may not be blank : ";
            }
            if (OrderID.Length > 6)
            {
                Error = Error + "The Order ID must be less than 6 characters : ";
            }
            if (CustomerID.Length == 0)
            {
                Error = Error + "The Customer ID may not be blank : ";
            }
            if (CustomerID.Length > 6)
            {
                Error = Error + "The Customer ID must be less than 6 characters : ";
            }
            if (StaffID.Length == 0)
            {
                Error = Error + "The Staff ID may not be blank : ";
            }
            if (StaffID.Length > 6)
            {
                Error = Error + "The Staff ID must be less than 6 characters : ";
            }
            if (StockID.Length == 0)
            {
                Error = Error + "The Stock ID may not be blank : ";
            }
            if (StockID.Length > 6)
            {
                Error = Error + "The Stock ID must be less than 6 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            return Error;

        }

        /* Statisics grouped by Order ID */
        public string StatisticsByOrderID(string OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            string OrderStatistics = "";
            OrderStatistics = OrderStatistics + "Order ID: " + OrderID + "\n";
            OrderStatistics = OrderStatistics + "Customer ID: " + DB.DataTable.Rows[0]["CustomerID"] + "\n";
            OrderStatistics = OrderStatistics + "Staff ID: " + DB.DataTable.Rows[0]["StaffID"] + "\n";
            OrderStatistics = OrderStatistics + "Stock ID: " + DB.DataTable.Rows[0]["StockID"] + "\n";
            OrderStatistics = OrderStatistics + "Order Date: " + DB.DataTable.Rows[0]["OrderDate"] + "\n";
            OrderStatistics = OrderStatistics + "Is Paid: " + DB.DataTable.Rows[0]["IsPaid"] + "\n";
            OrderStatistics = OrderStatistics + "Notes: " + DB.DataTable.Rows[0]["Notes"] + "\n";
            return OrderStatistics;
        }

        /* Statisics grouped by IsPaid */
        public string StatisticsByIsPaid(string IsPaid)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@IsPaid", IsPaid);
            DB.Execute("sproc_tblOrder_FilterByIsPaid");
            string OrderStatistics = "";
            OrderStatistics = OrderStatistics + "Order ID: " + DB.DataTable.Rows[0]["OrderID"] + "\n";
            OrderStatistics = OrderStatistics + "Customer ID: " + DB.DataTable.Rows[0]["CustomerID"] + "\n";
            OrderStatistics = OrderStatistics + "Staff ID: " + DB.DataTable.Rows[0]["StaffID"] + "\n";
            OrderStatistics = OrderStatistics + "Stock ID: " + DB.DataTable.Rows[0]["StockID"] + "\n";
            OrderStatistics = OrderStatistics + "Order Date: " + DB.DataTable.Rows[0]["OrderDate"] + "\n";
            OrderStatistics = OrderStatistics + "Is Paid: " + IsPaid + "\n";
            OrderStatistics = OrderStatistics + "Notes: " + DB.DataTable.Rows[0]["Notes"] + "\n";
            return OrderStatistics;
        }
    }
}
