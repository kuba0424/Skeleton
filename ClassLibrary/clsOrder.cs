using System;
using System.IO;

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
        /****** FIND METHOD ******/
        public bool Find(int OrderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@OrderId", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderProcessing_FilterByOrderId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mDispatchDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DispatchDate"]);
                mOrderDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["OrdDispatch"]);
                mPaymentInformation = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentInfo"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CstmrAdd"]);
                mTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["TotalPrice"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {

                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string DispatchDate,
                            string PaymentInformation,
                            string CustomerAddress,
                            string TotalPrice)
        {
            //create a string variable to store the error
            String Error = "";
            //Create a temporary variable to store the data values
            DateTime DateComp = DateTime.Now.Date;
            DateTime DateTemp;
            try
            {

    }
    }
