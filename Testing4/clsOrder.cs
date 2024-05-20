using System;

namespace Testing4
{
    internal class clsOrder
    {
        public int OrderID { get; internal set; }
        public int CustomerID { get; internal set; }
        public int StaffID { get; internal set; }
        public DateTime Date { get; internal set; }
        public bool IsPaid { get; internal set; }
        public string Notes { get; internal set; }
    }
}