﻿using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private member data for thisOrder
        clsOrder mThisOrder = new clsOrder();

        //constructor for the class
        public clsOrderCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderProcessing_SelectAll");
            PopulateArray(DB);
            //variable for the index
            //Int32 Index = 0;
            /*//variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("Sproc_tblOrderProcessing_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields for the current record
                AnOrder.OrderDispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrdDispatch"]);
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.TotalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CstmrAdd"]);
                AnOrder.PaymentInformation = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentInfo"]);
                AnOrder.DispatchDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DispatchDate"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;*/
        }





        /*//create the items of test data
        clsOrder TestItem = new clsOrder();
        //set its properties
        TestItem.OrderDispatched = true;
        TestItem.TotalPrice = 7;
        TestItem.CustomerAddress = "6 Fosse Park Rd";
        TestItem.PaymentInformation = 88998;
        TestItem.DispatchDate = DateTime.Now;
        //add the test item to the test list
        mOrderList.Add(TestItem);
        //re initialise the object for some new data
        TestItem = new clsOrder();
        //set its properties
        TestItem.OrderDispatched = true;
        TestItem.TotalPrice = 2;
        TestItem.CustomerAddress = "6 Fosse Park Rd";
        TestItem.PaymentInformation = 88998;
        TestItem.DispatchDate = DateTime.Now;
        //add the item to the test list
        mOrderList.Add(TestItem);*/


        //private data member for the list
        public List<clsOrder> mOrderList = new List<clsOrder>();
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data 
                mThisOrder = value;
            }
        }


        public int Add()
        {
            //adds a record to the database based on the values of the mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@CstmrAdd", mThisOrder.CustomerAddress);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@OrdDispatch", mThisOrder.OrderDispatched);
            DB.AddParameter("@PaymentInfo", mThisOrder.PaymentInformation);
            DB.AddParameter("@DispatchDate", mThisOrder.DispatchDate);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrderProcessing_Insert");
        }

        public void update()
        {
            //update an existing record based on the values of this Order
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderID);
            DB.AddParameter("@CstmrAdd", mThisOrder.CustomerAddress);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@OrdDispatch", mThisOrder.OrderDispatched);
            DB.AddParameter("@PaymentInfo", mThisOrder.PaymentInformation);
            DB.AddParameter("@DispatchDate", mThisOrder.DispatchDate);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderProcessing_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by this order
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderID);
            //execute the stored procedures
            DB.Execute("sproc_tblOrderProcessing_Delete");
        }

        public void ReportByCustomerAddress(string CustomerAddress)
        {
            //filters the records based on full or partial address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the customer address parameter to the database
            DB.AddParameter("@CustomerAddress", CustomerAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderProcessing_FilterByCustomerAddress");
            //populate the aray list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //cleat the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields for the current record
                AnOrder.OrderDispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrdDispatch"]);
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.TotalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CstmrAdd"]);
                AnOrder.PaymentInformation = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentInfo"]);
                AnOrder.DispatchDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DispatchDate"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

    }
}

