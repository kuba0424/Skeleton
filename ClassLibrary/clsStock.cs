using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsStock
    {

        public bool mItemAvailable;
        public bool itemAvailable
        {
            get
            {
                return mItemAvailable;
            }
            set
            {
                mItemAvailable = value;
            }
        }

        public DateTime mItemDate;
        public DateTime itemDate
        {
            get
            {
                return mItemDate;
            }
            set
            {
                mItemDate = value;
            }
        }


        private Int32 mId;
        public Int32 Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }


        private Int32 mItemId;
        public Int32 itemId
        {
            get
            {
                //this line of code sends data out of the property
                return mItemId;
            }
            set
            {
                //this line of code allows data onto the property
                mItemId = value;
            }
        }



        private Int32 mItemStock;
        public Int32 itemStock
        {
            get
            {
                return mItemStock;
            }
            set
            {
                mItemStock = value;
            }
        }

        private double mItemSize;
        public double itemSize
        {
            get
            {
                return mItemSize;
            }
            set
            {
                mItemSize = value;
            }
        }

        private double mItemPrice;
        public double itemPrice
        {
            get
            {
                return mItemPrice;
            }
            set
            {
                mItemPrice = value;
            }
        }

        private string mItemDescription;
        public string itemDescription
        {
            get
            {
                return mItemDescription;
            }
            set
            {
                mItemDescription = value;
            }
        }
        public bool Active { get; set; }




        public bool Find(int Id)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the item id to search for
            DB.AddParameter("@Id", Id);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByItemId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members

                mId = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mItemId = Convert.ToInt32(DB.DataTable.Rows[0]["itemId"]);
                mItemStock = Convert.ToInt32(DB.DataTable.Rows[0]["itemStock"]);
                mItemSize = Convert.ToDouble(DB.DataTable.Rows[0]["itemSize"]);
                mItemPrice = Convert.ToDouble(DB.DataTable.Rows[0]["itemPrice"]);
                mItemDescription = Convert.ToString(DB.DataTable.Rows[0]["itemDescription"]);
                mItemAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["itemAvailable"]);
                mItemDate = Convert.ToDateTime(DB.DataTable.Rows[0]["itemDate"]);
                //return that everything worked ok
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating there was a problem
                return false;
            }


            


        }

        public string Valid(string itemId, string itemStock, string itemSize, string itemPrice, string itemDescription, string itemAvailable, string itemDate)
        {
            //create a string variable to store the error
            String Error = "";
            //if the itemDescription is blank
            if(itemDescription.Length == 0)
            {
                //record the error
                Error = Error + "The itemDescription may not be blank : ";
            }
            //if the itemDescription is greater than 50 characters
            if(itemDescription.Length > 50)
            {
                Error = Error + "The itemDescription must be less than 51 characters : ";
            }
            //return any error messages
            return Error;
            
        }
    }
}
