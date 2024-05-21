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
                //copy the dispatchdate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DispatchDate);

                if (DateTemp < DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //if the paymentinfo is blank
            if (PaymentInformation.Length == 0)
            {
                Error = Error + "The payment information may not be blank : ";
            }
            //if the payment info is greater than 20
            if (PaymentInformation.Length > 20)
            {
                //record the error
                Error = Error + "The payment Information must be less than 20 characters : ";
            }
            //is the address blank
            if (CustomerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank : ";
            }
            //if the address is too long
            if (CustomerAddress.Length > 50)
            {
                //record the error
                Error = Error + "The address must be less than 50 characters : ";
            }
            //is the town blank
            if (TotalPrice.Length == 0)
            {
                //record the error
                Error = Error + "The Total Price may not be blank : ";
            }
            //if the town is too long
            if (TotalPrice.Length > 6)
            {
                //record the error
                Error = Error + "The Total Price must be less than 50 characters : ";
            }
            return Error;
        }
            }
            
        }
    
                    //create a string variable to store the error
        //String Error = "";
        //Create a temporary variable to store the data values
        //DateTime DateTemp;
        //copy the DispatchDate value to the DateTemp variable
        //DateTemp = Convert.ToDateTime(DispatchDate);
        //check to see if the data is less thank todays date
        //if (DateTemp < DateTime.Now.Date) ;
        //{
          //  Error = Error + "The date cannot be in the past : ";
        //}
    
      

       
    //this function accepts 5 parameters for validation
    //the function returns a string containing any error message
    //if no erros found then a blank string is returned
    
      //  return "";
    
    //}}
