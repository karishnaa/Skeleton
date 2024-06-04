using System;

namespace ClassLibrary
{
    public class clsDelivery
    {
        // Private data member for the DeliveryID property
        private int mDeliveryID;

        // DeliveryID public property
        public int DeliveryID
        {
            get { return mDeliveryID; }
            set { mDeliveryID = value; }
        }

        // Private data member for the OrderID property
        private int mOrderID;

        // OrderID public property
        public int OrderID
        {
            get { return mOrderID; }
            set { mOrderID = value; }
        }

        // Private data member for the DeliveryAddress property
        private string mDeliveryAddress;

        // DeliveryAddress public property
        public string DeliveryAddress
        {
            get { return mDeliveryAddress; }
            set { mDeliveryAddress = value; }
        }

        // Private data member for the DateOfDelivery property
        private DateTime mDateOfDelivery;

        // DateOfDelivery public property
        public DateTime DateOfDelivery
        {
            get { return mDateOfDelivery; }
            set { mDateOfDelivery = value; }
        }

        // Private data member for the Dispatched property
        private bool mDispatched;

        // Dispatched public property
        public bool Dispatched
        {
            get { return mDispatched; }
            set { mDispatched = value; }
        }

        // Method to simulate finding a delivery by DeliveryID
        public bool Find(int deliveryID)
        {
            // Simulate setting the properties with test data
            mDeliveryID = 1;
            mOrderID = 1001;
            mDeliveryAddress = "123 Main Street";
            mDateOfDelivery = DateTime.Now;
            mDispatched = true;
            // Always return true
            return true;
        }
    }
}
