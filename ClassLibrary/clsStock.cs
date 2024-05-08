using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool itemAvailable { get; set; }

        public DateTime itemDate { get; set; }

        public int itemID { get; set; }

        public int itemStock { get; set; }

        public double itemSize { get; set; }

        public double itemPrice { get; set; }

        public string itemDescription { get; set; }
        public bool Active { get; set; }
    }
}
