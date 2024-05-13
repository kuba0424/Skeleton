using System;

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


        private Int32 mItemID;
        public Int32 itemID
        {
            get
            {
                //this line of code sends data out of the property
                return mItemID;
            }
            set
            {
                //this line of code allows data onto the property
                mItemID = value;
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

        public bool Find(int itemId)
        {
            //set the private data members to the test data value
            mItemID = 45;
            mItemStock = 30;
            mItemSize = 1.5;
            mItemPrice = 8.5;
            mItemDescription = "This is an item description.";
            mItemAvailable = true;
            mItemDate = Convert.ToDateTime("10 / 05 / 2024");

            //always return true
            return true;
        }

    }
}