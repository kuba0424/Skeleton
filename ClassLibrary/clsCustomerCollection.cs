using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection() 
        {
            //varible for the index
            Int32 Index = 0;
            //varible to store the recrod count
            Int32 RecordCount= 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields for the current record
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCustomer.Customer_Id = Convert.ToInt32(DB.DataTable.Rows[Index]["Customer_Id"]);
                AnCustomer.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                AnCustomer.RegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["RegistrationDate"]);
                AnCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.HomeAddress = Convert.ToString(DB.DataTable.Rows[Index]["HomeAddress"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }

            //create the items of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_Id = 1;
            TestItem.Username = "DMU";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.Password = "DDMMUU";
            TestItem.Email = "dmu@gmail.com";
            TestItem.HomeAddress = "18 leicester road";
            //add the test item to the test list
            mCustomerList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_Id = 3;
            TestItem.Username = "BillyJean";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.Password = "MichealJ";
            TestItem.Email = "MJ@gmail.com";
            TestItem.HomeAddress = "12 grange lane";
            //add the item to the test list
            mCustomerList.Add(TestItem);
        }
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member data for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
       
        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry later
            }
        }
        //public property for thisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private
                mThisCustomer = value;
            }
        }

        public int Add()
        {
           //adds a record to the database based on the value of mThisCustomer
           //connect to the database
           clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@HomeAddress", mThisCustomer.HomeAddress);
            DB.AddParameter("@RegistrationDate", mThisCustomer.RegistrationDate);
            DB.AddParameter("@Active", mThisCustomer.Active);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomers_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new sotred procedure
            DB.AddParameter("@Customer_Id", mThisCustomer.Customer_Id);
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@HomeAddress", mThisCustomer.HomeAddress);
            DB.AddParameter("@RegistrationDate", mThisCustomer.RegistrationDate);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_Update");
        }
    }
}