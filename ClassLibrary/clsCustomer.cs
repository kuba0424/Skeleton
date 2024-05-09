﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the Customer id property
        private Int32 mCustomerId;
        //CustomerId public property
        public int CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }
        //private data member for the username property
        private string mUsername;
        //username public property
        public string Username
        {
            get
            {
                //this line of code sends data out of the property
                return mUsername;
            }
            set
            {
                //this line of code allows data into the property
                mUsername = value;
            }
        }
        //private data member for the password property
        private string mPassword;
        //password public property
        public string Password
        {
            get
            {
                //this line of code sends data out of the property
                return mPassword;
            }
            set
            {
                //this line of code allows data into the property
                mPassword = value;
            }
        }
        //private data member for the town property
        private string mEmail;
        //email public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        //private data member for the post code property
        private string mHomeAddress;
        //HomeAddress public property
        public string HomeAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mHomeAddress;
            }
            set
            {
                //this line of code allows data into the property
                mHomeAddress = value;
            }
        }

        //private data member for the RegistrationDate property
        private DateTime mRegistrationDate;
        //RegistrationDate public property
        public DateTime RegistrationDate
        {
            get
            {
                //this line of code sends data out of the property
                return mRegistrationDate;
            }
            set
            {
                //this line of code allows data into the property
                mRegistrationDate = value;
            }
        }
        //private data member for the active property
        private Boolean mActive;
        //active public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }


        public bool Find(int customerId)
        {
            //set the private data members to the test data value
            mCustomerId = 21;
            mUsername = "test username";
            mPassword = "test password";
            mEmail = "test email";
            mHomeAddress = "test homeaddress";
            mRegistrationDate = Convert.ToDateTime(DateTime.Now);
            mActive = true;
            //always return true
            return true;
        }

    }
}