using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

       //constructor for the class
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //executre the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create luh blank stock
                clsStock Stock = new clsStock();
                //read in the fields for the current record
                //Stock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                Stock.Id = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                Stock.itemId = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemId"]);
                Stock.itemStock = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemStock"]);
                Stock.itemPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["ItemPrice"]);
                Stock.itemSize = Convert.ToDouble(DB.DataTable.Rows[Index]["ItemSize"]);
                Stock.itemDescription = Convert.ToString(DB.DataTable.Rows[Index]["ItemDescription"]);
                Stock.itemAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["ItemAvailable"]);
                Stock.itemDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ItemDate"]);
                //add the record to the private data member
                mStockList.Add(Stock);
                //point at the next record
                Index++;
                    

            }
            
            
            /*//create the items of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Active = true;
            TestItem.Id = 1;
            TestItem.itemId = 2;
            TestItem.itemStock = 45;
            TestItem.itemPrice = 7;
            TestItem.itemSize = 44;
            TestItem.itemDescription = "this is an item";
            TestItem.itemAvailable = true;
            TestItem.itemDate = DateTime.Now;
            //add the test item to the test list
            mStockList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsStock();
            //set its properties
            //set its properties
            TestItem.Active = true;
            TestItem.Id = 2;
            TestItem.itemId = 3;
            TestItem.itemStock = 67;
            TestItem.itemPrice = 9;
            TestItem.itemSize = 7;
            TestItem.itemDescription = "this is an item2";
            TestItem.itemAvailable = true;
            TestItem.itemDate = DateTime.Now;
            //add the item to the test list
            mStockList.Add(TestItem);*/

        }

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //worry about later
            }
        }

        public clsStock ThisStock { get; set; }


    }
}