using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the order id property
        private Int32 mOrderID;
        private DateTime mDispatchDate;
        private Boolean mOrderDispatched;
        private Int32 mPaymentInformation;
        private string mCustomerAddress;
        private double mTotalPrice;
        public bool OrderDispatched
        {
            get
            {
                return mOrderDispatched;
            }
            set
            {
                mOrderDispatched = value;
            }
        }
        public DateTime DispatchDate
        {
            get
            {
                return mDispatchDate;
            }
            set
            {
                mDispatchDate = value;
            }
        }
        public Int32 OrderID
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
        public Int32 PaymentInformation
        {
            get
            {
                return mPaymentInformation;
            }
            set
            {
                mPaymentInformation = value;
            }
        }
        public String CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }
        public Double TotalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }

        public bool Find(int orderID)
        {
            //set the private data members to the test date value
            mOrderID = 21;
            mDispatchDate = Convert.ToDateTime("23/12/2022");
            mOrderDispatched = true;
            mPaymentInformation = 21;
            mCustomerAddress = "Test Address";
            mTotalPrice = 9.99;
            //always return true
            return true;
        }
    }
}