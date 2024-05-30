using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection() 
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_SelectAll");
            //populate the array list with the data table
            PopulateArraay(DB);
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

        public void Delete()
        {
            //deletes the record pointed to by ThisCusotmer 
            //connects to the database
            clsDataConnection DB =new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Customer_Id", mThisCustomer.Customer_Id);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_Delete");
        }
        public void ReportByHomeAddress(string HomeAddress)
        {
            //filters the records based on a full or partial homeaddress
            //connects to database
            clsDataConnection DB = new clsDataConnection();
            //send the homeaddress parameters to the database
            DB.AddParameter("@HomeAddress", HomeAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_FilteredByHomeAddress");
            //populate the array list with the data table
            PopulateArraay(DB);
        }
        void PopulateArraay(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to stored the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank custmer object
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCustomer.Customer_Id = Convert.ToInt32(DB.DataTable.Rows[Index]["Customer_Id"]);
                AnCustomer.RegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["RegistrationDate"]);
                AnCustomer.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                AnCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnCustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.HomeAddress = Convert.ToString(DB.DataTable.Rows[Index]["HomeAddress"]);
                //add the record to te private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }
    }
}