using System;
using System.Diagnostics;

namespace ClassLibrary
{
    public class clsOrder
    {
        // Private data member for the OrderID property
        private int mOrderID;

        // OrderID public property
        public int OrderID
        {
            get { return mOrderID; }
            set { mOrderID = value; }
        }

        // Private data member for the CustomerID property
        private int mCustomerID;

        // CustomerID public property
        public int CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }

        // Private data member for the StaffID property
        private int mStaffID;

        // StaffID public property
        public int StaffID
        {
            get { return mStaffID; }
            set { mStaffID = value; }
        }

        // Private data member for the Date property
        private DateTime mDate;

        // Date public property
        public DateTime Date
        {
            get { return mDate; }
            set { mDate = value; }
        }

        // Private data member for the IsPaid property
        private bool mIsPaid;

        // IsPaid public property
        public bool IsPaid
        {
            get { return mIsPaid; }
            set { mIsPaid = value; }
        }

        // Private data member for the Notes property
        private string mNotes;

        // Notes public property
        public string Notes
        {
            get { return mNotes; }
            set { mNotes = value; }
        }

        // Method to simulate finding an order by OrderID
        public bool Find(int orderID)
        {
            // Simulate setting the properties with test data
            mOrderID = 1;
            mCustomerID = 1001;
            mStaffID = 101;
            mDate = DateTime.Now;
            mIsPaid = true;
            mNotes = "This is a test order.";
            // Always return true
            return true;
        }
    }
}
