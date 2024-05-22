using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the Customer id property
        private Int32 mCustomer_Id;
        //CustomerId public property
        public int Customer_Id
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomer_Id;
            }
            set
            {
                //this line of code allows data into the property
                mCustomer_Id = value;
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


        /****** FIND METHOD *******/
        public bool Find(int Customer_Id)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the address id to search for
            DB.AddParameter("@Customer_Id", Customer_Id);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_FilterByCustomer_Id");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data members 
                mCustomer_Id = Convert.ToInt32(DB.DataTable.Rows[0]["Customer_Id"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mHomeAddress = Convert.ToString(DB.DataTable.Rows[0]["HomeAddress"]);
                mRegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["RegistrationDate"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
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

        public string Valid(string username, string password, string email, string homeaddress, string registrionDate)
        {
            //create a strring varible to sotre the error
            string Error = "";
            //create a temp variable to store the date values
            DateTime DateTemp;
            //if the username is blank
            if (username.Length == 0)
            {
                //record the error 
                Error = Error + "The Username may not be blank : ";
            }
            //if the username is greater than 50 characters
            if (username.Length > 50)
            {
                //record the error 
                Error = Error + "The Username must be less than 50 characters : ";
            }
            //if password is blank 
            if (password.Length == 0)
            {
                //record the error 
                Error = Error + "The Password may not be blank : ";
            }
            //if the Password is greater than 50 characters
            if (password.Length > 50)
            {
                //record the error 
                Error = Error + "The Password must be less than 50 characters : ";
            }
            //if email is blank 
            if (email.Length == 0)
            {
                //record the error 
                Error = Error + "The Email may not be blank : ";
            }
            //if the Email is greater than 50 characters
            if (email.Length > 50)
            {
                //record the error 
                Error = Error + "The Email must be less than 50 characters : ";
            }
            //if HomeAddress is blank 
            if (homeaddress.Length == 0)
            {
                //record the error 
                Error = Error + "The HomeAddress may not be blank : ";
            }
            //if the HomeAddress is greater than 50 characters
            if (homeaddress.Length > 50)
            {
                //record the error 
                Error = Error + "The HomeAddress must be less than 50 characters : ";
            }
            //create an instance of REgistrationDAte to compare with DateTemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;

            try
            {

                //copy the RegistrationDate value to the datetemp varible
                DateTemp = Convert.ToDateTime(registrionDate);
                if (DateTemp < DateComp)
                {
                    // record the error
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
                Error = Error + "The Date was not valid : ";
            }
                return Error;
            
        }
    }
}
