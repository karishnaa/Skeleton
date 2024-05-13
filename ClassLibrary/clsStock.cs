using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public string StockName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}