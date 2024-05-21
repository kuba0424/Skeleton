using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection() 
        {
            //create the items of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerId = 1;
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
            TestItem.CustomerId = 3;
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
        public clsCustomer ThisCustomer { get; set; }

    }
}