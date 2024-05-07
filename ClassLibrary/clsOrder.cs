using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool OrderDispatched { get; set; }
        public DateTime DispatchDate { get; set; }
        public int OrderID { get; set; }
        public int PaymentInformation { get; set; }
        public string CustomerAddress { get; set; }
        public double TotalPrice { get; set; }
    }
}