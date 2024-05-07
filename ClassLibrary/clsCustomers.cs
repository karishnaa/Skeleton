using System;

namespace ClassLibrary
{
    public class clsCustomers
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOB { get; set; }
        public bool Subscribed { get; set; }
        
    }
}